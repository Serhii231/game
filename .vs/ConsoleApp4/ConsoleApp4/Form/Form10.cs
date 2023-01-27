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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(1);
            this.Hide();
            form3.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DB.GetDBConnection();
                conn.Open();
                SqlCommand command = new SqlCommand("declare @a table( title1 text, foto1 text, reiting1 int)" +
                    " insert @a select title, foto, reiting from game" +
                    " declare @b int set @b = (select MAX (reiting1) As maxq from @a) " +
                    "select * from @a where reiting1 = @b", conn);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    label2.Text =  reader["title1"].ToString();
                    pictureBox1.Image = Image.FromFile(reader["foto1"].ToString());
                }
                conn.Close();
                conn.Open();
                SqlCommand command1 = new SqlCommand("declare @a table( title1 text, foto1 text, reiting1 int)" +
                    " insert @a select title, foto, reiting from game" +
                    " declare @b int set @b = (select MIN (reiting1) As maxq from @a) " +
                    "select * from @a where reiting1 = @b", conn);

                SqlDataReader reader1 = command.ExecuteReader();
                while (reader1.Read())
                {
                    label4.Text = reader1["title1"].ToString();
                    pictureBox2.Image = Image.FromFile(reader1["foto1"].ToString());
                }
                conn.Close();
                conn.Open();
                SqlCommand command2 = new SqlCommand("SELECT SUM(price) AS Avg1 FROM game", conn);

                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    label5.Text ="Загальна вартість відеоігор: "+ reader2["Avg1"].ToString();
                    
                }
                conn.Close();
                conn.Open();
                SqlCommand command3 = new SqlCommand("SELECT AVG(price) AS Avg1 FROM game", conn);

                SqlDataReader reader3= command3.ExecuteReader();
                while (reader3.Read())
                {
                    label6.Text = "Середня вартість відеогри " + reader3["Avg1"].ToString();

                }
                conn.Close();
                conn.Open();
                SqlCommand command4 = new SqlCommand("SELECT MAX(id) AS Avg1 FROM game", conn);

                SqlDataReader reader4 = command4.ExecuteReader();
                while (reader4.Read())
                {
                    label7.Text = "Кількість відоігор в базі даних " + reader4["Avg1"].ToString();

                }
                conn.Close();
                int x = 6, y = 19, x2 = 46, y2 = 125, i = 0;
              /*  while (reader.Read())
                {


                    if (i == 5)
                    {
                        x = 6;
                        x2 = 46;
                        y += 140;
                        y2 += 140;
                        i = 0;
                    }
                    i++;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(reader["foto"].ToString());
                    pictureBox.ImageLocation = reader["foto"].ToString();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(120, 105);
                    pictureBox.Location = new Point(x, y);
                    void PictureBox_Click(object send, EventArgs eventArgs)
                    {
                        this.Hide();
                        Form5 form5 = new Form5(pictureBox.ImageLocation, 1);
                        form5.Show();
                    }
                    pictureBox.MouseHover += new EventHandler(PictureBox_MouseHover);
                    void PictureBox_MouseHover(object send, EventArgs s)
                    {
                        pictureBox.Size = new Size(300, 250);
                    }
                    pictureBox.MouseLeave += PictureBox_MouseLeave;
                    void PictureBox_MouseLeave(object send, EventArgs e1)
                    {
                        pictureBox.Size = new Size(114, 105);
                    }
                    pictureBox.Click += new EventHandler(PictureBox_Click);
                    panel1.Controls.Add(pictureBox);
                    LinkLabel label2 = new LinkLabel();
                    label2.Size = new Size(50, 20);
                    label2.Location = new Point(x2, y2);
                    label2.Text = reader["title1"].ToString();
                    panel1.Controls.Add(label2);
                    x += 141;
                    x2 += 141;

                }*/
            }
            catch (Exception ex) { MessageBox.Show(Convert.ToString(ex)); }
        }
    }
}
