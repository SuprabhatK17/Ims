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
    public partial class frmAddCategory : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        frmCategoryList cl;

        public frmAddCategory(frmCategoryList c)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            cl = c;
        }

        // clear function
        private void Clear()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            txtCategory.Clear();
            txtCategory.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are toy sure you want to save this Category?", "CATEGORY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO tblCategory (Category) VALUES (@Category) ", con);
                    cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(txtCategory.Text + " has been suceesfully saved");
                    Clear();
                    cl.LoadCategory();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are toy sure you want to update this Category?", "CATEGORY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE tblCategory SET Category = @category WHERE id like '" + lblID.Text + "'", con);
                    cmd.Parameters.AddWithValue("@category", txtCategory.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(txtCategory.Text + " has been suceesfully Updated");
                    Clear();
                    cl.LoadCategory();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
