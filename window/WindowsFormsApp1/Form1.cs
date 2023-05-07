using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBoxNames.Items.Add(textBoxName.Text);
            // SortOrder.Ascending.CompareTo(listBoxNames.Items);
            listBoxNames.Sorted = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
           // listBoxNames.SelectedIndexChanged
             
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            listBoxNames.Items.Add(btnDown);
        }

        private void listBoxNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
