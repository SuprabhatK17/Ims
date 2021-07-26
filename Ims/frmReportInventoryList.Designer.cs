
namespace Ims
{
    partial class frmReportInventoryList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportInventoryList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportInventoryList
            // 
            this.reportInventoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportInventoryList.Location = new System.Drawing.Point(0, 0);
            this.reportInventoryList.Name = "reportInventoryList";
            this.reportInventoryList.ServerReport.BearerToken = null;
            this.reportInventoryList.Size = new System.Drawing.Size(800, 450);
            this.reportInventoryList.TabIndex = 0;
            // 
            // frmReportInventoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportInventoryList);
            this.Name = "frmReportInventoryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORT INVENTORY LIST";
            this.Load += new System.EventHandler(this.frmReportInventoryList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportInventoryList;
    }
}