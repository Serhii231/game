using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp4
{
    public partial class Form3 : Form
    {
        public Form3(int n)
        {
            InitializeComponent();
            this.nm = n;
        }
        int nm;
        public void show2()
        {

            try
            {
                SqlConnection conn = DB.GetDBConnection();
                int x = 6, y = 19, x2 = 46, y2 = 125, i = 0;
                SqlCommand command = new SqlCommand("Select  title,  foto from dbo.game", conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
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
                    String ss = reader["foto"].ToString();
                    pictureBox.Image = Image.FromFile(ss);
                    pictureBox.ImageLocation = ss;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(114, 105);
                    pictureBox.Location = new Point(x, y);
                    void PictureBox_Click(object send, EventArgs eventArgs)
                    {
                        this.Hide();
                        Form5 form5 = new Form5(pictureBox.ImageLocation, nm);
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
                    label2.Text = reader["title"].ToString();
                    label2.Enter += Label2_Enter;
                    void Label2_Enter(object sender2, EventArgs e3)
                    {
                        this.Hide();
                        Form5 form5 = new Form5(label2.Text, nm);
                        form5.Show();
                    }
                    panel1.Controls.Add(label2);
                    x += 141;
                    x2 += 141;
                }
                conn.Close();
            }
            catch (Exception ex) { }
            if (nm == 0) менюToolStripMenuItem.Enabled = false;
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DB.GetDBConnection();
                int x = 6, y = 19, x2 = 46, y2 = 125, i = 0;
                SqlCommand command = new SqlCommand("Select  title,  foto from dbo.game", conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
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
                    String ss = reader["foto"].ToString();
                    pictureBox.Image = Image.FromFile(ss);
                    pictureBox.ImageLocation = ss;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(114, 105);
                    pictureBox.Location = new Point(x, y);
                    void PictureBox_Click(object send, EventArgs eventArgs)
                    {
                        this.Hide();
                        Form5 form5 = new Form5(pictureBox.ImageLocation, nm);
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
                    label2.Text = reader["title"].ToString();
                    label2.Enter += Label2_Enter;
                    void Label2_Enter(object sender2, EventArgs e3)
                    {
                        this.Hide();
                        Form5 form5 = new Form5(label2.Text, nm);
                        form5.Show();
                    }
                    panel1.Controls.Add(label2);
                    x += 141;
                    x2 += 141;
                }
                conn.Close();
            }
            catch (Exception ex) { }
            if (nm == 0) менюToolStripMenuItem.Enabled = false;
        }



        private void Label_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(nm);
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void добавитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4(nm);
            form4.Show();
        }
        public void show() {
            try
            {
                panel1.Controls.Clear();
                SqlConnection conn = DB.GetDBConnection();
                conn.Open();
                SqlCommand command = new SqlCommand("Select  title, genre, gamemode,date, developer, publisher, composer, manager, agerating, description, foto from game", conn);

                SqlDataReader reader = command.ExecuteReader();
                int x = 6, y = 19, x2 = 46, y2 = 125, i = 0;
                while (reader.Read())
                {

                    if (textBox1.Text == reader["title"].ToString())
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
                            Form5 form5 = new Form5(pictureBox.ImageLocation, nm);
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
                        label2.Text = reader["title"].ToString();
                        panel1.Controls.Add(label2);
                        x += 141;
                        x2 += 141;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(Convert.ToString(ex)); }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") show2();
            else if (textBox1.Text != "Пошук") show();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext2(textBox1, "Пошук");
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            code obj = new code();
            obj.regtext1(textBox1, "Пошук");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                String S = "";
                SqlConnection conn = DB.GetDBConnection();
                conn.Open();
                String cmdText1 = "SELECT MAX(id) AS id FROM game ";
                SqlCommand cmd1 = new SqlCommand(cmdText1, conn);
                SqlDataReader t = cmd1.ExecuteReader();
                int n = 0;
                while (t.Read())
                {
                    n = Convert.ToInt32(t["id"].ToString());
                }
                
                
                    SqlCommand command2 = new SqlCommand("SELECT * FROM game ORDER BY reiting ASC", conn);
                    SqlDataReader reader2 = command2.ExecuteReader();

                    int x = 6, y = 19, x2 = 46, y2 = 125, i = 0;

                while (reader2.Read())
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

                    pictureBox.Image = Image.FromFile(reader2["foto"].ToString());
                    pictureBox.ImageLocation = reader2["foto"].ToString();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(120, 105);
                    pictureBox.Location = new Point(x, y);
                    void PictureBox_Click(object send, EventArgs eventArgs)
                    {
                        this.Hide();
                        Form5 form5 = new Form5(pictureBox.ImageLocation, nm);
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
                    label2.Text = reader2["title1"].ToString();
                    panel1.Controls.Add(label2);
                    x += 141;
                    x2 += 141;
                    SqlCommand command1 = new SqlCommand("delete from @a where reiting1 = @b", conn);
                    command1.ExecuteNonQuery();
                }
                }
                
            
            catch (Exception ex) { MessageBox.Show(Convert.ToString(ex)); }
}
  }  
    
}
