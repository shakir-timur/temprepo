using HomeAccountant_MicrosTestProject.DataConnection;
using HomeAccountant_MicrosTestProject.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccountant_MicrosTestProject
{
    public partial class Home : Form
    {
        IDataConnection dataConnection;
        Dictionary<TabPage, Action> pageChangeDelegates;

        public Home(string profileName)
        {
            InitializeComponent();

            ProfileName = profileName;

            LocaleInit();

            this.dataConnection = new LiteDbDataConnection(ProfileName);

            BindCategoryItems();

            UpdateAddDataGrid();

            AssignPageChangeDelegates();

            AssignControlHandles();

            CustomPeriodSelectionChange(null, null);

            this.FormClosed += FormClosedHandler;
        }

        public string ProfileName { get; }

        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettings = config.AppSettings.Settings;
            var locale = appSettings["locale"];
            var profile = appSettings["profile"];

            if (locale is null || profile is null)
            {
                locale = new KeyValueConfigurationElement("locale", Locale.ResourceCultureName);
                appSettings.Add(locale);
                profile = new KeyValueConfigurationElement("profile", ProfileName);
                appSettings.Add(profile);
            }
            else
            {
                locale.Value = Locale.ResourceCultureName;
                profile.Value = ProfileName;
            }

            config.Save(ConfigurationSaveMode.Modified);

            dataConnection.Dispose();
        }

        /// <summary>
        /// Initialise controls' text according to current locale
        /// </summary>
        private void LocaleInit()
        {
            this.Text = Locale.HomeFormTitle + $" ({ProfileName})";
            addExpenceTab.Text = Locale.AddExenceTabText;
            WeekTab.Text = Locale.WeekName;
            customPeriodTab.Text = Locale.CustomPeriodTabText;
            otherTab.Text = Locale.OtherTabName;
            changeLangLabel.Text = Locale.LanguageLabelText;
            addRecordButton.Text = Locale.AddExenceTabText;

            dangerZoneGroupBox.Text = Locale.DangerZoneGbText;
            categoryControlGroupBox.Text = Locale.CategoryControlGbText;
            deleteProfileButton.Text = Locale.DeleteProfileButtonText;

            weekShowAllCheckBox.Text = Locale.ShowAllTextBoxText;
            weekGroupCheckBox.Text = Locale.GroupTextBoxText;
            weekPrevButton.Text = Locale.PreviousButtonText;
            weekNextButton.Text = Locale.NextButtonText;

            customShowAllCheckBox.Text = Locale.ShowAllTextBoxText;
            customGroupCheckBox.Text = Locale.GroupTextBoxText;
            customNextButton.Text = Locale.NextButtonText;
            customPrevButton.Text = Locale.PreviousButtonText;
            monthRadioButton.Text = Locale.MonthTabName;
            yearRadioButton.Text = Locale.YearName;
            customDateRadioButton.Text = Locale.CustomPeriodTabText;

            createCategoryLabel.Text = Locale.NewLabelText;
            removeCategoryLabel.Text = Locale.RemoveLabelText;
            addCategoryButton.Text = Locale.NewLabelText;
            removeCategoryButton.Text = Locale.RemoveLabelText;

            LocaleSelector.SetComboboxDataSource(langSelectComboBox, langSelectComboBox_SelectedIndexChanged);
        }

        private void BindCategoryItems()
        {
            ComboBox[] boxes = new ComboBox[] { addRecordCategoryComboBox, weekCategoryComboBox,
                customCategoryComboBox, removeCategoryComboBox };

            var source = dataConnection.GetCategories(ProfileName).ToList();

            foreach (var box in boxes)
            {
                box.DataSource = source;
                box.DisplayMember = nameof(PurchaseCategory.Name);
            }
        }


        private void langSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocaleSelector.SetLocale((string)langSelectComboBox.SelectedItem);
            LocaleInit();
        }

        private void deleteProfileButton_Click(object sender, EventArgs e)
        {
            bool okDel = MessageBox.Show($"{Locale.DeleteProfileQuestion}?", $"{Locale.Attention}",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK;

            if (okDel)
            {
                dataConnection.DeleteUserProfile(ProfileName);

                this.DialogResult = DialogResult.Retry;
                this.Close();
            }
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            ExpenceRecord record = new ExpenceRecord()
            {
                Category = (addRecordCategoryComboBox.SelectedItem as PurchaseCategory) ?? new PurchaseCategory() { Name = $"{Locale.NoCategory}" },
                Price = priceNumericUpDown.Value,
                Comment = commentTextBox.Text,
                PurchaseDate = addDateTimePicker.Value
            };

            dataConnection.InsertExpenseRecord(ProfileName, record);

            UpdateAddDataGrid();
        }

        private void addDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateAddDataGrid();
        }

        private void UpdateAddDataGrid()
        {

            DateTime start = addDateTimePicker.Value.Date;
            DateTime stop = addDateTimePicker.Value.Date + TimeSpan.FromDays(1);

            dayDataGridView.DataSource = dataConnection.GetExpenceRecords(ProfileName, start, stop).ToList();

        }

        private void UpdateWeekDataGrid() => UpdateWeekDataGrid(0);

        private void UpdateWeekDataGrid(int weekShift = 0)
        {
            DateTime date = weekDateTimePicker.Value + TimeSpan.FromDays(weekShift * 7);
            weekDateTimePicker.Value = date;
            var dayDiff = date.DayOfWeek - DayOfWeek.Monday;
            if (dayDiff < 0) dayDiff = 6;
            DateTime start = date.Date - TimeSpan.FromDays(dayDiff);
            DateTime stop = start + TimeSpan.FromDays(7);

            weekStartdateTimePicker.Value = start;
            weekEndDateTimePicker.Value = stop - TimeSpan.FromDays(1);

            var records = GetRecordsFromTo(start, stop);


            if (!weekShowAllCheckBox.Checked)
            {
                records = FilterByCategory(records, weekCategoryComboBox.Text);
            }

            if (weekGroupCheckBox.Checked)
            {
                weekDataGridView.DataSource = records
                    .GroupBy(r => r.Category.Name)
                    .Select(g => new { Category = g.Key, Total = g.Sum(r => r.Price) }).ToList();
            }
            else
            {
                weekDataGridView.DataSource = records.ToList();
            }
        }

        IEnumerable<ExpenceRecord> GetRecordsFromTo(DateTime start, DateTime stop)
        {
            return dataConnection.GetExpenceRecords(ProfileName, start, stop).ToList();
        }

        IEnumerable<ExpenceRecord> FilterByCategory(IEnumerable<ExpenceRecord> records, string categoryName)
        {
            return records.Where(r => r.Category.Name == categoryName);
        }

        private void tabControlHome_Selected(object sender, TabControlEventArgs e)
        {
            var tab = e.TabPage;
            if (pageChangeDelegates.TryGetValue(tab, out Action action))
            {
                action.Invoke();
            }
        }

        private void AssignPageChangeDelegates()
        {
            pageChangeDelegates = new Dictionary<TabPage, Action>()
            {
                [addExpenceTab] = UpdateAddDataGrid,
                [WeekTab] = UpdateWeekDataGrid,
                [customPeriodTab] = UpdateCustomPeriodDataGrid
            };
        }

        private void AssignControlHandles()
        {
            customDateTimePicker.ValueChanged += UpdateCustomPeriodTabOnValueChanged;
            customDateRadioButton.CheckedChanged += UpdateCustomPeriodTabOnValueChanged;
            customDateRadioButton.CheckedChanged += CustomPeriodSelectionChange;
            monthRadioButton.CheckedChanged += UpdateCustomPeriodTabOnValueChanged;
            yearRadioButton.CheckedChanged += UpdateCustomPeriodTabOnValueChanged;
            customShowAllCheckBox.CheckStateChanged += UpdateCustomPeriodTabOnValueChanged;
            customGroupCheckBox.CheckedChanged += UpdateCustomPeriodTabOnValueChanged;
            customCategoryComboBox.SelectedIndexChanged += UpdateCustomPeriodTabOnValueChanged;
            customStartDateTimePicker.ValueChanged += UpdateCustomPeriodTabOnValueChanged;
            customStopDateTimePicker.ValueChanged += UpdateCustomPeriodTabOnValueChanged;
        }

        private void UpdateCustomPeriodDataGrid() => UpdateCustomPeriodDataGrid(0);

        private void UpdateCustomPeriodDataGrid(int shift = 0)
        {
            DateTime start;
            DateTime stop;
            DateTime date = customDateTimePicker.Value;

            if (customDateRadioButton.Checked)
            {
                start = customStartDateTimePicker.Value;
                stop = customStopDateTimePicker.Value + TimeSpan.FromDays(1);
            }
            else if (monthRadioButton.Checked)
            {
                start = new DateTime(date.Year, date.Month, 1).AddMonths(shift);
                stop = start.AddMonths(1);
                customDateTimePicker.Value = start;
            }
            else
            {
                start = new DateTime(date.Year, 1, 1).AddYears(shift);
                stop = start.AddYears(1);
                customDateTimePicker.Value = start;
            }

            customStartDateTimePicker.Value = start;
            customStopDateTimePicker.Value = stop - TimeSpan.FromDays(1);

            var records = GetRecordsFromTo(start, stop);

            if (!customShowAllCheckBox.Checked)
            {
                records = FilterByCategory(records, customCategoryComboBox.Text);
            }

            if (customGroupCheckBox.Checked)
            {
                customDateDataGridView.DataSource = records
                    .GroupBy(r => r.Category.Name)
                    .Select(g => new { Category = g.Key, Total = g.Sum(r => r.Price) }).ToList();
            }
            else
            {
                customDateDataGridView.DataSource = records.ToList();
            }
        }

        private void CustomPeriodSelectionChange(object sender, EventArgs e)
        {
            if (customDateRadioButton.Checked)
            {
                customDateTimePicker.Enabled = false;
                customNextButton.Enabled = false;
                customPrevButton.Enabled = false;

                customStartDateTimePicker.Enabled = true;
                customStopDateTimePicker.Enabled = true;
            }
            else
            {
                customDateTimePicker.Enabled = true;
                customNextButton.Enabled = true;
                customPrevButton.Enabled = true;

                customStartDateTimePicker.Enabled = false;
                customStopDateTimePicker.Enabled = false;
            }
        }

        private void weekDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateWeekDataGrid();
        }

        private void weekPrevButton_Click(object sender, EventArgs e)
        {
            UpdateWeekDataGrid(-1);
        }

        private void weekNextButton_Click(object sender, EventArgs e)
        {
            UpdateWeekDataGrid(+1);
        }

        private void weekShowChanged(object sender, EventArgs e)
        {
            UpdateWeekDataGrid();
        }

        private void cusomPrevButton_Click(object sender, EventArgs e)
        {
            UpdateCustomPeriodDataGrid(-1);
        }

        private void customNextButton_Click(object sender, EventArgs e)
        {
            UpdateCustomPeriodDataGrid(+1);
        }

        private void UpdateCustomPeriodTabOnValueChanged(object sender, EventArgs e)
        {
            UpdateCustomPeriodDataGrid();
        }

        private void deleteContextMenuItem_Click(object sender, EventArgs e)
        {
            var currentRow = dayDataGridView.CurrentRow;

            if (currentRow != null && currentRow.Index >= 0)
            {
                var record = dayDataGridView.CurrentRow.DataBoundItem as ExpenceRecord;

                dataConnection.RemoveExpenceRecord(ProfileName, record);

                UpdateAddDataGrid();
            }
        }

        private void editContextMenuItem_Click(object sender, EventArgs e)
        {
            var currentRow = dayDataGridView.CurrentRow;

            if (currentRow != null && currentRow.Index >= 0)
            {
                var record = dayDataGridView.CurrentRow.DataBoundItem as ExpenceRecord;
                var result = new EditRecord(ProfileName, dataConnection, record).ShowDialog();

                UpdateAddDataGrid();
            }
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            if (newCategoryTextBox.Text.Length > 0)
            {
                var existingCats = removeCategoryComboBox.DataSource as List<PurchaseCategory>;

                if (existingCats.Any(c => c.Name == newCategoryTextBox.Text))
                {
                    MessageBox.Show($"{Locale.CategoryExists}");
                    return;
                }

                dataConnection.InsertCategory(ProfileName, new PurchaseCategory() { Name = newCategoryTextBox.Text });
                newCategoryTextBox.Text = "";
                BindCategoryItems();
            }
        }

        private void removeCategoryButton_Click(object sender, EventArgs e)
        {
            if (removeCategoryComboBox.Items.Count == 1)
            {
                MessageBox.Show($"{Locale.OneCategoryShouldRemain}", $"{Locale.Error}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var category = removeCategoryComboBox.SelectedItem as PurchaseCategory;

            dataConnection.RemoveCategory(ProfileName, category);

            BindCategoryItems();
        }
    }
}
