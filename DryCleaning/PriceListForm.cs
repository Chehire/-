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
    public partial class PriceListForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public PriceListForm()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\DryCleaning.ico");
            Icon = iconForm;
            lblService.Text = "Название услуги";
            lblPrice.Text = "Цена услуги";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Price_List_Insert", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Service_Name", tbNameService.Text);
                    sqlCommand.Parameters.AddWithValue("@Price", tbPrice.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Услуга добавлена");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Услуга не добавлена");
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
                    SqlCommand sqlCommand = new SqlCommand("Price_List_Update", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Service", Program.ID_Service);
                    sqlCommand.Parameters.AddWithValue("@Service_Name", tbNameService.Text);
                    sqlCommand.Parameters.AddWithValue("@Price", tbPrice.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Услуга изменена");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Услугане изменена");
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
                    SqlCommand sqlCommand = new SqlCommand("Price_List_Delete", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Service", Program.ID_Service);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Услуга удалена");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Услуга не удалена");
            }
        }
    }
}
