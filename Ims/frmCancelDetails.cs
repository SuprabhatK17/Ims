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
    public partial class frmCancelDetails : Form
    {
        frmSoldItems si;

        public frmCancelDetails(frmSoldItems fsi)
        {
            InitializeComponent();
            si = fsi;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboAddInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cboAddInv.Text != String.Empty) && (txtQty.Text != String.Empty) && (txtReason.Text != String.Empty)) 
                {
                    if (int.Parse(txtQty.Text) >= int.Parse(txtCanceldQty.Text))
                    {
                        frmVoid vo = new frmVoid(this);
                        vo.ShowDialog();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RefreshList()
        {
            si.LoadSoldItems();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
