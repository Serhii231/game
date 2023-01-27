using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.ComponentModel;
using System.IO;
using ConsoleApp4.Class;
using MySql.Data.MySqlClient;

namespace ConsoleApp4
{
    public partial class Form4 : Form
    {
        public Form4(int n1)
        {
            InitializeComponent();
            openFileDialog1.Filter = "All files(*.*) | *.* ";
            n = n1;
        }
        int n;
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button8_Click(object sender, EventArgs e)
        {
            game gam = new game(textBox1.Text, comboBox2.Text, comboBox1.Text, textBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text, textBox3.Text, textBox4.Text, pictureBox1.ImageLocation, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            gam.enter();
            Form3 form3 = new Form3(n);
            this.Hide();
            form3.Show();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Добавити+")
            {
                comboBox3.Text = "";
                this.Hide();
                Form6 form5 = new Form6("Виробник");
                form5.Show();

            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Добавити+")
            {
                comboBox4.Text = "";
                this.Hide();
                Form6 form5 = new Form6("Видавництво");
                form5.Show();

            }
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Добавити+")
            {
                comboBox5.Text = "";
                this.Hide();
                Form6 form5 = new Form6("Композитор");
                form5.Show();

            }
        }
        public void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "Добавити+")
            {
                comboBox6.Text = "";
                this.Hide();
                Form6 form5 = new Form6("Менеджер");
                form5.Show();
                int[] k;
            }
        }
        public   void  picturebox(String n)
        {
            pictureBox1.Image = Image.FromFile(n);
            pictureBox1.ImageLocation = n;
        }
        public   void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread((ThreadStart)(() => {
                OpenFileDialog openFileDialog2 = new OpenFileDialog();
                openFileDialog2.RestoreDirectory = true;
                if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                String filename;
               
                filename = openFileDialog2.FileName;
               
                picturebox(filename);
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
        public void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Kreativ kreativ = new Meneger();
            Kreativ kreativ1 = new Compositor();
            compani compani = new developer();
            compani compani1 = new Publisher();
            compani.cheks(comboBox3);


            compani1.cheks(comboBox4);

            kreativ1.cheks(comboBox5);

            kreativ.cheks(comboBox6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(1);
            this.Hide();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext1(textBox1, "Назва");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext2(textBox1, "Назва");
        }

        
        

        

        

       

       

        private void textBox2_Leave(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext2(textBox2, "Дата випуску");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext1(textBox2, "Дата випуску");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext2(textBox3, "Віковий рейтинг");
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext1(textBox3, "Віковий рейтинг");
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext2(textBox4, "Опис");
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext1(textBox4, "Опис");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext1(textBox4, "Вартість");
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext2(textBox4, "Вартість");
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext2(textBox4, "Рейтинг гри");
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext1(textBox4, "Рейтинг гри");
        }
    }
}
