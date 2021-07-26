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
    public partial class frmSoldItems : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public string si_user;
        

        public frmSoldItems()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            
            LoadSoldItems();
            LoadCashier();
        }

        private void frmSoldItems_Load(object sender, EventArgs e)
        {

        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        public void LoadSoldItems()
        {

            int i = 0;
            double total = 0;
            dgvSoldItems.Rows.Clear();
            con.Open();
            if(cboCashier.Text == "ALL CASHIER")
            {
                cmd = new SqlCommand(" SELECT c.id,c.transno,c.pcode,p.pdesc,c.price,c.qty,c.discount,c.total from tblCart as c inner join tblproduct as p on c.pcode = p.pcode WHERE STATUS LIKE 'SOLD' and sdate between '" + dateTimeFrom.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimeTo.Value.ToString("yyyy-MM-dd") +  "'", con);
            }
            else
            {
                cmd = new SqlCommand(" SELECT c.id,c.transno,c.pcode,p.pdesc,c.price,c.qty,c.discount,c.total from tblCart as c inner join tblproduct as p on c.pcode = p.pcode WHERE STATUS LIKE 'SOLD' and sdate between '" + dateTimeFrom.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimeTo.Value.ToString("yyyy-MM-dd") + "'and cashier LIKE '" + cboCashier.Text + "'", con);
            }
            
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                total += double.Parse(dr["total"].ToString());
                dgvSoldItems.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["discount"].ToString(), dr["total"].ToString());
            }
            dr.Close();
            con.Close();
            lblTotal.Text = total.ToString("#,##0.00");
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            frmSoldItemsReport sir = new frmSoldItemsReport(this);
            sir.LoadSoldReport();
            sir.ShowDialog();
        }

        private void cboCashier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        public void LoadCashier()
        {
            cboCashier.Items.Clear();
            cboCashier.Items.Add("ALL CASHIER");
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblUser WHERE role LIKE 'CASHIER'",con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboCashier.Items.Add(dr["username"].ToString());
            }

            dr.Close();
            con.Close();
        }

        private void cboCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        private void dgvSoldItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSoldItems.Columns[e.ColumnIndex].Name;
            if(colName == "CANCEL")
            {
                frmCancelDetails cd = new frmCancelDetails(this);
                cd.txtId.Text = dgvSoldItems.Rows[e.RowIndex].Cells[1].Value.ToString();
                cd.txtTransactionNo.Text = dgvSoldItems.Rows[e.RowIndex].Cells[2].Value.ToString();
                cd.txtPCODE.Text = dgvSoldItems.Rows[e.RowIndex].Cells[3].Value.ToString();
                cd.txtDesc.Text = dgvSoldItems.Rows[e.RowIndex].Cells[4].Value.ToString();
                cd.txtPrice.Text = dgvSoldItems.Rows[e.RowIndex].Cells[5].Value.ToString();
                cd.txtQty.Text = dgvSoldItems.Rows[e.RowIndex].Cells[6].Value.ToString();
                cd.txtDisc.Text = dgvSoldItems.Rows[e.RowIndex].Cells[7].Value.ToString();
                cd.txtTotal.Text = dgvSoldItems.Rows[e.RowIndex].Cells[8].Value.ToString();
                cd.txtCanceledBy.Text = si_user;

                cd.ShowDialog();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
