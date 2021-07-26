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
    public partial class frmStoreSetting : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;


        public frmStoreSetting()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("SAVE STORE DETAILS?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int count;
                    con.Open();
                    cmd = new SqlCommand(" SELECT COUNT(*) FROM tblStore ", con);
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                    con.Close();
                    if(count > 0)
                    {
                        con.Open();
                        cmd = new SqlCommand("UPDATE tblStore SET store  = @store ,address = @address", con);
                        cmd.Parameters.AddWithValue("@store", txtStoreName.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        cmd = new SqlCommand("INSERT INTO tblStore (store ,address )VALUES (@store,@address)", con);
                        cmd.Parameters.AddWithValue("@store", txtStoreName.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Store Details has been successfully saved ", "SETTING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Open();
                con.Close();
            }catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void loadRecords()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblStore", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtAddress.Text = dr["address"].ToString();
                txtStoreName.Text = dr["store"].ToString();
            }
            else
            {
                txtAddress.Clear();
                txtStoreName.Clear();
            }
            dr.Close();
            
            con.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
