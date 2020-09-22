using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            using (Form2 frm2 = new Form2())
            {
                DialogResult result = frm2.ShowDialog();
                MessageBox.Show("DialogResult: " + result);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label2.Text = "Is64BitProcess = " + Environment.Is64BitProcess + ";\nIs64BitOperatingSystem = " + Environment.Is64BitOperatingSystem;
        }

        private void btnSE_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            MessageBox.Show("After Show");
        }

        private void btnSME_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            MessageBox.Show("After Show");
        }
    }
}
