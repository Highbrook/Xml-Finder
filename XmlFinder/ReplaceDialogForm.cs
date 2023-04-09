using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                            MainForm.ReplaceKeyword(replaceCheckState, replaceTextBox.Text);
                        }
                        return;
                    }
                    else if (replaceCheckState == false)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you wish to replace " + MainForm.selectedFile + " with the text " + replaceTextBox.Text + " ?", "Confirmation.", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            MainForm.ReplaceKeyword(replaceCheckState, replaceTextBox.Text);
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
