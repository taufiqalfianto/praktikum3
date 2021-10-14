using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIStyle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama = textBox1.Text;
            var jeniskelamin = comboBox1.Text;
            var pendidikan = comboBox2.Text;
            var pekerjaan = comboBox3.Text;

            textBox2.Text = string.Format(nama);
            textBox3.Text = string.Format(jeniskelamin);
            textBox4.Text = string.Format(pendidikan);
            textBox5.Text = string.Format(pekerjaan);
        }
    }
}
