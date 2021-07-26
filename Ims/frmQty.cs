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
    public partial class frmQty : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmCashier cas;


        private String pcode;
        private double price;
        private String transno;
        private int qty;


        public frmQty(frmCashier c)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            cas = c;
        }

        public void ProductDetails(String pcode, double price, String transno,int qty)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (txtQty.Text != String.Empty))
            {
                String id = "";
                int cart_qty = 0;
                bool found = false;
                

                con.Open();
                cmd = new SqlCommand("SELECT * FROM tblCart WHERE transno = @transno and pcode = @pcode",con);
                cmd.Parameters.AddWithValue("@transno",cas.lblTransaction.Text);
                cmd.Parameters.AddWithValue("@pcode", pcode);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    id = dr["id"].ToString();
                    cart_qty = int.Parse(dr["qty"].ToString());
                }
                else
                {
                    found = false;
                }
                dr.Close();
                con.Close();


                if(found == true)
                {
                    if (qty < (int.Parse(txtQty.Text) + cart_qty))
                    {
                        MessageBox.Show("Unable to proceed.Remaining qty on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    con.Open();
                    cmd = new SqlCommand(" UPDATE tblCart SET qty = (qty + " + int.Parse(txtQty.Text) + ") WHERE id ='" +  id +"'", con);
                                        
                    cmd.ExecuteNonQuery();

                    con.Close();

                    cas.txtSearch.Clear();
                    cas.txtSearch.Focus();
                    cas.LoadCart();
                    this.Dispose();
                }
                else
                {
                    if (qty < int.Parse(txtQty.Text))
                    {
                        MessageBox.Show("Unable to proceed.Remaining qty on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    con.Open();
                    cmd = new SqlCommand("INSERT INTO tblCart(transno,pcode,price,qty,sdate,cashier) VALUES (@transno,@pcode,@price,@qty,@sdate,@cashier)", con);
                    cmd.Parameters.AddWithValue("@transno", transno);
                    cmd.Parameters.AddWithValue("@pcode", pcode);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                    cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@cashier", cas.lblUserName.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    cas.txtSearch.Clear();
                    cas.txtSearch.Focus();
                    cas.LoadCart();
                    this.Dispose();
                }
                

            }
        }
    }
}
