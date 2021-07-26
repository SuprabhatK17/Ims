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
    public partial class frmStockAdjustment : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        int _qty = 0;

        frmMainDashboard md;
        public frmStockAdjustment(frmMainDashboard fmd)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            md = fmd;
            LoadProduct();
        }


        public void ReferenceNo()
        {
            Random rmd = new Random();
            txtReferenceNo.Text = rmd.Next().ToString();
        }

    

        // load data from data base to data gridview
        public void LoadProduct()
        {
            int i = 0;
            dgvProductList.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT p.pcode,p.barcode,p.pdesc,b.brand,c.category,p.price,p.qty from tblProduct as p inner join tblbrand as b on b.id = p.bid inner join tblCategory as c on c.id=p.cid WHERE p.pdesc LIKE '" + txtSearch.Text + "%'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProductList.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr["brand"].ToString(), dr["category"].ToString(), dr["pdesc"].ToString(), dr[5].ToString(), dr[6].ToString());
            }

            dr.Close();
            con.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                LoadProduct();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProductList.Columns[e.ColumnIndex].Name;
            if(colName == "SELECT")
            {
                
                txtPCode.Text = dgvProductList.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescription.Text = dgvProductList.Rows[e.RowIndex].Cells[3].Value.ToString() + "," +  dgvProductList.Rows[e.RowIndex].Cells[4].Value.ToString()  + "," + dgvProductList.Rows[e.RowIndex].Cells[5].Value.ToString();
                _qty = int.Parse(dgvProductList.Rows[e.RowIndex].Cells[7].Value.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //valaditaiton for empty field

                if (int.Parse(txtQty.Text) > _qty)
                {
                    MessageBox.Show("Stock on hand out of bound , stock on hand available Quantity is lesser than the entry adjustment qty,check stock on hand qty", " WARNING ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // update stock

                if (cboCmd.Text == "REMOVE FROM INVENTORY") /*|| (int.Parse(txtQty.Text) <= _qty))*/
                {
                    User_SqlStatement("UPDATE tblProduct SET qty = (qty - " + int.Parse(txtQty.Text) + ") WHERE pcode LIKE '" + txtPCode.Text + "'");
                }
                

                else if (cboCmd.Text == "ADD TO INVENTORY") /*||  (int.Parse(txtQty.Text) >= _qty))*/
                {
                    User_SqlStatement("UPDATE tblProduct SET qty = (qty + " + int.Parse(txtQty.Text) + ") WHERE pcode LIKE '" + txtPCode.Text + "'");
                }
                

                User_SqlStatement("INSERT INTO tblStockAdjustment(referenceno,pcode,qty,action,remarks,sdate,[user]) VALUES  ('" + txtReferenceNo.Text + "','" + txtPCode.Text + "' ,'" + int.Parse(txtQty.Text) + "','" + cboCmd.Text + "','" + txtRemarks.Text + "' , '" + DateTime.Now.ToString("yyyy-MM-dd") + "' , '" + txtUser.Text + "')");   //(@refernceno,@pcode,@qty,@action,@remarks,@sdate,@user)");

                MessageBox.Show("Stock has been successfully adjusted", "PROCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProduct();
                Clear();
            }catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void Clear()
        {
            txtDescription.Clear();
            txtPCode.Clear();
            txtQty.Clear();
            txtReferenceNo.Clear();
            txtRemarks.Clear();
            cboCmd.Text = "";
            //txtUser.Clear();
            ReferenceNo();
        }


        public void User_SqlStatement(string u_sql)
        {
            con.Open();
            cmd = new SqlCommand(u_sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }





        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtReferenceNo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPCode_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtQty_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboCmd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRemarks_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmStockAdjustment_Load(object sender, EventArgs e)
        {

        }
    }
}
