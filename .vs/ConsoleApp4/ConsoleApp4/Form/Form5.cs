using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4
{
    public partial class Form5 : Form
    {
        public Form5(string data, int n1)
        {
            InitializeComponent();
            this.data = data;
            n = n1;
        }
        string data;
        int n;
        int q;
        private void Form5_Load(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection conn = DB.GetDBConnection();
                conn.Open();

               SqlCommand command = new SqlCommand("Select  title, genre, gamemode,date, developer, publisher, composer, manager, agerating, description, foto, price, reiting, id from game",conn);
                
                SqlDataReader reader = command.ExecuteReader();
                int n = 0;
                String[] x = new String[3];

                while (reader.Read())
                {
                     
                    
                    
                    
                    if (data == reader.GetValue(10).ToString()||data == reader.GetValue(0).ToString())
                    {
                        label11.Text = reader.GetValue(0).ToString();
                        label2.Text = "Жанр: " + reader.GetValue(1).ToString();
                        label3.Text = "Режим гри: " + reader.GetValue(2).ToString();
                        linkLabel1.Text =  reader.GetValue(4).ToString().Replace("  ", string.Empty);
                        label10.Text = "Дата випуску: "+ reader.GetValue(3).ToString();
                        linkLabel2.Text =  reader.GetValue (5).ToString().Replace("  ", string.Empty);
                        linkLabel3.Text =  reader.GetValue(6).ToString();
                        linkLabel4.Text =  reader.GetValue(7).ToString();
                        label4.Text = "Віковй рейтинг: " + reader.GetValue(8).ToString();
                        label8.Text = "Опис: " ;
                        richTextBox1.Text = reader.GetValue(9).ToString();
                        pictureBox1.Image = Image.FromFile(reader.GetValue(10).ToString());
                        q = reader.GetInt32(13);
                        label12.Text = "Вартість: " + reader.GetInt32(11).ToString()+ "$";
                        label13.Text = "Рейтинг гри: " + reader.GetInt32(12).ToString() ;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(Convert.ToString(ex)); }
            if(n == 1)
            {
                 this.Size  = new Size(601, 535);
                Button button = new Button();
                button.Size = new Size(230, 33);
                button.Location = new Point(19, 500);
                button.Text = "Редагувати";
                button.Click += Button_Click;
                this.Controls.Add(button);
                Button button1 = new Button();
                button1.Size = new Size(230, 33);
                button1.Location = new Point(310, 500);
                button1.Text = "Видалити";
                button1.Click += Button_Click1;
                this.Controls.Add(button1);
            }
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            SqlConnection conn = DB.GetDBConnection();
            conn.Open();
            String s = "DELETE FROM game WHERE game.id =" + Convert.ToString(q) + ";";
           
           SqlCommand command = new SqlCommand(s, conn);

            command.ExecuteReader();
            conn.Close();
            Form3 form3 = new Form3(n);
            this.Hide();
            form3.Show();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8(label11.Text);
            form8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(n);
            this.Hide();
            form3.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            
        {
            
            Form7 form7 = new Form7(linkLabel1.Text, label5.Text, n);
            form7.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form7 form7 = new Form7(linkLabel2.Text,  label6.Text, n);
            form7.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form7 form7 = new Form7(linkLabel3.Text, label7.Text, n);
            form7.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Form7 form7 = new Form7( linkLabel4.Text, label9.Text, n);
            form7.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
