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

using Microsoft.Reporting.WinForms;

namespace Ims
{
    public partial class frmSalesReport : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmCashier ca;
        string store = "CEC";
        string address = "NADHERI (EAST)";

        public frmSalesReport(frmCashier cas)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            ca = cas;
        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }


        public void SalesReport(string pcash,string pchange)
        {
            ReportDataSource rptDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\salesReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand("SELECT c.id,c.transno,c.pcode,c.price,c.qty,c.discount,c.total,c.sdate,c.status,p.pdesc FROM tblCart as c inner join tblProduct as p on p.pcode = c.pcode WHERE transno LIKE '" + ca.lblTransaction.Text + "'",con);
                da.Fill(ds.Tables["dtSOld"]);
                con.Close();

                ReportParameter pCashier = new ReportParameter("pCashier", ca.lblUserName.Text);
                ReportParameter pVatable = new ReportParameter("pVatable",ca.lblVatable.Text);
                ReportParameter pVat = new ReportParameter("pVat", ca.lblVat.Text);
                ReportParameter pDiscount = new ReportParameter("pDiscount", ca.lblDiscount.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", ca.lblSalesTotal.Text);
                ReportParameter pCash = new ReportParameter("pCash", pcash);
                ReportParameter pChange = new ReportParameter("pChange", pchange);
                ReportParameter ptransaction  = new ReportParameter("pTransaction"," INVOICE #: " + ca.lblTransaction.Text);
                ReportParameter pstore = new ReportParameter("pStore", store);
                ReportParameter paddress = new ReportParameter("pAddress", address);

                reportViewer1.LocalReport.SetParameters(pCashier);
                reportViewer1.LocalReport.SetParameters(pVatable);
                reportViewer1.LocalReport.SetParameters(pVat);
                reportViewer1.LocalReport.SetParameters(pDiscount);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pCash);
                reportViewer1.LocalReport.SetParameters(pChange);
                reportViewer1.LocalReport.SetParameters(ptransaction);
                reportViewer1.LocalReport.SetParameters(pstore);
                reportViewer1.LocalReport.SetParameters(paddress);
                


                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtSold"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);


                //reportViewer1.ZoomMode = ZoomMode.Percent;

            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
