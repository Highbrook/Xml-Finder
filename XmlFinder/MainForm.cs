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
        private FolderBrowserDialog folderBrowserDialog;
        private List<string> allItems = new List<string>();

        private string replacementKeyword;
        private bool allOrSegment;
        public MainForm(bool allOrSegment, string replacementKeyword)
        {
            this.allOrSegment = allOrSegment;
            this.replacementKeyword = replacementKeyword;
        }

        public MainForm()
        {
            InitializeComponent();
        }
        private void folderPathButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderPathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultListView.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(folderPathTextBox.Text);
                FileInfo[] dirFilesCount = dir.GetFiles("*");

                // TODO Fix error handling
                string keyword = keywordTextBox.Text;
                searchKeywordInFiles(keyword, dir, dirFilesCount);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect data input");
            }
        }

        // Searches for the keyword in all files in the directory
        private void searchKeywordInFiles(string keyword, DirectoryInfo dir, FileInfo[] dirFilesCount)
        {
            if (keyword != null && keyword != "")
            {
                foreach (var fileName in dirFilesCount)
                {
                    searchCaseInsensitive(keyword, fileName.ToString(), dir);
                }

                foreach (var item in resultListView.Items)
                {
                    this.allItems.Add(item.ToString());
                }
            }
            else
            {
                MessageBox.Show("Incorrect input for search keyword");
            }
        }

        // Search keyword depending on if case sensitivity or insensitivity is ticked
        private void searchCaseInsensitive(string keyword, string fileName, DirectoryInfo dir)
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

        // Opens the file explorer and navigates to the selected file and highlights it
        private void resultListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultListView.SelectedItems.Count == 0)
                return;
            else
            {
                string selected = resultListView.SelectedItems[0].Text;
                string argument = "/select, \"" + folderPathTextBox.Text + @"\" + selected;
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }
        }

        // TODO return information on which checkbox is checked
        private void replaceDialogWindowButton_Click(object sender, EventArgs e)
        {
            ReplaceDialogForm replaceDialogForm = new ReplaceDialogForm();
            replaceDialogForm.ShowDialog();
        }

        public static void replaceKeyword(bool replaceState, string replaceText)
        {
            Console.WriteLine("Data returned " + replaceState + " with text: " + replaceText);
        }
    }
}


//{
//    Arguments = folderPath,
//    FileName = "explorer.exe";
//};