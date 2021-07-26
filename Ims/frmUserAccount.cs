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
    public partial class frmUserAccount : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        frmMainDashboard md;
        

        public frmUserAccount(frmMainDashboard fmd)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            md = fmd;
        }

        private void frmUserAccount_Resize_1(object sender, EventArgs e)
        {
            userAccount.Left = (this.Width - userAccount.Width) / 2;
            userAccount.Top = (this.Height - userAccount.Height) / 2;
        }

        private void CLear()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtReTypePass.Clear();
            txtUserName.Clear();
            txtRole.Text = "";
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CLear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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



                if (txtPassword.Text != txtReTypePass.Text)
                {
                    MessageBox.Show("PASSWORD DID NOT MATCH", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!SignUp(txtEmail.Text, txtPassword.Text))
                {
                    MessageBox.Show("Register failed");
                    return;
                }
                frmverifyToken vt = new frmverifyToken();
                
                vt.Email = txtEmail.Text;
                vt.Pw = txtPassword.Text;
                if(vt.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Verified done, New Account has been created");
                }


                
                //con.Open();
                //var code = new Random().Next(9999999);
                //cmd = new SqlCommand("INSERT INTO tblUser(email,username,password,role,name) VALUES (@email,@username,@password,@role,@name)", con);
                //cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                //cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                //cmd.Parameters.AddWithValue("@role", txtRole.Text);
                //cmd.Parameters.AddWithValue("@name", txtName.Text);
                //cmd.Parameters.AddWithValue("@email", txtEmail.Text);



                //var mailhelp = new EmailRegister();
                //mailhelp.Send(code + string.Empty, email);
                //return cmd.ExecuteNonQuery() > 0;

                //cmd.ExecuteNonQuery();

                //con.Close();
                //MessageBox.Show("NEW ACCOUNT HAS SAVED");
                //CLear();
            }
            
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public bool SignUp(string email, string pw)
        {
            LoginStatus loginStatus = dbcon.CheckLogin(email, pw);
            if (loginStatus == LoginStatus.NotExist)
            {
                //con.ConnectionString = dbcon.MyConnection();
                con.Open();
                var hash = dbcon.GenerateHash(pw);
                var code = new Random().Next(999999);
                cmd = new SqlCommand("INSERT INTO tblUser(email,username,password,role,name) VALUES (@email,@username,@password,@role,@name)", con);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", txtRole.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                //cmd.Parameters.AddWithValue("@email", email);
                //cmd.Parameters.AddWithValue("@password", code);
                cmd.Parameters.AddWithValue("@code", code);
                var mailhelp = new EmailRegister();
                mailhelp.Send(code + string.Empty, email);
                return cmd.ExecuteNonQuery() > 0;
                //con.Close();
                //MessageBox.Show("NEW ACCOUNT HAS SAVED");
                //CLear();


            }
            //con.Close();
            return false;
        }


        //public bool SignUp(string email, string pw)
        //{
        //    LoginStatus loginStatus = dbcon.CheckLogin(email, pw);

        //}







        private void frmUserAccount_Resize(object sender, EventArgs e)
        {
            userAccount.Left = (this.Width - userAccount.Width) / 2;
            userAccount.Top = (this.Height - userAccount.Height) / 2;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtReTypePass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtOldPassword.Text != md._pass)
                {
                    MessageBox.Show("Old password did not matched! ", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if(txtnewPassword.Text != txtReNewPass.Text)
                {
                    MessageBox.Show("Confirm new password did not matched! ", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                con.Open();
                cmd = new SqlCommand("UPDATE tblUser SET  password = @password WHERE username = @username ",con);
                cmd.Parameters.AddWithValue("@password", txtnewPassword.Text);
                cmd.Parameters.AddWithValue("@username", txtUserName2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password has been successfully changed ", "VALID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPassword.Clear();
                
                txtnewPassword.Clear();
                txtReNewPass.Clear();

            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtusername3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE username = @username", con);
                cmd.Parameters.AddWithValue("@username", txtusername3.Text.Trim());
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    cboActive.Checked = bool.Parse(dr["isactive"].ToString());
                }
                else
                {
                    cboActive.Checked = false;
                }
                dr.Close();
                con.Close();
            }catch(Exception ex){
                con.Close();
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = true;
                con.Open();
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE username = @username", con);
                cmd.Parameters.AddWithValue("@username", txtusername3.Text.Trim());
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                 
                }
                else
                {
                    found = false;
                }
                dr.Close();
                con.Close();

                if(found == true)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE tblUser SET isactive = @isactive WHERE username = @username", con);
                    cmd.Parameters.AddWithValue("@isActive", cboActive.Checked.ToString());
                    cmd.Parameters.AddWithValue("@username", txtusername3.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Account status has been updated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusername3.Clear();
                    cboActive.Checked = false;
                }
                else
                {
                    MessageBox.Show("Some error with the Account \n OR Account is missing \n kindly check the account details", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                
            }catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if(txtEmail.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Invalid email");
                    return;
                }
            }
        }
    }
    
}
