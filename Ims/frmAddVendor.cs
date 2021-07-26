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
    public partial class frmAddVendor : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        frmVednorList vl;

        public frmAddVendor(frmVednorList fvl)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            vl = fvl;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtVendor.Clear();
            txtAddress.Clear();
            txtDealer.Clear();
            txtCoNo.Clear();
            txtEmail.Clear();
            txtFax.Clear();
            txtVendor.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save this Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                con.Open();
                cmd = new SqlCommand("INSERT INTO tblVendor (vendor,address,contactperson,telephone,email,fax) VALUES (@vendor,@address,@contactperson,@telephone,@email,@fax)", con);
                //cmd.Parameters.AddWithValue("@id", txtVendor.Text);
                cmd.Parameters.AddWithValue("@vendor", txtVendor.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@contactperson", txtDealer.Text);
                cmd.Parameters.AddWithValue("@telephone", txtCoNo.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@fax", txtFax.Text);
                cmd.ExecuteNonQuery();
                btnUpdate.Enabled = false;
                con.Close();
                MessageBox.Show("Vendor details has been successfuly saved", "RECORDS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vl.LoadVendor();
                Clear();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Update this Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand("UPDATE tblVendor SET vendor=@vendor,address=@address,contactperson=@contactperson,telephone=@telephone,email=@email,fax=@fax WHERE id like '" + lblID.Text + "'", con);
                cmd.Parameters.AddWithValue("@vendor", txtVendor.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@contactperson", txtDealer.Text);
                cmd.Parameters.AddWithValue("@telephone", txtCoNo.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@fax", txtFax.Text);
                cmd.ExecuteNonQuery();
                btnAdd.Enabled = false;
                con.Close();
                MessageBox.Show("Record has been successfuly updated");

                
                vl.LoadVendor();
                Clear();
                this.Dispose();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
