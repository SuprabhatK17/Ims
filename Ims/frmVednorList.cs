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
    public partial class frmVednorList : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmVednorList()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddVendor ven = new frmAddVendor(this);
            ven.btnAdd.Enabled = true;
            ven.btnUpdate.Enabled = false;
            ven.ShowDialog();
        }

        // load data from data base to data gridview
        public void LoadVendor()
        {
            int i = 0;
            dgvVendorlist.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblvendor", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvVendorlist.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }

            dr.Close();
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadVendor();
        }

        private void dgvVendorlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvVendorlist.Columns[e.ColumnIndex].Name;
            if (colName == "EDIT")
            {
                frmAddVendor ven = new frmAddVendor(this);
                ven.btnAdd.Enabled = false;
                ven.lblID.Text = dgvVendorlist[1, e.RowIndex].Value.ToString();
                ven.txtVendor.Text = dgvVendorlist.Rows[e.RowIndex].Cells[2].Value.ToString();
                ven.txtAddress.Text = dgvVendorlist.Rows[e.RowIndex].Cells[3].Value.ToString();
                ven.txtDealer.Text = dgvVendorlist.Rows[e.RowIndex].Cells[4].Value.ToString();
                ven.txtCoNo.Text = dgvVendorlist.Rows[e.RowIndex].Cells[5].Value.ToString();
                ven.txtEmail.Text = dgvVendorlist.Rows[e.RowIndex].Cells[6].Value.ToString();
                ven.txtFax.Text = dgvVendorlist.Rows[e.RowIndex].Cells[7].Value.ToString();
                // p.txtReorder.Text = dgvVendorlist.Rows[e.RowIndex].Cells[7].Value.ToString();
                ven.btnAdd.Enabled = false;
                ven.btnUpdate.Enabled = true;
                ven.ShowDialog();

            }
            else if (colName == "DELETE")
            {
                if (MessageBox.Show("Are you sure you want to delete this vendor info?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tblVendor WHERE id like '" + dgvVendorlist[1, e.RowIndex].Value.ToString() + "'", con);
                    //cmd = new SqlCommand("DELETE FROM tblVendor WHERE id like '" + dgvVendorlist.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVendor();
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
