namespace DryCleaning
{
    partial class CompanyForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAdresRegs = new System.Windows.Forms.Label();
            this.lblAdresFact = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbAdresRegs = new System.Windows.Forms.TextBox();
            this.tbAdresFact = new System.Windows.Forms.TextBox();
            this.lblInn = new System.Windows.Forms.Label();
            this.lblNumder = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtbINN = new System.Windows.Forms.MaskedTextBox();
            this.mtbNum = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(183, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название организации";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 34);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(421, 26);
            this.tbName.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(13, 65);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(242, 20);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Полное название организации";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 350);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(157, 350);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(301, 350);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAdresRegs
            // 
            this.lblAdresRegs.AutoSize = true;
            this.lblAdresRegs.Location = new System.Drawing.Point(12, 121);
            this.lblAdresRegs.Name = "lblAdresRegs";
            this.lblAdresRegs.Size = new System.Drawing.Size(257, 20);
            this.lblAdresRegs.TabIndex = 10;
            this.lblAdresRegs.Text = "Адрес регистрации организации";
            // 
            // lblAdresFact
            // 
            this.lblAdresFact.AutoSize = true;
            this.lblAdresFact.Location = new System.Drawing.Point(12, 177);
            this.lblAdresFact.Name = "lblAdresFact";
            this.lblAdresFact.Size = new System.Drawing.Size(261, 20);
            this.lblAdresFact.TabIndex = 11;
            this.lblAdresFact.Text = "Фактический адрес организации";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(13, 90);
            this.tbFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFullName.MaxLength = 200;
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(421, 26);
            this.tbFullName.TabIndex = 14;
            // 
            // tbAdresRegs
            // 
            this.tbAdresRegs.Location = new System.Drawing.Point(13, 146);
            this.tbAdresRegs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAdresRegs.MaxLength = 300;
            this.tbAdresRegs.Name = "tbAdresRegs";
            this.tbAdresRegs.Size = new System.Drawing.Size(421, 26);
            this.tbAdresRegs.TabIndex = 15;
            // 
            // tbAdresFact
            // 
            this.tbAdresFact.Location = new System.Drawing.Point(13, 202);
            this.tbAdresFact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAdresFact.MaxLength = 300;
            this.tbAdresFact.Name = "tbAdresFact";
            this.tbAdresFact.Size = new System.Drawing.Size(421, 26);
            this.tbAdresFact.TabIndex = 16;
            // 
            // lblInn
            // 
            this.lblInn.AutoSize = true;
            this.lblInn.Location = new System.Drawing.Point(12, 233);
            this.lblInn.Name = "lblInn";
            this.lblInn.Size = new System.Drawing.Size(44, 20);
            this.lblInn.TabIndex = 18;
            this.lblInn.Text = "ИНН";
            // 
            // lblNumder
            // 
            this.lblNumder.AutoSize = true;
            this.lblNumder.Location = new System.Drawing.Point(255, 233);
            this.lblNumder.Name = "lblNumder";
            this.lblNumder.Size = new System.Drawing.Size(179, 20);
            this.lblNumder.TabIndex = 20;
            this.lblNumder.Text = "Телефон организации";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(13, 314);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.MaxLength = 100;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(421, 26);
            this.tbEmail.TabIndex = 21;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 289);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(263, 20);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Электронный адрес организации";
            // 
            // mtbINN
            // 
            this.mtbINN.Location = new System.Drawing.Point(12, 256);
            this.mtbINN.Mask = "000000000000";
            this.mtbINN.Name = "mtbINN";
            this.mtbINN.Size = new System.Drawing.Size(196, 26);
            this.mtbINN.TabIndex = 23;
            // 
            // mtbNum
            // 
            this.mtbNum.Location = new System.Drawing.Point(259, 256);
            this.mtbNum.Mask = "00000000000";
            this.mtbNum.Name = "mtbNum";
            this.mtbNum.Size = new System.Drawing.Size(175, 26);
            this.mtbNum.TabIndex = 24;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 396);
            this.Controls.Add(this.mtbNum);
            this.Controls.Add(this.mtbINN);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblNumder);
            this.Controls.Add(this.lblInn);
            this.Controls.Add(this.tbAdresFact);
            this.Controls.Add(this.tbAdresRegs);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lblAdresFact);
            this.Controls.Add(this.lblAdresRegs);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CompanyForm";
            this.Text = "Организация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblFullName;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAdresRegs;
        private System.Windows.Forms.Label lblAdresFact;
        public System.Windows.Forms.TextBox tbFullName;
        public System.Windows.Forms.TextBox tbAdresRegs;
        public System.Windows.Forms.TextBox tbAdresFact;
        private System.Windows.Forms.Label lblInn;
        private System.Windows.Forms.Label lblNumder;
        public System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.MaskedTextBox mtbINN;
        public System.Windows.Forms.MaskedTextBox mtbNum;
    }
}