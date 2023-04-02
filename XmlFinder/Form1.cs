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
using System.Xml;

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

                // TODO Fix listing of items 4 times in a row
                // TODO Fix error handling
                // TODO Fix reading xml files
                string keyword = keywordTextBox.Text;
                if (keyword != null)
                {
                    foreach (var fileName in dirFilesCount)
                    {
                        XmlTextReader reader = new XmlTextReader(dir.ToString() + @"\" + fileName);
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.Value);
                            if (reader.Value.Contains(keyword))
                            {
                                resultListView.Items.Add(fileName.ToString());
                            }
                        }
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

                //foreach (var fileName in dirFilesCount)
                //{
                //    resultListView.Items.Add(fileName.ToString());
                //}

                //foreach (var item in resultListView.Items)
                //{
                //    this.allItems.Add(item.ToString());
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect data input");
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