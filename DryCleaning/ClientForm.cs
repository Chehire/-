using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DryCleaning
{
    public partial class ClientForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public ClientForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\DryCleaning.ico");
            Icon = iconForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Client_Insert", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Fam_Client", tbFam.Text);
                    sqlCommand.Parameters.AddWithValue("@Name_Client", tbName.Text);
                    sqlCommand.Parameters.AddWithValue("@Otch_Client", tbOtch.Text);
                    sqlCommand.Parameters.AddWithValue("@Nomer_Client", mtbNum.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Клиент добавлен");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Клиент не добавлен");
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
                    SqlCommand sqlCommand = new SqlCommand("Client_Update", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Client", Program.ID_Client);
                    sqlCommand.Parameters.AddWithValue("@Fam_Client", tbFam.Text);
                    sqlCommand.Parameters.AddWithValue("@Name_Client", tbName.Text);
                    sqlCommand.Parameters.AddWithValue("@Otch_Client", tbOtch.Text);
                    sqlCommand.Parameters.AddWithValue("@Nomer_Client", mtbNum.Text);
                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Клиент изменен");
                this.Hide();
            }

            catch
            {
                MessageBox.Show("Клиент не изменен");
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
                    SqlCommand sqlCommand = new SqlCommand("Client_Delete", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Client", Program.ID_Client);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Сотрудник удален");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Сотрудник не удален ");
            }
        }
    }
}
