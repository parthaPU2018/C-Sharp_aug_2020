using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            if (username.Equals("PARTHA") && password.Equals("123456"))
            {
                Form2 f = new Form2();
                this.Hide();
                f.Show();
               // MessageBox.Show("login succesfull", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("login not succesfull","Important Note",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
    }
}
