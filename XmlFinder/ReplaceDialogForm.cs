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
                Console.WriteLine(replaceCheckState);
                MainForm.replaceKeyword(replaceCheckState, replaceTextBox.Text);
            }
            catch (Exception)
            {
                //XmlFinder.MainForm
                MessageBox.Show("please select one of the replacement filters.");
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
