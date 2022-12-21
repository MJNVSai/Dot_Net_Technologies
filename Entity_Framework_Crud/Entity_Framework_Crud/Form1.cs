using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework_Crud
{
    public partial class Form1 : Form
    {
        // customer is table created in database
        Customer model = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear Button
            Clear();
        }

        void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            button1.Text = "Save";
            button2.Enabled = false;

            model.CustomerID = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = textBox1;
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save Button
            model.FirstName = textBox1.Text.Trim();
            model.LastName = textBox2.Text.Trim();
            model.City = textBox3.Text.Trim();
            model.Address = textBox4.Text.Trim();

            using (EntityFrameworkEntities db = new EntityFrameworkEntities())
            {
                // here EntityFrameworkEntites is an database object
                if(model.CustomerID == 0)
                {
                    db.Customers.Add(model);
                    //db.SaveChanges();
                }
                else
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            Clear();
            LoadData();
            MessageBox.Show("Inserted a Record Sucessfully");
        }

        void LoadData()
        {
            // displaying the data in datagrid view.

            dataGridView1.AutoGenerateColumns = false;
            using(EntityFrameworkEntities db = new EntityFrameworkEntities())
            {
                dataGridView1.DataSource = db.Customers.ToList<Customer>();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                model.CustomerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgCustomerID"].Value);

                using(EntityFrameworkEntities db = new EntityFrameworkEntities())
                {
                    model = db.Customers.Where(x => x.CustomerID == model.CustomerID).FirstOrDefault();

                    textBox1.Text = model.FirstName;
                    textBox2.Text = model.LastName;
                    textBox3.Text = model.City;
                    textBox4.Text = model.Address;
                }
                button1.Text = "Update";
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Delete Button
            if(MessageBox.Show("Are You Sure To Delete this record", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(EntityFrameworkEntities db = new EntityFrameworkEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Customers.Attach(model);
                        db.Customers.Remove(model);
                        db.SaveChanges();
                        LoadData();
                        Clear();
                        MessageBox.Show("Deleted Sucessfully ");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
