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
using Tulpep.NotificationWindow;

namespace Ims
{
    public partial class frmCashier : Form
    {
        String id;
        String Totalprice;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmLogin log;
        int qty;
        

        public frmCashier(frmLogin lo)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            NotifyCriticalItems();
            lblTransactionDate.Text = DateTime.Now.ToLongDateString(); // show transaction date 
            this.KeyPreview = true;
            log = lo;
        }
        



        public void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                //string time = DateTime.Now.ToString("HH:mm");
                string transno;
                int count;
                con.Open();
                cmd = new SqlCommand("SELECT TOP 1 transno from tblCart WHERE transno like '" + sdate + "%' order by id desc ", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransaction.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblTransaction.Text = transno;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void LoadCart()
        {
            try
            {
                Boolean hasRecord = false;
                dgvLoadStockInList.Rows.Clear();
                int i = 0;
                double total = 0;
                double discount = 0;
                con.Open();
                cmd = new SqlCommand("Select c.id,c.pcode,p.pdesc,c.price,c.qty,c.discount,c.total from tblCart as c inner join tblProduct as p on c.pcode = p.pcode WHERE transno LIKE '" + lblTransaction.Text + "' and STATUS LIKE 'PENDING'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += double.Parse(dr["total"].ToString());
                    discount += double.Parse(dr["discount"].ToString());
                    dgvLoadStockInList.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), double.Parse(dr["price"].ToString()), dr["qty"].ToString(), dr["discount"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"),"[ + ]","[ - ]");
                    hasRecord = true;
                }
                dr.Close();
                con.Close();
                lblSalesTotal.Text = total.ToString("#,##0.00");
                lblDiscount.Text = discount.ToString("#,##0.00");
                GetCartTotal();
                if (hasRecord == true)
                {
                    btnSettlePayment.Enabled = true;
                    btnAddDiscount.Enabled = true;
                    btnClearCart.Enabled = true;
                }
                else
                {
                    btnSettlePayment.Enabled = false;
                    btnAddDiscount.Enabled = false;
                    btnClearCart.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void GetCartTotal()
        {
            double sales = Double.Parse(lblSalesTotal.Text);
            double discount = double.Parse(lblDiscount.Text);
            double vat = sales * dbcon.GetVal();
            double vatable = sales - vat;
            lblTotal.Text = sales.ToString("#,##0.00");
            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");

        }

        //btndailysales click event
        private void btnDailySales_Click(object sender, EventArgs e)
        {
            frmSoldItems si = new frmSoldItems();
            //si.dateTimeFrom.Enabled = false;
            //si.dateTimeTo.Enabled = false;
            si.cboCashier.Enabled = false;
            si.cboCashier.Text = lblUserName.Text;
            si.si_user = lblUserName.Text;
            si.ShowDialog();
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            frmSettlePayment sp = new frmSettlePayment(this);
            sp.txtSale.Text = lblTotal.Text;
            sp.ShowDialog();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if(dgvLoadStockInList.Rows.Count > 0)
            {
                return;
            }

            GetTransNo();
            txtSearch.Enabled = true;
            txtSearch.Focus();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (lblTransaction.Text == "00000")
            {
                return;
            }
            frmLookUp lp = new frmLookUp(this);
            lp.LoadSelectStockList();
            lp.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtSearch.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    String _pcode;
                    double _price;
                    int _qty;
                    con.Open();
                    cmd = new SqlCommand("SELECT * from tblProduct WHERE barcode like '" + txtSearch.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        qty = int.Parse(dr["qty"].ToString());
                        //frmQty qt = new frmQty(this);
                        // qt.ProductDetails(dr["pcode"].ToString(), double.Parse(dr["price"].ToString()), lblTransaction.Text,qty);
                        _pcode = dr["pcode"].ToString();
                        _price = double.Parse(dr["price"].ToString());
                        _qty = int.Parse(txtQty.Text);
                        dr.Close();
                        con.Close();
                        // qt.ShowDialog();
                        AddToCart(_pcode, _price,_qty);
                    }
                    else
                    {
                        dr.Close();
                        con.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddToCart(String _pcode,double _price,int _qty)
        {
            String id = "";
            bool found = false;
            int cart_qty = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblCart WHERE transno = @transno and pcode = @pcode", con);
            cmd.Parameters.AddWithValue("@transno", lblTransaction.Text);
            cmd.Parameters.AddWithValue("@pcode", _pcode);
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

            if (found == true)
            {
                if (qty < (int.Parse(txtQty.Text) + cart_qty))
                {
                    MessageBox.Show("Unable to proceed.Remaining qty on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                con.Open();
                cmd = new SqlCommand(" UPDATE tblCart SET qty = (qty + " + _qty + ") WHERE id ='" + id + "'", con);

                cmd.ExecuteNonQuery();

                con.Close();

                txtSearch.SelectionStart = 0;
                txtSearch.SelectionLength = txtSearch.Text.Length;
                LoadCart();
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
                cmd.Parameters.AddWithValue("@transno", lblTransaction);
                cmd.Parameters.AddWithValue("@pcode", _pcode);
                cmd.Parameters.AddWithValue("@price", _price);
                cmd.Parameters.AddWithValue("@qty", _qty);
                cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@cashier", lblUserName.Text);
                cmd.ExecuteNonQuery();

                con.Close();

                txtSearch.SelectionStart = 0;
                txtSearch.SelectionLength = txtSearch.Text.Length;
                LoadCart();
                this.Dispose();
            }
        }

        private void dgvLoadStockInList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvLoadStockInList.Columns[e.ColumnIndex].Name;
            if (colName == "DELETE")
            {
                if (MessageBox.Show("Remove this Item?", "REMOVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tblCart WHERE id LIKE '" + dgvLoadStockInList.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item has successfully removed", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
            else if (colName == "ADD")
            {
                int i = 0;
                con.Open();
                cmd = new SqlCommand("SELECT sum(qty) as qty FROM tblProduct WHERE pcode like '" + dgvLoadStockInList.Rows[e.RowIndex].Cells[2].Value.ToString() + "' group by pcode ", con);
                i = int.Parse(cmd.ExecuteScalar().ToString());
                con.Close();

                if (int.Parse(dgvLoadStockInList.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE tblCart set qty = qty + " + int.Parse(txtQty.Text) + " WHERE transno LIKE '" + lblTransaction.Text + "' AND pcode LIKE '" + dgvLoadStockInList.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining qty on hand is " + i + " ! ", " Out of stock ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (colName == "REMOVE")
            {
                int i = 0;
                con.Open();
                cmd = new SqlCommand("SELECT sum(qty) as qty FROM tblCart WHERE pcode like '" + dgvLoadStockInList.Rows[e.RowIndex].Cells[2].Value.ToString() + "' and transno like '" + lblTransaction.Text + "' group by transno,pcode ", con);
                i = int.Parse(cmd.ExecuteScalar().ToString());
                con.Close();

                //if (int.Parse(dgvLoadStockInList.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
                if(i > 1)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE tblCart set qty = qty - " + int.Parse(txtQty.Text) + " WHERE transno LIKE '" + lblTransaction.Text + "' AND pcode LIKE '" + dgvLoadStockInList.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining qty on cart is " + i + " ! ", " WARNING ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

        }
        // Discount button click event
        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount disc = new frmDiscount(this);
            disc.lblID.Text = id;
            disc.txtPRICE.Text = Totalprice;
            disc.ShowDialog();
        }

        private void dgvLoadStockInList_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvLoadStockInList.CurrentRow.Index;
            id = dgvLoadStockInList[1, i].Value.ToString();
            Totalprice = dgvLoadStockInList[7, i].Value.ToString();
        }

        private void lblTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDay.Text = DateTime.Now.ToLongDateString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmUserSetting us = new frmUserSetting();
            us.ShowDialog();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Remove all items from cart?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM tblCart WHERE transno like '" + lblTransaction.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("All items has been clear ", "CLEAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCart();
            }
        }

        private void frmCashier_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                btnTransaction_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnSearchProduct_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnAddDiscount_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnSettlePayment_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnClearCart_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnDailySales_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F7)
            {
                btnChangePassword_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8)
            {
                txtSearch.SelectionStart = 0;
                txtSearch.SelectionLength = txtSearch.Text.Length;
            }
            else if (e.KeyCode == Keys.F10)
            {
                btnLogout_Click(sender, e);
                
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmCahngePassword cp = new frmCahngePassword(this);
            cp.ShowDialog();
        }


        public void NotifyCriticalItems()
        {
            string critical = "";
            con.Open();
            cmd = new SqlCommand("SELECT count(*) FROM vwCriticalItems", con);
            string count = cmd.ExecuteScalar().ToString();
            con.Close();


            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM vwCriticalItems", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                critical += "(" + i + ")" + dr["pdesc"].ToString() + Environment.NewLine;

            }
            dr.Close();
            con.Close();


            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.error;
            popup.TitleText = count + " CRITICAL ITEM(S)";
            popup.ContentText = critical;
            popup.Popup();

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            if (dgvLoadStockInList.Rows.Count > 0)
            {
                MessageBox.Show("Unable to logout.Clear the Transaction", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("LOGOUT APPLICATION?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin log = new frmLogin();
                log.ShowDialog();
            }
        }
    }
}
