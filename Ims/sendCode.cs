using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Ims
{
    public partial class sendCode : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        string randomCode;
        public static string to;

        public sendCode()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random ranNo = new Random();
            randomCode = (ranNo.Next(9999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtSendEmail.Text).ToString();
            from = "suprabhatk086577@gmail.com";
            pass = "suprabhat0117";
            messageBody = " your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE email = '" + txtSendEmail.Text.Trim() +"'", con);
                DataTable dt = new DataTable();
                
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    smtp.Send(message);
                    MessageBox.Show("Code send successfully", "OTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No such email exist", "VERIFY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                dr.Close();
                con.Close();

                

                



            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;

            }

        }

        private void txtSendCode_Click(object sender, EventArgs e)
        {

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtVerifyCode.Text).ToString())
            {
                to = txtSendEmail.Text;
                ResetPassword rp = new ResetPassword();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
