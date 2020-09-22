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
    public partial class Form2 : Form
    {
        //private bool modal;

        public Form2()
        {
            InitializeComponent();
        }

        //public new void Show()
        //{
        //    modal = false;

        //    //AcceptButton = null;
        //    //CancelButton = null;

        //    base.Show();
        //}

        //public new DialogResult ShowDialog()
        //{
        //    modal = true;
        //    return base.ShowDialog();
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(DialogResult.Cancel);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Close reason: " + e.CloseReason + "\n\nSender type: " + sender.GetType().ToString());
            if (UserCloseIsCanceled(e)) return;
        }

        private Boolean UserCloseIsCanceled(FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return false;
            if (CanClose) return false;

            // Cancel the Form Closing event
            return e.Cancel = true;
        }

        Boolean CanClose => MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close(DialogResult.OK);
        }

        private void Close(DialogResult dialogResult)
        {
            if (Modal)
                DialogResult = dialogResult;
            else
                Close();

        }
    }
}
