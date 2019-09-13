namespace DryCleaning
{
    partial class ClientForm
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
            this.lblNum = new System.Windows.Forms.Label();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.lblOtch = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.lblFam = new System.Windows.Forms.Label();
            this.mtbNum = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(12, 186);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(95, 20);
            this.lblNum.TabIndex = 39;
            this.lblNum.Text = "Моб. номер";
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(13, 155);
            this.tbOtch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(331, 26);
            this.tbOtch.TabIndex = 38;
            this.tbOtch.Tag = "";
            // 
            // lblOtch
            // 
            this.lblOtch.AutoSize = true;
            this.lblOtch.Location = new System.Drawing.Point(13, 130);
            this.lblOtch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtch.Name = "lblOtch";
            this.lblOtch.Size = new System.Drawing.Size(83, 20);
            this.lblOtch.TabIndex = 37;
            this.lblOtch.Text = "Отчество";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 90);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(331, 26);
            this.tbName.TabIndex = 36;
            this.tbName.Tag = "";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 65);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 20);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Имя";
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(13, 34);
            this.tbFam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(331, 26);
            this.tbFam.TabIndex = 34;
            this.tbFam.Tag = "";
            // 
            // lblFam
            // 
            this.lblFam.AutoSize = true;
            this.lblFam.Location = new System.Drawing.Point(12, 9);
            this.lblFam.Name = "lblFam";
            this.lblFam.Size = new System.Drawing.Size(81, 20);
            this.lblFam.TabIndex = 33;
            this.lblFam.Text = "Фамилия";
            // 
            // mtbNum
            // 
            this.mtbNum.Location = new System.Drawing.Point(13, 209);
            this.mtbNum.Mask = "9990000000";
            this.mtbNum.Name = "mtbNum";
            this.mtbNum.Size = new System.Drawing.Size(331, 26);
            this.mtbNum.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 286);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtbNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(this.lblOtch);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.lblFam);
            this.Name = "ClientForm";
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblOtch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFam;
        public System.Windows.Forms.TextBox tbOtch;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbFam;
        public System.Windows.Forms.MaskedTextBox mtbNum;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
    }
}