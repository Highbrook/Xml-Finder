using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
//using System.Xml;

namespace XmlFinder
{
    public partial class MainForm : Form
    {
        #region Variables
        private FolderBrowserDialog folderBrowserDialog;
        public static MainForm instance;
        public static string directoryPath;
        public static string keywordToSearch;
        public static List<string> allItems = new List<string>();
        public static string selectedFile;

        #endregion

        #region Getters and Setters
        public System.Windows.Forms.RadioButton _caseInSensRadioButton
        {
            get { return caseInSensRadioButton; }
        }

        public System.Windows.Forms.RadioButton _caseSensRadioButton
        {
            get { return caseSensRadioButton; }
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();

            resultListView.MouseDown += new MouseEventHandler(ResultListView_MouseDown);
            resultListView.MouseDoubleClick += new MouseEventHandler(ResultListView_MouseDoubleClick);
        }

        // Opens a dialog box for folder browsing
        private void FolderPathButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderPathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        // Search button
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultListView.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(folderPathTextBox.Text);
                FileInfo[] dirFilesCount = dir.GetFiles("*");
                directoryPath = dir.ToString();

                // TODO Fix error handling
                string keyword = keywordTextBox.Text;
                SearchKeywordInFiles(keyword, dir, dirFilesCount);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect data input.");
            }
        }

        // Searches for the keyword in all files in the directory
        private void SearchKeywordInFiles(string keyword, DirectoryInfo dir, FileInfo[] dirFilesCount)
        {
            if (keyword != null && keyword != "")
            {
                keywordToSearch = keyword;
                foreach (var fileName in dirFilesCount)
                {
                    SearchCaseInsensitive(keyword, fileName.ToString(), dir);
                }
            }
            else
            {
                MessageBox.Show("Incorrect input for search keyword.");
            }
        }

        // Search keyword depending on if case sensitivity or insensitivity is ticked
        private void SearchCaseInsensitive(string keyword, string fileName, DirectoryInfo dir)
        {
            StreamReader sr = new StreamReader(dir.ToString() + @"\" + fileName);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (caseInSensRadioButton.Checked == true)
                {
                    Console.WriteLine("Case insensitive");
                    Match m = Regex.Match(line, keyword, RegexOptions.IgnoreCase);
                    if (m.Success)
                    {
                        resultListView.Items.Add(fileName.ToString());
                        allItems.Add(dir.ToString() + @"\" + fileName.ToString());
                        line = sr.ReadLine();
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                else if (caseSensRadioButton.Checked == true)
                {
                    Console.WriteLine("Case sensitive");
                    Match m = Regex.Match(line, keyword);
                    if (m.Success)
                    {
                        resultListView.Items.Add(fileName.ToString());
                        line = sr.ReadLine();
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
            }
            sr.Close();
        }

        // Summons the ReplaceDialogForm.cs
        private void ReplaceDialogWindowButton_Click(object sender, EventArgs e)
        {
            if ((keywordTextBox.Text != null && keywordTextBox.Text !="") && (folderPathTextBox.Text != null && folderPathTextBox.Text != ""))
            {
                instance = this;
                ReplaceDialogForm replaceDialogForm = new ReplaceDialogForm();
                replaceDialogForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please input all required parameters.");
            }
        }

        // Opens the file explorer and navigates to the selected file and highlights it when double clicked
        void ResultListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = resultListView.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (resultListView.SelectedItems.Count == 0)
                return;
            else
            {
                string selected = resultListView.SelectedItems[0].Text;
                string argument = "/select, \"" + folderPathTextBox.Text + @"\" + selected;
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }
        }

        // Selects item in list view when clicked on Once
        void ResultListView_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = resultListView.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                selectedFile = item.Text;
            }
            else
            {
                this.resultListView.SelectedItems.Clear();
                this.resultListView.Text = "No Item is Selected";
            }
        }


        private void TestThingButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(allItems.Count); 
            foreach (var item in allItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
