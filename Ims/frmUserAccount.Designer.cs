
namespace Ims
{
    partial class frmUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccount));
            this.userAccount = new MetroFramework.Controls.MetroTabControl();
            this.CreateAccount = new MetroFramework.Controls.MetroTabPage();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReTypePass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePASSWORD = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.txtUserName2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReNewPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnewPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteAccount = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave3 = new System.Windows.Forms.Button();
            this.cboActive = new MetroFramework.Controls.MetroCheckBox();
            this.txtusername3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.PictureBox();
            this.userAccount.SuspendLayout();
            this.CreateAccount.SuspendLayout();
            this.ChangePASSWORD.SuspendLayout();
            this.panel2.SuspendLayout();
            this.deleteAccount.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            this.SuspendLayout();
            // 
            // userAccount
            // 
            this.userAccount.Controls.Add(this.CreateAccount);
            this.userAccount.Controls.Add(this.ChangePASSWORD);
            this.userAccount.Controls.Add(this.deleteAccount);
            this.userAccount.Location = new System.Drawing.Point(0, 30);
            this.userAccount.Name = "userAccount";
            this.userAccount.SelectedIndex = 0;
            this.userAccount.Size = new System.Drawing.Size(800, 420);
            this.userAccount.TabIndex = 1;
            this.userAccount.UseSelectable = true;
            // 
            // CreateAccount
            // 
            this.CreateAccount.BackColor = System.Drawing.Color.White;
            this.CreateAccount.Controls.Add(this.txtEmail);
            this.CreateAccount.Controls.Add(this.label10);
            this.CreateAccount.Controls.Add(this.btnCancel);
            this.CreateAccount.Controls.Add(this.btnAdd);
            this.CreateAccount.Controls.Add(this.txtRole);
            this.CreateAccount.Controls.Add(this.txtName);
            this.CreateAccount.Controls.Add(this.label5);
            this.CreateAccount.Controls.Add(this.label4);
            this.CreateAccount.Controls.Add(this.txtReTypePass);
            this.CreateAccount.Controls.Add(this.label3);
            this.CreateAccount.Controls.Add(this.txtPassword);
            this.CreateAccount.Controls.Add(this.Password);
            this.CreateAccount.Controls.Add(this.txtUserName);
            this.CreateAccount.Controls.Add(this.label1);
            this.CreateAccount.HorizontalScrollbarBarColor = true;
            this.CreateAccount.HorizontalScrollbarHighlightOnWheel = false;
            this.CreateAccount.HorizontalScrollbarSize = 10;
            this.CreateAccount.Location = new System.Drawing.Point(4, 38);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(792, 378);
            this.CreateAccount.TabIndex = 0;
            this.CreateAccount.Text = "CREATE ACCOUNT";
            this.CreateAccount.VerticalScrollbarBarColor = true;
            this.CreateAccount.VerticalScrollbarHighlightOnWheel = false;
            this.CreateAccount.VerticalScrollbarSize = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(241, 113);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(411, 26);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Location = new System.Drawing.Point(98, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "EMAIL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(577, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(496, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRole
            // 
            this.txtRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRole.FormattingEnabled = true;
            this.txtRole.Items.AddRange(new object[] {
            "SYSTEM ADMINISTRATIOR",
            "CASHIER"});
            this.txtRole.Location = new System.Drawing.Point(241, 238);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(411, 21);
            this.txtRole.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(241, 37);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(411, 26);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Location = new System.Drawing.Point(98, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "NAME";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(98, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "ROLE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReTypePass
            // 
            this.txtReTypePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReTypePass.Location = new System.Drawing.Point(241, 192);
            this.txtReTypePass.Multiline = true;
            this.txtReTypePass.Name = "txtReTypePass";
            this.txtReTypePass.PasswordChar = '*';
            this.txtReTypePass.Size = new System.Drawing.Size(411, 26);
            this.txtReTypePass.TabIndex = 7;
            this.txtReTypePass.TextChanged += new System.EventHandler(this.txtReTypePass_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(98, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "RE-TYPE PASSWORD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(241, 149);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(411, 26);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Location = new System.Drawing.Point(98, 152);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 23);
            this.Password.TabIndex = 4;
            this.Password.Text = "PASSWORD";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Location = new System.Drawing.Point(241, 78);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(411, 26);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(98, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChangePASSWORD
            // 
            this.ChangePASSWORD.Controls.Add(this.panel2);
            this.ChangePASSWORD.Location = new System.Drawing.Point(4, 38);
            this.ChangePASSWORD.Name = "ChangePASSWORD";
            this.ChangePASSWORD.Size = new System.Drawing.Size(792, 378);
            this.ChangePASSWORD.TabIndex = 1;
            this.ChangePASSWORD.Text = "CHANGE PASSWORD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCancel2);
            this.panel2.Controls.Add(this.btnAdd2);
            this.panel2.Controls.Add(this.txtUserName2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtReNewPass);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtnewPassword);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtOldPassword);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 378);
            this.panel2.TabIndex = 0;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel2.BackColor = System.Drawing.Color.Silver;
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Location = new System.Drawing.Point(622, 236);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 24;
            this.btnCancel2.Text = "CANCEL";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd2.ForeColor = System.Drawing.Color.White;
            this.btnAdd2.Location = new System.Drawing.Point(541, 236);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 23;
            this.btnAdd2.Text = "ADD";
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // txtUserName2
            // 
            this.txtUserName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName2.Location = new System.Drawing.Point(285, 79);
            this.txtUserName2.Multiline = true;
            this.txtUserName2.Name = "txtUserName2";
            this.txtUserName2.Size = new System.Drawing.Size(411, 26);
            this.txtUserName2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(119, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "USER NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReNewPass.Location = new System.Drawing.Point(285, 204);
            this.txtReNewPass.Multiline = true;
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.PasswordChar = '*';
            this.txtReNewPass.Size = new System.Drawing.Size(411, 26);
            this.txtReNewPass.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(119, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "RE-TYPE NEW PASSWORD";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtnewPassword
            // 
            this.txtnewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnewPassword.Location = new System.Drawing.Point(285, 161);
            this.txtnewPassword.Multiline = true;
            this.txtnewPassword.Name = "txtnewPassword";
            this.txtnewPassword.PasswordChar = '*';
            this.txtnewPassword.Size = new System.Drawing.Size(411, 26);
            this.txtnewPassword.TabIndex = 18;
            this.txtnewPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Location = new System.Drawing.Point(119, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "NEW PASSWORD";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOldPassword.Location = new System.Drawing.Point(285, 120);
            this.txtOldPassword.Multiline = true;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(411, 26);
            this.txtOldPassword.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Location = new System.Drawing.Point(119, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "OLD PASSWORD";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteAccount
            // 
            this.deleteAccount.Controls.Add(this.panel3);
            this.deleteAccount.Location = new System.Drawing.Point(4, 38);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(792, 378);
            this.deleteAccount.TabIndex = 2;
            this.deleteAccount.Text = "ACTIVE / DE-ACTIVE ACCOUNT";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnSave3);
            this.panel3.Controls.Add(this.cboActive);
            this.panel3.Controls.Add(this.txtusername3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 378);
            this.panel3.TabIndex = 0;
            // 
            // btnSave3
            // 
            this.btnSave3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave3.AutoSize = true;
            this.btnSave3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave3.ForeColor = System.Drawing.Color.White;
            this.btnSave3.Location = new System.Drawing.Point(278, 161);
            this.btnSave3.Name = "btnSave3";
            this.btnSave3.Size = new System.Drawing.Size(75, 25);
            this.btnSave3.TabIndex = 26;
            this.btnSave3.Text = "ADD";
            this.btnSave3.UseVisualStyleBackColor = false;
            this.btnSave3.Click += new System.EventHandler(this.btnSave3_Click);
            // 
            // cboActive
            // 
            this.cboActive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboActive.AutoSize = true;
            this.cboActive.Location = new System.Drawing.Point(278, 126);
            this.cboActive.Name = "cboActive";
            this.cboActive.Size = new System.Drawing.Size(73, 15);
            this.cboActive.TabIndex = 25;
            this.cboActive.Text = "IS ACTIVE";
            this.cboActive.UseSelectable = true;
            // 
            // txtusername3
            // 
            this.txtusername3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusername3.Location = new System.Drawing.Point(278, 82);
            this.txtusername3.Multiline = true;
            this.txtusername3.Name = "txtusername3";
            this.txtusername3.Size = new System.Drawing.Size(411, 26);
            this.txtusername3.TabIndex = 24;
            this.txtusername3.TextChanged += new System.EventHandler(this.txtusername3_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Location = new System.Drawing.Point(112, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "USER NAME";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(197)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 2;
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
            this.btnback.Location = new System.Drawing.Point(768, 0);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(32, 30);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnback.TabIndex = 2;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userAccount);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.frmUserAccount_Resize_1);
            this.userAccount.ResumeLayout(false);
            this.CreateAccount.ResumeLayout(false);
            this.CreateAccount.PerformLayout();
            this.ChangePASSWORD.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.deleteAccount.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl userAccount;
        public MetroFramework.Controls.MetroTabPage CreateAccount;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ComboBox txtRole;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReTypePass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ChangePASSWORD;
        private System.Windows.Forms.TabPage deleteAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnCancel2;
        public System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReNewPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnewPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtUserName2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtusername3;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroCheckBox cboActive;
        public System.Windows.Forms.Button btnSave3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btnback;
        private System.Windows.Forms.Label label11;
    }
}