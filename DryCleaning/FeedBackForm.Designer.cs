namespace DryCleaning
{
    partial class FeedBackForm
    {

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTema = new System.Windows.Forms.TextBox();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.Location = new System.Drawing.Point(18, 12);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(73, 22);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "От кого";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.Transparent;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTema.Location = new System.Drawing.Point(18, 54);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(62, 25);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Тема";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(92, 9);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(697, 26);
            this.tbFrom.TabIndex = 2;
            // 
            // tbTema
            // 
            this.tbTema.Location = new System.Drawing.Point(92, 54);
            this.tbTema.Name = "tbTema";
            this.tbTema.Size = new System.Drawing.Size(697, 26);
            this.tbTema.TabIndex = 3;
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(16, 89);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(770, 306);
            this.tbBody.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.Location = new System.Drawing.Point(12, 401);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(774, 40);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // FeedBackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.tbTema);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FeedBackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Письмо Разработчику";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.TextBox tbTema;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox tbFrom;
    }
}

