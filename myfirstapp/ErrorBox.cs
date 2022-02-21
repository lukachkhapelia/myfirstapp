using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace myfirstapp
{
    public partial class ErrorBox : Form
    {
        public ErrorBox(string ErrorMessage)
        {
            InitializeComponent();
            Errorlable.Text = ErrorMessage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
