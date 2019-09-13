namespace DryCleaning
{
    partial class PriceListForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.tbNameService = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(278, 144);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 46);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Location = new System.Drawing.Point(141, 144);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(45, 46);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(13, 27);
            this.lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(135, 20);
            this.lblService.TabIndex = 9;
            this.lblService.Text = "Название услуги";
            // 
            // tbNameService
            // 
            this.tbNameService.Location = new System.Drawing.Point(13, 52);
            this.tbNameService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNameService.Name = "tbNameService";
            this.tbNameService.Size = new System.Drawing.Size(310, 26);
            this.tbNameService.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(13, 144);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(13, 108);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(310, 26);
            this.tbPrice.TabIndex = 14;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 83);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(103, 20);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Цена Услуги";
            // 
            // PriceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 208);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.tbNameService);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PriceListForm";
            this.Text = "Прейскурант";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblService;
        public System.Windows.Forms.TextBox tbNameService;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}