using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ims
{
    public partial class frmverifyToken : Form
    {
        public string Email
        {
            get; set;
        }

        public string Pw
        {
            get; set;
        }

        public frmverifyToken()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(new DBConnection().VerifyCode(Email, Pw, txtCode.Text))
            {
                //MessageBox.Show("Account has been Created Successfully \n login and complete your profile from user setting","SIGN UP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new DBConnection().VerifyCode(Email, Pw, txtCode.Text))
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void txtCode_Click(object sender, EventArgs e)
        {

        }
    }
}
