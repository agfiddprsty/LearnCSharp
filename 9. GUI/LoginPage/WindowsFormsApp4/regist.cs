using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class regist : Form
    {
        public regist()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 lo = new Form1();
            lo.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ("") && (textBox4.Text == ("")))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong");
            }
            else if (textBox1.Text == ("") && (textBox2.Text == ("")))
            {
                MessageBox.Show("Nama dan Username tidak boleh kosong");
            }
            else if (textBox1.Text == (""))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
            }
            else if (textBox2.Text == (""))
            {
                MessageBox.Show("Username Tidak Boleh Kosong");
            }
            else if (textBox3.Text == (""))
            {
                MessageBox.Show("Email Tidak Boleh Kosong");
            }
            else if (textBox4.Text == (""))
            {
                MessageBox.Show("Password Tidak Boleh Kosong");
            }
            else if (textBox5.Text == (""))
            {
                MessageBox.Show("Tulis Ulang Password Anda");
            }
            else if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Password Yang Anda Masukkan Tidak Sama");
            }
        }
    }
}
