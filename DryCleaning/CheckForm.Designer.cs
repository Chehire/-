namespace DryCleaning
{
    partial class CheckForm
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
            this.cbFIOKas = new System.Windows.Forms.ComboBox();
            this.lblFIOKas = new System.Windows.Forms.Label();
            this.nudKolichecstvo = new System.Windows.Forms.NumericUpDown();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.cbFIOCln = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolichecstvo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFIOKas
            // 
            this.cbFIOKas.FormattingEnabled = true;
            this.cbFIOKas.Location = new System.Drawing.Point(12, 32);
            this.cbFIOKas.Name = "cbFIOKas";
            this.cbFIOKas.Size = new System.Drawing.Size(441, 28);
            this.cbFIOKas.TabIndex = 1;
            this.cbFIOKas.SelectedIndexChanged += new System.EventHandler(this.cbFIOKas_SelectedIndexChanged);
            // 
            // lblFIOKas
            // 
            this.lblFIOKas.AutoSize = true;
            this.lblFIOKas.Location = new System.Drawing.Point(12, 9);
            this.lblFIOKas.Name = "lblFIOKas";
            this.lblFIOKas.Size = new System.Drawing.Size(113, 20);
            this.lblFIOKas.TabIndex = 2;
            this.lblFIOKas.Text = "ФИО Кассира";
            // 
            // nudKolichecstvo
            // 
            this.nudKolichecstvo.Location = new System.Drawing.Point(12, 140);
            this.nudKolichecstvo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKolichecstvo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolichecstvo.Name = "nudKolichecstvo";
            this.nudKolichecstvo.Size = new System.Drawing.Size(113, 26);
            this.nudKolichecstvo.TabIndex = 4;
            this.nudKolichecstvo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolichecstvo.ValueChanged += new System.EventHandler(this.nudKolichecstvo_ValueChanged);
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(12, 86);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(441, 28);
            this.cbService.TabIndex = 5;
            this.cbService.SelectedIndexChanged += new System.EventHandler(this.cbService_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(12, 63);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(60, 20);
            this.lblService.TabIndex = 7;
            this.lblService.Text = "Услуга";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(127, 117);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(58, 20);
            this.lblSum.TabIndex = 8;
            this.lblSum.Text = "Сумма";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(131, 140);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(322, 26);
            this.tbSum.TabIndex = 11;
            // 
            // cbFIOCln
            // 
            this.cbFIOCln.FormattingEnabled = true;
            this.cbFIOCln.Location = new System.Drawing.Point(12, 192);
            this.cbFIOCln.Name = "cbFIOCln";
            this.cbFIOCln.Size = new System.Drawing.Size(321, 28);
            this.cbFIOCln.TabIndex = 13;
            this.cbFIOCln.SelectedIndexChanged += new System.EventHandler(this.cbFIOCln_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "ФИО Клиента";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Провести";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddCheck_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(162, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 29);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateCheck_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(339, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = " Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteCheck_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(339, 192);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(34, 28);
            this.btnAddClient.TabIndex = 18;
            this.btnAddClient.Text = "button4";
            this.btnAddClient.UseVisualStyleBackColor = true;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(379, 192);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(34, 28);
            this.btnUpdateClient.TabIndex = 19;
            this.btnUpdateClient.Text = "button5";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(419, 192);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(34, 28);
            this.btnDeleteClient.TabIndex = 20;
            this.btnDeleteClient.Text = "button6";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 223);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 44;
            this.lblDate.Text = "Дата";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(270, 246);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(178, 26);
            this.dtpDate.TabIndex = 42;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(12, 246);
            this.mtbDate.Mask = "00/00/0000 00:00:00";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(166, 26);
            this.mtbDate.TabIndex = 43;
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 356);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFIOCln);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.nudKolichecstvo);
            this.Controls.Add(this.lblFIOKas);
            this.Controls.Add(this.cbFIOKas);
            this.Name = "CheckForm";
            this.Text = "Чек";
            ((System.ComponentModel.ISupportInitialize)(this.nudKolichecstvo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFIOKas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        public System.Windows.Forms.ComboBox cbFIOKas;
        public System.Windows.Forms.NumericUpDown nudKolichecstvo;
        public System.Windows.Forms.ComboBox cbService;
        public System.Windows.Forms.TextBox tbSum;
        public System.Windows.Forms.ComboBox cbFIOCln;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.MaskedTextBox mtbDate;
    }
}