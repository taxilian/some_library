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
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.claimFileDirButton = new System.Windows.Forms.Button();
            this.databaseFile = new System.Windows.Forms.TextBox();
            this.allBooksTab = new System.Windows.Forms.TabPage();
            this.allBooksGridView = new System.Windows.Forms.DataGridView();
            this.allBooksTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allGridType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allBooksCheckedOutTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allBooksCheckoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allBooksDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdueBooksTab = new System.Windows.Forms.TabPage();
            this.overDueGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterODByCheckedOutPerson = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedOutBooksTab = new System.Windows.Forms.TabPage();
            this.checkedOutGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterCOBooksPatron = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.availableBooksTab = new System.Windows.Forms.TabPage();
            this.availableGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCheckoutTo = new System.Windows.Forms.ComboBox();
            this.databaseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.allBooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksGridView)).BeginInit();
            this.overdueBooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overDueGrid)).BeginInit();
            this.checkedOutBooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedOutGrid)).BeginInit();
            this.availableBooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableGrid)).BeginInit();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Current Date";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Library Database File";
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
            this.databaseFile.ReadOnly = true;
            this.databaseFile.Size = new System.Drawing.Size(466, 20);
            this.databaseFile.TabIndex = 15;
            // 
            // allBooksTab
            // 
            this.allBooksTab.Controls.Add(this.allBooksGridView);
            this.allBooksTab.Location = new System.Drawing.Point(4, 22);
            this.allBooksTab.Name = "allBooksTab";
            this.allBooksTab.Padding = new System.Windows.Forms.Padding(3);
            this.allBooksTab.Size = new System.Drawing.Size(941, 449);
            this.allBooksTab.TabIndex = 0;
            this.allBooksTab.Text = "All Items";
            this.allBooksTab.UseVisualStyleBackColor = true;
            // 
            // allBooksGridView
            // 
            this.allBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allBooksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.allBooksTitle,
            this.allGridType,
            this.Status,
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
            this.allBooksTitle.ReadOnly = true;
            this.allBooksTitle.Width = 190;
            // 
            // allGridType
            // 
            this.allGridType.HeaderText = "Type";
            this.allGridType.Name = "allGridType";
            this.allGridType.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // allBooksCheckedOutTo
            // 
            this.allBooksCheckedOutTo.HeaderText = "Checked Out To";
            this.allBooksCheckedOutTo.MaxInputLength = 60;
            this.allBooksCheckedOutTo.Name = "allBooksCheckedOutTo";
            this.allBooksCheckedOutTo.ReadOnly = true;
            this.allBooksCheckedOutTo.Width = 110;
            // 
            // allBooksCheckoutDate
            // 
            this.allBooksCheckoutDate.HeaderText = "Checkout Date";
            this.allBooksCheckoutDate.MaxInputLength = 12;
            this.allBooksCheckoutDate.Name = "allBooksCheckoutDate";
            this.allBooksCheckoutDate.ReadOnly = true;
            this.allBooksCheckoutDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.allBooksCheckoutDate.Width = 110;
            // 
            // allBooksDueDate
            // 
            this.allBooksDueDate.HeaderText = "Due Date";
            this.allBooksDueDate.MaxInputLength = 12;
            this.allBooksDueDate.Name = "allBooksDueDate";
            this.allBooksDueDate.ReadOnly = true;
            this.allBooksDueDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.allBooksDueDate.Width = 90;
            // 
            // overdueBooksTab
            // 
            this.overdueBooksTab.Controls.Add(this.overDueGrid);
            this.overdueBooksTab.Controls.Add(this.label2);
            this.overdueBooksTab.Controls.Add(this.cbFilterODByCheckedOutPerson);
            this.overdueBooksTab.Controls.Add(this.button1);
            this.overdueBooksTab.Location = new System.Drawing.Point(4, 22);
            this.overdueBooksTab.Name = "overdueBooksTab";
            this.overdueBooksTab.Size = new System.Drawing.Size(941, 449);
            this.overdueBooksTab.TabIndex = 2;
            this.overdueBooksTab.Text = "Overdue Items";
            this.overdueBooksTab.UseVisualStyleBackColor = true;
            // 
            // overDueGrid
            // 
            this.overDueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overDueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.overDueGrid.Location = new System.Drawing.Point(6, 67);
            this.overDueGrid.Name = "overDueGrid";
            this.overDueGrid.Size = new System.Drawing.Size(928, 315);
            this.overDueGrid.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 120;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 190;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Checked Out To";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 60;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Checkout Date";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 12;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Due Date";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 12;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 90;
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
            // cbFilterODByCheckedOutPerson
            // 
            this.cbFilterODByCheckedOutPerson.FormattingEnabled = true;
            this.cbFilterODByCheckedOutPerson.Items.AddRange(new object[] {
            "Frank",
            "louis",
            "george",
            "bob"});
            this.cbFilterODByCheckedOutPerson.Location = new System.Drawing.Point(159, 25);
            this.cbFilterODByCheckedOutPerson.Name = "cbFilterODByCheckedOutPerson";
            this.cbFilterODByCheckedOutPerson.Size = new System.Drawing.Size(291, 21);
            this.cbFilterODByCheckedOutPerson.TabIndex = 6;
            this.cbFilterODByCheckedOutPerson.SelectedIndexChanged += new System.EventHandler(this.cbFilterByCheckedOutPerson_SelectedIndexChanged);
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
            // checkedOutBooksTab
            // 
            this.checkedOutBooksTab.Controls.Add(this.checkedOutGrid);
            this.checkedOutBooksTab.Controls.Add(this.label1);
            this.checkedOutBooksTab.Controls.Add(this.cbFilterCOBooksPatron);
            this.checkedOutBooksTab.Controls.Add(this.button2);
            this.checkedOutBooksTab.Location = new System.Drawing.Point(4, 22);
            this.checkedOutBooksTab.Name = "checkedOutBooksTab";
            this.checkedOutBooksTab.Padding = new System.Windows.Forms.Padding(3);
            this.checkedOutBooksTab.Size = new System.Drawing.Size(941, 449);
            this.checkedOutBooksTab.TabIndex = 1;
            this.checkedOutBooksTab.Text = "Checked Out Items";
            this.checkedOutBooksTab.UseVisualStyleBackColor = true;
            // 
            // checkedOutGrid
            // 
            this.checkedOutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkedOutGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.checkedOutGrid.Location = new System.Drawing.Point(6, 67);
            this.checkedOutGrid.Name = "checkedOutGrid";
            this.checkedOutGrid.Size = new System.Drawing.Size(928, 315);
            this.checkedOutGrid.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Title";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 120;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 190;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Type";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Status";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Checked Out To";
            this.dataGridViewTextBoxColumn10.MaxInputLength = 60;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 110;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Checkout Date";
            this.dataGridViewTextBoxColumn11.MaxInputLength = 12;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn11.Width = 110;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Due Date";
            this.dataGridViewTextBoxColumn12.MaxInputLength = 12;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn12.Width = 90;
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
            // cbFilterCOBooksPatron
            // 
            this.cbFilterCOBooksPatron.FormattingEnabled = true;
            this.cbFilterCOBooksPatron.Location = new System.Drawing.Point(162, 23);
            this.cbFilterCOBooksPatron.Name = "cbFilterCOBooksPatron";
            this.cbFilterCOBooksPatron.Size = new System.Drawing.Size(291, 21);
            this.cbFilterCOBooksPatron.TabIndex = 4;
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
            // availableBooksTab
            // 
            this.availableBooksTab.Controls.Add(this.availableGrid);
            this.availableBooksTab.Controls.Add(this.button3);
            this.availableBooksTab.Controls.Add(this.label3);
            this.availableBooksTab.Controls.Add(this.cbCheckoutTo);
            this.availableBooksTab.Location = new System.Drawing.Point(4, 22);
            this.availableBooksTab.Name = "availableBooksTab";
            this.availableBooksTab.Size = new System.Drawing.Size(941, 449);
            this.availableBooksTab.TabIndex = 3;
            this.availableBooksTab.Text = "Available Items";
            this.availableBooksTab.UseVisualStyleBackColor = true;
            // 
            // availableGrid
            // 
            this.availableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.availableGrid.Location = new System.Drawing.Point(6, 67);
            this.availableGrid.Name = "availableGrid";
            this.availableGrid.Size = new System.Drawing.Size(928, 315);
            this.availableGrid.TabIndex = 9;
            this.availableGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Title";
            this.dataGridViewTextBoxColumn13.MaxInputLength = 120;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 190;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Type";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Status";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
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
            // cbCheckoutTo
            // 
            this.cbCheckoutTo.FormattingEnabled = true;
            this.cbCheckoutTo.Location = new System.Drawing.Point(562, 409);
            this.cbCheckoutTo.Name = "cbCheckoutTo";
            this.cbCheckoutTo.Size = new System.Drawing.Size(291, 21);
            this.cbCheckoutTo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 565);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "The Totally Awesome and Cool Simple Library";
            this.tabControl1.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.allBooksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allBooksGridView)).EndInit();
            this.overdueBooksTab.ResumeLayout(false);
            this.overdueBooksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overDueGrid)).EndInit();
            this.checkedOutBooksTab.ResumeLayout(false);
            this.checkedOutBooksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedOutGrid)).EndInit();
            this.availableBooksTab.ResumeLayout(false);
            this.availableBooksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage allBooksTab;
        private System.Windows.Forms.TabPage checkedOutBooksTab;
        private System.Windows.Forms.TabPage overdueBooksTab;
        private System.Windows.Forms.TabPage availableBooksTab;
        private System.Windows.Forms.DataGridView allBooksGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterCOBooksPatron;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterODByCheckedOutPerson;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCheckoutTo;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button claimFileDirButton;
        private System.Windows.Forms.TextBox databaseFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker currentDate;
        private System.Windows.Forms.OpenFileDialog databaseFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn allBooksTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn allGridType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn allBooksCheckedOutTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn allBooksCheckoutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn allBooksDueDate;
        private System.Windows.Forms.DataGridView overDueGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView checkedOutGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView availableGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}

