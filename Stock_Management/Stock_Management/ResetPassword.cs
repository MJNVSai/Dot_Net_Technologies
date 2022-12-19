using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock_Management
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Submit Button
            Login obj = new Login();
            //obj.textbox1.text
            //label3.Text = Login.usern;

            string newp = textBox1.Text;
            string conp = textBox2.Text;

            if(newp == conp)
            {
                SqlConnection con = Connection.getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Login values(@UserName, @Password)", con);
                cmd.Parameters.AddWithValue("@UserName", textBox3.Text);
                cmd.Parameters.AddWithValue("@Password", newp);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show(" Sucessfully Updated ");
                obj.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(" Check again the Passwords !!! ");
            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear Button
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox3.Focus();
        }
    }
}
