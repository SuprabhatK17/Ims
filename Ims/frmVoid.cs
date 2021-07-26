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
    public partial class frmVoid : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        frmCancelDetails cd;
        string user;

        public frmVoid(frmCancelDetails fcd)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            cd = fcd;

        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtPassword.Text != String.Empty)
                {
                    //string user;
                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM tblUser WHERE username = @username AND password =@password",con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        user = dr["username"].ToString();
                        dr.Close();
                        con.Close();

                        SaveCancelOrder(user);
                        if(cd.cboAddInv.Text == "YES")
                        {
                            UpdateInventory("UPDATE tblProduct SET qty = qty + " + int.Parse(cd.txtCanceldQty.Text) + " WHERE pcode ='" + cd.txtPCODE.Text + "'");
                        }
                        UpdateInventory("UPDATE tblCart SET qty = qty - " + int.Parse(cd.txtCanceldQty.Text) + " WHERE id LIKE '" + cd.txtId.Text + "'");

                        MessageBox.Show("ORDER TRANSACTION SICCESSFULLY CANCELLED!", "TRANSACTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        cd.RefreshList();
                        cd.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("SUSPECTED USER !WRONG CREDENTIALS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    dr.Close();
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void SaveCancelOrder(string user)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tblCancelOrder (transno,pcode,price,qty,sdate,voidby,cancelledby,reason,action) VALUES (@transno,@pcode,@price,@qty,@sdate,@voidby,@cancelledby,@reason,@action) ",con);
            cmd.Parameters.AddWithValue("@transno", cd.txtTransactionNo.Text);
            cmd.Parameters.AddWithValue("@pcode", cd.txtPCODE.Text);
            cmd.Parameters.AddWithValue("@price", double.Parse(cd.txtPrice.Text));
            cmd.Parameters.AddWithValue("@qty", int.Parse(cd.txtQty.Text));
            cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
            cmd.Parameters.AddWithValue("@voidby", user);
            cmd.Parameters.AddWithValue("@cancelledby", cd.txtCanceledBy.Text);
            cmd.Parameters.AddWithValue("@reason", cd.txtReason.Text);
            cmd.Parameters.AddWithValue("@action", cd.cboAddInv.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void UpdateInventory(string sql)
        {
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

}
