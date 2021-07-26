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
    public partial class frmAddBrand : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmBrandList bl;
        public frmAddBrand(frmBrandList b)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            bl = b;
        }

        // clear function
        private void Clear()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            txtBrand.Clear();
            txtBrand.Focus();
        }

        // btn save click event 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are toy sure you want to save this brand?", "BRAND", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO tblBrand (Brand) VALUES (@brand) ", con);
                    cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(txtBrand.Text + " has been suceesfully saved");
                    Clear();
                    bl.LoadBrand();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //btn update click event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are toy sure you want to update this brand?", "BRAND", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE tblBrand SET Brand = @brand WHERE id like '" + lblID.Text + "'", con);
                    cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(txtBrand.Text + " has been suceesfully Updated");
                    Clear();
                    bl.LoadBrand();
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
