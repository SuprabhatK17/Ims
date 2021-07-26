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
    public partial class frmCategoryList : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        public frmCategoryList()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            LoadCategory();
        }

        private void btnAddCateogry_Click(object sender, EventArgs e)
        {
            frmAddCategory ac = new frmAddCategory(this);
            ac.btnUpdate.Enabled = false;
            ac.ShowDialog();
        }

        // load data from data base to data gridview
        public void LoadCategory()
        {
            int i = 0;
            dgvCategoryList.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblCategory ORDER BY Category ", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dgvCategoryList.Rows.Add(i, dr["id"].ToString(), dr["Category"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvCategoryList.Columns[e.ColumnIndex].Name;
            if (ColName == "EDIT")
            {
                frmAddCategory ab = new frmAddCategory(this);
                ab.lblID.Text = dgvCategoryList[1, e.RowIndex].Value.ToString();
                ab.txtCategory.Text = dgvCategoryList[2, e.RowIndex].Value.ToString();
                ab.btnAdd.Enabled = false;
                ab.ShowDialog();
            }
            else if (ColName == "DELETE")
            {
                if (MessageBox.Show("Are you sure you want to delete this brand?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tblBrand WHERE id like '" + dgvCategoryList[1, e.RowIndex].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Brand has been successfully deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategory();
                }

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
