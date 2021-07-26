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
    public partial class frmAddProduct : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmProductList pl;

        public frmAddProduct(frmProductList prl)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            pl = prl;
        }

        //populate data from database to combo box
        public void LoadBrand()
        {
            cboBrand.Items.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT brand from tblBrand ", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboBrand.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();

        }

        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT category from tblCategory ", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboCategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string bid = ""; string cid = "";
                    con.Open();
                    cmd = new SqlCommand("SELECT id from tblBrand WHERE brand LIKE '" + cboBrand.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        bid = dr[0].ToString();
                    }
                    dr.Close();
                    con.Close();

                    con.Open();
                    cmd = new SqlCommand("SELECT id from tblCategory WHERE category LIKE '" + cboCategory.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        cid = dr[0].ToString();
                    }
                    dr.Close();
                    con.Close();

                    con.Open();
                    cmd = new SqlCommand("INSERT INTO tblProduct (pcode,barcode,pdesc,bid,cid,price,reorder) VALUES (@pcode,@barcode,@pdesc,@bid,@cid,@price,@reorder)", con);
                    cmd.Parameters.AddWithValue("@pcode", txtPCode.Text);
                    cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@pdesc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@bid", bid);
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@reorder", int.Parse(txtReorder.Text));
                    cmd.ExecuteNonQuery();
                    btnUpdate.Enabled = false;
                    con.Close();
                    MessageBox.Show("Product has been successfuly saved");
                    pl.LoadProduct();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtPrice.Clear();
            txtDescription.Clear();
            txtPCode.Clear();
            txtBarcode.Clear();
            cboBrand.Text = "";
            cboCategory.Text = "";
            txtReorder.Clear();
            txtPCode.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this product?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string bid = ""; string cid = "";
                    con.Open();
                    cmd = new SqlCommand("SELECT id from tblBrand WHERE brand LIKE '" + cboBrand.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        bid = dr[0].ToString();
                    }
                    dr.Close();
                    con.Close();

                    con.Open();
                    cmd = new SqlCommand("SELECT id from tblCategory WHERE category LIKE '" + cboCategory.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        cid = dr[0].ToString();
                    }
                    dr.Close();
                    con.Close();

                    con.Open();
                    
                    cmd = new SqlCommand("UPDATE tblProduct SET barcode=@barocde,pdesc=@pdesc,bid=@bid,cid=@cid,price=@price,reorder=@reorder WHERE pcode like '"+ txtPCode.Text + "%'", con);
                    
                    //cmd.Parameters.AddWithValue("@pcode", txtPCode.Text);
                    cmd.Parameters.AddWithValue("@barocde", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@pdesc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@bid", bid);
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@reorder", int.Parse(txtReorder.Text));
                    cmd.ExecuteNonQuery();
                    btnAdd.Enabled = false;
                    con.Close();
                    MessageBox.Show("Product has been successfuly updated");
                    Clear();
                    pl.LoadProduct();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
