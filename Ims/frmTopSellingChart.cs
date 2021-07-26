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
using System.Windows.Forms.DataVisualization.Charting;

namespace Ims
{
    public partial class frmTopSellingChart : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        


        frmRecords rec;
        public frmTopSellingChart(frmRecords frec)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            rec = frec;
        }


        public void loadChartTopSelling()
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            con.Open();
            
            if (rec.cboSort.Text == "SORT BY QTY")
            {
                sda = new SqlDataAdapter("SELECT pdesc,isnull(sum(qty),0) as qty from vwSoldItems WHERE sdate BETWEEN '" + rec.datetimefrom1.Value.ToString("yyyy-MM-dd") + "' AND '" + rec.DateTimeto1.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'SOLD' GROUP BY pdesc ORDER BY qty desc", con);
            }
            else if (rec.cboSort.Text == "SORT BY TOTAL AMOUNT")
            {
                sda = new SqlDataAdapter("SELECT pdesc,isnull(sum(total),0) as total from vwSoldItems WHERE sdate BETWEEN '" + rec.datetimefrom1.Value.ToString("yyyy-MM-dd") + "' AND '" + rec.DateTimeto1.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'SOLD' GROUP BY pdesc ORDER BY total desc", con);
            }
            DataSet ds = new DataSet();
            sda.Fill(ds,"TOPSELLING");
            chart1.DataSource = ds.Tables["TOPSELLING"];
            Series series = chart1.Series[0];
            series.ChartType = SeriesChartType.Doughnut;

            series.Name = "TOP SELLING";
            var chart = chart1;
            chart.Series[0].XValueMember = "pdesc";
            if(rec.cboSort.Text == "SORT BY QTY")
            {
                chart.Series[0].YValueMembers = "qty";
            }
            if (rec.cboSort.Text == "SORT BY TOTAL AMOUNT")
            {
                chart.Series[0].YValueMembers = "total";
            }
            chart.Series[0].IsValueShownAsLabel = true;
            if (rec.cboSort.Text == "SORT BY TOTAL AMOUNT")
            {
                chart.Series[0].LabelFormat = "(#,##0.00)";
            }
            if (rec.cboSort.Text == "SORT BY qty")
            {
                chart.Series[0].LabelFormat = "(#,##0)";
            }
            con.Close();
        }
    }
}
