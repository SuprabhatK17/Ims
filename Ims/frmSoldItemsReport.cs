using Microsoft.Reporting.WinForms;
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
    public partial class frmSoldItemsReport : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmSoldItems si;

        public frmSoldItemsReport(frmSoldItems fsi)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            si = fsi;
        }

        private void frmSoldItemsReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }



        public void LoadSoldReport()
        {
            ReportDataSource rptDS;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\soldItemsReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                if (si.cboCashier.Text == "ALL CASHIER")
                {
                    da.SelectCommand = new SqlCommand(" SELECT c.id,c.transno,c.pcode,p.pdesc,c.price,c.qty,c.discount as discount,c.total from tblCart as c inner join tblproduct as p on c.pcode = p.pcode WHERE STATUS LIKE 'SOLD' and sdate between '" + si.dateTimeFrom.Value.ToString("yyyy-MM-dd") + "' and '" + si.dateTimeTo.Value.ToString("yyyy-MM-dd") + "'", con);
                }
                else
                {
                    da.SelectCommand = new SqlCommand(" SELECT c.id,c.transno,c.pcode,p.pdesc,c.price,c.qty,c.discount as discount,c.total from tblCart as c inner join tblproduct as p on c.pcode = p.pcode WHERE STATUS LIKE 'SOLD' and sdate between '" + si.dateTimeFrom.Value.ToString("yyyy-MM-dd") + "' and '" + si.dateTimeTo.Value.ToString("yyyy-MM-dd") + "' and cashier LIKE '" + si.cboCashier.Text + "'", con);
                }

                da.Fill(ds.Tables["dtSoldReport"]);
                con.Close();

                ReportParameter pDate = new ReportParameter("pDate", "DATE FROM: " + si.dateTimeFrom.Value + " TO " + si.dateTimeTo.Value);
                ReportParameter pCashier = new ReportParameter("pCashier", "CASHIER " + si.cboCashier.Text );
                ReportParameter PHeader = new ReportParameter("pHeader", " SALES REPORT "  );

                //ReportParameter pCashier = new ReportParameter("pCashier", ca.cboCashier.Text);
                //ReportParameter pDate = new ReportParameter("pVatable", ca.lblVatable.Text);
                //ReportParameter pVat = new ReportParameter("pVat", ca.lblVat.Text);
                //ReportParameter pDiscount = new ReportParameter("pDiscount", ca.lblDiscount.Text);
                //ReportParameter pTotal = new ReportParameter("pTotal", ca.lblSalesTotal.Text);
                //ReportParameter pCash = new ReportParameter("pCash", pcash);
                //ReportParameter pChange = new ReportParameter("pChange", pchange);
                //ReportParameter ptransaction = new ReportParameter("pTransaction", " INVOICE #: " + ca.lblTransaction.Text);
                //ReportParameter pstore = new ReportParameter("pStore", store);
                //ReportParameter paddress = new ReportParameter("pAddress", address);

                reportViewer1.LocalReport.SetParameters(pCashier);
                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(PHeader);
                //reportViewer1.LocalReport.SetParameters(pDiscount);
                //reportViewer1.LocalReport.SetParameters(pTotal);
                //reportViewer1.LocalReport.SetParameters(pCash);
                //reportViewer1.LocalReport.SetParameters(pChange);
                //reportViewer1.LocalReport.SetParameters(ptransaction);
                //reportViewer1.LocalReport.SetParameters(pstore);
                //reportViewer1.LocalReport.SetParameters(paddress);



                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtSoldReport"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);


                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }



        
    
    }
}
