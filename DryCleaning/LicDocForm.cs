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
    public partial class LicDocForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public LicDocForm()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            mtbDate.Text = dtpDate.Value.ToShortDateString();
            ShowCombobox();
        }

        private void ShowCombobox() 
        {
            var sqlConnection = database.DatabaseSQL();
            using (sqlConnection)
            {
                cbSotr.DataSource = database.TableFill("select [Fam_Sotr]+' '+[Name_Sotr]+' ' +[Otch_Sotr] as FIO from [dbo].[Sotr] where [Dolj_ID] = 2", sqlConnection).Tables[0];
                cbSotr.DisplayMember = "FIO";
                cbOrganization.DataSource = database.TableFill("select [Full_Name] as organization from [dbo].[organization]", sqlConnection).Tables[0];
                cbOrganization.DisplayMember = "organization";
                cbLicenziat.DataSource = database.TableFill("select [Fam_Licenziat]+' '+[Name_Licenziat]+' ' +[Otch_Licenziat] as FIOLic from [dbo].[Licenziat] ", sqlConnection).Tables[0];
                cbLicenziat.DisplayMember = "FIOLic";
                cbLicenzia.DataSource = database.TableFill("select [Licenzia_Name] as Licenzia from [Licenzii]", sqlConnection).Tables[0];
                cbLicenzia.DisplayMember = "Licenzia";
            }
        }

        private void cbOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Organization] from [dbo].[Organization] where [Full_Name] = '{cbOrganization.Text}'", sqlConnect);
                    Program.ID_Company = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch
            {
            }
        }

        private void cbSotr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Sotr] from [dbo].[Sotr] where [Fam_Sotr]+' '+[Name_Sotr]+' ' +[Otch_Sotr] = '{cbSotr.Text}'", sqlConnect);
                    Program.ID_Sotr = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch
            {
            }
        }

        private void cbLicenziat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Licenziat] from [dbo].[Licenziat] where [Fam_Licenziat]+' '+[Name_Licenziat]+' ' +[Otch_Licenziat] = '{cbLicenziat.Text}'", sqlConnect);
                    Program.ID_Licenziat = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch
            {
            }
        }

        private void cbLicenzia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Licenzia] from [dbo].[Licenzii] where [Licenzia_Name] = '{cbLicenzia.Text}'", sqlConnect);
                    Program.ID_Licenzia = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch
            {
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            mtbDate.Text = dtpDate.Value.ToShortDateString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("LicDoc_Insert", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Sotr_ID", Program.ID_Sotr);
                    sqlCommand.Parameters.AddWithValue("@Organization_ID", Program.ID_Company);
                    sqlCommand.Parameters.AddWithValue("@Licenziat_ID", Program.ID_Licenziat);
                    sqlCommand.Parameters.AddWithValue("@Cena", Convert.ToInt64(tbCena.Text));
                    sqlCommand.Parameters.AddWithValue("@Date",Convert.ToDateTime(mtbDate.Text));
                    sqlCommand.Parameters.AddWithValue("@Licenzia_ID", Program.ID_Licenzia);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Договор добавлен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Договор не добавлен " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("LicDoc_Update", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Doc", Program.ID_LicDoc);
                    sqlCommand.Parameters.AddWithValue("@Sotr_ID", Program.ID_Sotr);
                    sqlCommand.Parameters.AddWithValue("@Organization_ID", Program.ID_Company);
                    sqlCommand.Parameters.AddWithValue("@Licenziat_ID", Program.ID_Licenziat);
                    sqlCommand.Parameters.AddWithValue("@Cena", Convert.ToInt64(tbCena.Text));
                    sqlCommand.Parameters.AddWithValue("@Date", Convert.ToDateTime(mtbDate.Text));
                    sqlCommand.Parameters.AddWithValue("@Licenzia_ID", Program.ID_Licenzia);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Договор изменен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Договор не изменен " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("LicDoc_Delete", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Doc", Program.ID_Check);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Договор удален");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Договор не удален");
            }
        }
    }    
}
