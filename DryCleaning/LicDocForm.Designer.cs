namespace DryCleaning
{
    partial class LicDocForm
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
            this.cbOrganization = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSotr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLicenziat = new System.Windows.Forms.ComboBox();
            this.cbLicenzia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cbOrganization
            // 
            this.cbOrganization.FormattingEnabled = true;
            this.cbOrganization.Location = new System.Drawing.Point(12, 32);
            this.cbOrganization.Name = "cbOrganization";
            this.cbOrganization.Size = new System.Drawing.Size(426, 28);
            this.cbOrganization.TabIndex = 0;
            this.cbOrganization.SelectedIndexChanged += new System.EventHandler(this.cbOrganization_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Организация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сотрудник";
            // 
            // cbSotr
            // 
            this.cbSotr.FormattingEnabled = true;
            this.cbSotr.Location = new System.Drawing.Point(12, 86);
            this.cbSotr.Name = "cbSotr";
            this.cbSotr.Size = new System.Drawing.Size(426, 28);
            this.cbSotr.TabIndex = 3;
            this.cbSotr.SelectedIndexChanged += new System.EventHandler(this.cbSotr_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Лицензиат";
            // 
            // cbLicenziat
            // 
            this.cbLicenziat.FormattingEnabled = true;
            this.cbLicenziat.Location = new System.Drawing.Point(12, 140);
            this.cbLicenziat.Name = "cbLicenziat";
            this.cbLicenziat.Size = new System.Drawing.Size(426, 28);
            this.cbLicenziat.TabIndex = 5;
            this.cbLicenziat.SelectedIndexChanged += new System.EventHandler(this.cbLicenziat_SelectedIndexChanged);
            // 
            // cbLicenzia
            // 
            this.cbLicenzia.FormattingEnabled = true;
            this.cbLicenzia.Location = new System.Drawing.Point(12, 194);
            this.cbLicenzia.Name = "cbLicenzia";
            this.cbLicenzia.Size = new System.Drawing.Size(426, 28);
            this.cbLicenzia.TabIndex = 6;
            this.cbLicenzia.SelectedIndexChanged += new System.EventHandler(this.cbLicenzia_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Лицензия";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(12, 248);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(426, 26);
            this.tbCena.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(239, 300);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(199, 26);
            this.dtpDate.TabIndex = 12;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 37);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(169, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 37);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(326, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 37);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(13, 300);
            this.mtbDate.Mask = "00.00.0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(200, 26);
            this.mtbDate.TabIndex = 16;
            // 
            // LicDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 381);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLicenzia);
            this.Controls.Add(this.cbLicenziat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSotr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOrganization);
            this.Name = "LicDocForm";
            this.Text = "Лицензионный договор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.ComboBox cbOrganization;
        public System.Windows.Forms.ComboBox cbSotr;
        public System.Windows.Forms.ComboBox cbLicenziat;
        public System.Windows.Forms.ComboBox cbLicenzia;
        public System.Windows.Forms.TextBox tbCena;
        public System.Windows.Forms.DateTimePicker dtpDate;
    }
}