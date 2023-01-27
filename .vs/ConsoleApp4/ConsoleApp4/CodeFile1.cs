using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
public class code
{
    public void regtext1(TextBox textBox, String s)
    {
        if (textBox.Text == s)
        {
            textBox.ForeColor = Color.Black;
            textBox.Text = "";
        }
    }
    public void regtext2(TextBox textBox, String s)
    {
        if (textBox.Text == "")
        {
            textBox.Text = s;
            textBox.ForeColor = Color.Gray;
        }
    }
}