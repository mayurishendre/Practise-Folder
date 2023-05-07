using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoListbox
{
    public partial class frmlistbox : Form
    {
        public frmlistbox()
        {
            InitializeComponent();
        }

        private void btnForwar_Click(object sender, EventArgs e)
        {
            
            lstbox2.Items.Add(lstbox1.SelectedItem.ToString());
            // btnBack.Enabled = false;
            // btnBackward.Enabled = false;
            lstbox2.ClearSelected();
            // lstbox1.Items.RemoveAt();
            lstbox1.Items.Remove(lstbox1.SelectedIndex);

            
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            //lstbox2.AllowDrop = true;
            lstbox2.Items.AddRange(lstbox1.Items);
           btnBack.Enabled = false;
           btnBackward.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lstbox1.Items.Add(lstbox2.SelectedItem.ToString());
            btnForwar.Enabled = false;
            btnForward.Enabled = false;
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            btnForward.Enabled = false;
            btnForwar.Enabled = false;
            lstbox1.Items.AddRange(lstbox2.Items);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //FormClosed(frmlistbox);
            //  FormClosing(frmlistbox.ActiveForm);
            // Close(ActiveForm);
            Close();
        }
    }
}
