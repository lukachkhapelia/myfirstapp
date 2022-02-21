using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirstapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {   
            string Firstname = textboxname.Text;
            string Lastname = textboxlast.Text;
            int Group = 0;
            
            try
            {
                 Group = Convert.ToInt32(textboxgroup.Text);

            }
            catch(Exception exc)
            {
                ErrorBox error = new ErrorBox(exc.Message);
                error.Show();
                this.Hide();
            }

            Person per = new Person(Firstname, Lastname,Group);
            //MessageBox.Show(per.ToString());

            FileStream filestream = new FileStream("Data.txt", FileMode.OpenOrCreate) ;
            StreamWriter streamwriter = new StreamWriter(filestream);
            filestream.Seek(0,SeekOrigin.End);
            streamwriter.WriteLine(per.ToString());

            textboxname.ResetText();
            textboxlast.ResetText();
            textboxgroup.ResetText();

            streamwriter.Close();
            filestream.Close();
            

        }
        private void label1_Click(object sender, EventArgs e)
        {


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

    }
}
