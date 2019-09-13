namespace DryCleaning
{
    partial class LicenziatForm
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
            this.lblFam = new System.Windows.Forms.Label();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAdresRegs = new System.Windows.Forms.Label();
            this.lblAdresFact = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAdresRegs = new System.Windows.Forms.TextBox();
            this.tbAdresFact = new System.Windows.Forms.TextBox();
            this.lblInn = new System.Windows.Forms.Label();
            this.lblNumder = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtbINN = new System.Windows.Forms.MaskedTextBox();
            this.mtbNum = new System.Windows.Forms.MaskedTextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.lblOtch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFam
            // 
            this.lblFam.AutoSize = true;
            this.lblFam.Location = new System.Drawing.Point(13, 9);
            this.lblFam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFam.Name = "lblFam";
            this.lblFam.Size = new System.Drawing.Size(81, 20);
            this.lblFam.TabIndex = 0;
            this.lblFam.Text = "Фамилия";
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(13, 34);
            this.tbFam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(421, 26);
            this.tbFam.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 65);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Имя";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 402);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 402);
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
            this.btnDelete.Location = new System.Drawing.Point(300, 402);
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
            this.lblAdresRegs.Location = new System.Drawing.Point(13, 177);
            this.lblAdresRegs.Name = "lblAdresRegs";
            this.lblAdresRegs.Size = new System.Drawing.Size(157, 20);
            this.lblAdresRegs.TabIndex = 10;
            this.lblAdresRegs.Text = "Адрес регистрации";
            // 
            // lblAdresFact
            // 
            this.lblAdresFact.AutoSize = true;
            this.lblAdresFact.Location = new System.Drawing.Point(12, 233);
            this.lblAdresFact.Name = "lblAdresFact";
            this.lblAdresFact.Size = new System.Drawing.Size(161, 20);
            this.lblAdresFact.TabIndex = 11;
            this.lblAdresFact.Text = "Фактический адрес";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 90);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(421, 26);
            this.tbName.TabIndex = 14;
            // 
            // tbAdresRegs
            // 
            this.tbAdresRegs.Location = new System.Drawing.Point(13, 202);
            this.tbAdresRegs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAdresRegs.Name = "tbAdresRegs";
            this.tbAdresRegs.Size = new System.Drawing.Size(421, 26);
            this.tbAdresRegs.TabIndex = 15;
            // 
            // tbAdresFact
            // 
            this.tbAdresFact.Location = new System.Drawing.Point(13, 258);
            this.tbAdresFact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAdresFact.Name = "tbAdresFact";
            this.tbAdresFact.Size = new System.Drawing.Size(421, 26);
            this.tbAdresFact.TabIndex = 16;
            // 
            // lblInn
            // 
            this.lblInn.AutoSize = true;
            this.lblInn.Location = new System.Drawing.Point(13, 289);
            this.lblInn.Name = "lblInn";
            this.lblInn.Size = new System.Drawing.Size(44, 20);
            this.lblInn.TabIndex = 18;
            this.lblInn.Text = "ИНН";
            // 
            // lblNumder
            // 
            this.lblNumder.AutoSize = true;
            this.lblNumder.Location = new System.Drawing.Point(255, 289);
            this.lblNumder.Name = "lblNumder";
            this.lblNumder.Size = new System.Drawing.Size(79, 20);
            this.lblNumder.TabIndex = 20;
            this.lblNumder.Text = "Телефон";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(17, 366);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(421, 26);
            this.tbEmail.TabIndex = 21;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 341);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(163, 20);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Электронный адрес";
            // 
            // mtbINN
            // 
            this.mtbINN.Location = new System.Drawing.Point(13, 312);
            this.mtbINN.Mask = "000000000000";
            this.mtbINN.Name = "mtbINN";
            this.mtbINN.Size = new System.Drawing.Size(196, 26);
            this.mtbINN.TabIndex = 23;
            // 
            // mtbNum
            // 
            this.mtbNum.Location = new System.Drawing.Point(259, 312);
            this.mtbNum.Mask = "00000000000";
            this.mtbNum.Name = "mtbNum";
            this.mtbNum.Size = new System.Drawing.Size(175, 26);
            this.mtbNum.TabIndex = 24;
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(12, 146);
            this.tbOtch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(421, 26);
            this.tbOtch.TabIndex = 26;
            // 
            // lblOtch
            // 
            this.lblOtch.AutoSize = true;
            this.lblOtch.Location = new System.Drawing.Point(13, 121);
            this.lblOtch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtch.Name = "lblOtch";
            this.lblOtch.Size = new System.Drawing.Size(83, 20);
            this.lblOtch.TabIndex = 25;
            this.lblOtch.Text = "Отчество";
            // 
            // LicenziatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 453);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(this.lblOtch);
            this.Controls.Add(this.mtbNum);
            this.Controls.Add(this.mtbINN);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblNumder);
            this.Controls.Add(this.lblInn);
            this.Controls.Add(this.tbAdresFact);
            this.Controls.Add(this.tbAdresRegs);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblAdresFact);
            this.Controls.Add(this.lblAdresRegs);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.lblFam);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LicenziatForm";
            this.Text = "Лицензиат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFam;
        public System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAdresRegs;
        private System.Windows.Forms.Label lblAdresFact;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbAdresRegs;
        public System.Windows.Forms.TextBox tbAdresFact;
        private System.Windows.Forms.Label lblInn;
        private System.Windows.Forms.Label lblNumder;
        public System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.MaskedTextBox mtbINN;
        public System.Windows.Forms.MaskedTextBox mtbNum;
        public System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.Label lblOtch;
    }
}