using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.view
{
    public partial class Form1 : Form
    {
        string email = "";
        string passcode = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
            email = textBox1.Text;
            passcode = textBox2.Text;
            MessageBox.Show($"Vo Ceci seu email {email} esta correto !?!?");
            MessageBox.Show("Ola, C#");
            if (email.Equals("ceci@gmail.com") && passcode.Equals("123"))
            {
                MessageBox.Show("valid");
            }

        }
        private void textBox2_MouseMove(object sender, MouseEventArgs e) 
        {
            if (passcode.Equals(123))
            {
                button1.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
