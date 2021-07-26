
namespace Ims
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSwitchSIgnIn = new System.Windows.Forms.Label();
            this.btnSwitchSingIn = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new ePOSOne.btnProduct.Button_WOC();
            this.btnSignUp = new ePOSOne.btnProduct.Button_WOC();
            this.txtConfirmPass = new Ims.CeLearningTextbox();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            this.btnHidePass = new ePOSOne.btnProduct.Button_WOC();
            this.btnShowPass = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Ims.CeLearningTextbox();
            this.txtEmail = new Ims.CeLearningTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitchSingIn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 410);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblSwitchSIgnIn);
            this.panel3.Controls.Add(this.btnSwitchSingIn);
            this.panel3.Controls.Add(this.btn_Cancel);
            this.panel3.Controls.Add(this.btnSignUp);
            this.panel3.Controls.Add(this.txtConfirmPass);
            this.panel3.Controls.Add(this.button_WOC2);
            this.panel3.Controls.Add(this.button_WOC3);
            this.panel3.Controls.Add(this.btnHidePass);
            this.panel3.Controls.Add(this.btnShowPass);
            this.panel3.Controls.Add(this.button_WOC1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(400, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 410);
            this.panel3.TabIndex = 1;
            // 
            // lblSwitchSIgnIn
            // 
            this.lblSwitchSIgnIn.AutoSize = true;
            this.lblSwitchSIgnIn.ForeColor = System.Drawing.Color.White;
            this.lblSwitchSIgnIn.Location = new System.Drawing.Point(335, 59);
            this.lblSwitchSIgnIn.Name = "lblSwitchSIgnIn";
            this.lblSwitchSIgnIn.Size = new System.Drawing.Size(62, 13);
            this.lblSwitchSIgnIn.TabIndex = 40;
            this.lblSwitchSIgnIn.Text = "SING IN >>";
            this.lblSwitchSIgnIn.Visible = false;
            // 
            // btnSwitchSingIn
            // 
            this.btnSwitchSingIn.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchSingIn.Image")));
            this.btnSwitchSingIn.Location = new System.Drawing.Point(348, 3);
            this.btnSwitchSingIn.Name = "btnSwitchSingIn";
            this.btnSwitchSingIn.Size = new System.Drawing.Size(49, 50);
            this.btnSwitchSingIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSwitchSingIn.TabIndex = 39;
            this.btnSwitchSingIn.TabStop = false;
            this.btnSwitchSingIn.Click += new System.EventHandler(this.btnSwitchSingIn_Click);
            this.btnSwitchSingIn.MouseLeave += new System.EventHandler(this.btnSwitchSingIn_MouseLeave);
            this.btnSwitchSingIn.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(45, 341);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cancel.Size = new System.Drawing.Size(310, 50);
            this.btn_Cancel.TabIndex = 38;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.TextColor = System.Drawing.Color.White;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BorderColor = System.Drawing.Color.Transparent;
            this.btnSignUp.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(45, 285);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSignUp.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSignUp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignUp.Size = new System.Drawing.Size(310, 50);
            this.btnSignUp.TabIndex = 37;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPass.BorderColor = System.Drawing.Color.Gray;
            this.txtConfirmPass.BorderSize = 0;
            this.txtConfirmPass.Br = System.Drawing.Color.White;
            this.txtConfirmPass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPass.Location = new System.Drawing.Point(82, 207);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(252, 43);
            this.txtConfirmPass.TabIndex = 35;
            this.txtConfirmPass.textboxRadius = 15;
            this.txtConfirmPass.UseSystemPasswordChar = false;
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC2.ButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Image = ((System.Drawing.Image)(resources.GetObject("button_WOC2.Image")));
            this.button_WOC2.Location = new System.Drawing.Point(24, 200);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC2.Size = new System.Drawing.Size(52, 55);
            this.button_WOC2.TabIndex = 34;
            this.button_WOC2.Text = "\r\n";
            this.button_WOC2.TextColor = System.Drawing.Color.White;
            this.button_WOC2.UseVisualStyleBackColor = true;
            // 
            // button_WOC3
            // 
            this.button_WOC3.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC3.ButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Image = ((System.Drawing.Image)(resources.GetObject("button_WOC3.Image")));
            this.button_WOC3.Location = new System.Drawing.Point(24, 200);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC3.Size = new System.Drawing.Size(52, 55);
            this.button_WOC3.TabIndex = 33;
            this.button_WOC3.Text = "\r\n";
            this.button_WOC3.TextColor = System.Drawing.Color.White;
            this.button_WOC3.UseVisualStyleBackColor = true;
            // 
            // btnHidePass
            // 
            this.btnHidePass.BorderColor = System.Drawing.Color.Transparent;
            this.btnHidePass.ButtonColor = System.Drawing.Color.Transparent;
            this.btnHidePass.FlatAppearance.BorderSize = 0;
            this.btnHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePass.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePass.Image")));
            this.btnHidePass.Location = new System.Drawing.Point(24, 139);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnHidePass.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnHidePass.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnHidePass.Size = new System.Drawing.Size(52, 55);
            this.btnHidePass.TabIndex = 32;
            this.btnHidePass.Text = "\r\n";
            this.btnHidePass.TextColor = System.Drawing.Color.White;
            this.btnHidePass.UseVisualStyleBackColor = true;
            // 
            // btnShowPass
            // 
            this.btnShowPass.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowPass.ButtonColor = System.Drawing.Color.Transparent;
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            this.btnShowPass.Location = new System.Drawing.Point(24, 139);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnShowPass.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnShowPass.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnShowPass.Size = new System.Drawing.Size(52, 55);
            this.btnShowPass.TabIndex = 31;
            this.btnShowPass.Text = "\r\n";
            this.btnShowPass.TextColor = System.Drawing.Color.White;
            this.btnShowPass.UseVisualStyleBackColor = true;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Image = ((System.Drawing.Image)(resources.GetObject("button_WOC1.Image")));
            this.button_WOC1.Location = new System.Drawing.Point(24, 78);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Size = new System.Drawing.Size(52, 55);
            this.button_WOC1.TabIndex = 28;
            this.button_WOC1.Text = "\r\n";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 51);
            this.label1.TabIndex = 27;
            this.label1.Text = "USER SIGN-UP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Gray;
            this.txtPassword.BorderSize = 0;
            this.txtPassword.Br = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(82, 144);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(252, 43);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.textboxRadius = 15;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.Gray;
            this.txtEmail.BorderSize = 0;
            this.txtEmail.Br = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(82, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Size = new System.Drawing.Size(252, 43);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.textboxRadius = 15;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 410);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 73);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sign Up for cashier account \r\nonly store workers can signup";
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignUp";
            this.Text = "frmSignUp";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitchSingIn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public CeLearningTextbox txtPassword;
        public CeLearningTextbox txtEmail;
        private System.Windows.Forms.Label label1;
        public ePOSOne.btnProduct.Button_WOC button_WOC1;
        public ePOSOne.btnProduct.Button_WOC btnShowPass;
        public ePOSOne.btnProduct.Button_WOC btnHidePass;
        public CeLearningTextbox txtConfirmPass;
        public ePOSOne.btnProduct.Button_WOC button_WOC2;
        public ePOSOne.btnProduct.Button_WOC button_WOC3;
        private ePOSOne.btnProduct.Button_WOC btn_Cancel;
        private ePOSOne.btnProduct.Button_WOC btnSignUp;
        private System.Windows.Forms.PictureBox btnSwitchSingIn;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblSwitchSIgnIn;
    }
}