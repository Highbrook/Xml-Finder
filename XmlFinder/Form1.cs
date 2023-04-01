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
            DirectoryInfo dir = new DirectoryInfo(folderPathTextBox.Text);
            FileInfo[] dirFilesCount = dir.GetFiles("*");

            foreach (var fileName in dirFilesCount)
            {
                resultListView.Items.Add(fileName.ToString());
            }

            foreach (var item in resultListView.Items)
            {
                this.allItems.Add(item.ToString());
            }
        }
        // TODO Add windows explorer opening when you select a file and navigate to its location
        private void resultListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultListView.SelectedItems.Count == 0)
                return;
            else
            {
                string selected = resultListView.SelectedItems[0].Text;
                OpenFileDialog dialog = new OpenFileDialog();
                DialogResult dialogResult = MessageBox.Show(selected);
            }
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(folderPath, "explorer.exe");
                
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }
    }
}


//{
//    Arguments = folderPath,
//    FileName = "explorer.exe";
//};