using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class Form2 : Form
    {
        public string name, roll, mobile, mail, Q, HQ;

        private void Form2_Load(object sender, EventArgs e)
        {
            T1.Text = name;
            T2.Text = roll;
            T3.Text = mobile;
            T4.Text = mail;
            T5.Text = Q;
            T6.Text = HQ;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
