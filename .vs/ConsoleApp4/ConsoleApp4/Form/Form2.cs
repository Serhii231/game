using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp4;
namespace ConsoleApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            user us = new user(textBox1.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text);
            int i = 1; 
                us.enter();
            if (i == 1) {
                this.Hide();
                Form3 form3 = new Form3(0);
                form3.Show();
            }
            else MessageBox.Show("No");
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
          
           
          
        }
        public void textBox1_TextChanged1(object sender, EventArgs e) { 
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
       
        private void textBox1_Enter(object sender, EventArgs e)
        {

            code obj = new code(); 
                obj.regtext1(textBox1, "Ім'я");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext2(textBox1, "Ім'я");
        }      
        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext2(textBox2, "Прізвище");
        }
        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext1(textBox2, "Прізвище");
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext1(textBox3, "Логін");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext2(textBox3, "Логін");
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "Пароль")
            {
                maskedTextBox1.ForeColor = Color.Black;
                maskedTextBox1.Text = "";
                maskedTextBox1.PasswordChar = '*';
            }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                maskedTextBox1.ForeColor = Color.Gray;
                maskedTextBox1.PasswordChar = '\0';
                maskedTextBox1.Text = "Пароль";
                
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
