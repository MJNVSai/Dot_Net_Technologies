using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Stock_Management.Datas;

namespace Stock_Management.ReportForm
{
    public partial class ProductsReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        public ProductsReport()
        {
            InitializeComponent();
        }

        private void ProductsReport_Load(object sender, EventArgs e)
        {
            // Load Form 

            cryrpt.Load(@"E:\venkat sai\Dot_Net\Csharp\Stock_Management\Stock_Management\Reports\Product.rpt");
            SqlConnection con = Connection.getConnection();
            con.Open();

            DataSet dst = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Products", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;

        }
    }
}
