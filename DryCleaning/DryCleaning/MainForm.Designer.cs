namespace DryCleaning
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВыводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ВыходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doljToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenziatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ОбновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.licdocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ФайлToolStripMenuItem,
            this.dirToolStripMenuItem,
            this.ОбновитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1206, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ФайлToolStripMenuItem
            // 
            this.ФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ВыводToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ВыходToolStripMenuItem});
            this.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem";
            this.ФайлToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.ФайлToolStripMenuItem.Text = "Файл";
            // 
            // ВыводToolStripMenuItem
            // 
            this.ВыводToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.wordToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.ВыводToolStripMenuItem.Name = "ВыводToolStripMenuItem";
            this.ВыводToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.ВыводToolStripMenuItem.Text = "Вывод";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.ExcelToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.WordToolStripMenuItem_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.PDFToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.signOutToolStripMenuItem.Text = "Выход из учетной записи";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.SigOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(299, 6);
            // 
            // ВыходToolStripMenuItem
            // 
            this.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem";
            this.ВыходToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.ВыходToolStripMenuItem.Text = "Выход";
            this.ВыходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // dirToolStripMenuItem
            // 
            this.dirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doljToolStripMenuItem,
            this.employeeListToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.checkToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.licenziaToolStripMenuItem,
            this.cardToolStripMenuItem,
            this.licenziatToolStripMenuItem,
            this.licdocToolStripMenuItem});
            this.dirToolStripMenuItem.Name = "dirToolStripMenuItem";
            this.dirToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.dirToolStripMenuItem.Text = "Справочники";
            // 
            // doljToolStripMenuItem
            // 
            this.doljToolStripMenuItem.Name = "doljToolStripMenuItem";
            this.doljToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.doljToolStripMenuItem.Text = "Список должностей";
            this.doljToolStripMenuItem.Click += new System.EventHandler(this.DoljToolStripMenuItem_Click);
            // 
            // employeeListToolStripMenuItem
            // 
            this.employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            this.employeeListToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.employeeListToolStripMenuItem.Text = "Список сотрудников";
            this.employeeListToolStripMenuItem.Click += new System.EventHandler(this.EmployeeListToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.serviceToolStripMenuItem.Text = "Список услуг";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.ServiceToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.clientToolStripMenuItem.Text = "Список клиентов";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.checkToolStripMenuItem.Text = "Список чеков";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.companyToolStripMenuItem.Text = "Данные организации";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.CompanyToolStripMenuItem_Click);
            // 
            // licenziaToolStripMenuItem
            // 
            this.licenziaToolStripMenuItem.Name = "licenziaToolStripMenuItem";
            this.licenziaToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.licenziaToolStripMenuItem.Text = "Список лицензий";
            this.licenziaToolStripMenuItem.Click += new System.EventHandler(this.LicenziaToolStripMenuItem_Click);
            // 
            // cardToolStripMenuItem
            // 
            this.cardToolStripMenuItem.Name = "cardToolStripMenuItem";
            this.cardToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.cardToolStripMenuItem.Text = "Список карт учета НМА";
            this.cardToolStripMenuItem.Click += new System.EventHandler(this.CardToolStripMenuItem_Click);
            // 
            // licenziatToolStripMenuItem
            // 
            this.licenziatToolStripMenuItem.Name = "licenziatToolStripMenuItem";
            this.licenziatToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.licenziatToolStripMenuItem.Text = "Список лицензиатов";
            this.licenziatToolStripMenuItem.Click += new System.EventHandler(this.LicenziatToolStripMenuItem_Click);
            // 
            // ОбновитьToolStripMenuItem
            // 
            this.ОбновитьToolStripMenuItem.Name = "ОбновитьToolStripMenuItem";
            this.ОбновитьToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.ОбновитьToolStripMenuItem.Text = "Обновить";
            this.ОбновитьToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 403);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.changeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 64);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.changeToolStripMenuItem.Text = "Изменить";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.ChangeToolStripMenuItem_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(76, 38);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(400, 30);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(14, 45);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 20);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Поиск";
            // 
            // licdocToolStripMenuItem
            // 
            this.licdocToolStripMenuItem.Name = "licdocToolStripMenuItem";
            this.licdocToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.licdocToolStripMenuItem.Text = "Список лицензионных договоров";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 510);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ВыходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem dirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doljToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenziatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenziaToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ToolStripMenuItem ОбновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВыводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeListToolStripMenuItem;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ToolStripMenuItem licdocToolStripMenuItem;
    }
}

