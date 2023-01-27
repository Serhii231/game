using ConsoleApp4.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4
{
    public partial class Form8 : Form
    {
        public Form8(String s)
        {
            InitializeComponent();
            this.s = s;
            
        }
        String s;
        int q;
        private void Form8_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DB.GetDBConnection();
            
            Kreativ kreativ = new Meneger();
            Kreativ kreativ1 = new Compositor();
            compani compani = new developer();
            compani compani1 = new Publisher();
            compani.cheks( comboBox3);

           
            compani1.cheks( comboBox4);
           
            kreativ1.cheks( comboBox5);
           
            kreativ.cheks( comboBox6);
            
            

            SqlCommand command = new SqlCommand("Select id, title, genre, gamemode,date, developer, publisher, composer, manager, agerating, description, foto, price from game",conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            int n = 0;
            String[] x = new String[3];

            while (reader.Read())
            {
                if (s == reader.GetValue(1).ToString())
                {
                    q = reader.GetInt32(0);
                    textBox1.Text = reader.GetValue(1).ToString();
                    comboBox1.Text = reader.GetValue(2).ToString();
                    comboBox2.Text = reader.GetValue(3).ToString();
                    textBox2.Text = reader.GetValue(4).ToString();
                    comboBox3.Text = reader.GetValue(5).ToString();
                    comboBox4.Text = reader.GetValue(6).ToString();
                    comboBox5.Text = reader.GetValue(7).ToString();
                    comboBox6.Text = reader.GetValue(8).ToString();
                    textBox3.Text = reader.GetValue(9).ToString();
                    textBox4.Text = reader.GetValue(10).ToString();
                    pictureBox1.Image = Image.FromFile(reader.GetValue(11).ToString());
                    pictureBox1.ImageLocation = reader.GetValue(11).ToString();
                    textBox5.Text = reader.GetValue(12).ToString();
                }
            }
            conn.Close();
        }
        public void picturebox(String n)
        {
            pictureBox1.Image = Image.FromFile(n);
            pictureBox1.ImageLocation = n;
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

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DB.GetDBConnection();
            
            
            String s = "UPDATE game  SET title = '" +textBox1.Text +"', genre ='" + comboBox1.Text+"', gamemode = '" + comboBox2.Text+
                "', date ='" + textBox2.Text+"', developer ='" + comboBox3.Text+
                "', publisher = '" + comboBox4.Text+
                "', composer = '" + comboBox5.Text+
                "', manager = '" + comboBox6.Text+
                "', agerating = '" + textBox3.Text+
                "', description = '" + textBox4.Text+
                "', price = '" + textBox5.Text +
                "', reiting = '" + textBox6.Text +
                "', foto = @a" +
                " WHERE game.id = " + Convert.ToString(q);
            conn.Open();
            SqlCommand  command = new SqlCommand(s, conn);
            command.Parameters.AddWithValue("@a",  pictureBox1.ImageLocation);
            
            command.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            Form3 form3 = new Form3(1);
            form3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3(1);
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

