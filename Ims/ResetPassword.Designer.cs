
namespace Ims
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.txtVerifyPass = new Ims.CeLearningTextbox();
            this.txtNewPass = new Ims.CeLearningTextbox();
            this.btnSave = new ePOSOne.btnProduct.Button_WOC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVerifyPass
            // 
            this.txtVerifyPass.BackColor = System.Drawing.Color.Transparent;
            this.txtVerifyPass.BorderColor = System.Drawing.Color.Gray;
            this.txtVerifyPass.BorderSize = 1;
            this.txtVerifyPass.Br = System.Drawing.Color.White;
            this.txtVerifyPass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtVerifyPass.ForeColor = System.Drawing.Color.Black;
            this.txtVerifyPass.Location = new System.Drawing.Point(77, 106);
            this.txtVerifyPass.Name = "txtVerifyPass";
            this.txtVerifyPass.PasswordChar = '\0';
            this.txtVerifyPass.Size = new System.Drawing.Size(207, 33);
            this.txtVerifyPass.TabIndex = 3;
            this.txtVerifyPass.textboxRadius = 15;
            this.txtVerifyPass.UseSystemPasswordChar = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPass.BorderColor = System.Drawing.Color.Gray;
            this.txtNewPass.BorderSize = 1;
            this.txtNewPass.Br = System.Drawing.Color.White;
            this.txtNewPass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNewPass.ForeColor = System.Drawing.Color.Black;
            this.txtNewPass.Location = new System.Drawing.Point(77, 53);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.Size = new System.Drawing.Size(207, 33);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.textboxRadius = 15;
            this.txtNewPass.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.ButtonColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(204, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSave.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 30);
            this.panel1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "RESET PASSWORD";
            // 
            // btnback
            // 
            this.btnback.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(264, 0);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(32, 30);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnback.TabIndex = 2;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "CONFIRM -\r\nPASSWORD";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVerifyPass);
            this.Controls.Add(this.txtNewPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CeLearningTextbox txtVerifyPass;
        private CeLearningTextbox txtNewPass;
        private ePOSOne.btnProduct.Button_WOC btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btnback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}