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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();

            DataInit();
        }

        private void ValidateSelectButton()
        {
            selectProfileButton.Enabled = (profileListBox.SelectedIndex >= 0);
        }

        private void ValidateNewUserTextBox(object sender = null, EventArgs e = null)
        {
            var name = newProfileNameTextBox.Text.Trim();

            bool valid = name.Length >= 3 && name.Length <= 25 &&
                name.All(c =>
                {
                    return char.IsLetterOrDigit(c) || c == ' ';
                });

            createProfileButton.Enabled = valid;
        }

        private void LocaleInit()
        {
            selectProfileLabel.Text = Locale.SelectProfileLabelText;
            languageLabel.Text = Locale.LanguageLabelText;
            selectProfileButton.Text = Locale.SelectProfileButtonText;
            createProfileLabel.Text = Locale.CreateProfileLabelText;
            createProfileButton.Text = Locale.CreateProfileButtonText;
            this.Text = Locale.StartPageText;

            LocaleSelector.SetComboboxDataSource(languageComboBox, languageComboBox_SelectedIndexChanged);


        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocaleSelector.SetLocale((string)languageComboBox.SelectedItem);
            LocaleInit();
        }

        private void createProfileButton_Click(object sender, EventArgs e)
        {
            var name = newProfileNameTextBox.Text.Trim();

            if (profileListBox.Items != null && profileListBox.Items.Cast<UserProfile>().Any(p => p.UserName == name))
            {
                MessageBox.Show("Name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var defaultCategories = Locale.DefaultCategoryNames.Split(';');

            using (var dataConnection = new LiteDbDataConnection())
            {
                dataConnection.CreateUserProfile(name, defaultCategories);
            }

            LoadHomePage(name);
        }

        private void LoadHomePage(string profileName)
        {
            var newHome = new Home(profileName);
            newHome.Show();
            newHome.FormClosed += (s, a) => this.ShowAfterHomeClosed(s);
            this.Hide();
        }

        private void ShowAfterHomeClosed(object sender)
        {
            var home = (Form)sender;
            if (home.DialogResult == DialogResult.Retry)
            {
                this.DataInit();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void DataInit()
        {
            LocaleInit();

            newProfileNameTextBox.Text = "";

            ValidateNewUserTextBox();

            newProfileNameTextBox.TextChanged += ValidateNewUserTextBox;

            using (var dbconn = new LiteDbDataConnection())
            {
                profileListBox.DataSource = dbconn.GetUserProfiles().ToList();
            }

            profileListBox.DisplayMember = nameof(UserProfile.UserName);

            ValidateSelectButton();
        }

        private void selectProfileButton_Click(object sender, EventArgs e)
        {
            string name = (profileListBox.SelectedItem as UserProfile).UserName;

            LoadHomePage(name);
        }
    }
}
