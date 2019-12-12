namespace DryCleaning
{
    partial class SigUpForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblYvol = new System.Windows.Forms.Label();
            this.cbDolj = new System.Windows.Forms.ComboBox();
            this.lblDolj = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbRepPas = new System.Windows.Forms.TextBox();
            this.lblNaim = new System.Windows.Forms.Label();
            this.tbPas = new System.Windows.Forms.TextBox();
            this.mtbNaim = new System.Windows.Forms.MaskedTextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblRepPas = new System.Windows.Forms.Label();
            this.dtpNaim = new System.Windows.Forms.DateTimePicker();
            this.mtbYvol = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mtbNum = new System.Windows.Forms.MaskedTextBox();
            this.mtbSer = new System.Windows.Forms.MaskedTextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblSer = new System.Windows.Forms.Label();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.lblOtch = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.lblFam = new System.Windows.Forms.Label();
            this.tcSotr = new System.Windows.Forms.TabControl();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tcSotr.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(283, 418);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 418);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblYvol);
            this.tabPage2.Controls.Add(this.cbDolj);
            this.tabPage2.Controls.Add(this.lblDolj);
            this.tabPage2.Controls.Add(this.tbLogin);
            this.tabPage2.Controls.Add(this.tbRepPas);
            this.tabPage2.Controls.Add(this.lblNaim);
            this.tabPage2.Controls.Add(this.tbPas);
            this.tabPage2.Controls.Add(this.mtbNaim);
            this.tabPage2.Controls.Add(this.lblLogin);
            this.tabPage2.Controls.Add(this.lblRepPas);
            this.tabPage2.Controls.Add(this.dtpNaim);
            this.tabPage2.Controls.Add(this.mtbYvol);
            this.tabPage2.Controls.Add(this.lblPassword);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(377, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "О сотруднике";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblYvol
            // 
            this.lblYvol.AutoSize = true;
            this.lblYvol.Location = new System.Drawing.Point(192, 230);
            this.lblYvol.Name = "lblYvol";
            this.lblYvol.Size = new System.Drawing.Size(141, 20);
            this.lblYvol.TabIndex = 39;
            this.lblYvol.Text = "Дата увольнения";
            // 
            // cbDolj
            // 
            this.cbDolj.FormattingEnabled = true;
            this.cbDolj.Location = new System.Drawing.Point(4, 196);
            this.cbDolj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDolj.Name = "cbDolj";
            this.cbDolj.Size = new System.Drawing.Size(332, 28);
            this.cbDolj.TabIndex = 21;
            this.cbDolj.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lblDolj
            // 
            this.lblDolj.AutoSize = true;
            this.lblDolj.Location = new System.Drawing.Point(7, 171);
            this.lblDolj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDolj.Name = "lblDolj";
            this.lblDolj.Size = new System.Drawing.Size(95, 20);
            this.lblDolj.TabIndex = 26;
            this.lblDolj.Text = "Должность";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(4, 28);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLogin.MaxLength = 16;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(331, 26);
            this.tbLogin.TabIndex = 18;
            this.tbLogin.Tag = "";
            // 
            // tbRepPas
            // 
            this.tbRepPas.Location = new System.Drawing.Point(4, 140);
            this.tbRepPas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRepPas.MaxLength = 16;
            this.tbRepPas.Name = "tbRepPas";
            this.tbRepPas.Size = new System.Drawing.Size(331, 26);
            this.tbRepPas.TabIndex = 20;
            // 
            // lblNaim
            // 
            this.lblNaim.AutoSize = true;
            this.lblNaim.Location = new System.Drawing.Point(9, 230);
            this.lblNaim.Name = "lblNaim";
            this.lblNaim.Size = new System.Drawing.Size(108, 20);
            this.lblNaim.TabIndex = 38;
            this.lblNaim.Text = "Дата приема";
            // 
            // tbPas
            // 
            this.tbPas.Location = new System.Drawing.Point(4, 84);
            this.tbPas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPas.MaxLength = 16;
            this.tbPas.Name = "tbPas";
            this.tbPas.Size = new System.Drawing.Size(331, 26);
            this.tbPas.TabIndex = 19;
            // 
            // mtbNaim
            // 
            this.mtbNaim.Location = new System.Drawing.Point(5, 253);
            this.mtbNaim.Mask = "00/00/0000";
            this.mtbNaim.Name = "mtbNaim";
            this.mtbNaim.Size = new System.Drawing.Size(178, 26);
            this.mtbNaim.TabIndex = 36;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(7, 3);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 20);
            this.lblLogin.TabIndex = 23;
            this.lblLogin.Text = "Логин";
            // 
            // lblRepPas
            // 
            this.lblRepPas.AutoSize = true;
            this.lblRepPas.Location = new System.Drawing.Point(7, 115);
            this.lblRepPas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepPas.Name = "lblRepPas";
            this.lblRepPas.Size = new System.Drawing.Size(152, 20);
            this.lblRepPas.TabIndex = 25;
            this.lblRepPas.Text = "Повторите пароль";
            // 
            // dtpNaim
            // 
            this.dtpNaim.Location = new System.Drawing.Point(6, 285);
            this.dtpNaim.Name = "dtpNaim";
            this.dtpNaim.Size = new System.Drawing.Size(177, 26);
            this.dtpNaim.TabIndex = 33;
            this.dtpNaim.ValueChanged += new System.EventHandler(this.dtpNaim_ValueChanged);
            // 
            // mtbYvol
            // 
            this.mtbYvol.Location = new System.Drawing.Point(195, 253);
            this.mtbYvol.Name = "mtbYvol";
            this.mtbYvol.Size = new System.Drawing.Size(178, 26);
            this.mtbYvol.TabIndex = 37;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 59);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 20);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Пароль";
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.mtbNum);
            this.tabPage1.Controls.Add(this.mtbSer);
            this.tabPage1.Controls.Add(this.lblNum);
            this.tabPage1.Controls.Add(this.lblSer);
            this.tabPage1.Controls.Add(this.tbOtch);
            this.tabPage1.Controls.Add(this.lblOtch);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.tbFam);
            this.tabPage1.Controls.Add(this.lblFam);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(377, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Персональные данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mtbNum
            // 
            this.mtbNum.Location = new System.Drawing.Point(193, 194);
            this.mtbNum.Mask = "999999";
            this.mtbNum.Name = "mtbNum";
            this.mtbNum.Size = new System.Drawing.Size(178, 26);
            this.mtbNum.TabIndex = 32;
            // 
            // mtbSer
            // 
            this.mtbSer.Location = new System.Drawing.Point(6, 194);
            this.mtbSer.Mask = "9999";
            this.mtbSer.Name = "mtbSer";
            this.mtbSer.Size = new System.Drawing.Size(178, 26);
            this.mtbSer.TabIndex = 31;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(210, 171);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(134, 20);
            this.lblNum.TabIndex = 30;
            this.lblNum.Text = "Номер паспорта";
            // 
            // lblSer
            // 
            this.lblSer.AutoSize = true;
            this.lblSer.Location = new System.Drawing.Point(7, 171);
            this.lblSer.Name = "lblSer";
            this.lblSer.Size = new System.Drawing.Size(131, 20);
            this.lblSer.TabIndex = 29;
            this.lblSer.Text = "Серия паспорта";
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(7, 140);
            this.tbOtch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOtch.MaxLength = 25;
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(363, 26);
            this.tbOtch.TabIndex = 28;
            this.tbOtch.Tag = "";
            // 
            // lblOtch
            // 
            this.lblOtch.AutoSize = true;
            this.lblOtch.Location = new System.Drawing.Point(7, 115);
            this.lblOtch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtch.Name = "lblOtch";
            this.lblOtch.Size = new System.Drawing.Size(83, 20);
            this.lblOtch.TabIndex = 27;
            this.lblOtch.Text = "Отчество";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(7, 84);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.MaxLength = 20;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(363, 26);
            this.tbName.TabIndex = 26;
            this.tbName.Tag = "";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 59);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 20);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Имя";
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(7, 28);
            this.tbFam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFam.MaxLength = 25;
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(363, 26);
            this.tbFam.TabIndex = 24;
            this.tbFam.Tag = "";
            // 
            // lblFam
            // 
            this.lblFam.AutoSize = true;
            this.lblFam.Location = new System.Drawing.Point(3, 3);
            this.lblFam.Name = "lblFam";
            this.lblFam.Size = new System.Drawing.Size(81, 20);
            this.lblFam.TabIndex = 0;
            this.lblFam.Text = "Фамилия";
            // 
            // tcSotr
            // 
            this.tcSotr.Controls.Add(this.tabPage1);
            this.tcSotr.Controls.Add(this.tabPage2);
            this.tcSotr.Location = new System.Drawing.Point(4, 50);
            this.tcSotr.Name = "tcSotr";
            this.tcSotr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tcSotr.SelectedIndex = 0;
            this.tcSotr.Size = new System.Drawing.Size(385, 360);
            this.tcSotr.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 418);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 30);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // SigUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 462);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tcSotr);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SigUpForm";
            this.Text = "Регистрация";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tcSotr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDolj;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblRepPas;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tcSotr;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblSer;
        private System.Windows.Forms.Label lblOtch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFam;
        private System.Windows.Forms.Label lblYvol;
        private System.Windows.Forms.Label lblNaim;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ComboBox cbDolj;
        public System.Windows.Forms.TextBox tbLogin;
        public System.Windows.Forms.TextBox tbRepPas;
        public System.Windows.Forms.TextBox tbPas;
        public System.Windows.Forms.MaskedTextBox mtbNum;
        public System.Windows.Forms.MaskedTextBox mtbSer;
        public System.Windows.Forms.TextBox tbOtch;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbFam;
        public System.Windows.Forms.MaskedTextBox mtbYvol;
        public System.Windows.Forms.MaskedTextBox mtbNaim;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.DateTimePicker dtpNaim;
        private System.Windows.Forms.Button btnPrint;
    }
}