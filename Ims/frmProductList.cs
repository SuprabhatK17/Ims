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
    public partial class frmProductList : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmProductList()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct ap = new frmAddProduct(this);
            ap.btnUpdate.Enabled = false;
            ap.LoadBrand();
            ap.LoadCategory();
            ap.ShowDialog();
        }

        // load data from data base to data gridview
        public void LoadProduct()
        {
            int i = 0;
            dgvProductList.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT p.pcode,p.barcode,b.brand,c.category,p.pdesc,p.price,p.reorder from tblProduct as p inner join tblbrand as b on b.id = p.bid inner join tblCategory as c on c.id=p.cid WHERE p.pdesc LIKE '" + txtSearch.Text + "%'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                //dgvProductList.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                dgvProductList.Rows.Add(i, dr["pcode"].ToString(), dr["barcode"].ToString(), dr["brand"].ToString(), dr["category"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["reorder"].ToString());
            }

            dr.Close();
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProductList.Columns[e.ColumnIndex].Name;
            if (colName == "EDIT")
            {
                frmAddProduct p = new frmAddProduct(this);
                p.txtPCode.Enabled = false;
                p.btnAdd.Enabled = false;
                p.txtPCode.Text = dgvProductList.Rows[e.RowIndex].Cells[1].Value.ToString();
                p.txtBarcode.Text = dgvProductList.Rows[e.RowIndex].Cells[2].Value.ToString();
                p.cboBrand.Text = dgvProductList.Rows[e.RowIndex].Cells[3].Value.ToString();
                p.cboCategory.Text = dgvProductList.Rows[e.RowIndex].Cells[4].Value.ToString();
                p.txtDescription.Text = dgvProductList.Rows[e.RowIndex].Cells[5].Value.ToString();
                p.txtPrice.Text = dgvProductList.Rows[e.RowIndex].Cells[6].Value.ToString();
                p.txtReorder.Text = dgvProductList.Rows[e.RowIndex].Cells[7].Value.ToString();
                //p.txtReorder.Text = dgvProductList[7, e.RowIndex].Value.ToString();
                p.ShowDialog();

            }
            else if (colName == "DELETE")
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tblProduct WHERE pcode like '" + dgvProductList[1, e.RowIndex].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been successfully deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProduct();
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
