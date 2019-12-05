namespace DryCleaning
{
    partial class SignInForm
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblAutorization = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(20, 234);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLogin.MaxLength = 16;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(331, 26);
            this.tbLogin.TabIndex = 0;
            // 
            // lblAutorization
            // 
            this.lblAutorization.AutoSize = true;
            this.lblAutorization.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAutorization.Location = new System.Drawing.Point(10, 66);
            this.lblAutorization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutorization.Name = "lblAutorization";
            this.lblAutorization.Size = new System.Drawing.Size(218, 45);
            this.lblAutorization.TabIndex = 1;
            this.lblAutorization.Text = "Авторизация";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(20, 342);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(166, 54);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(15, 209);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 20);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Логин";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(18, 302);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.MaxLength = 16;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(331, 26);
            this.tbPassword.TabIndex = 1;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(14, 277);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(71, 20);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = " Пароль";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(186, 342);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 54);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 414);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAutorization);
            this.Controls.Add(this.tbLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SignInForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblAutorization;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button btnClose;
    }
}