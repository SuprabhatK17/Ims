
namespace Ims
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSIgnUp = new System.Windows.Forms.LinkLabel();
            this.btnForgetpassword = new System.Windows.Forms.LinkLabel();
            this.cboRemMe = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHidePass = new ePOSOne.btnProduct.Button_WOC();
            this.btnShowPass = new ePOSOne.btnProduct.Button_WOC();
            this.btn_Cancel = new ePOSOne.btnProduct.Button_WOC();
            this.btn_Login = new ePOSOne.btnProduct.Button_WOC();
            this.txtPassword = new Ims.CeLearningTextbox();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.txtUsername = new Ims.CeLearningTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.btnSIgnUp);
            this.panel1.Controls.Add(this.btnForgetpassword);
            this.panel1.Controls.Add(this.cboRemMe);
            this.panel1.Controls.Add(this.btnHidePass);
            this.panel1.Controls.Add(this.btnShowPass);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.button_WOC1);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 500);
            this.panel1.TabIndex = 21;
            // 
            // btnSIgnUp
            // 
            this.btnSIgnUp.AutoSize = true;
            this.btnSIgnUp.LinkColor = System.Drawing.Color.White;
            this.btnSIgnUp.Location = new System.Drawing.Point(135, 478);
            this.btnSIgnUp.Name = "btnSIgnUp";
            this.btnSIgnUp.Size = new System.Drawing.Size(155, 13);
            this.btnSIgnUp.TabIndex = 34;
            this.btnSIgnUp.TabStop = true;
            this.btnSIgnUp.Text = "Dont Have Account ?Sign Up";
            this.btnSIgnUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSIgnUp_LinkClicked);
            // 
            // btnForgetpassword
            // 
            this.btnForgetpassword.AutoSize = true;
            this.btnForgetpassword.LinkColor = System.Drawing.Color.White;
            this.btnForgetpassword.Location = new System.Drawing.Point(250, 284);
            this.btnForgetpassword.Name = "btnForgetpassword";
            this.btnForgetpassword.Size = new System.Drawing.Size(98, 13);
            this.btnForgetpassword.TabIndex = 33;
            this.btnForgetpassword.TabStop = true;
            this.btnForgetpassword.Text = "Forget Password?";
            this.btnForgetpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnForgetpassword_LinkClicked);
            // 
            // cboRemMe
            // 
            this.cboRemMe.AutoSize = true;
            this.cboRemMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRemMe.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRemMe.ForeColor = System.Drawing.Color.White;
            this.cboRemMe.Location = new System.Drawing.Point(249, 426);
            this.cboRemMe.Name = "cboRemMe";
            this.cboRemMe.Size = new System.Drawing.Size(100, 19);
            this.cboRemMe.TabIndex = 30;
            this.cboRemMe.Text = "Remember Me";
            this.cboRemMe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 51);
            this.label1.TabIndex = 21;
            this.label1.Text = "USER LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHidePass
            // 
            this.btnHidePass.BorderColor = System.Drawing.Color.Transparent;
            this.btnHidePass.ButtonColor = System.Drawing.Color.Transparent;
            this.btnHidePass.FlatAppearance.BorderSize = 0;
            this.btnHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePass.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePass.Image")));
            this.btnHidePass.Location = new System.Drawing.Point(296, 216);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnHidePass.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnHidePass.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnHidePass.Size = new System.Drawing.Size(52, 55);
            this.btnHidePass.TabIndex = 29;
            this.btnHidePass.Text = "\r\n";
            this.btnHidePass.TextColor = System.Drawing.Color.White;
            this.btnHidePass.UseVisualStyleBackColor = true;
            this.btnHidePass.Click += new System.EventHandler(this.btnHidePass_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowPass.ButtonColor = System.Drawing.Color.Transparent;
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            this.btnShowPass.Location = new System.Drawing.Point(296, 216);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnShowPass.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnShowPass.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnShowPass.Size = new System.Drawing.Size(52, 55);
            this.btnShowPass.TabIndex = 28;
            this.btnShowPass.Text = "\r\n";
            this.btnShowPass.TextColor = System.Drawing.Color.White;
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(134)))), ((int)(((byte)(136)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(38, 370);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cancel.Size = new System.Drawing.Size(310, 50);
            this.btn_Cancel.TabIndex = 27;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.TextColor = System.Drawing.Color.White;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Login.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(134)))), ((int)(((byte)(136)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(38, 314);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Login.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Login.Size = new System.Drawing.Size(310, 50);
            this.btn_Login.TabIndex = 26;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.TextColor = System.Drawing.Color.White;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Gray;
            this.txtPassword.BorderSize = 0;
            this.txtPassword.Br = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(38, 228);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(252, 43);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.textboxRadius = 15;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Image = ((System.Drawing.Image)(resources.GetObject("button_WOC1.Image")));
            this.button_WOC1.Location = new System.Drawing.Point(38, 149);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Size = new System.Drawing.Size(52, 55);
            this.button_WOC1.TabIndex = 23;
            this.button_WOC1.Text = "\r\n";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.Gray;
            this.txtUsername.BorderSize = 0;
            this.txtUsername.Br = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(96, 154);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Size = new System.Drawing.Size(252, 43);
            this.txtUsername.TabIndex = 22;
            this.txtUsername.textboxRadius = 15;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public CeLearningTextbox txtPassword;
        public CeLearningTextbox txtUsername;
        public ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC btn_Login;
        private ePOSOne.btnProduct.Button_WOC btn_Cancel;
        public ePOSOne.btnProduct.Button_WOC btnShowPass;
        public ePOSOne.btnProduct.Button_WOC btnHidePass;
        private System.Windows.Forms.CheckBox cboRemMe;
        private System.Windows.Forms.LinkLabel btnForgetpassword;
        private System.Windows.Forms.LinkLabel btnSIgnUp;
    }
}