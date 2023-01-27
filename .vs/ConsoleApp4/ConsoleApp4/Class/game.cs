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

namespace ConsoleApp4
{
    class game
    {
        String name;
        String genre;
        String gamemode;
        String date;
        String developer;
        String publisher;
        String composer;
        String manager;
        String agerating;
        String description;
        static String foto;
        int price;
        int reiting;
        public game() { }
        public game(String name, String genre, String gamemode, String date, String developer, String publisher, String composer, String manager,String agerating, String description, String fot, int price, int reiting) {
            this.name = name;
            this.genre = genre;
            this.gamemode = gamemode;
            this.date = date;
            this.developer = developer;
            this.publisher = publisher;
            this.composer = composer;
            this.manager = manager;
            this.agerating = agerating;
            this.description = description;
            foto = fot;
            this.price = price;
            this.reiting = reiting;
        }
        public int getId()
        {
            int id = 0;

            SqlConnection conn = DB.GetDBConnection();
            conn.Open();
            try
            {


                String cmdText1 = "SELECT MAX(id) AS id FROM game ";
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
        public int enter()
        {
            SqlConnection conn = DB.GetDBConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(" INSERT INTO game ( id, title, genre, gamemode, date, developer, publisher, composer, manager, agerating, description,foto, price, reiting) VALUES (@id, @title, @genre, @gamemode, @date, @developer, @publisher, @composer, @manager, @agerating, @description, @foto, @price, @reiting)", conn);
            command.Parameters.AddWithValue("@title", name);
            command.Parameters.AddWithValue("@genre", genre);
            command.Parameters.AddWithValue("@gamemode", gamemode);
            command.Parameters.AddWithValue("@date",  date);
            command.Parameters.AddWithValue("@developer", developer);
            command.Parameters.AddWithValue("@publisher", publisher);
            command.Parameters.AddWithValue("@composer", composer);
            command.Parameters.AddWithValue("@manager", manager);
            command.Parameters.AddWithValue("@agerating", agerating);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@foto", foto);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@reiting", reiting);
            command.Parameters.AddWithValue("@id", getId()+1);
            int i = command.ExecuteNonQuery();
            conn.Close();
            return i;

        }
        

        

        public static int print()
        {
            SqlConnection conn = DB.GetDBConnection();
            conn.Open();

            SqlCommand comand = new SqlCommand(" SELECT * FROM game WHERE foto = @l", conn);
            comand.Parameters.AddWithValue("@l", foto);
            SqlDataReader reader = comand.ExecuteReader();
            return 0;
        }
        public void prin(String s)
        {
            
        }
        private void PictureBox_MouseHover1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
