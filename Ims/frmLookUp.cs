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
    public partial class frmLookUp : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmCashier cash;

        public frmLookUp(frmCashier ca)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            cash = ca;
            this.KeyPreview = true;
        }


        public void LoadSelectStockList()
        {
            int i = 0;
            dgvLoadStockInList.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT p.pcode,p.barcode,b.brand,c.category,p.pdesc,p.price,p.qty from tblProduct as p inner join tblBrand as b on b.id = p.bid inner join tblCategory as c on c.id = p.cid WHERE p.pdesc like '%" + txtSearch.Text + "%' ORDER BY p.pdesc", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvLoadStockInList.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());



            }
            dr.Close();
            con.Close();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSelectStockList();
        }

        private void dgvLoadStockInList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvLoadStockInList.Columns[e.ColumnIndex].Name;
            if (colName == "SELECT")
            {
                frmQty qty = new frmQty(cash);
                qty.ProductDetails(dgvLoadStockInList.Rows[e.RowIndex].Cells[1].Value.ToString(), double.Parse(dgvLoadStockInList.Rows[e.RowIndex].Cells[6].Value.ToString()), cash.lblTransaction.Text, int.Parse(dgvLoadStockInList.Rows[e.RowIndex].Cells[7].Value.ToString()));

                qty.ShowDialog();

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLookUp_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
