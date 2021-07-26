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

namespace Ims
{
    public partial class frmRecords : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmRecords()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
        }

        public void LoadTopSelling()
        {
            int i = 0;
            con.Open();
            dgvTopSelling.Rows.Clear();
            if (cboSort.Text == "SORT BY QTY")
            {
                cmd = new SqlCommand("SELECT top 10 pcode,pdesc,isnull(sum(qty),0) as qty from vwSoldItems WHERE sdate BETWEEN '" + datetimefrom1.Value.ToString("yyyy-MM-dd") + "' AND '" + DateTimeto1.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'SOLD' GROUP BY pcode,pdesc ORDER BY qty desc", con);
            }
            else if (cboSort.Text == "SORT BY TOTAL")
            {
                cmd = new SqlCommand("SELECT top 10 pcode,pdesc,isnull(sum(qty),0) as qty from vwSoldItems WHERE sdate BETWEEN '" + datetimefrom1.Value.ToString("yyyy-MM-dd") + "' AND '" + DateTimeto1.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'SOLD' GROUP BY pcode,pdesc ORDER BY total desc", con);
            }

            cmd = new SqlCommand("SELECT top 10 pcode,pdesc ,isnull(sum(qty),0) as qty from vwSoldItems WHERE sdate BETWEEN '" + datetimefrom1.Value.ToString("yyyy-MM-dd") + "' AND '" + DateTimeto1.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'SOLD' GROUP BY pcode,pdesc ORDER BY qty desc", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvTopSelling.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString());

            }
            dr.Close();
            con.Close();
        }

        // date time from 
        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            
            LoadTopSelling();
        }

        // date time to
        private void DateTimeto1_ValueChanged(object sender, EventArgs e)
        {
            LoadTopSelling();
        }

        // btn print preview
        private void btnprintpre_Click(object sender, EventArgs e)
        {
            frmReportInventoryList ril = new frmReportInventoryList(this);
            if (cboSort.Text == "SORT BY QTY")
            {
                ril.LoadTopSelling("SELECT pcode,pdesc,isnull(sum(qty),0) as qty from vwSoldItems WHERE sdate BETWEEN '" + datetimefrom1.Value.ToString("yyyy-MM-dd") + "' AND '" + DateTimeto1.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'SOLD' GROUP BY pcode,pdesc ORDER BY qty desc", "From : " + datetimefrom1.Value.ToString("yyyy-MM-dd") + " To : " + DateTimeto1.Value.ToString("yyyy-MM-dd"), "TOP SELLING LIST SORT BY  QTY ");
            }
            else if (cboSort.Text == "SORT BY TOTAL")
            {
                ril.LoadTopSelling("SELECT pcode,pdesc,sum(qty) as qty from vwSoldItems WHERE sdate BETWEEN '" + datetimefrom1.Value.ToString("yyyy-MM-dd") + "' AND '" + DateTimeto1.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'SOLD' GROUP BY pcode,pdesc ORDER BY total desc", "From : " + datetimefrom1.Value.ToString("yyyy-MM-dd") + " To : " + DateTimeto1.Value.ToString("yyyy-MM-dd"), "TOP SELLING LIST SORT BY TOTAL AMOUNT ");
            }
            ril.LoadTopSelling("SELECT pcode,pdesc,sum(qty) as qty from vwSoldItems WHERE sdate BETWEEN '" + datetimefrom1.Value.ToString("yyyy-MM-dd") + "' AND '" + DateTimeto1.Value.ToString("yyyy-MM-dd") + "' AND status LIKE 'SOLD' GROUP BY pcode,pdesc ORDER BY qty desc", "From : " + datetimefrom1.Value.ToString("yyyy-MM-dd") + " To : " + DateTimeto1.Value.ToString("yyyy-MM-dd"), "TOP SELLING LIST ");
            ril.ShowDialog();
        }

        // btn Print Charts
        private void metroLink2_Click(object sender, EventArgs e)
        {
            frmTopSellingChart tsc = new frmTopSellingChart(this);
            tsc.loadChartTopSelling();
            tsc.ShowDialog();
        }


        public void LoadSoldItems()
        {
            try
            {
                dgvSoldItems.Rows.Clear();
                int i = 0;
                con.Open();
                cmd = new SqlCommand("SELECT c.pcode,p.pdesc,c.price,sum(c.qty) as qty,sum(c.discount) as discount,sum(c.total) as total from tblCart as c inner join tblproduct as p on c.pcode = p.pcode where status like 'SOLD' and sdate between '" + DateTimeFrom2.Value.ToString("yyyy-MM-dd") + "' AND '" + DateTimeTo2.Value.ToString("yyyy-MM-dd") + "'  group by c.pcode,p.pdesc,c.price", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvSoldItems.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), Double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["qty"].ToString(), dr["discount"].ToString(), dr["total"].ToString());
                }
                dr.Close();
                con.Close();


                String x;
                con.Open();
                cmd = new SqlCommand("SELECT isnull(sum(total),0) from tblCart  where status like 'SOLD' and sdate between '" + DateTimeFrom2.Value.ToString("yyyy-MM-dd") + "' AND '" + DateTimeTo2.Value.ToString("yyyy-MM-dd") + "'", con);
                lblTotal.Text = Double.Parse(cmd.ExecuteScalar().ToString()).ToString("#,##0.00");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printChart2_Click(object sender, EventArgs e)
        {
            frmChart cha = new frmChart();
            cha.lblText.Text = "SOLD ITEMS [" + DateTimeFrom2.Value.ToShortDateString() + " - " + DateTimeTo2.Value.ToShortDateString() + "]";
            cha.LoadSoldItemsChart("SELECT c.pcode,p.pdesc,c.price,sum(c.qty) as qty,sum(c.discount) as discount,sum(c.total) as total from tblCart as c inner join tblproduct as p on c.pcode = p.pcode where status like 'SOLD' and sdate between '" + DateTimeFrom2.Value.ToString("yyyy-MM-dd") + "' AND '" + DateTimeTo2.Value.ToString("yyyy-MM-dd") + "'  group by c.pcode,p.pdesc,c.price order by total desc");
            cha.ShowDialog();
        }

        private void DateTimeFrom2_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        private void DateTimeTo2_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
        }




        private void btnSoldItems_Click(object sender, EventArgs e)
        {
            frmReportInventoryList ril = new frmReportInventoryList(this);

            ril.LoadSoldItems("SELECT c.pcode,p.pdesc,c.price,sum(c.qty) as qty,sum(c.discount) as discount,sum(c.total) as total from tblCart as c inner join tblproduct as p on c.pcode = p.pcode where status like 'SOLD' and sdate between '" + DateTimeFrom2.Value.ToString("yyyy-MM-dd") + "' AND '" + DateTimeTo2.Value.ToString("yyyy-MM-dd") + "'  group by c.pcode,p.pdesc,c.price", "From : " + DateTimeFrom2.Value.ToString("yyyy-MM-dd") + " To : " + DateTimeTo2.Value.ToString("yyyy-MM-dd"), "SOLD ITEMS");
            ril.ShowDialog();
        }

        public void LoadCriticalItems()
        {
            try
            {
                dgvCriticalItems.Rows.Clear();
                int i = 0;
                con.Open();
                //cmd = new SqlCommand("SELECT p.pcode,p.barcode,p.pdesc,b.brand,c.ctaegory,p.price,p.reorder,p.qty FROM tblProduct as p inner join tblbrand as b on b.id = p.bid inner join tblCategory as c on c.id  = p.cid WHERE qty <= reorder", con);
                cmd = new SqlCommand("SELECT * FROM vwCriticalItems", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvCriticalItems.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void LoadInventoryList()
        {
            int i = 0;
            dgvInvList.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT p.pcode,p.barcode,p.pdesc,b.brand,c.category,p.price,p.qty,p.reorder from tblProduct as p inner join tblbrand as b on p.bid = b.id inner join tblcategory as c on p.cid = c.id  ", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvInvList.Rows.Add(i, dr["pcode"].ToString(), dr["barcode"].ToString(), dr["pdesc"].ToString(), dr["brand"].ToString(), dr["category"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["reorder"].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void LoadCancelledOrder()
        {
            int i = 0;
            con.Open();
            //cmd = new SqlCommand("SELECT c.transno,c.pcode,p.pdesc,c.price ,sum(c.qty) as qty ,sum(c.total) as total,c.sdate,c.voidby,c.cancelledby,c.reason,c.action from tblCancel as c inner join tblProduct as p on c.pcode= p.pcode", con);
            cmd = new SqlCommand("SELECT * FROM vwCancelledOrder WHERE sdate between '" + DateTimeFrom5.Value.ToString("yyyy-MM-dd") + "' and '" + DateTimeTo5.Value.ToString("yyyy-MM-dd") + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCancelOrd.Rows.Add(i, dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["total"].ToString(), dr["sdate"].ToString(), dr["voidby"].ToString(), dr["cancelledby"].ToString(), dr["reason"].ToString(), dr["action"].ToString());

            }
            dr.Close();
            con.Close();
        }


        public void LoadStockInHistory()
        {
            int i = 0;
            dgvStockInHistory.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * from vwStockIn WHERE cast (sdate as date) between '" + DateTimeFrom6.Value.ToString("yyyy-MM-dd") + "' and '" + DateTimeTo6.Value.ToString("yyyy-MM-dd") + "' and status like 'DONE'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                //dgvStockInHistory.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString());
                dgvStockInHistory.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), DateTime.Parse(dr["sdate"].ToString()).ToShortDateString(), dr["stockInBy"].ToString());
            }
            dr.Close();
            con.Close();
        }


        // btn stock in history print pre 
        private void metroLink4_Click(object sender, EventArgs e)
        {
            frmReportInventoryList ril = new frmReportInventoryList(this);
            string param = "Date Covered " + DateTimeFrom6.Value.ToString("yyyy - MM - dd") + "' - '" + DateTimeTo6.Value.ToString("yyyy - MM - dd");
            string header = "STOCK IN-HISTORY";
            ril.LoadReportStockInList("SELECT * from vwStockIn WHERE cast (sdate as date) between '" + DateTimeFrom6.Value.ToString("yyyy-MM-dd") + "' and '" + DateTimeTo6.Value.ToString("yyyy-MM-dd") + "' and status like 'DONE'",param,header);
            ril.ShowDialog();
        }


        // Cancelled Order Preview
        private void metroLink6_Click(object sender, EventArgs e)
        {
            frmReportInventoryList ril = new frmReportInventoryList(this);
            string param = "Date Covered " + DateTimeFrom6.Value.ToString("yyyy - MM - dd") + "' - '" + DateTimeTo6.Value.ToString("yyyy - MM - dd");
            string header = "CANCELLED ORDER";
            ril.LoadReportStockInList("SELECT * FROM vwCancelledOrder WHERE sdate between '" + DateTimeFrom5.Value.ToString("yyyy-MM-dd") + "' and '" + DateTimeTo5.Value.ToString("yyyy-MM-dd") + "'",param,header);
            ril.ShowDialog();
        }

        private void DateTimeTo5_ValueChanged(object sender, EventArgs e)
        {
            LoadCancelledOrder();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DateTimeFrom3_ValueChanged(object sender, EventArgs e)
        {
            LoadCriticalItems();
        }

        private void DateTimeTo3_ValueChanged(object sender, EventArgs e)
        {
            LoadCriticalItems();
        }

        private void DateTimeFrom4_ValueChanged(object sender, EventArgs e)
        {
            LoadInventoryList();
        }

        private void DateTimeTo4_ValueChanged(object sender, EventArgs e)
        {
            LoadInventoryList();
        }

        private void DateTimeFrom5_ValueChanged(object sender, EventArgs e)
        {
            LoadCancelledOrder();
        }

        private void DateTimeFrom6_ValueChanged(object sender, EventArgs e)
        {
            LoadStockInHistory();
        }

        private void DateTimeTo6_ValueChanged(object sender, EventArgs e)
        {
            LoadStockInHistory();
        }

        private void btnPreCritical_Click(object sender, EventArgs e)
        {

        }

        private void btnInvPre_Click(object sender, EventArgs e)
        {
            frmReportInventoryList ril = new frmReportInventoryList(this);
            //string param = "Date Covered " + DateTimeFrom6.Value.ToString("yyyy - MM - dd") + "' - '" + DateTimeTo6.Value.ToString("yyyy - MM - dd");
            string header = "INVENTORY LIST";
            ril.LoadInventoryList(header);
            //ril.LoadReportStockInList("SELECT p.pcode,p.barcode,p.pdesc,b.brand,c.category,p.price,p.qty,p.reorder from tblProduct as p inner join tblbrand as b on p.bid = b.id inner join tblcategory as c on p.cid = c.id WHERE sdate between '" + DateTimeFrom5.Value.ToString("yyyy-MM-dd") + "' and '" + DateTimeTo5.Value.ToString("yyyy-MM-dd") + "'", param, header);
            ril.ShowDialog();
        }
    }
}
