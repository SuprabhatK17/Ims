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
    public partial class frmChart : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmChart()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
        }


        public void LoadSoldItemsChart(string sql)
        {
            SqlDataAdapter da;
            con.Open();
            da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "SOLD");
            chart1.DataSource = ds.Tables["SOLD"];
            Series series = chart1.Series[0];
            series.ChartType = SeriesChartType.Column;

            series.Name = "SOLD ITEMS";
            chart1.Series[0].XValueMember = "pdesc";
            //chart1.Series[0]["PieLabelStyle"] = "Outside";
            //chart1.Series[0].BorderColor = System.Drawing.Color.Gray;
            chart1.Series[0].YValueMembers = "total";
            chart1.Series[0].LabelFormat = "(#,##0.00)";
            chart1.Series[0].IsValueShownAsLabel = true;
            con.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
