
namespace Ims
{
    partial class sendCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendCode));
            this.txtSendEmail = new Ims.CeLearningTextbox();
            this.txtVerifyCode = new Ims.CeLearningTextbox();
            this.btnSend = new ePOSOne.btnProduct.Button_WOC();
            this.btnVerify = new ePOSOne.btnProduct.Button_WOC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSendEmail
            // 
            this.txtSendEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtSendEmail.BorderColor = System.Drawing.Color.Gray;
            this.txtSendEmail.BorderSize = 1;
            this.txtSendEmail.Br = System.Drawing.Color.White;
            this.txtSendEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSendEmail.ForeColor = System.Drawing.Color.Black;
            this.txtSendEmail.Location = new System.Drawing.Point(126, 57);
            this.txtSendEmail.Name = "txtSendEmail";
            this.txtSendEmail.PasswordChar = '\0';
            this.txtSendEmail.Size = new System.Drawing.Size(207, 33);
            this.txtSendEmail.TabIndex = 0;
            this.txtSendEmail.textboxRadius = 15;
            this.txtSendEmail.UseSystemPasswordChar = false;
            this.txtSendEmail.Click += new System.EventHandler(this.txtSendCode_Click);
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.BackColor = System.Drawing.Color.Transparent;
            this.txtVerifyCode.BorderColor = System.Drawing.Color.Gray;
            this.txtVerifyCode.BorderSize = 1;
            this.txtVerifyCode.Br = System.Drawing.Color.White;
            this.txtVerifyCode.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtVerifyCode.ForeColor = System.Drawing.Color.Black;
            this.txtVerifyCode.Location = new System.Drawing.Point(126, 125);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.PasswordChar = '\0';
            this.txtVerifyCode.Size = new System.Drawing.Size(207, 33);
            this.txtVerifyCode.TabIndex = 1;
            this.txtVerifyCode.textboxRadius = 15;
            this.txtVerifyCode.UseSystemPasswordChar = false;
            // 
            // btnSend
            // 
            this.btnSend.BorderColor = System.Drawing.Color.Silver;
            this.btnSend.ButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(258, 96);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSend.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnSend.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "SEND";
            this.btnSend.TextColor = System.Drawing.Color.White;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BorderColor = System.Drawing.Color.Silver;
            this.btnVerify.ButtonColor = System.Drawing.Color.Turquoise;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Location = new System.Drawing.Point(225, 164);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnVerify.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnVerify.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnVerify.Size = new System.Drawing.Size(108, 23);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "VERIFY CODE";
            this.btnVerify.TextColor = System.Drawing.Color.White;
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 30);
            this.panel1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "USSER ACCOUNT";
            // 
            // btnback
            // 
            this.btnback.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(313, 0);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(32, 30);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnback.TabIndex = 2;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "EMAIL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "OTP";
            // 
            // sendCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtVerifyCode);
            this.Controls.Add(this.txtSendEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sendCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sendCode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CeLearningTextbox txtSendEmail;
        private CeLearningTextbox txtVerifyCode;
        private ePOSOne.btnProduct.Button_WOC btnSend;
        private ePOSOne.btnProduct.Button_WOC btnVerify;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btnback;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}