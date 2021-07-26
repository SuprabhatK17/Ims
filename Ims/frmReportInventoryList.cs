using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace Ims
{
    public partial class frmReportInventoryList : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmRecords rec;

        public frmReportInventoryList(frmRecords re)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            rec = re;
        }


        public void LoadInventoryList(string header) 
        {
            ReportDataSource rptDs;
            try
            {
                reportInventoryList.LocalReport.ReportPath = Application.StartupPath  + @"\Reports\reportInventoryList.rdlc";
                this.reportInventoryList.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand("SELECT p.pcode,p.barcode,p.pdesc,b.brand,c.category,p.price,p.qty,p.reorder from tblProduct as p inner join tblbrand as b on p.bid = b.id inner join tblcategory as c on p.cid = c.id", con);
                da.Fill(ds.Tables["dtInventoryList"]);
                con.Close();


                
                ReportParameter pHeader = new ReportParameter("pHeader", header);
                
                reportInventoryList.LocalReport.SetParameters(pHeader);
                rptDs = new ReportDataSource("DataSet1", ds.Tables["dtInventoryList"]);
                reportInventoryList.LocalReport.DataSources.Add(rptDs);
                reportInventoryList.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmReportInventoryList_Load(object sender, EventArgs e)
        {

            this.reportInventoryList.RefreshReport();
        }



        public void LoadTopSelling(string sql, string param,string header)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportInventoryList.LocalReport.ReportPath = Application.StartupPath + @"\Reports\reportTopSelling.rdlc";
                this.reportInventoryList.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand(sql, con);
                da.Fill(ds.Tables["dtTopSelling"]);
                con.Close();

                ReportParameter pDate = new ReportParameter("pDate", param); //,"DATE FROM: " + rec.datetimefrom1.Value.ToShortDateString() + " TO " + rec.DateTimeto1.Value.ToShortDateString());
                ReportParameter pHeader = new ReportParameter("pHeader",header);
                reportInventoryList.LocalReport.SetParameters(pDate);
                reportInventoryList.LocalReport.SetParameters(pHeader);
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtTopSelling"]);
                reportInventoryList.LocalReport.DataSources.Add(rptDS);
                reportInventoryList.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);


                reportInventoryList.ZoomMode = ZoomMode.Percent;
                reportInventoryList.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadSoldItems(string sql, string param,string header)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportInventoryList.LocalReport.ReportPath = Application.StartupPath + @"\Reports\reportSoldItems.rdlc";
                this.reportInventoryList.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand(sql, con);
                da.Fill(ds.Tables["dtSoldItems"]);
                con.Close();

                ReportParameter pDate = new ReportParameter("pDate",param);
                ReportParameter pHeader = new ReportParameter("pHeader", header);

                reportInventoryList.LocalReport.SetParameters(pDate);
                reportInventoryList.LocalReport.SetParameters(pHeader);
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtSoldItems"]);
                reportInventoryList.LocalReport.DataSources.Add(rptDS);
                reportInventoryList.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);


                reportInventoryList.ZoomMode = ZoomMode.Percent;
                reportInventoryList.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ReportCancelOrder(string sql, string param, string header)
        {
            ReportDataSource rptDs;
            try
            {
                reportInventoryList.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportCancelledOrder.rdlc";
                this.reportInventoryList.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand(sql, con);
                da.Fill(ds.Tables["dtCancelledOrder"]);
                con.Close();


                ReportParameter pDate = new ReportParameter("pDate", param);
                ReportParameter pHeader = new ReportParameter("pHeader",header);
                reportInventoryList.LocalReport.SetParameters(pDate);
                reportInventoryList.LocalReport.SetParameters(pHeader);

                rptDs = new ReportDataSource("DataSet1", ds.Tables["dtCancelledOrder"]);
                reportInventoryList.LocalReport.DataSources.Add(rptDs);
                reportInventoryList.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        public void LoadReportStockInList(string sql,string param,string header)
        {
            ReportDataSource rptDs;
            try
            {
                reportInventoryList.LocalReport.ReportPath = Application.StartupPath + @"\Reports\reportStockIn.rdlc";
                this.reportInventoryList.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand(sql, con);
                da.Fill(ds.Tables["dtStockIn"]);
                con.Close();


                ReportParameter pDate = new ReportParameter("pDate", param);
                ReportParameter pHeader = new ReportParameter("pHeader",header);
                reportInventoryList.LocalReport.SetParameters(pDate);
                reportInventoryList.LocalReport.SetParameters(pHeader);

                rptDs = new ReportDataSource("DataSet1", ds.Tables["dtStockIn"]);
                reportInventoryList.LocalReport.DataSources.Add(rptDs);
                reportInventoryList.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
