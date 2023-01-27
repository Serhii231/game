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
    public partial class Form9 : Form
    {
        public Form9(String s1, String s2, int q)
        {
            InitializeComponent();
            this.s1 = s1;
            this.s2 = s2;
            this.q = q;
            
        }
        String s1, s2;
        int q;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Thread t = new Thread((ThreadStart)(() =>
            {
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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  try
            //{
                if (s2 == "Розробник:")
                {
                SqlConnection conn = DB.GetDBConnection();
                conn.Open();
                String s = "UPDATE developer  SET Name = '" + textBox1.Text +
                    "', dat ='" + textBox2.Text +
                    "', placing = '" + textBox3.Text +
                    "', description = '" + textBox5.Text + "',kilkist='" + textBox4.Text +
                    "', foto = @a" +
                    " WHERE developer.id = " + Convert.ToString(q);
                    SqlCommand command = new SqlCommand(s,conn);
                    
                    command.Parameters.AddWithValue("@a",pictureBox1.ImageLocation);
                command.ExecuteNonQuery();
                conn.Close();
                    this.Hide();
                }
                if (s2 == "Видавництво:")
                {
                SqlConnection conn = DB.GetDBConnection();
                conn.Open();
                DB db = new DB();
                    String s = "UPDATE publisher  SET Name = '" + textBox1.Text +
                    "', dat ='" + textBox2.Text +
                    "', placing = '" + textBox3.Text +
                    "', description = '" + textBox5.Text +
                    "',founder='"+ textBox4.Text +
                    "', foto = @a" +
                    " WHERE publisher.id = " + Convert.ToString(q);
                    SqlCommand command = new SqlCommand(s,conn);
                    command.Parameters.AddWithValue("@a",pictureBox1.ImageLocation);
                command.ExecuteNonQuery();
                conn.Close();
                    this.Hide();
                }
                if (s2 == "Композитор:")
                {
                SqlConnection conn = DB.GetDBConnection();
                conn.Open();
                
                    String s = "UPDATE compositor1  SET Name = '" + textBox1.Text +
                    "', Surname ='" + textBox2.Text +
                    "', date = '" + textBox3.Text +
                    "', description = '" + textBox5.Text +
                    "',citizenship = '" + textBox4.Text +
                    "', foto = @a" +
                    " WHERE compositor.id = " + Convert.ToString(q);
                    SqlCommand command = new SqlCommand(s,conn);
                    command.Parameters.AddWithValue("@a",pictureBox1.ImageLocation);
                command.ExecuteNonQuery();
                conn.Close();
                    this.Hide();
                }
                if (s2 == "Продюсор:")
                {
                try
                {
                    SqlConnection conn = DB.GetDBConnection();
                    conn.Open();
                    String s = "UPDATE manager  SET Name = '" + textBox1.Text +
                     "', Surname ='" + textBox2.Text +
                     "', date = '" + textBox3.Text +
                     "',citizenship = '" + textBox4.Text +
                     "', description = '" + textBox5.Text +
                     "', foto = @a" +
                     " WHERE manager.id = " + Convert.ToString(q);
                    SqlCommand command = new SqlCommand(s,conn);
                    command.Parameters.AddWithValue("@a",pictureBox1.ImageLocation);
                    command.ExecuteNonQuery();
                   conn.Close();
                    this.Hide();
                }
                catch(Exception e1)
                {
                    MessageBox.Show(Convert.ToString(e1));
                }
                }
              //  }
            //catch (Exception e1) { MessageBox.Show(Convert.ToString(e1)); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            try {
                if (s2 == "Розробник:")
                {
                    compani compani = new developer();
                    compani.print(textBox1, textBox2, textBox3, textBox4, textBox5, pictureBox1, s1,q);
                }
                if (s2 == "Видавництво:")
                {
                    compani compani = new Publisher();
                    compani.print(textBox1, textBox2, textBox3, textBox4, textBox5, pictureBox1, s1,q);
                }
                if (s2 == "Композитор:")
                {
                    Kreativ kreativ = new Compositor();
                    kreativ.print(textBox1, textBox2, textBox3, textBox4, textBox5, pictureBox1, s1,q);

                }
                if (s2 == "Продюсор:")
                {
                    Kreativ kreativ = new Meneger();
                    kreativ.print(textBox1, textBox2, textBox3, textBox4, textBox5, pictureBox1, s1,q);
                }
            }
            catch(Exception e1) { MessageBox.Show(Convert.ToString(e1)); }
            }
    }
}
