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
    public partial class CompanyForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public CompanyForm()
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
            lblName.Text = "Название организации";
            lblFullName.Text = "Полное назнание организации";
            lblAdresRegs.Text = "Адрес регистрации организации";
            lblAdresFact.Text = "Фактический адрес организации";
            lblInn.Text = "ИНН";
            lblNumder.Text = "Телефон организации";
            lblEmail.Text = "Электронный адрес организации";
            btnAdd.Text = "Добавить";
            btnUpdate.Text = "Изменить";
            btnDelete.Text = "Удалить";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Organization_Insert", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Name", tbName.Text);
                    sqlCommand.Parameters.AddWithValue("@Full_Name", tbFullName.Text);
                    sqlCommand.Parameters.AddWithValue("@Adres_Registr", tbAdresRegs.Text);
                    sqlCommand.Parameters.AddWithValue("@Fact_Adres", tbAdresFact.Text);
                    sqlCommand.Parameters.AddWithValue("@INN", mtbINN.Text);
                    sqlCommand.Parameters.AddWithValue("@Nomer_Organization", mtbNum.Text);
                    sqlCommand.Parameters.AddWithValue("@e_mail", tbEmail.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Компания добавлена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Компания не добавлена " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("Organization_Update", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Organization", Program.ID_Company);
                    sqlCommand.Parameters.AddWithValue("@Name", tbName.Text);
                    sqlCommand.Parameters.AddWithValue("@Full_Name", tbFullName.Text);
                    sqlCommand.Parameters.AddWithValue("@Adres_Registr", tbAdresRegs.Text);
                    sqlCommand.Parameters.AddWithValue("@Fact_Adres", tbAdresFact.Text);
                    sqlCommand.Parameters.AddWithValue("@INN", mtbINN.Text);
                    sqlCommand.Parameters.AddWithValue("@Nomer_Organization", mtbNum.Text);
                    sqlCommand.Parameters.AddWithValue("@e_mail", tbEmail.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Компания изменена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Компания не изменена " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("Organization_Delete", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Organization", Program.ID_Company);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Компания удалена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Компания не удалена " + ex.Message);
            }
        }

    }
}
