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
    public partial class frmBrandList : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        public frmBrandList()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            LoadBrand();
        }

        

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            frmAddBrand ab = new frmAddBrand(this);
            ab.btnUpdate.Enabled = false;
            ab.ShowDialog();
        }

        // load data from data base to data gridview
        public void LoadBrand()
        {
            int i = 0;
            dgvBrandList.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblBrand ORDER BY Brand ", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dgvBrandList.Rows.Add(i, dr["id"].ToString(), dr["Brand"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvBrandList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvBrandList.Columns[e.ColumnIndex].Name;
            if (ColName == "EDIT")
            {
                frmAddBrand ab = new frmAddBrand(this);
                ab.lblID.Text = dgvBrandList[1, e.RowIndex].Value.ToString();
                ab.txtBrand.Text = dgvBrandList[2, e.RowIndex].Value.ToString();
                ab.btnAdd.Enabled = false;
                ab.ShowDialog();
            }
            else if (ColName == "DELETE")
            {
                if (MessageBox.Show("Are you sure you want to delete this brand?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tblBrand WHERE id like '" + dgvBrandList[1, e.RowIndex].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Brand has been successfully deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBrand();
                }

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvBrandList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvBrandList.Columns[e.ColumnIndex].Name;
            if (ColName == "EDIT")
            {
                frmAddBrand ab = new frmAddBrand(this);
                ab.lblID.Text = dgvBrandList[1, e.RowIndex].Value.ToString();
                ab.txtBrand.Text = dgvBrandList[2, e.RowIndex].Value.ToString();
                ab.btnAdd.Enabled = false;
                ab.ShowDialog();
            }
            else if (ColName == "DELETE")
            {
                if (MessageBox.Show("Are you sure you want to delete this brand?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tblBrand WHERE id like '" + dgvBrandList[1, e.RowIndex].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Brand has been successfully deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBrand();
                }

            }
        }
    }
}
