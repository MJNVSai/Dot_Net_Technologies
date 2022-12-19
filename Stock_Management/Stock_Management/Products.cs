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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stock_Management
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add button
            if(Validation())
            {
                SqlConnection con = Connection.getConnection();
                con.Open();

                bool status = false;
                if (comboBox1.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                var sqlquery = "";
                if (IfProductExists(con, textBox1.Text))
                {
                    sqlquery = "update Products set ProductName = @ProductName, ProductStatus = @ProductStatus where ProductCode = @ProductCode";
                }
                else
                {
                    sqlquery = "insert into Products values(@ProductCode, @ProductName, @ProductStatus)";
                }

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.AddWithValue("@ProductCode", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@ProductName", textBox2.Text);
                cmd.Parameters.AddWithValue("@ProductStatus", status);
                cmd.ExecuteNonQuery();

                con.Close();

                LoadData();

                ResetRecords(); //..
            }
            

        }

        private bool IfProductExists(SqlConnection con, string productCode)
        {

            SqlDataAdapter sda = new SqlDataAdapter("select 1 from Products where ProductCode = '"+ productCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadData()
        {
            SqlConnection con = Connection.getConnection();
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from Products", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactive";
                }

                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                //dataGridView1.Rows[n].Cells[0].Value = item["ProductStatus"].ToString();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button1.Text = "Update"; //..
            
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //comboBox1.SelectedText = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            if(dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Delete button

            DialogResult dialogResult = MessageBox.Show(" Are You Sure Want To Delete ", "Message", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                if (Validation())
                {
                    SqlConnection con = Connection.getConnection();
                    con.Open();

                    var sqlquery = "";
                    if (IfProductExists(con, textBox1.Text))
                    {
                        sqlquery = "delete from Products where ProductCode = @ProductCode";

                        SqlCommand cmd = new SqlCommand(sqlquery, con);
                        cmd.Parameters.AddWithValue("@ProductCode", int.Parse(textBox1.Text));
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Record Doesn't Exists in the table ..... !");
                    }

                    con.Close();

                    LoadData();
                    ResetRecords();
                }
            }

            
            
        }

        private void ResetRecords()
        {
            //..
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;

            button1.Text = "Add";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ..
            ResetRecords();
        }

        private bool Validation()
        {
            // ..
            bool result = false;
            
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, " Product Code required ");
            }
            else if(string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, " Product Name Required ");
            }
            else if(comboBox1.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboBox1, " Select the status ");
            }
            else
            {
                return true;
            }

            return result;
        }
    }
}
