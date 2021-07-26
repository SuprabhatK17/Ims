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
    public partial class frmSettlePayment : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmCashier cas;

        public frmSettlePayment(frmCashier ca)
        {
            InitializeComponent();
            
            con = new SqlConnection(dbcon.MyConnection());
            cas = ca;
            this.KeyPreview = true;

        }

        private void txtCash_Click(object sender, EventArgs e)
        {

        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale = double.Parse(txtSale.Text);
                double cash = double.Parse(txtCash.Text);
                double change = cash - sale;
                txtChange.Text = change.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                txtChange.Text = "0.00";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double.Parse(txtChange.Text) < 0) || (txtCash.Text == String.Empty))
                {
                    MessageBox.Show("Insufficient amount.Please enter the correct amount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                else
                {
                    for (int i = 0; i < cas.dgvLoadStockInList.Rows.Count; i++)
                    {
                        con.Open();
                        cmd = new SqlCommand("UPDATE tblProduct SET qty = qty - " + int.Parse(cas.dgvLoadStockInList.Rows[i].Cells[5].Value.ToString()) + "WHERE pcode = '" + cas.dgvLoadStockInList.Rows[i].Cells[2].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        cmd = new SqlCommand("UPDATE tblCart SET status = 'SOLD' WHERE id like '" + cas.dgvLoadStockInList.Rows[i].Cells[1].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }

                    frmSalesReport sr = new frmSalesReport(cas);
                    sr.SalesReport(txtCash.Text,txtChange.Text);
                    sr.ShowDialog();

                    MessageBox.Show("Payment successfully saved ", "PAYMENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cas.GetTransNo();
                    cas.LoadCart();
                    this.Dispose();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn0.Text;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn00.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtCash.Text += button13.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn9.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnClear.Text;
        }

        private void frmSettlePayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnCalculate_Click(sender, e);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
