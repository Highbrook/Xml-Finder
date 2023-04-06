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


        private void replaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (replaceTextBox.Text != "" && replaceTextBox.Text != null)
                {
                    MainForm.replaceKeyword(replaceCheckState, replaceTextBox.Text);
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

        private void replaceAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            replaceCheckState = true;
        }

        private void replaceSelectedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            replaceCheckState = false;
        }
    }
}
