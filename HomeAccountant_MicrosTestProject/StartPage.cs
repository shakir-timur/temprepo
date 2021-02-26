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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();

            DataInit();

            ApplySavedConfig();
        }

        private void ApplySavedConfig()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettings = config.AppSettings.Settings;
            var locale = appSettings["locale"];
            var profile = appSettings["profile"];

            if (locale != null )
            {
                int ind = languageComboBox.Items.IndexOf(locale.Value == "" ? "En" : locale.Value);
                if (ind >= 0) languageComboBox.SelectedIndex = ind;
            }

            if (profile  != null)
            {
                string profileName = profile.Value;
                var userProfile = profileListBox.Items.Cast<UserProfile>().Where(p => p.UserName == profileName).FirstOrDefault();
                if (userProfile != null)
                {
                    int ind = profileListBox.Items.IndexOf(userProfile);
                    if (ind >= 0) profileListBox.SelectedIndex = ind;
                }
            }
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

            var defaultExpenceCats = Locale.DefaultExpenceCategoryNames.Split(';');
            var defaultIncomeCats = Locale.DefaultIncomeCategoryNames.Split(';');

            using (var dataConnection = new LiteDbDataConnection())
            {
                dataConnection.CreateUserProfile(name, defaultExpenceCats, defaultIncomeCats);
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
