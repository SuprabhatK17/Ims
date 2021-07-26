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
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public string _pass, _username = "";
        public bool _isactive = false;



        public frmLogin()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            LoadRememeberMe();
        }

        public void SaveRememberMe()
        {
            if (cboRemMe.Checked == true)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();

            }
            else if (cboRemMe.Checked == false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();

            }
        }


        public void LoadRememeberMe()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
                cboRemMe.Checked = true;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        


        private void btnLogin_Click(object sender, EventArgs e)
        {
            


            string _role = "", _name = "";
            try
            {
                bool found = false;
                con.Open();
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE username = @username AND password = @password", con);
                //cmd.Parameters.AddWithValue("@username", textBox1.Text);
                //cmd.Parameters.AddWithValue("@password", textBox2.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _role = dr["role"].ToString();
                    _name = dr["name"].ToString();
                    _pass = dr["password"].ToString();
                    _isactive = bool.Parse(dr["isactive"].ToString());
                }
                else
                {
                    found = false;
                }
                dr.Close();
                con.Close();

                if (found == true)
                {
                    if (_isactive == false)
                    {
                        MessageBox.Show("Account is inactive.Unable to login \n Contact admin", "INACTIVE ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (_role == "CASHIER")
                    {
                        
                        MessageBox.Show("WELCOME " + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SaveRememberMe();
                        //textBox1.Text = "";
                        //textBox2.Text = "";
                        this.Hide();
                        frmCashier ca = new frmCashier(this);
                        ca.lblUserName.Text = _username;
                        ca.lblUser.Text = _role + " | " + _username;
                        
                        ca.ShowDialog();
                    }
                    else
                    {
                        
                        MessageBox.Show("WELCOME " + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SaveRememberMe();
                        //textBox1.Text = "";
                        //textBox2.Text = "";
                        this.Hide();
                        frmMainDashboard das = new frmMainDashboard();
                        das.lblUserName.Text = _username;
                        das.lblRole.Text = _role;
                        das._pass = _pass;
                        das._user = _username;
                        das.DashBoard();
                        das.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            {
                string _role = "", _name = "";
                try
                {
                    bool found = false;
                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM tblUser WHERE username = @username AND password = @password", con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    //cmd.Parameters.AddWithValue("@email", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        found = true;
                        _username = dr["username"].ToString();
                        _role = dr["role"].ToString();
                        _name = dr["name"].ToString();
                        _pass = dr["password"].ToString();
                        _isactive = bool.Parse(dr["isactive"].ToString());
                    }
                    else
                    {
                        found = false;
                    }
                    dr.Close();
                    con.Close();

                    if (found == true)
                    {
                        if (_isactive == false)
                        {
                            MessageBox.Show("Account is inactive.Unable to login \n Contact admin", "INACTIVE ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        if (_role == "CASHIER")
                        {
                            MessageBox.Show("WELCOME " + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SaveRememberMe();
                            txtPassword.Text = "";
                            txtUsername.Text = "";
                            
                            this.Hide();
                            frmCashier ca = new frmCashier(this);
                            ca.lblUserName.Text = _username;
                            ca.lblUser.Text = _role + " | " + _username;
                            ca.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("WELCOME " + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SaveRememberMe();
                            txtPassword.Text = "";
                            txtUsername.Text = "";
                            
                            this.Hide();
                            frmMainDashboard das = new frmMainDashboard();
                            das.lblUserName.Text = _username;
                            das.lblRole.Text = _role;
                            das._pass = _pass;
                            das._user = _username;
                            das.DashBoard();
                            das.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("EXIT APPLICATION", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void button_WOC2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnShowPass.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnHidePass.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnForgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sendCode sc = new sendCode();
            this.Hide();
            sc.Show();
        }

        private void btnSIgnUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmSignUp sup = new frmSignUp();
            sup.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("EXIT APPLICATION", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
