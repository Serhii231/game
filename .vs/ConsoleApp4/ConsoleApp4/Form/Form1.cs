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

namespace ConsoleApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Логін") MessageBox.Show("Ви не ввели логін!!");
            else if (textBox2.Text == "Пароль") MessageBox.Show("Ви не ввели пароль!!");
            else
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    this.Hide();
                    Form3 form3 = new Form3(1);
                    form3.Show();
                }
                else
                {
                    user us = new user(textBox1.Text, textBox2.Text);
                    
                    bool i = us.print(textBox1.Text, textBox2.Text); ;
                    if (i ==true)
                    {
                        this.Hide();
                        Form3 form3 = new Form3(0);
                        form3.Show();
                    }
                    else MessageBox.Show("Не вдалось увійти!");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            code obj = new code();
            obj.regtext1(textBox1, "Логін");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext2(textBox1, "Логін");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext1(textBox2, "Пароль");
            textBox2.PasswordChar = '*';
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0) { textBox2.PasswordChar = '\0'; }
            code obj = new code();
            obj.regtext2(textBox2, "Пароль");
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
