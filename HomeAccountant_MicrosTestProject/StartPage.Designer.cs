
namespace HomeAccountant_MicrosTestProject
{
    partial class StartPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectProfileLabel = new System.Windows.Forms.Label();
            this.profileListBox = new System.Windows.Forms.ListBox();
            this.selectProfileButton = new System.Windows.Forms.Button();
            this.createProfileButton = new System.Windows.Forms.Button();
            this.newProfileNameTextBox = new System.Windows.Forms.TextBox();
            this.createProfileLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selectProfileLabel
            // 
            this.selectProfileLabel.AutoSize = true;
            this.selectProfileLabel.Location = new System.Drawing.Point(12, 18);
            this.selectProfileLabel.Name = "selectProfileLabel";
            this.selectProfileLabel.Size = new System.Drawing.Size(91, 17);
            this.selectProfileLabel.TabIndex = 0;
            this.selectProfileLabel.Text = "Select Profile";
            // 
            // profileListBox
            // 
            this.profileListBox.ItemHeight = 16;
            this.profileListBox.Location = new System.Drawing.Point(12, 48);
            this.profileListBox.Name = "profileListBox";
            this.profileListBox.Size = new System.Drawing.Size(312, 212);
            this.profileListBox.TabIndex = 1;
            // 
            // selectProfileButton
            // 
            this.selectProfileButton.Location = new System.Drawing.Point(12, 266);
            this.selectProfileButton.Name = "selectProfileButton";
            this.selectProfileButton.Size = new System.Drawing.Size(312, 44);
            this.selectProfileButton.TabIndex = 2;
            this.selectProfileButton.Text = "Select";
            this.selectProfileButton.UseVisualStyleBackColor = true;
            this.selectProfileButton.Click += new System.EventHandler(this.selectProfileButton_Click);
            // 
            // createProfileButton
            // 
            this.createProfileButton.Location = new System.Drawing.Point(12, 392);
            this.createProfileButton.Name = "createProfileButton";
            this.createProfileButton.Size = new System.Drawing.Size(312, 46);
            this.createProfileButton.TabIndex = 3;
            this.createProfileButton.Text = "Create";
            this.createProfileButton.UseVisualStyleBackColor = true;
            this.createProfileButton.Click += new System.EventHandler(this.createProfileButton_Click);
            // 
            // newProfileNameTextBox
            // 
            this.newProfileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newProfileNameTextBox.Location = new System.Drawing.Point(12, 354);
            this.newProfileNameTextBox.Name = "newProfileNameTextBox";
            this.newProfileNameTextBox.Size = new System.Drawing.Size(312, 30);
            this.newProfileNameTextBox.TabIndex = 4;
            // 
            // createProfileLabel
            // 
            this.createProfileLabel.AutoSize = true;
            this.createProfileLabel.Location = new System.Drawing.Point(12, 334);
            this.createProfileLabel.Name = "createProfileLabel";
            this.createProfileLabel.Size = new System.Drawing.Size(243, 17);
            this.createProfileLabel.TabIndex = 5;
            this.createProfileLabel.Text = "Or Create a New Profile (3-25 letters)";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(167, 18);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(72, 17);
            this.languageLabel.TabIndex = 6;
            this.languageLabel.Text = "Language";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(246, 15);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(78, 24);
            this.languageComboBox.TabIndex = 7;
            // 
            // StartPage
            // 
            this.AcceptButton = this.createProfileButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.createProfileLabel);
            this.Controls.Add(this.newProfileNameTextBox);
            this.Controls.Add(this.createProfileButton);
            this.Controls.Add(this.selectProfileButton);
            this.Controls.Add(this.profileListBox);
            this.Controls.Add(this.selectProfileLabel);
            this.MaximizeBox = false;
            this.Name = "StartPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectProfileLabel;
        private System.Windows.Forms.ListBox profileListBox;
        private System.Windows.Forms.Button selectProfileButton;
        private System.Windows.Forms.Button createProfileButton;
        private System.Windows.Forms.TextBox newProfileNameTextBox;
        private System.Windows.Forms.Label createProfileLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}