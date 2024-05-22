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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(namatext.Text);
            if (rblaki.Checked == true)
                listBox1.Items.Add(rblaki.Text);
            else if (rbperempuan.Checked == true)
                listBox1.Items.Add(rbperempuan.Text);
            listBox1.Items.Add(jurusancombo.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btbersih_Click(object sender, EventArgs e)
        {
            namatext.Text = "";
            rblaki.Checked = false;
            rbperempuan.Checked = false;
            jurusancombo.Text = "Pillihan Jurusan";
            listBox1.Items.Clear();
            namatext.Focus();
        }
    }
}
