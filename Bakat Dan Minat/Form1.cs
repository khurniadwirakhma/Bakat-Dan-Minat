using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakat_Dan_Minat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernametext .Text=="Nia" && passwordtext .Text == "12345")
            {
                MessageBox.Show("login Successfully", "Login", MessageBoxButtons.OK);
                this.Hide();
                Form2 co = new Form2();
                co.Show();
            }
            else
            {
                MessageBox.Show("username dan password is incorrect", "eror", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usernametext.Text = "";
            passwordtext.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}