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
     class user
    {

        String name;
        String surname;
        String login;
        String password;
        public user(String nam, String surnam, String log, String pass) {
            name = nam;
            surname = surnam;
            login = log;
            password = pass;
        }
        public user(String log, String pass) {
            login = log;
            password = pass;
        }
        public int getId()
        {
            int id = 0;

            SqlConnection conn = DB.GetDBConnection();
            conn.Open();
            try
            {
                

                String cmdText1 = "SELECT MAX(id) AS id FROM users ";
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
        public void enter() {
            SqlConnection conn = DB.GetDBConnection();
            
            SqlCommand command = new SqlCommand(" INSERT INTO users (id, login, password, name, surname) VALUES (@id, @login, @pass, @name, @surname)",conn);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@pass",  password);
            command.Parameters.AddWithValue("@name",  name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@id", getId() + 1);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();


        }
        public bool print(String s, String f) {
            SqlConnection conn = DB.GetDBConnection();
            conn.Open();
            
            SqlCommand comand = new SqlCommand(" SELECT login, password FROM  users ", conn);
            SqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                String l = Convert.ToString(reader["login"].ToString());
                String p = Convert.ToString(reader["password"].ToString());
                if (l == s && f == p)
                {
                    return true;
                }
            }
            return false;

        }
        

    }

}
