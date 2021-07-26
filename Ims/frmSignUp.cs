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
    public partial class frmSignUp : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;


        public frmSignUp()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            lblSwitchSIgnIn.Show();
        }

        private void btnSwitchSingIn_MouseLeave(object sender, EventArgs e)
        {
            lblSwitchSIgnIn.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Select email from tbluser where email = '" + txtEmail.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("This Email is already in use,or email doesnt exist ,check with another email", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dr.Close();
                con.Close();


                if (txtPassword.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Password not match");
                    return;
                }
                if (!dbcon.SignUp(txtEmail.Text, txtConfirmPass.Text))
                {
                    MessageBox.Show("Regester Failed");
                    return;
                }
                frmverifyToken vt = new frmverifyToken();
                vt.Email = txtEmail.Text;
                vt.Pw = txtPassword.Text;
                if (vt.ShowDialog() == DialogResult.Yes)
                {
                    
                    MessageBox.Show("Verified donw , New Account has been created");
                }

                //con.Close();
                //MessageBox.Show("NEW ACCOUNT HAS SAVED");

            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSwitchSingIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin log = new frmLogin();
            log.ShowDialog();
            
        }
    }
}
