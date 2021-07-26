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
    public partial class ResetPassword : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        string username = sendCode.to;

        public ResetPassword()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text == txtVerifyPass.Text)
            {
                con.Open();
                //string username = dr["username"].ToString();
                cmd = new SqlCommand("UPDATE tblUser SET  password = '" + txtVerifyPass.Text.Trim() +  "'WHERE username ='" + username +"'", con); ;
                //cmd.Parameters.AddWithValue("@password", txtnewPassword.Text);
                //cmd.Parameters.AddWithValue("@username", txtUserName2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password has been successfully changed ", "VALID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPass.Text = "";

                txtVerifyPass.Text = "";

            }
            else
            {
                MessageBox.Show("The new password do not match ");
            }


        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
