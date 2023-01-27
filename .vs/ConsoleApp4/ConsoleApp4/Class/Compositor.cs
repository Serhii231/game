using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4.Class
{
    class Compositor : Kreativ
    {
        DB db = new DB();
        String surname;
        String name;
        String date;
        String citizenship;
        String description;
        String foto;
        public Compositor()
        {
        }

        public Compositor(String surname, String name, String date, String citizenship, String description, String foto)
        {
            this.surname = surname;
            this.name = name;
            this.date = date;
            this.citizenship = citizenship;
            this.description = description;
            this.foto = foto;
        }
        public int getId()
        {
            int id = 0;

            SqlConnection conn = DB.GetDBConnection();
            conn.Open();
            try
            {


                String cmdText1 = "SELECT MAX(id) AS id FROM compositor ";
                SqlCommand cmd1 = new SqlCommand(cmdText1, conn);

                SqlDataReader t = cmd1.ExecuteReader();
                while (t.Read())
                {
                    id = Convert.ToInt32(t["id"].ToString());
                }
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            return id;
        }
        public override int enter()
        {
            SqlConnection conn = DB.GetDBConnection();
            conn.Open();
            DB db = new DB();
            SqlCommand command = new SqlCommand(" INSERT INTO compositor ( Name, Surname, date, citizenship, description, foto, id) VALUES ( @name, @surname,@date,@citizenship, @description, @foto, @id)", conn);
            command.Parameters.AddWithValue("@name",  name);
            command.Parameters.AddWithValue("@surname",  surname);
            command.Parameters.AddWithValue("@citizenship",  citizenship);
            command.Parameters.AddWithValue("@date",  date);
            command.Parameters.AddWithValue("@description",  description);
            command.Parameters.AddWithValue("@foto",  foto);
            command.Parameters.AddWithValue("@id", getId() + 1);
            int i = command.ExecuteNonQuery();
            conn.Close();
            return i;

        }
        public override int print(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5, PictureBox pictureBox1, String s1, int q)
        {
            SqlConnection conn = DB.GetDBConnection();
            
            SqlCommand command = new SqlCommand("Select * from compositor",conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (s1 == reader.GetValue(0).ToString()+ " "+reader.GetValue(1).ToString())
                {
                    textBox1.Text =  reader.GetValue(0).ToString();
                    textBox2.Text =  reader.GetValue(1).ToString();
                    textBox3.Text =  reader.GetValue(2).ToString();
                    textBox4.Text =  reader.GetValue(3).ToString();
                    textBox5.Text =  reader.GetValue(4).ToString();
                    pictureBox1.Image = Image.FromFile(reader.GetValue(5).ToString());
                    pictureBox1.ImageLocation = reader.GetValue(5).ToString();
                    q = reader.GetInt32(6);
                }
            }
            conn.Close();
            return q;
        }
        public override void cheks(ComboBox comboBox)
        {
           SqlConnection conn = DB.GetDBConnection();
            conn.Open();
            SqlCommand command = new SqlCommand("Select Name ,Surname,citizenship,date, description, foto from compositor",conn);
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString());
            }
            conn.Close();
        }
    }
}
