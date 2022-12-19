using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_Insert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SHREEE\OneDrive\Documents\MyDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand com = new SqlCommand();

            con.Open();
            com.Connection = con;

            com.CommandText = "Insert into Login(username,password) values('" + textBox1.Text + "','" + textBox2.Text + "')";
            com.ExecuteNonQuery();

            con.Close();
            MessageBox.Show(" Details Sucessfully inserted into The Login Table In The DataBase ");
            //MessageBox.Show(label1.Text);
        }
    }
}
