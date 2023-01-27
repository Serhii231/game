using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4.Class
{
    abstract class Kreativ
    {

        public abstract int enter();

        public abstract int print(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5, PictureBox pictureBox1, String s1,int q);
        abstract public void cheks(ComboBox comboBox);
    }
}
