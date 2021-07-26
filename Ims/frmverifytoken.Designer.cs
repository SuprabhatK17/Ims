
namespace Ims
{
    partial class frmverifyToken
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
            this.btnSubmit = new ePOSOne.btnProduct.Button_WOC();
            this.txtCode = new Ims.CeLearningTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubmit.ButtonColor = System.Drawing.Color.LightSeaGreen;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(134, 114);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSubmit.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnSubmit.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Size = new System.Drawing.Size(304, 40);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.Transparent;
            this.txtCode.BorderColor = System.Drawing.Color.Gray;
            this.txtCode.BorderSize = 1;
            this.txtCode.Br = System.Drawing.Color.White;
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(122, 58);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.Size = new System.Drawing.Size(316, 41);
            this.txtCode.TabIndex = 0;
            this.txtCode.textboxRadius = 15;
            this.txtCode.UseSystemPasswordChar = false;
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "CODE";
            // 
            // frmverifyToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCode);
            this.Name = "frmverifyToken";
            this.Text = "frmverifytoken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CeLearningTextbox txtCode;
        private ePOSOne.btnProduct.Button_WOC btnSubmit;
        private System.Windows.Forms.Label label1;
    }
}