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
    public partial class frmDashboard : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();


        public frmDashboard()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            LoadChart();
        }

        private void frmDashboard_Resize(object sender, EventArgs e)
        {
            panel2.Left = (this.Width - panel2.Width) / 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadChart()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" SELECT Year(sdate) as year,isnull(sum(total),0.0) as total from tblCart WHERE status like 'SOLD' group by year(sdate) ", con);
            DataSet ds = new DataSet();

            sda.Fill(ds, "Sales");
            chart1.DataSource = ds.Tables["Sales"];

            Series series1 = chart1.Series["Series1"];
            series1.ChartType = SeriesChartType.Doughnut;

            series1.Name = "SALES";

            var chart = chart1;
            chart.Series[series1.Name].XValueMember = "year";
            chart.Series[series1.Name].YValueMembers = "total";
            chart.Series[0].IsValueShownAsLabel = true;




            con.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
