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
using Tulpep.NotificationWindow;

namespace Ims
{
    public partial class frmMainDashboard : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string _pass,_user;

        public frmMainDashboard()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            
            NotifyCriticalItems();
            
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            frmBrandList bl = new frmBrandList();
            bl.TopLevel = false;
            mainLoadPanel.Controls.Add(bl);
            bl.BringToFront();
            bl.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategoryList cl = new frmCategoryList();
            cl.TopLevel = false;
            mainLoadPanel.Controls.Add(cl);
            cl.BringToFront();
            cl.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProductList pl = new frmProductList();
            pl.TopLevel = false;
            mainLoadPanel.Controls.Add(pl);
            pl.BringToFront();
            pl.LoadProduct();
            pl.Show();
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            frmVednorList ven = new frmVednorList();
            ven.TopLevel = false;
            ven.LoadVendor();
            mainLoadPanel.Controls.Add(ven);
            ven.BringToFront();
            ven.Show();
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            frmStockInModule sim = new frmStockInModule();
            sim.TopLevel = false;
            mainLoadPanel.Controls.Add(sim);
            sim.BringToFront();
            //sim.LoadProduct();
            sim.Show();
        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            frmStockAdjustment sa = new frmStockAdjustment(this);
            //sa.TopLevel = false;
            //mainLoadPanel.Controls.Add(sa);
            //sa.BringToFront();
            sa.LoadProduct();
            sa.txtUser.Text = lblUserName.Text;
            sa.ReferenceNo();
            sa.ShowDialog();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            frmRecords re = new frmRecords();
            re.TopLevel = false;
            mainLoadPanel.Controls.Add(re);
            re.BringToFront();
            re.Show();
            re.LoadTopSelling();
            re.LoadCriticalItems();
            re.LoadInventoryList();
            re.LoadCancelledOrder();
            re.LoadStockInHistory();
            
            
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            frmSoldItems si = new frmSoldItems();
            si.ShowDialog();
        }

        private void btnUserSetting_Click(object sender, EventArgs e)
        {
            frmUserAccount ua = new frmUserAccount(this);
            ua.TopLevel = false;
            mainLoadPanel.Controls.Add(ua);
            ua.txtUserName2.Text = _user;
            ua.BringToFront();
            ua.Show();
        }

        private void btnStoreSetting_Click(object sender, EventArgs e)
        {
            frmStoreSetting ss = new frmStoreSetting();
            ss.loadRecords();
            ss.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("LOGOUT APP:ICATION?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin lo = new frmLogin();
                lo.ShowDialog();
            }
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            DashBoard();
        }

        public void DashBoard()
        {
            frmDashboard da = new frmDashboard();
            da.TopLevel = false;
            mainLoadPanel.Controls.Add(da);
            da.lblDailySales.Text = dbcon.DailySales().ToString("#,##0.00");
            da.lblProductLine.Text = dbcon.ProductLine().ToString("#,##0");
            da.lblStockOnHand.Text = dbcon.ProductLine().ToString("#,##0");
            da.lblriticalItems.Text = dbcon.ProductLine().ToString("#,##0");
            da.BringToFront();
            da.Show();
        }


        public void NotifyCriticalItems()
        {
            string critical = "";
            con.Open();
            cmd = new SqlCommand("SELECT count(*) FROM vwCriticalItems", con);
            string count = cmd.ExecuteScalar().ToString();
            con.Close();


            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM vwCriticalItems",con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                critical += "(" + i + ")" + dr["pdesc"].ToString() + Environment.NewLine;

            }
            dr.Close();
            con.Close();


            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.error;
            popup.TitleText = count  + " CRITICAL ITEM(S)";
            popup.ContentText = critical;
            popup.Popup();

        }


        
    }
}
