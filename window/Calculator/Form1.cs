using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void txtboxCal_TextChanged(object sender, EventArgs e)
        {

        }
        public void Getdata()
        {
            txtboxCal.Text = btn1.Text;
            txtboxCal.Text = btn2.Text;
            txtboxCal.Text = btn3.Text;
            txtboxCal.Text = btn4.Text;
            txtboxCal.Text = btn5.Text;
            txtboxCal.Text = btn6.Text;
            txtboxCal.Text = btn7.Text;
            txtboxCal.Text = btn8.Text;
            // txtboxCal.Text = btn9.Text;
            // int[] number = new int[9];
            //for(int i=0;i<=9;i++)
            //{
            //     number[i] = Convert.ToInt32();
            //}

        }

       public void btn1_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        public void btn9_Click(object sender, EventArgs e)
        {
            Getdata();
           // btn1_Click();
        }

        private void btn1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btn9_ControlAdded(object sender, ControlEventArgs e)
        {
           // btn1_Click(btn1);
        }

        private void btn9_BindingContextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
