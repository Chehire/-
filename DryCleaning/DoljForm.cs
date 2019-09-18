using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DryCleaning
{
    public partial class DoljForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public DoljForm()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\DryCleaning.ico");
            Icon = iconForm;
            lblName.Text = "Название должности";
            lblOklad.Text = "Оклад";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Dolj_Insert", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Dolj", tbName.Text);
                    sqlCommand.Parameters.AddWithValue("@Oklad", tbOklad.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Должность добавлена");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Должность не добавлена");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Dolj_Update", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Dolj", Program.ID_Position);
                    sqlCommand.Parameters.AddWithValue("@Dolj", tbName.Text);
                    sqlCommand.Parameters.AddWithValue("@Oklad", tbOklad.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Должность изменена");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Должность не изменена");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Dolj_Delete", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Dolj", Program.ID_Position);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Должность удалена");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Должность не удалена");
            }
        }
    }
}