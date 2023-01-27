using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp4
{
   public class DB
    {
        
       
        public static SqlConnection openConection(string datasource, string database)
        {
           // Data Source = DESKTOP - 6MMCHL4\ROBERT; Initial Catalog = practic; Integrated Security = True
                    string connString = @"Data Source=" + datasource + ";Initial Catalog="
                                + database + ";Integrated Security = True";
                    SqlConnection conn = new SqlConnection(connString);
                    return conn;
        }
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-1V40V70\SQLEXPRESS";

            string database = "practic";
           

            return openConection(datasource, database);
        }
        /*public void closeConection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConection()
        {
            return connection;
        }*/
    
}
}

