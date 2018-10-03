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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("") && (textBox2.Text == ("")))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong");
            }
            else if (textBox1.Text == ("admin") && (textBox2.Text == ("fiid")))
            {
                MessageBox.Show("Login Berhasil");
                this.Hide();
                main ll = new main();
                ll.Show();

            }
            else if (textBox1.Text != ("admin") && (textBox2.Text != ("fiid")))
            {
                MessageBox.Show("Username atau Password Salah");
            }
            else if (textBox1.Text == ("admin") && (textBox2.Text != ("fiid")))
            {
                MessageBox.Show("Username atau Password Salah");
            }
            else if (textBox1.Text != ("admin") && (textBox2.Text == ("fiid")))
            {
                MessageBox.Show("Username atau Password Salah");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            regist reg = new regist();
            reg.Show();
        }
    }
}
