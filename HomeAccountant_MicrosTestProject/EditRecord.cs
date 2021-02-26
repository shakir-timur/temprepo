using HomeAccountant_MicrosTestProject.DataConnection;
using HomeAccountant_MicrosTestProject.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccountant_MicrosTestProject
{
    public partial class EditRecord : Form
    {
        IDbDataConnection data;
        string profileName;
        AccountRecord record;

        public EditRecord(string profileName, IDbDataConnection data, AccountRecord record)
        {
            InitializeComponent();

            LocaleInit();

            this.data = data;
            this.profileName = profileName;
            this.record = record;

            categoryComboBox.DataSource = 
                record.RecordType == AccountRecordType.Expence ?
                data.GetExpenceCategories(profileName).ToList() :
                data.GetIncomeCategories(profileName).ToList();

            categoryComboBox.DisplayMember = nameof(RecordCategory.Name);
            categoryComboBox.SelectedIndex = GetSelectedComboboxIndex(record.Category);

            commentTextBox.Text = record.Comment;
            priceNumericUpDown.Value = record.Amount;
        }

        private void LocaleInit()
        {
            this.Text = Locale.EditRecordText;
            button1.Text = Locale.SaveButtonText;
        }

        private int GetSelectedComboboxIndex(RecordCategory category)
        {
            int index = categoryComboBox.Items.IndexOf(category);

            return index >= 0 ? index : 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            record.Category = categoryComboBox.SelectedItem as RecordCategory;
            record.Comment = commentTextBox.Text;
            record.Amount = priceNumericUpDown.Value;

            data.UpdateAccountRecord(profileName, record);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
