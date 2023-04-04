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
        public string teststring = "tetete";
        public ReplaceDialogForm()
        {
            InitializeComponent();
        }

        // 0 = Replace keyword in selected file
        // 1 = Replace keyword in all files
        private void replaceSelectedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switchCheckedCheckBox(0);
        }

        private void replaceAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switchCheckedCheckBox(1);
        }

        // TODO Fix checkbox switching
        private void switchCheckedCheckBox(int checkState)
        {
            try
            {
                if (checkState == 0)
                {
                    replaceAllCheckBox.CheckState = CheckState.Unchecked;
                }
                else if (checkState == 1)
                {
                    replaceSelectedCheckBox.CheckState = CheckState.Unchecked;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("please select one of the replacement filters.");
            }
        }
    }
}
