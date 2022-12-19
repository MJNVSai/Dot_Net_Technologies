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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the Form....
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string Title = "Saved Credentials";
            //string greetings = "Greetings";
            //string print = "Sucessfully Saved Your Credentials \n\n" + "Student Name : " + T1.Text + "\n\n" + "Roll Number : " + T2.Text + "\n\n" + "Mobile number : " + T3.Text + "\n\n" + "Mail Id : " + T4.Text + "\n\n";
            string chec, rad, n1, r1, m1, mai;
            //long m1;

            n1 = T1.Text;
            r1 = T2.Text;
            //m1 = long.Parse(T3.Text);
            m1 = T3.Text;
            mai = T4.Text;

            if(C1.Checked == true)
            {
                chec = C1.Text;
                //string cs1 = "Choosed Qualification : \n\n" + c1;
                //string mainstring = print + "\n\n" + cs1;
                //MessageBox.Show(mainstring, Title);
            }
            else if(C2.Checked == true)
            {
                chec = C2.Text;
                //string cs2 = "Choosed Qualification : \n\n" + c2;
                //string mainstring = print + "\n\n" + cs2;
                //MessageBox.Show(mainstring, Title);
            }
            else if((C1.Checked == true) && (C2.Checked == true))
            {
                chec = "B.Tech and Intermediate";
            }
            else if((C1.Checked == true) && (C3.Checked == true))
            {
                chec = "B.Tech and S.S.C";
            }
            else if((C2.Checked == true) && (C3.Checked == true))
            {
                chec = "Intermediate and S.S.C";
            }
            else
            {
                chec = C3.Text;
                //string cs3 = "Choosed Qualification : \n\n" + c3;
                //string mainstring = print + "\n\n" + cs3;
                //MessageBox.Show(mainstring, Title);
            }

            if(R1.Checked == true)
            {
                rad = R1.Text;
                //string rs1 = "Choosed Specialization : \n\n" + r1;
                //string mainstring = print + "\n\n" + rs1;
                //MessageBox.Show(mainstring, Title);
            }
            else if(R2.Checked == true)
            {
                rad = R2.Text;
                //string rs2 = "Choosed Specialization : \n\n" + r2;
                //string mainstring = print + "\n\n" + rs2;
                //MessageBox.Show(mainstring, Title);
            }
            else
            {
                rad = R3.Text;
                //string rs3 = "Choosed Specialization : \n\n" + r3;
                //string mainstring = print + "\n\n" + rs3;
                //MessageBox.Show(mainstring, Title);
            }

            //MessageBox.Show(print, Title);
            //MessageBox.Show("Thank You ..... Bye \n\n", greetings);

            // Creating the form object for Form2.cs file;
            Form2 f2 = new Form2();

            f2.name = n1;
            f2.roll = r1;
            f2.mobile = m1;
            f2.mail = mai;
            f2.Q = chec;
            f2.HQ = rad;

            f2.Show(); // Displaying the Form;
        }
    }
}
