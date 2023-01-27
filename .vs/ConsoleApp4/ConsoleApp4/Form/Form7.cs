using ConsoleApp4.Class;
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
    public partial class Form7 : Form
    {
        public Form7(String s,  String s2, int n1)
        {
            InitializeComponent();
            this.s1 = s;
            
            this.s2 = s2;
            
            b = n1;
        }

        
        String s1;
        String s2;
        int q;
        int b;
        private void Form7_Load(object sender, EventArgs e)
        {
            
            
            
        

            try
            {
                if (s2 == "Розробник:")
                {
                    compani compani = new developer();
                    q =compani.print(textBox1, textBox2, textBox3, textBox4, textBox5, pictureBox1, s1,q);
                }
                if (s2 == "Видавництво:")
                {
                    compani compani = new Publisher();
                   q = compani.print(textBox1, textBox2, textBox3, textBox4, textBox5, pictureBox1, s1,q);
                }
                if(s2 == "Композитор:")
                {
                    Kreativ kreativ = new Compositor();
                    kreativ.print(textBox1, textBox2, textBox3, textBox4, textBox5, pictureBox1, s1,q);
                }
                if (s2 == "Продюсор:")
                {
                    Kreativ kreativ = new Meneger();
                    kreativ.print(textBox1, textBox2, textBox3, textBox4, textBox5, pictureBox1, s1,q);
                }
                if (b == 1)
                {
                    button2.Location = new Point(31, 382);
                    Button button = new Button();
                    button.Size = new Size(155, 39);
                    button.Location = new Point(279, 382);
                    button.Text = "Редагувати";
                    button.Click += Button_Click;
                    this.Controls.Add(button);

                }
            }
            catch (Exception ex) { MessageBox.Show(Convert.ToString(ex)); }
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form9 = new Form9(s1, s2, q);
            form9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
            {

            this.Hide();

        }

           private void Form7_MouseLeave(object sender, EventArgs e)
          {
                this.Hide();
          }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
