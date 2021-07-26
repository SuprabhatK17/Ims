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
    public partial class frmDiscount : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmCashier cas;

        public frmDiscount(frmCashier ca)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            cas = ca;
            this.KeyPreview = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {

        }

        private void txtDiscountPerc_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscountPerc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double disount = double.Parse(txtPRICE.Text) * double.Parse(txtDiscountPerc.Text);
                txtDiscountAmt.Text = disount.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                txtDiscountAmt.Text = "0.00";

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Add dsicount?Click yes to confirm ", "DISCOUNT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE tblCart SET discount = @discount,discount_percent = @discount_percent WHERE id = @id ", con);
                    cmd.Parameters.AddWithValue("@discount", double.Parse(txtDiscountAmt.Text));
                    cmd.Parameters.AddWithValue("@discount_percent", double.Parse(txtDiscountPerc.Text));
                    cmd.Parameters.AddWithValue("@id", int.Parse(lblID.Text));
                    cmd.ExecuteNonQuery();

                    con.Close();
                    cas.LoadCart();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
