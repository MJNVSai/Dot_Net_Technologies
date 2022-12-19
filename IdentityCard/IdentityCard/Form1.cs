using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentityCard
{
    public partial class Form1 : Form
    {
        public static string name;
        public static string roll;
        public static string dept;
        public static string vali;
        public static string picbox2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear Button
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            pictureBox1.ImageLocation = null;
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Submit Button
            //this.Close();
            name = textBox1.Text; 
            roll = textBox2.Text;
            dept = "DEPARTMENT OF " + textBox3.Text;
            vali = "VALIDITY : " + textBox4.Text;
            picbox2 = pictureBox1.ImageLocation;
            this.Hide();
            vrsecindentity vi = new vrsecindentity();
            vi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Upload Photo Button
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
