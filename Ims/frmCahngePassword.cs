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
    public partial class frmCahngePassword : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();


        frmCashier ca;
        public frmCahngePassword(frmCashier cas)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            ca = cas;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPass = dbcon.GetPassword(ca.lblUser.Text);
                if (oldPass != txtOldP.Text)
                {
                    MessageBox.Show(" Old Password did not matched!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                else if (txtNewP.Text != txtConP.Text)
                {
                    MessageBox.Show("New password did not matched ","WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if(MessageBox.Show("Are you sure " + ca.lblUser+  " To Change Password ?" ,"CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cmd = new SqlCommand("UPDATE tblUser SET password = @password  WHERE username = @username  ",con);
                        cmd.Parameters.AddWithValue("@password", txtNewP.Text);
                        cmd.Parameters.AddWithValue("@username", ca.lblUser.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(" Password has been successfully changed for  " + ca.lblUser, "CONFIRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }

            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
