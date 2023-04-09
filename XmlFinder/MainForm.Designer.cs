namespace XmlFinder
{
    partial class MainForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.caseInSensRadioButton = new System.Windows.Forms.RadioButton();
            this.caseSensRadioButton = new System.Windows.Forms.RadioButton();
            this.replaceDialogWindowButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.folderPathButton = new System.Windows.Forms.Button();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultListView = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.caseInSensRadioButton);
            this.tabPage1.Controls.Add(this.caseSensRadioButton);
            this.tabPage1.Controls.Add(this.replaceDialogWindowButton);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.folderPathButton);
            this.tabPage1.Controls.Add(this.folderPathTextBox);
            this.tabPage1.Controls.Add(this.keywordTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.resultListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1010, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search in Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // caseInSensRadioButton
            // 
            this.caseInSensRadioButton.AutoSize = true;
            this.caseInSensRadioButton.Checked = true;
            this.caseInSensRadioButton.Location = new System.Drawing.Point(152, 78);
            this.caseInSensRadioButton.Name = "caseInSensRadioButton";
            this.caseInSensRadioButton.Size = new System.Drawing.Size(102, 17);
            this.caseInSensRadioButton.TabIndex = 10;
            this.caseInSensRadioButton.TabStop = true;
            this.caseInSensRadioButton.Text = "Case Insensitive";
            this.caseInSensRadioButton.UseVisualStyleBackColor = true;
            // 
            // caseSensRadioButton
            // 
            this.caseSensRadioButton.AutoSize = true;
            this.caseSensRadioButton.Location = new System.Drawing.Point(152, 55);
            this.caseSensRadioButton.Name = "caseSensRadioButton";
            this.caseSensRadioButton.Size = new System.Drawing.Size(95, 17);
            this.caseSensRadioButton.TabIndex = 9;
            this.caseSensRadioButton.Text = "Case Sensitive";
            this.caseSensRadioButton.UseVisualStyleBackColor = true;
            // 
            // replaceDialogWindowButton
            // 
            this.replaceDialogWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.replaceDialogWindowButton.Location = new System.Drawing.Point(898, 57);
            this.replaceDialogWindowButton.Name = "replaceDialogWindowButton";
            this.replaceDialogWindowButton.Size = new System.Drawing.Size(106, 20);
            this.replaceDialogWindowButton.TabIndex = 8;
            this.replaceDialogWindowButton.Text = "Replace with";
            this.replaceDialogWindowButton.UseVisualStyleBackColor = true;
            this.replaceDialogWindowButton.Click += new System.EventHandler(this.ReplaceDialogWindowButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchButton.Location = new System.Drawing.Point(13, 55);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(106, 20);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // folderPathButton
            // 
            this.folderPathButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.folderPathButton.Location = new System.Drawing.Point(898, 29);
            this.folderPathButton.Name = "folderPathButton";
            this.folderPathButton.Size = new System.Drawing.Size(106, 20);
            this.folderPathButton.TabIndex = 6;
            this.folderPathButton.Text = "Open";
            this.folderPathButton.UseVisualStyleBackColor = true;
            this.folderPathButton.Click += new System.EventHandler(this.FolderPathButton_Click);
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.Location = new System.Drawing.Point(459, 29);
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.Size = new System.Drawing.Size(432, 20);
            this.folderPathTextBox.TabIndex = 5;
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(13, 29);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(440, 20);
            this.keywordTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Folder path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Keyword:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result of keyword search:";
            // 
            // resultListView
            // 
            this.resultListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName});
            this.resultListView.HideSelection = false;
            this.resultListView.Location = new System.Drawing.Point(13, 106);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(991, 359);
            this.resultListView.TabIndex = 0;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "File";
            this.FileName.Width = 990;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 521);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Xml Finder";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button folderPathButton;
        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.Button replaceDialogWindowButton;
        private System.Windows.Forms.RadioButton caseInSensRadioButton;
        private System.Windows.Forms.RadioButton caseSensRadioButton;
    }
}

