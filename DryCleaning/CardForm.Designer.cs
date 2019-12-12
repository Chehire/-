namespace DryCleaning
{
    partial class CardForm
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
            this.cbLicenzia = new System.Windows.Forms.ComboBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.lblLicenzia = new System.Windows.Forms.Label();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.cbOrganization = new System.Windows.Forms.ComboBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblSotr = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbSotr = new System.Windows.Forms.ComboBox();
            this.lblDolj = new System.Windows.Forms.Label();
            this.tbDolj = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbLicenzia
            // 
            this.cbLicenzia.FormattingEnabled = true;
            this.cbLicenzia.Location = new System.Drawing.Point(12, 32);
            this.cbLicenzia.Name = "cbLicenzia";
            this.cbLicenzia.Size = new System.Drawing.Size(350, 28);
            this.cbLicenzia.TabIndex = 0;
            this.cbLicenzia.SelectedIndexChanged += new System.EventHandler(this.cbLicenzia_SelectedIndexChanged);
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(12, 140);
            this.tbCena.MaxLength = 7;
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(350, 26);
            this.tbCena.TabIndex = 1;
            // 
            // lblLicenzia
            // 
            this.lblLicenzia.AutoSize = true;
            this.lblLicenzia.Location = new System.Drawing.Point(12, 9);
            this.lblLicenzia.Name = "lblLicenzia";
            this.lblLicenzia.Size = new System.Drawing.Size(83, 20);
            this.lblLicenzia.TabIndex = 2;
            this.lblLicenzia.Text = "Лицензия";
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.Location = new System.Drawing.Point(12, 63);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(108, 20);
            this.lblOrganization.TabIndex = 3;
            this.lblOrganization.Text = "Организация";
            // 
            // cbOrganization
            // 
            this.cbOrganization.FormattingEnabled = true;
            this.cbOrganization.Location = new System.Drawing.Point(12, 86);
            this.cbOrganization.Name = "cbOrganization";
            this.cbOrganization.Size = new System.Drawing.Size(350, 28);
            this.cbOrganization.TabIndex = 4;
            this.cbOrganization.SelectedIndexChanged += new System.EventHandler(this.cbOrganization_SelectedIndexChanged);
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(12, 117);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(48, 20);
            this.lblCena.TabIndex = 42;
            this.lblCena.Text = "Цена";
            // 
            // lblSotr
            // 
            this.lblSotr.AutoSize = true;
            this.lblSotr.Location = new System.Drawing.Point(12, 221);
            this.lblSotr.Name = "lblSotr";
            this.lblSotr.Size = new System.Drawing.Size(91, 20);
            this.lblSotr.TabIndex = 44;
            this.lblSotr.Text = "Сотрудник";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 36);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(126, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 36);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(258, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 36);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbSotr
            // 
            this.cbSotr.FormattingEnabled = true;
            this.cbSotr.Location = new System.Drawing.Point(12, 244);
            this.cbSotr.Name = "cbSotr";
            this.cbSotr.Size = new System.Drawing.Size(350, 28);
            this.cbSotr.TabIndex = 43;
            this.cbSotr.SelectedIndexChanged += new System.EventHandler(this.cbSotr_SelectedIndexChanged);
            // 
            // lblDolj
            // 
            this.lblDolj.AutoSize = true;
            this.lblDolj.Location = new System.Drawing.Point(12, 275);
            this.lblDolj.Name = "lblDolj";
            this.lblDolj.Size = new System.Drawing.Size(95, 20);
            this.lblDolj.TabIndex = 49;
            this.lblDolj.Text = "Должность";
            // 
            // tbDolj
            // 
            this.tbDolj.Location = new System.Drawing.Point(12, 298);
            this.tbDolj.Name = "tbDolj";
            this.tbDolj.ReadOnly = true;
            this.tbDolj.Size = new System.Drawing.Size(350, 26);
            this.tbDolj.TabIndex = 48;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(184, 192);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(178, 26);
            this.dtpDate.TabIndex = 39;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(12, 192);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(166, 26);
            this.mtbDate.TabIndex = 40;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(8, 169);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 41;
            this.lblDate.Text = "Дата";
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 378);
            this.Controls.Add(this.lblDolj);
            this.Controls.Add(this.tbDolj);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSotr);
            this.Controls.Add(this.cbSotr);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbOrganization);
            this.Controls.Add(this.lblOrganization);
            this.Controls.Add(this.lblLicenzia);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.cbLicenzia);
            this.Name = "CardForm";
            this.Text = "Карта учета НМА";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLicenzia;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblSotr;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.ComboBox cbLicenzia;
        public System.Windows.Forms.TextBox tbCena;
        public System.Windows.Forms.ComboBox cbOrganization;
        public System.Windows.Forms.ComboBox cbSotr;
        private System.Windows.Forms.Label lblDolj;
        public System.Windows.Forms.TextBox tbDolj;
        private System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.Label lblDate;
    }
}