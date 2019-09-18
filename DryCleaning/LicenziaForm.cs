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
    public partial class LicenziaForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public LicenziaForm()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\DryCleaning.ico");
            Icon = iconForm;
            lblLicenzia.Text = "Лицензия";
            btnAdd.Text = "Добавить";
            btnUpdate.Text = "Изменить";
            btnDelete.Text = "Удалить";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Licenzii_Insert", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Licenzia_Name", tbLicenzia.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Лицензия добавлена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Лицензия не добавлена " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("Licenzii_Update", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Licenzia", Program.ID_Licenzia);
                    sqlCommand.Parameters.AddWithValue("@Licenzia_Name", tbLicenzia.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Лицензия изменена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Лицензия не изменена " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("Licenzii_Delete", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Licenzia", Program.ID_Licenzia);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Лицензия удалена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Лицензия не удалена " + ex.Message);
            }
        }
    }
}
