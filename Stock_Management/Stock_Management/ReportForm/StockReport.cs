using CrystalDecisions.CrystalReports.Engine;
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

namespace Stock_Management.ReportForm
{
    public partial class StockReport : Form
    {
        ReportDocument crystal = new ReportDocument();
        public StockReport()
        {
            InitializeComponent();
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            // Form load Section
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show Report 
            crystal.Load(@"E:\venkat sai\Dot_Net\Csharp\Stock_Management\Stock_Management\Reports\Stock.rpt");
            SqlConnection con = Connection.getConnection();
            con.Open();

            DataSet dst = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Stock where Cast( TransDate as Date) between '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' and '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "'", con);

            sda.Fill(dst, "Stock");
            crystal.SetDataSource(dst);

            crystal.SetParameterValue("@FromDate", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            crystal.SetParameterValue("@ToDate", dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            crystalReportViewer1.ReportSource = crystal;
        }
    }
}
