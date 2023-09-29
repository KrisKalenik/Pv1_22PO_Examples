namespace WF_LibraryApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRememberUser = new System.Windows.Forms.CheckBox();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRegistrationFrm = new System.Windows.Forms.LinkLabel();
            this.lblDbConfigFrm = new System.Windows.Forms.LinkLabel();
            this.epCredentials = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCredentials)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(12, 25);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(210, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(12, 70);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(210, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // cbRememberUser
            // 
            this.cbRememberUser.AutoSize = true;
            this.cbRememberUser.Location = new System.Drawing.Point(15, 96);
            this.cbRememberUser.Name = "cbRememberUser";
            this.cbRememberUser.Size = new System.Drawing.Size(89, 17);
            this.cbRememberUser.TabIndex = 4;
            this.cbRememberUser.Text = "remember me";
            this.cbRememberUser.UseVisualStyleBackColor = true;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(203, 73);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(15, 14);
            this.cbShowPassword.TabIndex = 5;
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            this.cbShowPassword.MouseLeave += new System.EventHandler(this.cbShowPassword_MouseLeave);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 121);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(143, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRegistrationFrm
            // 
            this.lblRegistrationFrm.AutoSize = true;
            this.lblRegistrationFrm.Location = new System.Drawing.Point(84, 162);
            this.lblRegistrationFrm.Name = "lblRegistrationFrm";
            this.lblRegistrationFrm.Size = new System.Drawing.Size(63, 13);
            this.lblRegistrationFrm.TabIndex = 8;
            this.lblRegistrationFrm.TabStop = true;
            this.lblRegistrationFrm.Text = "Registration";
            // 
            // lblDbConfigFrm
            // 
            this.lblDbConfigFrm.AutoSize = true;
            this.lblDbConfigFrm.Location = new System.Drawing.Point(75, 191);
            this.lblDbConfigFrm.Name = "lblDbConfigFrm";
            this.lblDbConfigFrm.Size = new System.Drawing.Size(87, 13);
            this.lblDbConfigFrm.TabIndex = 9;
            this.lblDbConfigFrm.TabStop = true;
            this.lblDbConfigFrm.Text = "DB Configuration";
            // 
            // epCredentials
            // 
            this.epCredentials.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 226);
            this.Controls.Add(this.lblDbConfigFrm);
            this.Controls.Add(this.lblRegistrationFrm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.cbRememberUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCredentials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRememberUser;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lblRegistrationFrm;
        private System.Windows.Forms.LinkLabel lblDbConfigFrm;
        private System.Windows.Forms.ErrorProvider epCredentials;
    }
}

