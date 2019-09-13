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
    public partial class LicenziatForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public LicenziatForm()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            ////this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            ////Icon iconForm = new Icon(Application.StartupPath + "\\img\\icoApp.ico");
            //Icon = iconForm;
            UpdateForm();
        }

        private void UpdateForm()
        {
            lblFam.Text = "Фамилия";
            lblName.Text = "Имя";
            lblOtch.Text = "Отчество";
            lblAdresRegs.Text = "Адрес регистрации";
            lblAdresFact.Text = "Фактический адрес";
            lblInn.Text = "ИНН";
            lblNumder.Text = "Телефон";
            lblEmail.Text = "Электронный адрес";
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
                    SqlCommand sqlCommand = new SqlCommand("Licenziat_Insert", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Fam_Licenziat", tbFam.Text);
                    sqlCommand.Parameters.AddWithValue("@Name_Licenziat", tbName.Text);
                    sqlCommand.Parameters.AddWithValue("@Otch_Licenziat", tbOtch.Text); 
                    sqlCommand.Parameters.AddWithValue("@Adres_Licenziat", tbAdresRegs.Text);
                    sqlCommand.Parameters.AddWithValue("@Fact_Adres", tbAdresFact.Text);
                    sqlCommand.Parameters.AddWithValue("@INN_Licenziat", mtbINN.Text);
                    sqlCommand.Parameters.AddWithValue("@Nomer_Licenziat", mtbNum.Text);
                    sqlCommand.Parameters.AddWithValue("@e_mail_Licenziat", tbEmail.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Лицензиат добавлен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Лицензиат не добавлен " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("Licenziat_Update", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Licenziat", Program.ID_Licenziat);
                    sqlCommand.Parameters.AddWithValue("@Fam_Licenziat", tbFam.Text);
                    sqlCommand.Parameters.AddWithValue("@Name_Licenziat", tbName.Text);
                    sqlCommand.Parameters.AddWithValue("@Otch_Licenziat", tbOtch.Text);
                    sqlCommand.Parameters.AddWithValue("@Adres_Licenziat", tbAdresRegs.Text);
                    sqlCommand.Parameters.AddWithValue("@Fact_Adres", tbAdresFact.Text);
                    sqlCommand.Parameters.AddWithValue("@INN_Licenziat", mtbINN.Text);
                    sqlCommand.Parameters.AddWithValue("@Nomer_Licenziat", mtbNum.Text);
                    sqlCommand.Parameters.AddWithValue("@e_mail_Licenziat", tbEmail.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Лицензиат изменен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Лицензиат не изменен " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("Licenziat_Delete", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Licenziat", Program.ID_Licenziat);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Лицензиат удален");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Лицензиат не удален " + ex.Message);
            }
        }

    }
}
