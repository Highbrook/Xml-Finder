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

namespace XmlFinder
{
    public partial class ReplaceDialogForm : Form
    {
        private bool replaceCheckState = true;
        public ReplaceDialogForm()
        {
            InitializeComponent();
        }


        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (replaceTextBox.Text != "" && replaceTextBox.Text != null)
                {
                    if (replaceCheckState == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you wish to replace in all files with the text " + replaceTextBox.Text + " ?","Confirmation." , MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ReplaceKeyword(replaceCheckState, replaceTextBox.Text);
                        }
                        return;
                    }
                    else if (replaceCheckState == false)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you wish to replace " + MainForm.selectedFile + " with the text " + replaceTextBox.Text + " ?", "Confirmation.", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ReplaceKeyword(replaceCheckState, replaceTextBox.Text);
                        }
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please input a replacement string.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select one of the replacement filters.");
            }
        }


        // Works with data returned from the replacement dialog form
        // True - Replace in all
        // False - Replace in selected
        public void ReplaceKeyword(bool replaceState, string replaceText)
        {
            if (replaceState == false)
            {
                if (MainForm.selectedFile != null && MainForm.selectedFile != "")
                {
                    Console.WriteLine("Data returned " + replaceState + " With text: " + replaceText + " The selected file is: " + MainForm.selectedFile);
                    BeginReplacementOfStrings(replaceText, MainForm.selectedFile);
                }
                else
                {
                    MessageBox.Show("Please select one file to edit.");
                }
            }
            else if (replaceState == true)
            {
                Console.WriteLine("Data returned " + replaceState + " With text: " + replaceText + " Will replace all files.");
                BeginReplacementOfStrings(replaceText);
            }
        }

        private void BeginReplacementOfStrings(string replaceKeyword, string file)
        {
            string filePath = MainForm.directoryPath + @"\" + file;
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadToEnd();

            if (MainForm.instance._caseInSensRadioButton.Checked == true)
            {
                foreach (Match match in Regex.Matches(line, MainForm.keywordToSearch, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Found '{0}' at position {1}", match.Value, match.Index);
                }
            }
            else if (MainForm.instance._caseInSensRadioButton.Checked != true)
            {
                foreach (Match match in Regex.Matches(line, MainForm.keywordToSearch))
                {
                    Console.WriteLine("Found '{0}' at position {1}", match.Value, match.Index);
                }
            }
            else
            {
                return;
            }
        }

        // TODO Fix this :)
        private void BeginReplacementOfStrings(string text)
        {
            foreach (var file in MainForm.allItems)
            {
                string filePath = MainForm.directoryPath + @"\" + file;
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadToEnd();

                if (MainForm.instance._caseInSensRadioButton.Checked == true)
                {
                    foreach (Match match in Regex.Matches(line, MainForm.keywordToSearch, RegexOptions.IgnoreCase))
                    {
                        Console.WriteLine("Found '{0}' at position {1}", match.Value, match.Index);
                    }
                }
                else if (MainForm.instance._caseInSensRadioButton.Checked != true)
                {
                    foreach (Match match in Regex.Matches(line, MainForm.keywordToSearch))
                    {
                        Console.WriteLine("Found '{0}' at position {1}", match.Value, match.Index);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void ReplaceAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            replaceCheckState = true;
        }

        private void ReplaceSelectedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            replaceCheckState = false;
        }
    }
}
