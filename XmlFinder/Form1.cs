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
//using System.Xml;
//using System.Text.RegularExpressions;

namespace XmlFinder
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        private List<string> allItems = new List<string>();
        public Form1()
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
        private void folderPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void searchKeywordInFiles(string keyword, DirectoryInfo dir, FileInfo[] dirFilesCount)
        {
            if (keyword != null)
            {
                foreach (var fileName in dirFilesCount)
                {
                    StreamReader sr = new StreamReader(dir.ToString() + @"\" + fileName);
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        if (line.Contains(keyword.ToLower()))
                        {
                            resultListView.Items.Add(fileName.ToString());
                            line = sr.ReadLine();
                        }
                        else
                        {
                            line = sr.ReadLine();
                        }
                    }
                    sr.Close();
                }

                foreach (var item in resultListView.Items)
                {
                    this.allItems.Add(item.ToString());
                }
            }
            else if (keyword == null)
            {
                MessageBox.Show("Incorrect input for search keyword");
            }
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
    }
}


//{
//    Arguments = folderPath,
//    FileName = "explorer.exe";
//};