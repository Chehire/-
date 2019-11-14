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
    public partial class CardForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        string Sotr;
        public CardForm()
        {
            this.TopMost = true;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\DryCleaning.ico");
            Icon = iconForm;
            ShowComboBox();
        }

        private void ShowComboBox()
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    cbLicenzia.DataSource = database.TableFill("select [Licenzia_Name] as Lisenzia from [dbo].[Licenzii]", sqlConnect).Tables[0];
                    cbLicenzia.DisplayMember = "Lisenzia";
                    cbSotr.DataSource = database.TableFill("select [Fam_Sotr]+' '+[Name_Sotr]+' ' +[Otch_Sotr] as FIOSotr from [dbo].[Sotr] where [Dolj_ID]  = '3'", sqlConnect).Tables[0];
                    cbSotr.DisplayMember = "FIOSotr";
                    cbOrganization.DataSource = database.TableFill("select [Full_Name] as Organization from [dbo].[Organization]", sqlConnect).Tables[0];
                    cbOrganization.DisplayMember = "Organization";
                }
            }
            catch { }
        }

        private void cbLicenzia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Licenzia] from [dbo].[Licenzii] where [Licenzia_Name] =  '{cbLicenzia.Text}'", sqlConnect);
                    Program.ID_Licenzia = (int)sqlCommand.ExecuteScalar();

                }
            }
            catch
            {
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
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Organization] from [dbo].[Organization] where [Full_Name] =  '{cbOrganization.Text}'", sqlConnect);
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
                    SqlCommand sqlCommand = new SqlCommand($"select [ID] from [dbo].[View_Sotr] where [Фамилия]+' '+[Имя]+' '+[Отчество] = '{cbSotr.Text}'", sqlConnect);
                    Program.ID_Sotr= (int)sqlCommand.ExecuteScalar();
                    var command = new SqlCommand($"select [Должность] from [dbo].[View_Sotr] where [Фамилия]+' '+[Имя]+' '+[Отчество] = '{cbSotr.Text}'", sqlConnect);
                    Sotr = (string)command.ExecuteScalar();
                    tbDolj.Text = Sotr;
                }
            }
            catch
            {
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
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
                    SqlCommand sqlCommand = new SqlCommand("Card_Insert", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Licenzia_ID", Program.ID_Licenzia);
                    sqlCommand.Parameters.AddWithValue("@Organization_ID", Program.ID_Company);
                    sqlCommand.Parameters.AddWithValue("@Cena", Convert.ToInt64(tbCena.Text));
                    sqlCommand.Parameters.AddWithValue("@Date", Convert.ToDateTime(mtbDate.Text).ToShortDateString());
                    sqlCommand.Parameters.AddWithValue("@Sotr_ID", Program.ID_Sotr);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Карта добавлена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Карта не добавлена" + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("Card_Update", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Card", Program.ID_Card);
                    sqlCommand.Parameters.AddWithValue("@Licenzia_ID", Program.ID_Licenzia);
                    sqlCommand.Parameters.AddWithValue("@Organization_ID", Program.ID_Company);
                    sqlCommand.Parameters.AddWithValue("@Cena", Convert.ToInt32(tbCena.Text));
                    sqlCommand.Parameters.AddWithValue("@Date", Convert.ToDateTime(mtbDate.Text).ToShortDateString());
                    sqlCommand.Parameters.AddWithValue("@Sotr_ID", Program.ID_Sotr);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Карта изменена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Карта не изменена" + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("Card_Delete", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Card", Program.ID_Card);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Карта удалена");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Карта не удалена");
            }
        }
    }
 }
    
