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
    public partial class frmSelectProduct : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmStockInModule sim;

        public frmSelectProduct(frmStockInModule stim)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            sim = stim;
        }

        // upload data in data grid view
        public void LoadProduct()
        {
            int i = 0;
            dgvProductList.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT pcode,pdesc,qty,price FROM tblProduct WHERE pdesc LIKE '%" + txtSearch.Text + "%' ORDER BY pdesc  ", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProductList.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProductList.Columns[e.ColumnIndex].Name;
            if (colName == "SELECT")
            {
                if (sim.txtRefNo.Text == string.Empty)
                {
                    MessageBox.Show("Please enter refernce number", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sim.txtRefNo.Focus();
                    return;
                }
                if (sim.txtStockInBy.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Stock In By", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sim.txtStockInBy.Focus();
                    return;
                }
                //if (sim.txtDate.Text == string.Empty)
                //{
                //    MessageBox.Show("Please enter date In", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    sim.txtDate.Focus();
                //    return;
                //}
                if (MessageBox.Show("Add this Item?", "ADD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO tblStockin(refno,pcode,sdate,stockinby,vendorid) VALUES (@refno,@pcode,@sdate,@stockinby,@vendorid)", con);// SELECT * FROM tblProduct WHERE pcode LIKE '" + + "'", con);
                    cmd.Parameters.AddWithValue("@refno", sim.txtRefNo.Text);
                    cmd.Parameters.AddWithValue("@pcode", dgvProductList.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@sdate", sim.txtDate.Value);
                    cmd.Parameters.AddWithValue("@stockinby", sim.txtStockInBy.Text);
                    cmd.Parameters.AddWithValue("@vendorid", sim.lblVendorID.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully added!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sim.LoadStockIn();
                }

            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmSelectProduct_Load(object sender, EventArgs e)
        {

        }

        private void dgvProductList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProductList.Columns[e.ColumnIndex].Name;

            if (colName == "SELECT")
            {
                if (sim.txtRefNo.Text == string.Empty)
                {
                    MessageBox.Show("Please enter refernce number", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sim.txtRefNo.Focus();
                    return;
                }
                if (sim.txtStockInBy.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Stock In By", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sim.txtStockInBy.Focus();
                    return;
                }
                //if (sim.txtDate.Text == string.Empty)
                //{
                //    MessageBox.Show("Please enter date In", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    sim.txtDate.Focus();
                //    return;
                //}

                
                if (MessageBox.Show("Add this Item?", "ADD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO tblStockin(refno,pcode,sdate,stockinby,vendorid) VALUES (@refno,@pcode,@sdate,@stockinby,@vendorid)", con);// SELECT * FROM tblProduct WHERE pcode LIKE '" + + "'", con);
                    cmd.Parameters.AddWithValue("@refno", sim.txtRefNo.Text);
                    cmd.Parameters.AddWithValue("@pcode", dgvProductList.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@sdate", sim.txtDate.Value);
                    cmd.Parameters.AddWithValue("@stockinby", sim.txtStockInBy.Text);
                    cmd.Parameters.AddWithValue("@vendorid", sim.lblVendorID.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully added!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sim.LoadStockIn();
                }

            }
        }
    }
}
