using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace ConsoleApp4.Class
{
    class Publisher: compani
    {
        String name;
        String date;
        String placing;
        String description;
        String foto;
        String founder;
        DB db = new DB();
        public Publisher() { }
        public Publisher(String name, String date, String placing, String description,String founder, String foto) 
        {
            
            this.name = name;
            this.date = date;
            this.placing = placing;
            this.description = description;
            this.foto = foto;
            this.founder = founder;
        }
        public int getId()
        {
            int id = 0;

            SqlConnection conn = DB.GetDBConnection();
            conn.Open();
            try
            {


                String cmdText1 = "SELECT MAX(id) AS id FROM publisher ";
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
            SqlCommand command = new SqlCommand(" INSERT INTO publisher ( Name, dat, placing, description, founder, foto, id) VALUES ( @name, @date, @placing, @description, @founder, @foto, @id)", conn);
            command.Parameters.AddWithValue("@founder", founder);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@placing", placing);
            command.Parameters.AddWithValue("@description",description);
            command.Parameters.AddWithValue("@foto", foto);
            command.Parameters.AddWithValue("@id", getId() + 1);
            int i = command.ExecuteNonQuery();
            conn.Close();
            return i;

        }
        public override int print(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5, PictureBox pictureBox1, String s1, int q) {
            SqlConnection conn = DB.GetDBConnection();
            conn.Open();
            SqlCommand command = new SqlCommand("Select *  from publisher",conn);
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                if (s1 == reader.GetValue(0).ToString().Replace("  ", string.Empty))
                {
                    textBox1.Text =  reader.GetValue(0).ToString().Replace("  ", string.Empty);
                    textBox2.Text = reader.GetValue(1).ToString().Replace("  ", string.Empty);
                    textBox3.Text = reader.GetValue(2).ToString().Replace("  ", string.Empty);
                    textBox5.Text = reader.GetValue(3).ToString().Replace("  ", string.Empty);
                    textBox4.Text = reader.GetValue(4).ToString().Replace("  ", string.Empty); 
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
            SqlCommand command = new SqlCommand("Select *  from publisher",conn);
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(reader.GetValue(0).ToString().Replace("  ", string.Empty));
            }
            conn.Close();
        }
    }
}
