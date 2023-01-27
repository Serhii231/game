using ConsoleApp4.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4
{
    public partial class Form6 : Form
    {
        public Form6(String m)
        {
            InitializeComponent();
             s = m;
        }
        string s;
        private void Form6_Load(object sender, EventArgs e)
        {
            if (s == "Композитор" || s == "Менеджер")
            {
                textBox1.Text = "Ім'я";
                textBox1.Enter += TextBox1_Enter;
                void TextBox1_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox1, "Ім'я");
                }
                textBox1.Leave += TextBox1_Leave;
                 void TextBox1_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox1, "Ім'я");
                }
                textBox2.Text = "Прізвище";
                textBox2.Enter += TextBox2_Enter;
                void TextBox2_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox2, "Прізвище");
                }
                textBox2.Leave += TextBox2_Leave;
                void TextBox2_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox2, "Прізвище");
                }
                textBox3.Text = "Дата народження";
                textBox3.Enter += TextBox3_Enter;
                void TextBox3_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox3, "Дата народження");
                }
                textBox3.Leave += TextBox3_Leave;
                void TextBox3_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox3, "Дата народження");
                }
                textBox4.Text = "Громадянство";
                textBox4.Enter += TextBox4_Enter;
                void TextBox4_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox4, "Громадянство");
                }
                textBox4.Leave += TextBox4_Leave;
                void TextBox4_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox4, "Громадянство");
                }
                textBox5.Text = "Коротка біографія";
                textBox5.Enter += TextBox5_Enter;
                void TextBox5_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox5, "Коротка біографія");
                }
                textBox5.Leave += TextBox5_Leave;
                void TextBox5_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox5, "Коротка біографія");
                }
            }
            else if(s == "Виробник")
            {
                textBox1.Text = "Назва";
                textBox1.Enter += TextBox1_Enter;
                void TextBox1_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox1, "Назва");
                }
                textBox1.Leave += TextBox1_Leave;
                void TextBox1_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox1, "Назва");
                }
                textBox2.Text = "Рік заснування";
                textBox2.Enter += TextBox2_Enter;
                void TextBox2_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox2, "Рік заснування");
                }
                textBox2.Leave += TextBox2_Leave;
                void TextBox2_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox2, "Рік заснування");
                }
                textBox3.Text = "Розміщення головного офісу";
                textBox3.Enter += TextBox3_Enter;
                void TextBox3_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox3, "Розміщення головного офісу");
                }
                textBox3.Leave += TextBox3_Leave;
                void TextBox3_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox3, "Розміщення головного офісу");
                }
                textBox4.Text = "Кількість працівників";
                textBox4.Enter += TextBox4_Enter;
                void TextBox4_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox4, "Кількість працівників");
                }
                textBox4.Leave += TextBox4_Leave;
                void TextBox4_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox4, "Кількість працівників");
                }
                textBox5.Text = "Коротка інформація";
                textBox5.Enter += TextBox5_Enter;
                void TextBox5_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox5, "Коротка інформація");
                }
                textBox5.Leave += TextBox5_Leave;
                void TextBox5_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox5, "Коротка інформація");
                }
            }
            else
            {
                textBox1.Text = "Назва";
                textBox1.Enter += TextBox1_Enter;
                void TextBox1_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox1, "Назва");
                }
                textBox1.Leave += TextBox1_Leave;
                void TextBox1_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox1, "Назва");
                }
                textBox2.Text = "Рік заснування";
                textBox2.Enter += TextBox2_Enter;
                void TextBox2_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox2, "Рік заснування");
                }
                textBox2.Leave += TextBox2_Leave;
                void TextBox2_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox2, "Рік заснування");
                }
                textBox3.Text = "Розміщення головного офісу";
                textBox3.Enter += TextBox3_Enter;
                void TextBox3_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox3, "Розміщення головного офісу");
                }
                textBox3.Leave += TextBox3_Leave;
                void TextBox3_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox3, "Розміщення головного офісу");
                }
                textBox4.Text = "Засновник";
                textBox4.Enter += TextBox4_Enter;
                void TextBox4_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox4, "Засновник");
                }
                textBox4.Leave += TextBox4_Leave;
                void TextBox4_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox4, "Засновник");
                }
                textBox5.Text = "Коротка інформація";
                textBox5.Enter += TextBox5_Enter;
                void TextBox5_Enter(object sende, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext1(textBox5, "Коротка інформація");
                }
                textBox5.Leave += TextBox5_Leave;
                void TextBox5_Leave(object send, EventArgs e1)
                {
                    code obj = new code();
                    obj.regtext2(textBox5, "Коротка інформація");
                }
            }
            }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(s == "Композитор")
            {
                Class.Compositor kreativ = new Class.Compositor(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, pictureBox1.ImageLocation);
                kreativ.enter();

            }
            if(s== "Менеджер") { 
                Class.Meneger kreativ = new Class.Meneger(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, pictureBox1.ImageLocation);
                kreativ.enter();
            }
            if (s == "Видавництво")
            {
                compani compani = new Class.Publisher(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text, pictureBox1.ImageLocation);
                compani.enter();
            }
            if (s == "Виробник")
            {
                compani compani = new developer(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, Convert.ToInt32(textBox4.Text), pictureBox1.ImageLocation);
                compani.enter();
            }
            this.Hide();
            Form4 form5 = new Form4(1);
            form5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
        public void picturebox(String n)
        {
            pictureBox1.Image = Image.FromFile(n);
            pictureBox1.ImageLocation = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form5 = new Form4(1);
            form5.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
