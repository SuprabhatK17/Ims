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
    public partial class frmStockInModule : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        SqlDataAdapter da;
        DataTable dt;

        public frmStockInModule()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            LoadVendor();
            LoadStockInHistory();


        }


        public void LoadStockIn()
        {
            int i = 0;
            dgvLoadStockInList.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * from vwStockIn WHERE refno LIKE '" + txtRefNo.Text + "' and status like 'Pending'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvLoadStockInList.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr["vendor"].ToString());
                //dgvLoadStockInList.Rows.Add(i, dr["id"].ToString(), dr["refno"].ToString(), dr["vendor"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), dr["sdate"].ToString(), dr["stockInBy"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (dgvLoadStockInList.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to save this records?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvLoadStockInList.Rows.Count; i++)
                        {

                            int C_qty = int.Parse(dgvLoadStockInList.Rows[i].Cells[5].Value.ToString());
                            if (C_qty <= 0)
                            {
                                if (MessageBox.Show("Check the quantaty ! are you sure you want to finalize it", "QTY", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                                return;

                            }
                            else
                            {


                                //update tblProduct QTY
                                con.Open();
                                cmd = new SqlCommand("UPDATE tblProduct SET qty = qty + " + int.Parse(dgvLoadStockInList.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode LIKE'" + dgvLoadStockInList.Rows[i].Cells[3].Value.ToString() + "'", con);
                                cmd.ExecuteNonQuery();
                                con.Close();

                                // update tblStockIn qty
                                con.Open();
                                cmd = new SqlCommand("UPDATE tblStockIn SET qty = qty + " + int.Parse(dgvLoadStockInList.Rows[i].Cells[5].Value.ToString()) + ",status ='Done' WHERE id LIKE '" + dgvLoadStockInList.Rows[i].Cells[1].Value.ToString() + "'", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }                          
                        }
                        Clear();
                        LoadStockIn();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtStockInBy.Clear();
            txtRefNo.Clear();
            cboVendor.Text =" ";

            txtDealer.Clear();
            txtAddress.Clear();
            txtDate.Value = DateTime.Now;
        }

        private void btnProductList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSelectProduct sp = new frmSelectProduct(this);
            sp.LoadProduct();
            sp.Show();
        }

        private void dgvLoadStockInList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvLoadStockInList.Columns[e.ColumnIndex].Name;
            if (colName == "DELETE")
            {
                if (MessageBox.Show("Remove this item?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tblStockIn WHERE id = '" + dgvLoadStockInList.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item has been successfully removed.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }

        public void LoadStockInHistory()
        {
            int i = 0;
            dgvLoadStockInHistory.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * from vwStockIn WHERE cast (sdate as date) between '" + dtFrom.Value.ToString("yyyy-MM-dd") + "' and '" + dtTo.Value.ToString("yyyy-MM-dd") + "' and status like 'DONE'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvLoadStockInHistory.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString(), dr["vendor"].ToString());
                //dgvLoadStockInList.Rows.Add(i, dr["id"].ToString(), dr["refno"].ToString(), dr["vendor"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), DateTime.Parse(dr["sdate"].ToString()).ToShortDateString(), dr["stockInBy"].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadStockInHistory();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            LoadStockInHistory();
        }




        public void LoadVendor()
        {
            cboVendor.Items.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblvendor", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboVendor.Items.Add(dr["vendor"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void cboVendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboVendor_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblVendor WHERE vendor like '" + cboVendor.Text + "'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lblVendorID.Text = dr["id"].ToString();
                txtDealer.Text = dr["contactPerson"].ToString();
                txtAddress.Text = dr["Address"].ToString();


            }
            dr.Close();
            con.Close();
        }

        private void lblGen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random rmd = new Random();
            txtRefNo.Clear();
            txtRefNo.Text += rmd.Next();
            //int i = 0;
            //for (i = 0; i < 10; i++)
            //{
            //    txtRefNo.Text += rmd.Next();
            //}


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvLoadStockInHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
