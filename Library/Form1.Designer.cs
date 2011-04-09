namespace Library
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.allBooksTab = new System.Windows.Forms.TabPage();
            this.allBooksGridView = new System.Windows.Forms.DataGridView();
            this.allBooksTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allBooksAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allBooksType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.allBooksStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.allBooksCheckedOutTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allBooksCheckoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allBooksDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdueBooksTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.overdueGridView = new System.Windows.Forms.DataGridView();
            this.overdueTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdueAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdueType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.overdueCheckedOutTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdueCheckoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdueDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdueCheckIn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkedOutBooksTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedOutGridView = new System.Windows.Forms.DataGridView();
            this.checkedOutTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedOutAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedOutType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.checkedOutStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.checkedOutCheckedOutTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedOutCheckoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedOutDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedOutCheckIn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.availableBooksTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.availableBooksGridView = new System.Windows.Forms.DataGridView();
            this.availableBooksTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableBooksAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableBooksType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.availableBooksCheckOut = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.claimFileDirButton = new System.Windows.Forms.Button();
            this.databaseFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.databaseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.allBooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksGridView)).BeginInit();
            this.overdueBooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overdueGridView)).BeginInit();
            this.checkedOutBooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedOutGridView)).BeginInit();
            this.availableBooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooksGridView)).BeginInit();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.settingsTab);
            this.tabControl1.Controls.Add(this.allBooksTab);
            this.tabControl1.Controls.Add(this.overdueBooksTab);
            this.tabControl1.Controls.Add(this.checkedOutBooksTab);
            this.tabControl1.Controls.Add(this.availableBooksTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // allBooksTab
            // 
            this.allBooksTab.Controls.Add(this.allBooksGridView);
            this.allBooksTab.Location = new System.Drawing.Point(4, 22);
            this.allBooksTab.Name = "allBooksTab";
            this.allBooksTab.Padding = new System.Windows.Forms.Padding(3);
            this.allBooksTab.Size = new System.Drawing.Size(941, 449);
            this.allBooksTab.TabIndex = 0;
            this.allBooksTab.Text = "All Books";
            this.allBooksTab.UseVisualStyleBackColor = true;
            // 
            // allBooksGridView
            // 
            this.allBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allBooksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.allBooksTitle,
            this.allBooksAuthor,
            this.allBooksType,
            this.allBooksStatus,
            this.allBooksCheckedOutTo,
            this.allBooksCheckoutDate,
            this.allBooksDueDate});
            this.allBooksGridView.Location = new System.Drawing.Point(7, 43);
            this.allBooksGridView.Name = "allBooksGridView";
            this.allBooksGridView.Size = new System.Drawing.Size(928, 315);
            this.allBooksGridView.TabIndex = 0;
            // 
            // allBooksTitle
            // 
            this.allBooksTitle.HeaderText = "Title";
            this.allBooksTitle.MaxInputLength = 120;
            this.allBooksTitle.Name = "allBooksTitle";
            this.allBooksTitle.Width = 190;
            // 
            // allBooksAuthor
            // 
            this.allBooksAuthor.HeaderText = "Author";
            this.allBooksAuthor.MaxInputLength = 60;
            this.allBooksAuthor.Name = "allBooksAuthor";
            this.allBooksAuthor.Width = 110;
            // 
            // allBooksType
            // 
            this.allBooksType.HeaderText = "Type";
            this.allBooksType.Items.AddRange(new object[] {
            "Adult",
            "Children\'s",
            "DVD",
            "Videotape"});
            this.allBooksType.Name = "allBooksType";
            this.allBooksType.Width = 80;
            // 
            // allBooksStatus
            // 
            this.allBooksStatus.HeaderText = "Status";
            this.allBooksStatus.Items.AddRange(new object[] {
            "Available",
            "Checked Out",
            "Overdue"});
            this.allBooksStatus.Name = "allBooksStatus";
            this.allBooksStatus.Width = 95;
            // 
            // allBooksCheckedOutTo
            // 
            this.allBooksCheckedOutTo.HeaderText = "Checked Out To";
            this.allBooksCheckedOutTo.MaxInputLength = 60;
            this.allBooksCheckedOutTo.Name = "allBooksCheckedOutTo";
            this.allBooksCheckedOutTo.Width = 110;
            // 
            // allBooksCheckoutDate
            // 
            this.allBooksCheckoutDate.HeaderText = "Checkout Date";
            this.allBooksCheckoutDate.MaxInputLength = 12;
            this.allBooksCheckoutDate.Name = "allBooksCheckoutDate";
            this.allBooksCheckoutDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.allBooksCheckoutDate.Width = 110;
            // 
            // allBooksDueDate
            // 
            this.allBooksDueDate.HeaderText = "Due Date";
            this.allBooksDueDate.MaxInputLength = 12;
            this.allBooksDueDate.Name = "allBooksDueDate";
            this.allBooksDueDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.allBooksDueDate.Width = 90;
            // 
            // overdueBooksTab
            // 
            this.overdueBooksTab.Controls.Add(this.label2);
            this.overdueBooksTab.Controls.Add(this.comboBox2);
            this.overdueBooksTab.Controls.Add(this.button1);
            this.overdueBooksTab.Controls.Add(this.overdueGridView);
            this.overdueBooksTab.Location = new System.Drawing.Point(4, 22);
            this.overdueBooksTab.Name = "overdueBooksTab";
            this.overdueBooksTab.Size = new System.Drawing.Size(941, 449);
            this.overdueBooksTab.TabIndex = 2;
            this.overdueBooksTab.Text = "Overdue Books";
            this.overdueBooksTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter by books checked out to";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(159, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(291, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(746, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check in selected books";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // overdueGridView
            // 
            this.overdueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overdueGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.overdueTitle,
            this.overdueAuthor,
            this.overdueType,
            this.overdueCheckedOutTo,
            this.overdueCheckoutDate,
            this.overdueDueDate,
            this.overdueCheckIn});
            this.overdueGridView.Location = new System.Drawing.Point(6, 67);
            this.overdueGridView.Name = "overdueGridView";
            this.overdueGridView.Size = new System.Drawing.Size(928, 315);
            this.overdueGridView.TabIndex = 1;
            // 
            // overdueTitle
            // 
            this.overdueTitle.HeaderText = "Title";
            this.overdueTitle.MaxInputLength = 120;
            this.overdueTitle.Name = "overdueTitle";
            this.overdueTitle.Width = 190;
            // 
            // overdueAuthor
            // 
            this.overdueAuthor.HeaderText = "Author";
            this.overdueAuthor.MaxInputLength = 60;
            this.overdueAuthor.Name = "overdueAuthor";
            this.overdueAuthor.Width = 110;
            // 
            // overdueType
            // 
            this.overdueType.HeaderText = "Type";
            this.overdueType.Items.AddRange(new object[] {
            "Adult",
            "Children\'s",
            "DVD",
            "Videotape"});
            this.overdueType.Name = "overdueType";
            this.overdueType.Width = 80;
            // 
            // overdueCheckedOutTo
            // 
            this.overdueCheckedOutTo.HeaderText = "Checked Out To";
            this.overdueCheckedOutTo.MaxInputLength = 60;
            this.overdueCheckedOutTo.Name = "overdueCheckedOutTo";
            this.overdueCheckedOutTo.Width = 110;
            // 
            // overdueCheckoutDate
            // 
            this.overdueCheckoutDate.HeaderText = "Checkout Date";
            this.overdueCheckoutDate.MaxInputLength = 12;
            this.overdueCheckoutDate.Name = "overdueCheckoutDate";
            this.overdueCheckoutDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.overdueCheckoutDate.Width = 110;
            // 
            // overdueDueDate
            // 
            this.overdueDueDate.HeaderText = "Due Date";
            this.overdueDueDate.MaxInputLength = 12;
            this.overdueDueDate.Name = "overdueDueDate";
            this.overdueDueDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.overdueDueDate.Width = 90;
            // 
            // overdueCheckIn
            // 
            this.overdueCheckIn.HeaderText = "Check In";
            this.overdueCheckIn.Name = "overdueCheckIn";
            this.overdueCheckIn.Width = 60;
            // 
            // checkedOutBooksTab
            // 
            this.checkedOutBooksTab.Controls.Add(this.label1);
            this.checkedOutBooksTab.Controls.Add(this.comboBox1);
            this.checkedOutBooksTab.Controls.Add(this.button2);
            this.checkedOutBooksTab.Controls.Add(this.checkedOutGridView);
            this.checkedOutBooksTab.Location = new System.Drawing.Point(4, 22);
            this.checkedOutBooksTab.Name = "checkedOutBooksTab";
            this.checkedOutBooksTab.Padding = new System.Windows.Forms.Padding(3);
            this.checkedOutBooksTab.Size = new System.Drawing.Size(941, 449);
            this.checkedOutBooksTab.TabIndex = 1;
            this.checkedOutBooksTab.Text = "All Checked Out Books";
            this.checkedOutBooksTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter by books checked out to";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(776, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Check in selected books";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkedOutGridView
            // 
            this.checkedOutGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkedOutGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkedOutTitle,
            this.checkedOutAuthor,
            this.checkedOutType,
            this.checkedOutStatus,
            this.checkedOutCheckedOutTo,
            this.checkedOutCheckoutDate,
            this.checkedOutDueDate,
            this.checkedOutCheckIn});
            this.checkedOutGridView.Location = new System.Drawing.Point(6, 67);
            this.checkedOutGridView.Name = "checkedOutGridView";
            this.checkedOutGridView.Size = new System.Drawing.Size(928, 315);
            this.checkedOutGridView.TabIndex = 1;
            // 
            // checkedOutTitle
            // 
            this.checkedOutTitle.HeaderText = "Title";
            this.checkedOutTitle.MaxInputLength = 120;
            this.checkedOutTitle.Name = "checkedOutTitle";
            this.checkedOutTitle.Width = 190;
            // 
            // checkedOutAuthor
            // 
            this.checkedOutAuthor.HeaderText = "Author";
            this.checkedOutAuthor.MaxInputLength = 60;
            this.checkedOutAuthor.Name = "checkedOutAuthor";
            this.checkedOutAuthor.Width = 110;
            // 
            // checkedOutType
            // 
            this.checkedOutType.HeaderText = "Type";
            this.checkedOutType.Items.AddRange(new object[] {
            "Adult",
            "Children\'s",
            "DVD",
            "Videotape"});
            this.checkedOutType.Name = "checkedOutType";
            this.checkedOutType.Width = 80;
            // 
            // checkedOutStatus
            // 
            this.checkedOutStatus.HeaderText = "Status";
            this.checkedOutStatus.Items.AddRange(new object[] {
            "Available",
            "Checked Out",
            "Overdue"});
            this.checkedOutStatus.Name = "checkedOutStatus";
            this.checkedOutStatus.Width = 95;
            // 
            // checkedOutCheckedOutTo
            // 
            this.checkedOutCheckedOutTo.HeaderText = "Checked Out To";
            this.checkedOutCheckedOutTo.MaxInputLength = 60;
            this.checkedOutCheckedOutTo.Name = "checkedOutCheckedOutTo";
            this.checkedOutCheckedOutTo.Width = 110;
            // 
            // checkedOutCheckoutDate
            // 
            this.checkedOutCheckoutDate.HeaderText = "Checkout Date";
            this.checkedOutCheckoutDate.MaxInputLength = 12;
            this.checkedOutCheckoutDate.Name = "checkedOutCheckoutDate";
            this.checkedOutCheckoutDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkedOutCheckoutDate.Width = 110;
            // 
            // checkedOutDueDate
            // 
            this.checkedOutDueDate.HeaderText = "Due Date";
            this.checkedOutDueDate.MaxInputLength = 12;
            this.checkedOutDueDate.Name = "checkedOutDueDate";
            this.checkedOutDueDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkedOutDueDate.Width = 90;
            // 
            // checkedOutCheckIn
            // 
            this.checkedOutCheckIn.HeaderText = "Check In";
            this.checkedOutCheckIn.Name = "checkedOutCheckIn";
            this.checkedOutCheckIn.Width = 60;
            // 
            // availableBooksTab
            // 
            this.availableBooksTab.Controls.Add(this.button3);
            this.availableBooksTab.Controls.Add(this.label3);
            this.availableBooksTab.Controls.Add(this.comboBox3);
            this.availableBooksTab.Controls.Add(this.availableBooksGridView);
            this.availableBooksTab.Location = new System.Drawing.Point(4, 22);
            this.availableBooksTab.Name = "availableBooksTab";
            this.availableBooksTab.Size = new System.Drawing.Size(941, 449);
            this.availableBooksTab.TabIndex = 3;
            this.availableBooksTab.Text = "Available Books";
            this.availableBooksTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(859, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Check Out";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Check out selected books to";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(562, 409);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(291, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // availableBooksGridView
            // 
            this.availableBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableBooksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.availableBooksTitle,
            this.availableBooksAuthor,
            this.availableBooksType,
            this.availableBooksCheckOut});
            this.availableBooksGridView.Location = new System.Drawing.Point(6, 67);
            this.availableBooksGridView.Name = "availableBooksGridView";
            this.availableBooksGridView.Size = new System.Drawing.Size(928, 315);
            this.availableBooksGridView.TabIndex = 2;
            // 
            // availableBooksTitle
            // 
            this.availableBooksTitle.HeaderText = "Title";
            this.availableBooksTitle.MaxInputLength = 120;
            this.availableBooksTitle.Name = "availableBooksTitle";
            this.availableBooksTitle.Width = 190;
            // 
            // availableBooksAuthor
            // 
            this.availableBooksAuthor.HeaderText = "Author";
            this.availableBooksAuthor.MaxInputLength = 60;
            this.availableBooksAuthor.Name = "availableBooksAuthor";
            this.availableBooksAuthor.Width = 110;
            // 
            // availableBooksType
            // 
            this.availableBooksType.HeaderText = "Type";
            this.availableBooksType.Items.AddRange(new object[] {
            "Adult",
            "Children\'s",
            "DVD",
            "Videotape"});
            this.availableBooksType.Name = "availableBooksType";
            this.availableBooksType.Width = 80;
            // 
            // availableBooksCheckOut
            // 
            this.availableBooksCheckOut.HeaderText = "Check Out";
            this.availableBooksCheckOut.Name = "availableBooksCheckOut";
            this.availableBooksCheckOut.Width = 65;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.label5);
            this.settingsTab.Controls.Add(this.currentDate);
            this.settingsTab.Controls.Add(this.label4);
            this.settingsTab.Controls.Add(this.claimFileDirButton);
            this.settingsTab.Controls.Add(this.databaseFile);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(941, 449);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // claimFileDirButton
            // 
            this.claimFileDirButton.Location = new System.Drawing.Point(608, 30);
            this.claimFileDirButton.Name = "claimFileDirButton";
            this.claimFileDirButton.Size = new System.Drawing.Size(95, 23);
            this.claimFileDirButton.TabIndex = 14;
            this.claimFileDirButton.Text = "Select File";
            this.claimFileDirButton.UseVisualStyleBackColor = true;
            this.claimFileDirButton.Click += new System.EventHandler(this.claimFileDirButton_Click);
            // 
            // databaseFile
            // 
            this.databaseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseFile.Location = new System.Drawing.Point(136, 32);
            this.databaseFile.Name = "databaseFile";
            this.databaseFile.Size = new System.Drawing.Size(466, 20);
            this.databaseFile.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Library Database File";
            // 
            // currentDate
            // 
            this.currentDate.CustomFormat = "yyyy-MM-dd";
            this.currentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.currentDate.Location = new System.Drawing.Point(136, 82);
            this.currentDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.currentDate.MinDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(80, 20);
            this.currentDate.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Current Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 565);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "The Totally Awesome and Cool Simple Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.allBooksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allBooksGridView)).EndInit();
            this.overdueBooksTab.ResumeLayout(false);
            this.overdueBooksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overdueGridView)).EndInit();
            this.checkedOutBooksTab.ResumeLayout(false);
            this.checkedOutBooksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedOutGridView)).EndInit();
            this.availableBooksTab.ResumeLayout(false);
            this.availableBooksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooksGridView)).EndInit();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage allBooksTab;
        private System.Windows.Forms.TabPage checkedOutBooksTab;
        private System.Windows.Forms.TabPage overdueBooksTab;
        private System.Windows.Forms.TabPage availableBooksTab;
        private System.Windows.Forms.DataGridView allBooksGridView;
        private System.Windows.Forms.DataGridView overdueGridView;
        private System.Windows.Forms.DataGridView checkedOutGridView;
        private System.Windows.Forms.DataGridView availableBooksGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn allBooksTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn allBooksAuthor;
        private System.Windows.Forms.DataGridViewComboBoxColumn allBooksType;
        private System.Windows.Forms.DataGridViewComboBoxColumn allBooksStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn allBooksCheckedOutTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn allBooksCheckoutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn allBooksDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn overdueTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn overdueAuthor;
        private System.Windows.Forms.DataGridViewComboBoxColumn overdueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn overdueCheckedOutTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn overdueCheckoutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn overdueDueDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn overdueCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedOutTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedOutAuthor;
        private System.Windows.Forms.DataGridViewComboBoxColumn checkedOutType;
        private System.Windows.Forms.DataGridViewComboBoxColumn checkedOutStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedOutCheckedOutTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedOutCheckoutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedOutDueDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedOutCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableBooksTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableBooksAuthor;
        private System.Windows.Forms.DataGridViewComboBoxColumn availableBooksType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableBooksCheckOut;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button claimFileDirButton;
        private System.Windows.Forms.TextBox databaseFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker currentDate;
        private System.Windows.Forms.OpenFileDialog databaseFileDialog;
    }
}

