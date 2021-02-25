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
        IDataConnection data;
        string profileName;
        ExpenceRecord record;

        public EditRecord(string profileName, IDataConnection data, ExpenceRecord record)
        {
            InitializeComponent();

            LocaleInit();

            this.data = data;
            this.profileName = profileName;
            this.record = record;

            categoryComboBox.DataSource = data.GetCategories(profileName).ToList();
            categoryComboBox.DisplayMember = nameof(PurchaseCategory.Name);
            categoryComboBox.SelectedIndex = GetSelectedComboboxIndex(record.Category);

            commentTextBox.Text = record.Comment;
            priceNumericUpDown.Value = record.Price;
        }

        private void LocaleInit()
        {
            this.Text = Locale.EditRecordText;
            button1.Text = Locale.SaveButtonText;
        }

        private int GetSelectedComboboxIndex(PurchaseCategory category)
        {
            int index = categoryComboBox.Items.IndexOf(category);

            return index >= 0 ? index : 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            record.Category = categoryComboBox.SelectedItem as PurchaseCategory;
            record.Comment = commentTextBox.Text;
            record.Price = priceNumericUpDown.Value;

            data.UpdateExpenceRecord(profileName, record);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
