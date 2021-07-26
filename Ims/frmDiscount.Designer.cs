
namespace Ims
{
    partial class frmDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiscountPerc = new MetroFramework.Controls.MetroTextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscountAmt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPRICE = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDiscountPerc);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDiscountAmt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPRICE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 136);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDiscountPerc
            // 
            // 
            // 
            // 
            this.txtDiscountPerc.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtDiscountPerc.CustomButton.Image = null;
            this.txtDiscountPerc.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.txtDiscountPerc.CustomButton.Name = "";
            this.txtDiscountPerc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiscountPerc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscountPerc.CustomButton.TabIndex = 1;
            this.txtDiscountPerc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscountPerc.CustomButton.UseSelectable = true;
            this.txtDiscountPerc.CustomButton.Visible = false;
            this.txtDiscountPerc.Lines = new string[0];
            this.txtDiscountPerc.Location = new System.Drawing.Point(169, 44);
            this.txtDiscountPerc.MaxLength = 32767;
            this.txtDiscountPerc.Name = "txtDiscountPerc";
            this.txtDiscountPerc.PasswordChar = '\0';
            this.txtDiscountPerc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscountPerc.SelectedText = "";
            this.txtDiscountPerc.SelectionLength = 0;
            this.txtDiscountPerc.SelectionStart = 0;
            this.txtDiscountPerc.ShortcutsEnabled = true;
            this.txtDiscountPerc.Size = new System.Drawing.Size(277, 23);
            this.txtDiscountPerc.TabIndex = 37;
            this.txtDiscountPerc.UseSelectable = true;
            this.txtDiscountPerc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscountPerc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiscountPerc.TextChanged += new System.EventHandler(this.txtDiscountPerc_TextChanged);
            this.txtDiscountPerc.Click += new System.EventHandler(this.txtDiscountPerc_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(31, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 35;
            this.lblID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(250, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(169, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "DISCOUNT AMOUNT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmt
            // 
            this.txtDiscountAmt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDiscountAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscountAmt.Enabled = false;
            this.txtDiscountAmt.Location = new System.Drawing.Point(169, 70);
            this.txtDiscountAmt.Multiline = true;
            this.txtDiscountAmt.Name = "txtDiscountAmt";
            this.txtDiscountAmt.Size = new System.Drawing.Size(277, 17);
            this.txtDiscountAmt.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "DISCOUNT (%)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "TOTAL PRICE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPRICE
            // 
            this.txtPRICE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPRICE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPRICE.Enabled = false;
            this.txtPRICE.Location = new System.Drawing.Point(169, 24);
            this.txtPRICE.Multiline = true;
            this.txtPRICE.Name = "txtPRICE";
            this.txtPRICE.Size = new System.Drawing.Size(277, 17);
            this.txtPRICE.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 38);
            this.panel2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "DISCOUNT\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnback
            // 
            this.btnback.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(0, 0);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(32, 36);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnback.TabIndex = 0;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 174);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDiscount";
            this.Load += new System.EventHandler(this.frmDiscount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDiscount_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDiscountAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPRICE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnback;
        public MetroFramework.Controls.MetroTextBox txtDiscountPerc;
    }
}