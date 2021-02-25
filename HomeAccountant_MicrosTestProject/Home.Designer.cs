
namespace HomeAccountant_MicrosTestProject
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.tabControlHome = new System.Windows.Forms.TabControl();
            this.addExpenceTab = new System.Windows.Forms.TabPage();
            this.dayDataGridView = new System.Windows.Forms.DataGridView();
            this.addDgwContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.addDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addRecordCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.WeekTab = new System.Windows.Forms.TabPage();
            this.weekNextButton = new System.Windows.Forms.Button();
            this.weekEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.weekPrevButton = new System.Windows.Forms.Button();
            this.weekStartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.weekDataGridView = new System.Windows.Forms.DataGridView();
            this.weekGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.weekCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.weekShowAllCheckBox = new System.Windows.Forms.CheckBox();
            this.weekDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customPeriodTab = new System.Windows.Forms.TabPage();
            this.customDateDataGridView = new System.Windows.Forms.DataGridView();
            this.customNextButton = new System.Windows.Forms.Button();
            this.customStopDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.customStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customPrevButton = new System.Windows.Forms.Button();
            this.customDateRadioButton = new System.Windows.Forms.RadioButton();
            this.yearRadioButton = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.customGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.customCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.customShowAllCheckBox = new System.Windows.Forms.CheckBox();
            this.customDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.otherTab = new System.Windows.Forms.TabPage();
            this.categoryControlGroupBox = new System.Windows.Forms.GroupBox();
            this.removeCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.removeCategoryLabel = new System.Windows.Forms.Label();
            this.createCategoryLabel = new System.Windows.Forms.Label();
            this.newCategoryTextBox = new System.Windows.Forms.TextBox();
            this.removeCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dangerZoneGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteProfileButton = new System.Windows.Forms.Button();
            this.langSelectComboBox = new System.Windows.Forms.ComboBox();
            this.changeLangLabel = new System.Windows.Forms.Label();
            this.tabControlHome.SuspendLayout();
            this.addExpenceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayDataGridView)).BeginInit();
            this.addDgwContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.WeekTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekDataGridView)).BeginInit();
            this.customPeriodTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDateDataGridView)).BeginInit();
            this.otherTab.SuspendLayout();
            this.categoryControlGroupBox.SuspendLayout();
            this.dangerZoneGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHome
            // 
            this.tabControlHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlHome.Controls.Add(this.addExpenceTab);
            this.tabControlHome.Controls.Add(this.WeekTab);
            this.tabControlHome.Controls.Add(this.customPeriodTab);
            this.tabControlHome.Controls.Add(this.otherTab);
            this.tabControlHome.Location = new System.Drawing.Point(12, 12);
            this.tabControlHome.Name = "tabControlHome";
            this.tabControlHome.SelectedIndex = 0;
            this.tabControlHome.Size = new System.Drawing.Size(900, 529);
            this.tabControlHome.TabIndex = 0;
            this.tabControlHome.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlHome_Selected);
            // 
            // addExpenceTab
            // 
            this.addExpenceTab.Controls.Add(this.dayDataGridView);
            this.addExpenceTab.Controls.Add(this.priceNumericUpDown);
            this.addExpenceTab.Controls.Add(this.addRecordButton);
            this.addExpenceTab.Controls.Add(this.commentTextBox);
            this.addExpenceTab.Controls.Add(this.addDateTimePicker);
            this.addExpenceTab.Controls.Add(this.addRecordCategoryComboBox);
            this.addExpenceTab.Location = new System.Drawing.Point(4, 25);
            this.addExpenceTab.Name = "addExpenceTab";
            this.addExpenceTab.Padding = new System.Windows.Forms.Padding(3);
            this.addExpenceTab.Size = new System.Drawing.Size(892, 500);
            this.addExpenceTab.TabIndex = 0;
            this.addExpenceTab.Text = "Add new";
            this.addExpenceTab.UseVisualStyleBackColor = true;
            // 
            // dayDataGridView
            // 
            this.dayDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayDataGridView.ContextMenuStrip = this.addDgwContextMenuStrip;
            this.dayDataGridView.Location = new System.Drawing.Point(6, 77);
            this.dayDataGridView.MultiSelect = false;
            this.dayDataGridView.Name = "dayDataGridView";
            this.dayDataGridView.ReadOnly = true;
            this.dayDataGridView.RowHeadersWidth = 51;
            this.dayDataGridView.RowTemplate.Height = 24;
            this.dayDataGridView.Size = new System.Drawing.Size(880, 417);
            this.dayDataGridView.TabIndex = 6;
            // 
            // addDgwContextMenuStrip
            // 
            this.addDgwContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.addDgwContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editContextMenuItem,
            this.deleteContextMenuItem});
            this.addDgwContextMenuStrip.Name = "addDgwContextMenuStrip";
            this.addDgwContextMenuStrip.Size = new System.Drawing.Size(123, 52);
            // 
            // editContextMenuItem
            // 
            this.editContextMenuItem.Name = "editContextMenuItem";
            this.editContextMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editContextMenuItem.Text = "Edit";
            this.editContextMenuItem.Click += new System.EventHandler(this.editContextMenuItem_Click);
            // 
            // deleteContextMenuItem
            // 
            this.deleteContextMenuItem.Name = "deleteContextMenuItem";
            this.deleteContextMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteContextMenuItem.Text = "Delete";
            this.deleteContextMenuItem.Click += new System.EventHandler(this.deleteContextMenuItem_Click);
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(664, 25);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(106, 22);
            this.priceNumericUpDown.TabIndex = 4;
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(776, 25);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(98, 24);
            this.addRecordButton.TabIndex = 5;
            this.addRecordButton.Text = "Add record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(399, 25);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(258, 22);
            this.commentTextBox.TabIndex = 3;
            // 
            // addDateTimePicker
            // 
            this.addDateTimePicker.Location = new System.Drawing.Point(21, 25);
            this.addDateTimePicker.Name = "addDateTimePicker";
            this.addDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.addDateTimePicker.TabIndex = 1;
            this.addDateTimePicker.ValueChanged += new System.EventHandler(this.addDateTimePicker_ValueChanged);
            // 
            // addRecordCategoryComboBox
            // 
            this.addRecordCategoryComboBox.FormattingEnabled = true;
            this.addRecordCategoryComboBox.Location = new System.Drawing.Point(239, 25);
            this.addRecordCategoryComboBox.Name = "addRecordCategoryComboBox";
            this.addRecordCategoryComboBox.Size = new System.Drawing.Size(154, 24);
            this.addRecordCategoryComboBox.TabIndex = 2;
            // 
            // WeekTab
            // 
            this.WeekTab.Controls.Add(this.weekNextButton);
            this.WeekTab.Controls.Add(this.weekEndDateTimePicker);
            this.WeekTab.Controls.Add(this.label1);
            this.WeekTab.Controls.Add(this.weekPrevButton);
            this.WeekTab.Controls.Add(this.weekStartdateTimePicker);
            this.WeekTab.Controls.Add(this.weekDataGridView);
            this.WeekTab.Controls.Add(this.weekGroupCheckBox);
            this.WeekTab.Controls.Add(this.weekCategoryComboBox);
            this.WeekTab.Controls.Add(this.weekShowAllCheckBox);
            this.WeekTab.Controls.Add(this.weekDateTimePicker);
            this.WeekTab.Location = new System.Drawing.Point(4, 25);
            this.WeekTab.Name = "WeekTab";
            this.WeekTab.Padding = new System.Windows.Forms.Padding(3);
            this.WeekTab.Size = new System.Drawing.Size(892, 500);
            this.WeekTab.TabIndex = 1;
            this.WeekTab.Text = "Week";
            this.WeekTab.UseVisualStyleBackColor = true;
            // 
            // weekNextButton
            // 
            this.weekNextButton.Location = new System.Drawing.Point(558, 67);
            this.weekNextButton.Name = "weekNextButton";
            this.weekNextButton.Size = new System.Drawing.Size(75, 23);
            this.weekNextButton.TabIndex = 9;
            this.weekNextButton.Text = "Next";
            this.weekNextButton.UseVisualStyleBackColor = true;
            this.weekNextButton.Click += new System.EventHandler(this.weekNextButton_Click);
            // 
            // weekEndDateTimePicker
            // 
            this.weekEndDateTimePicker.Enabled = false;
            this.weekEndDateTimePicker.Location = new System.Drawing.Point(351, 67);
            this.weekEndDateTimePicker.Name = "weekEndDateTimePicker";
            this.weekEndDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.weekEndDateTimePicker.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "-";
            // 
            // weekPrevButton
            // 
            this.weekPrevButton.Location = new System.Drawing.Point(15, 67);
            this.weekPrevButton.Name = "weekPrevButton";
            this.weekPrevButton.Size = new System.Drawing.Size(103, 23);
            this.weekPrevButton.TabIndex = 6;
            this.weekPrevButton.Text = "Prev.";
            this.weekPrevButton.UseVisualStyleBackColor = true;
            this.weekPrevButton.Click += new System.EventHandler(this.weekPrevButton_Click);
            // 
            // weekStartdateTimePicker
            // 
            this.weekStartdateTimePicker.Enabled = false;
            this.weekStartdateTimePicker.Location = new System.Drawing.Point(124, 67);
            this.weekStartdateTimePicker.Name = "weekStartdateTimePicker";
            this.weekStartdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.weekStartdateTimePicker.TabIndex = 5;
            // 
            // weekDataGridView
            // 
            this.weekDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weekDataGridView.Location = new System.Drawing.Point(15, 108);
            this.weekDataGridView.Name = "weekDataGridView";
            this.weekDataGridView.ReadOnly = true;
            this.weekDataGridView.RowHeadersWidth = 51;
            this.weekDataGridView.RowTemplate.Height = 24;
            this.weekDataGridView.Size = new System.Drawing.Size(871, 386);
            this.weekDataGridView.TabIndex = 4;
            // 
            // weekGroupCheckBox
            // 
            this.weekGroupCheckBox.AutoSize = true;
            this.weekGroupCheckBox.Checked = true;
            this.weekGroupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.weekGroupCheckBox.Location = new System.Drawing.Point(598, 17);
            this.weekGroupCheckBox.Name = "weekGroupCheckBox";
            this.weekGroupCheckBox.Size = new System.Drawing.Size(70, 21);
            this.weekGroupCheckBox.TabIndex = 3;
            this.weekGroupCheckBox.Text = "Group";
            this.weekGroupCheckBox.UseVisualStyleBackColor = true;
            this.weekGroupCheckBox.CheckedChanged += new System.EventHandler(this.weekShowChanged);
            // 
            // weekCategoryComboBox
            // 
            this.weekCategoryComboBox.FormattingEnabled = true;
            this.weekCategoryComboBox.Location = new System.Drawing.Point(373, 15);
            this.weekCategoryComboBox.Name = "weekCategoryComboBox";
            this.weekCategoryComboBox.Size = new System.Drawing.Size(195, 24);
            this.weekCategoryComboBox.TabIndex = 2;
            this.weekCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.weekShowChanged);
            // 
            // weekShowAllCheckBox
            // 
            this.weekShowAllCheckBox.AutoSize = true;
            this.weekShowAllCheckBox.Checked = true;
            this.weekShowAllCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.weekShowAllCheckBox.Location = new System.Drawing.Point(241, 19);
            this.weekShowAllCheckBox.Name = "weekShowAllCheckBox";
            this.weekShowAllCheckBox.Size = new System.Drawing.Size(83, 21);
            this.weekShowAllCheckBox.TabIndex = 1;
            this.weekShowAllCheckBox.Text = "Show All";
            this.weekShowAllCheckBox.UseVisualStyleBackColor = true;
            this.weekShowAllCheckBox.CheckedChanged += new System.EventHandler(this.weekShowChanged);
            // 
            // weekDateTimePicker
            // 
            this.weekDateTimePicker.Location = new System.Drawing.Point(15, 19);
            this.weekDateTimePicker.Name = "weekDateTimePicker";
            this.weekDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.weekDateTimePicker.TabIndex = 0;
            this.weekDateTimePicker.ValueChanged += new System.EventHandler(this.weekDateTimePicker_ValueChanged);
            // 
            // customPeriodTab
            // 
            this.customPeriodTab.Controls.Add(this.customDateDataGridView);
            this.customPeriodTab.Controls.Add(this.customNextButton);
            this.customPeriodTab.Controls.Add(this.customStopDateTimePicker);
            this.customPeriodTab.Controls.Add(this.label2);
            this.customPeriodTab.Controls.Add(this.customStartDateTimePicker);
            this.customPeriodTab.Controls.Add(this.customPrevButton);
            this.customPeriodTab.Controls.Add(this.customDateRadioButton);
            this.customPeriodTab.Controls.Add(this.yearRadioButton);
            this.customPeriodTab.Controls.Add(this.monthRadioButton);
            this.customPeriodTab.Controls.Add(this.customGroupCheckBox);
            this.customPeriodTab.Controls.Add(this.customCategoryComboBox);
            this.customPeriodTab.Controls.Add(this.customShowAllCheckBox);
            this.customPeriodTab.Controls.Add(this.customDateTimePicker);
            this.customPeriodTab.Location = new System.Drawing.Point(4, 25);
            this.customPeriodTab.Name = "customPeriodTab";
            this.customPeriodTab.Padding = new System.Windows.Forms.Padding(3);
            this.customPeriodTab.Size = new System.Drawing.Size(892, 500);
            this.customPeriodTab.TabIndex = 3;
            this.customPeriodTab.Text = "Custom Period";
            this.customPeriodTab.UseVisualStyleBackColor = true;
            // 
            // customDateDataGridView
            // 
            this.customDateDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customDateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDateDataGridView.Location = new System.Drawing.Point(6, 118);
            this.customDateDataGridView.Name = "customDateDataGridView";
            this.customDateDataGridView.RowHeadersWidth = 51;
            this.customDateDataGridView.RowTemplate.Height = 24;
            this.customDateDataGridView.Size = new System.Drawing.Size(880, 376);
            this.customDateDataGridView.TabIndex = 12;
            // 
            // customNextButton
            // 
            this.customNextButton.Location = new System.Drawing.Point(554, 71);
            this.customNextButton.Name = "customNextButton";
            this.customNextButton.Size = new System.Drawing.Size(75, 23);
            this.customNextButton.TabIndex = 11;
            this.customNextButton.Text = "Next";
            this.customNextButton.UseVisualStyleBackColor = true;
            this.customNextButton.Click += new System.EventHandler(this.customNextButton_Click);
            // 
            // customStopDateTimePicker
            // 
            this.customStopDateTimePicker.Location = new System.Drawing.Point(333, 71);
            this.customStopDateTimePicker.Name = "customStopDateTimePicker";
            this.customStopDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.customStopDateTimePicker.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // customStartDateTimePicker
            // 
            this.customStartDateTimePicker.Location = new System.Drawing.Point(106, 71);
            this.customStartDateTimePicker.Name = "customStartDateTimePicker";
            this.customStartDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.customStartDateTimePicker.TabIndex = 8;
            // 
            // customPrevButton
            // 
            this.customPrevButton.Location = new System.Drawing.Point(6, 71);
            this.customPrevButton.Name = "customPrevButton";
            this.customPrevButton.Size = new System.Drawing.Size(75, 23);
            this.customPrevButton.TabIndex = 7;
            this.customPrevButton.Text = "Prev.";
            this.customPrevButton.UseVisualStyleBackColor = true;
            this.customPrevButton.Click += new System.EventHandler(this.cusomPrevButton_Click);
            // 
            // customDateRadioButton
            // 
            this.customDateRadioButton.AutoSize = true;
            this.customDateRadioButton.Location = new System.Drawing.Point(737, 72);
            this.customDateRadioButton.Name = "customDateRadioButton";
            this.customDateRadioButton.Size = new System.Drawing.Size(121, 21);
            this.customDateRadioButton.TabIndex = 6;
            this.customDateRadioButton.TabStop = true;
            this.customDateRadioButton.Text = "Custom Period";
            this.customDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearRadioButton
            // 
            this.yearRadioButton.AutoSize = true;
            this.yearRadioButton.Location = new System.Drawing.Point(737, 44);
            this.yearRadioButton.Name = "yearRadioButton";
            this.yearRadioButton.Size = new System.Drawing.Size(59, 21);
            this.yearRadioButton.TabIndex = 5;
            this.yearRadioButton.TabStop = true;
            this.yearRadioButton.Text = "Year";
            this.yearRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Checked = true;
            this.monthRadioButton.Location = new System.Drawing.Point(737, 16);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(68, 21);
            this.monthRadioButton.TabIndex = 4;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "Month";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            // 
            // customGroupCheckBox
            // 
            this.customGroupCheckBox.AutoSize = true;
            this.customGroupCheckBox.Checked = true;
            this.customGroupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customGroupCheckBox.Location = new System.Drawing.Point(542, 18);
            this.customGroupCheckBox.Name = "customGroupCheckBox";
            this.customGroupCheckBox.Size = new System.Drawing.Size(70, 21);
            this.customGroupCheckBox.TabIndex = 3;
            this.customGroupCheckBox.Text = "Group";
            this.customGroupCheckBox.UseVisualStyleBackColor = true;
            // 
            // customCategoryComboBox
            // 
            this.customCategoryComboBox.FormattingEnabled = true;
            this.customCategoryComboBox.Location = new System.Drawing.Point(346, 16);
            this.customCategoryComboBox.Name = "customCategoryComboBox";
            this.customCategoryComboBox.Size = new System.Drawing.Size(174, 24);
            this.customCategoryComboBox.TabIndex = 2;
            // 
            // customShowAllCheckBox
            // 
            this.customShowAllCheckBox.AutoSize = true;
            this.customShowAllCheckBox.Checked = true;
            this.customShowAllCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customShowAllCheckBox.Location = new System.Drawing.Point(227, 18);
            this.customShowAllCheckBox.Name = "customShowAllCheckBox";
            this.customShowAllCheckBox.Size = new System.Drawing.Size(88, 21);
            this.customShowAllCheckBox.TabIndex = 1;
            this.customShowAllCheckBox.Text = "Select All";
            this.customShowAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // customDateTimePicker
            // 
            this.customDateTimePicker.Location = new System.Drawing.Point(6, 18);
            this.customDateTimePicker.Name = "customDateTimePicker";
            this.customDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.customDateTimePicker.TabIndex = 0;
            this.customDateTimePicker.ValueChanged += new System.EventHandler(this.UpdateCustomPeriodTabOnValueChanged);
            // 
            // otherTab
            // 
            this.otherTab.Controls.Add(this.categoryControlGroupBox);
            this.otherTab.Controls.Add(this.dangerZoneGroupBox);
            this.otherTab.Controls.Add(this.langSelectComboBox);
            this.otherTab.Controls.Add(this.changeLangLabel);
            this.otherTab.Location = new System.Drawing.Point(4, 25);
            this.otherTab.Name = "otherTab";
            this.otherTab.Padding = new System.Windows.Forms.Padding(3);
            this.otherTab.Size = new System.Drawing.Size(892, 500);
            this.otherTab.TabIndex = 5;
            this.otherTab.Text = "Other";
            this.otherTab.UseVisualStyleBackColor = true;
            // 
            // categoryControlGroupBox
            // 
            this.categoryControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryControlGroupBox.Controls.Add(this.removeCategoryButton);
            this.categoryControlGroupBox.Controls.Add(this.addCategoryButton);
            this.categoryControlGroupBox.Controls.Add(this.removeCategoryLabel);
            this.categoryControlGroupBox.Controls.Add(this.createCategoryLabel);
            this.categoryControlGroupBox.Controls.Add(this.newCategoryTextBox);
            this.categoryControlGroupBox.Controls.Add(this.removeCategoryComboBox);
            this.categoryControlGroupBox.Location = new System.Drawing.Point(9, 74);
            this.categoryControlGroupBox.MinimumSize = new System.Drawing.Size(0, 200);
            this.categoryControlGroupBox.Name = "categoryControlGroupBox";
            this.categoryControlGroupBox.Size = new System.Drawing.Size(810, 207);
            this.categoryControlGroupBox.TabIndex = 3;
            this.categoryControlGroupBox.TabStop = false;
            this.categoryControlGroupBox.Text = "Category Control";
            // 
            // removeCategoryButton
            // 
            this.removeCategoryButton.Location = new System.Drawing.Point(252, 108);
            this.removeCategoryButton.Name = "removeCategoryButton";
            this.removeCategoryButton.Size = new System.Drawing.Size(91, 28);
            this.removeCategoryButton.TabIndex = 5;
            this.removeCategoryButton.Text = "Remove";
            this.removeCategoryButton.UseVisualStyleBackColor = true;
            this.removeCategoryButton.Click += new System.EventHandler(this.removeCategoryButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(252, 57);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(91, 28);
            this.addCategoryButton.TabIndex = 4;
            this.addCategoryButton.Text = "Add";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // removeCategoryLabel
            // 
            this.removeCategoryLabel.AutoSize = true;
            this.removeCategoryLabel.Location = new System.Drawing.Point(18, 115);
            this.removeCategoryLabel.Name = "removeCategoryLabel";
            this.removeCategoryLabel.Size = new System.Drawing.Size(60, 17);
            this.removeCategoryLabel.TabIndex = 3;
            this.removeCategoryLabel.Text = "Remove";
            // 
            // createCategoryLabel
            // 
            this.createCategoryLabel.AutoSize = true;
            this.createCategoryLabel.Location = new System.Drawing.Point(18, 57);
            this.createCategoryLabel.Name = "createCategoryLabel";
            this.createCategoryLabel.Size = new System.Drawing.Size(39, 17);
            this.createCategoryLabel.TabIndex = 2;
            this.createCategoryLabel.Text = "New:";
            // 
            // newCategoryTextBox
            // 
            this.newCategoryTextBox.Location = new System.Drawing.Point(86, 57);
            this.newCategoryTextBox.Name = "newCategoryTextBox";
            this.newCategoryTextBox.Size = new System.Drawing.Size(138, 22);
            this.newCategoryTextBox.TabIndex = 1;
            // 
            // removeCategoryComboBox
            // 
            this.removeCategoryComboBox.FormattingEnabled = true;
            this.removeCategoryComboBox.Location = new System.Drawing.Point(86, 112);
            this.removeCategoryComboBox.Name = "removeCategoryComboBox";
            this.removeCategoryComboBox.Size = new System.Drawing.Size(138, 24);
            this.removeCategoryComboBox.TabIndex = 0;
            // 
            // dangerZoneGroupBox
            // 
            this.dangerZoneGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dangerZoneGroupBox.Controls.Add(this.deleteProfileButton);
            this.dangerZoneGroupBox.Location = new System.Drawing.Point(9, 287);
            this.dangerZoneGroupBox.MinimumSize = new System.Drawing.Size(0, 100);
            this.dangerZoneGroupBox.Name = "dangerZoneGroupBox";
            this.dangerZoneGroupBox.Size = new System.Drawing.Size(810, 207);
            this.dangerZoneGroupBox.TabIndex = 2;
            this.dangerZoneGroupBox.TabStop = false;
            this.dangerZoneGroupBox.Text = "Danger Zone";
            // 
            // deleteProfileButton
            // 
            this.deleteProfileButton.Location = new System.Drawing.Point(21, 35);
            this.deleteProfileButton.Name = "deleteProfileButton";
            this.deleteProfileButton.Size = new System.Drawing.Size(144, 34);
            this.deleteProfileButton.TabIndex = 0;
            this.deleteProfileButton.Text = "Delete Profile";
            this.deleteProfileButton.UseVisualStyleBackColor = true;
            this.deleteProfileButton.Click += new System.EventHandler(this.deleteProfileButton_Click);
            // 
            // langSelectComboBox
            // 
            this.langSelectComboBox.FormattingEnabled = true;
            this.langSelectComboBox.Location = new System.Drawing.Point(173, 23);
            this.langSelectComboBox.Name = "langSelectComboBox";
            this.langSelectComboBox.Size = new System.Drawing.Size(121, 24);
            this.langSelectComboBox.TabIndex = 1;
            // 
            // changeLangLabel
            // 
            this.changeLangLabel.AutoSize = true;
            this.changeLangLabel.Location = new System.Drawing.Point(27, 23);
            this.changeLangLabel.Name = "changeLangLabel";
            this.changeLangLabel.Size = new System.Drawing.Size(120, 17);
            this.changeLangLabel.TabIndex = 0;
            this.changeLangLabel.Text = "Change language";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 553);
            this.Controls.Add(this.tabControlHome);
            this.MinimumSize = new System.Drawing.Size(18, 500);
            this.Name = "Home";
            this.Text = "Accountant - Home";
            this.tabControlHome.ResumeLayout(false);
            this.addExpenceTab.ResumeLayout(false);
            this.addExpenceTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayDataGridView)).EndInit();
            this.addDgwContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.WeekTab.ResumeLayout(false);
            this.WeekTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekDataGridView)).EndInit();
            this.customPeriodTab.ResumeLayout(false);
            this.customPeriodTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDateDataGridView)).EndInit();
            this.otherTab.ResumeLayout(false);
            this.otherTab.PerformLayout();
            this.categoryControlGroupBox.ResumeLayout(false);
            this.categoryControlGroupBox.PerformLayout();
            this.dangerZoneGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHome;
        private System.Windows.Forms.TabPage addExpenceTab;
        private System.Windows.Forms.TabPage WeekTab;
        private System.Windows.Forms.TabPage customPeriodTab;
        private System.Windows.Forms.TabPage otherTab;
        private System.Windows.Forms.Label changeLangLabel;
        private System.Windows.Forms.GroupBox dangerZoneGroupBox;
        private System.Windows.Forms.ComboBox langSelectComboBox;
        private System.Windows.Forms.GroupBox categoryControlGroupBox;
        private System.Windows.Forms.Button deleteProfileButton;
        private System.Windows.Forms.DataGridView dayDataGridView;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.DateTimePicker addDateTimePicker;
        private System.Windows.Forms.ComboBox addRecordCategoryComboBox;
        private System.Windows.Forms.DataGridView weekDataGridView;
        private System.Windows.Forms.CheckBox weekGroupCheckBox;
        private System.Windows.Forms.ComboBox weekCategoryComboBox;
        private System.Windows.Forms.CheckBox weekShowAllCheckBox;
        private System.Windows.Forms.DateTimePicker weekDateTimePicker;
        private System.Windows.Forms.Button weekNextButton;
        private System.Windows.Forms.DateTimePicker weekEndDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button weekPrevButton;
        private System.Windows.Forms.DateTimePicker weekStartdateTimePicker;
        private System.Windows.Forms.ContextMenuStrip addDgwContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContextMenuItem;
        private System.Windows.Forms.DataGridView customDateDataGridView;
        private System.Windows.Forms.Button customNextButton;
        private System.Windows.Forms.DateTimePicker customStopDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker customStartDateTimePicker;
        private System.Windows.Forms.Button customPrevButton;
        private System.Windows.Forms.RadioButton customDateRadioButton;
        private System.Windows.Forms.RadioButton yearRadioButton;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.CheckBox customGroupCheckBox;
        private System.Windows.Forms.ComboBox customCategoryComboBox;
        private System.Windows.Forms.CheckBox customShowAllCheckBox;
        private System.Windows.Forms.DateTimePicker customDateTimePicker;
        private System.Windows.Forms.Button removeCategoryButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label removeCategoryLabel;
        private System.Windows.Forms.Label createCategoryLabel;
        private System.Windows.Forms.TextBox newCategoryTextBox;
        private System.Windows.Forms.ComboBox removeCategoryComboBox;
    }
}

