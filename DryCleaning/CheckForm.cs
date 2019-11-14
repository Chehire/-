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
    public partial class CheckForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        int Cena;

        public CheckForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\DryCleaning.ico");
            Icon = iconForm;
            tbSum.Text = (Cena * nudKolichecstvo.Value).ToString();
            ShowComboBox();
            mtbDate.Text = dtpDate.Value.ToString();
        }

        private void ShowComboBox()
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    cbFIOKas.DataSource = database.TableFill("select [Fam_Sotr]+' '+[Name_Sotr]+' ' +[Otch_Sotr] as FIOSotr from [dbo].[Sotr] where [Dolj_ID]  = '4'", sqlConnect).Tables[0];
                    cbFIOKas.DisplayMember = "FIOSotr";
                    cbService.DataSource = database.TableFill("select Service_Name as Service from Price_List", sqlConnect).Tables[0];
                    cbService.DisplayMember = "Service";
                    cbFIOCln.DataSource = database.TableFill("select  [Fam_Client]+' '+[Name_Client]+' ' +[Otch_Client] +' '+ [Nomer_Client] as FIOCl from [dbo].[Client]", sqlConnect).Tables[0];
                    cbFIOCln.DisplayMember = "FIOCl";
                }
            }
            catch
            {
            }
        }

        private void cbFIOKas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Sotr] from [dbo].[Sotr] where [Fam_Sotr]+' '+[Name_Sotr]+' ' +[Otch_Sotr] = '{cbFIOKas.Text}'", sqlConnect);
                    Program.ID_Sotr = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch
            {
            }
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Service] from [dbo].[Price_List] where [Service_Name] = '{cbService.Text}'", sqlConnect);
                    Program.ID_Service = (int)sqlCommand.ExecuteScalar();
                    var command = new SqlCommand($"select [Price] from [dbo].[Price_List] where [Service_Name] = '{cbService.Text}'", sqlConnect);
                    Cena = (int)command.ExecuteScalar();
                }
            }
            catch
            {
            }
            tbSum.Text = (Cena * nudKolichecstvo.Value).ToString();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            mtbDate.Text = dtpDate.Value.ToString();
        }

        private void nudKolichecstvo_ValueChanged(object sender, EventArgs e)
        {
            tbSum.Text = (Cena * nudKolichecstvo.Value).ToString();
        }

        private void cbFIOCln_SelectedIndexChanged(object sender, EventArgs e)     
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Client] from [dbo].[Client] where [Fam_Client]+' '+[Name_Client]+' ' +[Otch_Client]+' '+[Nomer_Client] = '{cbFIOCln.Text}'", sqlConnect);
                    Program.ID_Client = (int)sqlCommand.ExecuteScalar();
                }
            }
            catch
            {
            }
        }

        private void btnAddCheck_Click(object sender, EventArgs e)
        {           
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Check_Insert", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Sotr_ID", Program.ID_Sotr);
                    sqlCommand.Parameters.AddWithValue("@Service_ID", Program.ID_Service);
                    sqlCommand.Parameters.AddWithValue("@Kolichestvo", nudKolichecstvo.Value);
                    sqlCommand.Parameters.AddWithValue("@Sum", Convert.ToInt32(tbSum.Text));
                    sqlCommand.Parameters.AddWithValue("@Date", Convert.ToDateTime(mtbDate.Text));
                    sqlCommand.Parameters.AddWithValue("@Client_ID", Program.ID_Client);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Чек добавлен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Чек не добавлен " + ex.Message);
            }
        }

        private void btnUpdateCheck_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {   
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Check_Update", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Check", Program.ID_Check);
                    sqlCommand.Parameters.AddWithValue("@Sotr_ID", Program.ID_Sotr);
                    sqlCommand.Parameters.AddWithValue("@Service_ID", Program.ID_Service);
                    sqlCommand.Parameters.AddWithValue("@Kolichestvo", nudKolichecstvo.Value);
                    sqlCommand.Parameters.AddWithValue("@Sum", Convert.ToInt32(tbSum.Text));
                    sqlCommand.Parameters.AddWithValue("@Date", Convert.ToDateTime(mtbDate.Text)); 
                    sqlCommand.Parameters.AddWithValue("@Client_ID", Program.ID_Client);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Чек изменен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Чек не изменен " + ex.Message);
            }
        }

        private void btnDeleteCheck_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Check_Delete", sqlConnect);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Check", Program.ID_Check);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Чек удален");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Чек не удален");
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientForm Client = new ClientForm();
            Client.btnUpdate.Enabled = false;
            Client.btnDelete.Enabled = false;
            Client.ShowDialog();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {   
            string FamCl = "",
                   NameCl="",
                   OtchCl="",
                   NumCl="";
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Client] from [dbo].[Client] where [Fam_Client]+' '+[Name_Client]+' ' +[Otch_Client] +' '+[Nomer_Client] = '{cbFIOCln.Text}'", sqlConnect);
                    Program.ID_Client = (int)sqlCommand.ExecuteScalar();
                    SqlCommand sqlFam = new SqlCommand($"select [Fam_Client] from [dbo].[Client] where [ID_Client] = '{Program.ID_Client.ToString()}'", sqlConnect);
                    FamCl = (string)sqlFam.ExecuteScalar();
                    SqlCommand sqlName = new SqlCommand($"select [Name_Client] from [dbo].[Client] where [ID_Client] = '{Program.ID_Client.ToString()}'", sqlConnect);
                    NameCl = (string)sqlName.ExecuteScalar();
                    SqlCommand sqlNum = new SqlCommand($"select [Nomer_Client] from [dbo].[Client] where [ID_Client] = '{Program.ID_Client.ToString()}'", sqlConnect);
                    NumCl = (string)sqlNum.ExecuteScalar();
                    SqlCommand sqlOtch = new SqlCommand($"select [Otch_Client] from [dbo].[Client] where [ID_Client] = '{Program.ID_Client.ToString()}'", sqlConnect);
                    OtchCl = (string)sqlOtch.ExecuteScalar();
                }
            }
            catch
            {
            }
            ClientForm Client = new ClientForm();
            Client.btnAdd.Enabled = false;
            Client.btnUpdate.Enabled = true;
            Client.btnDelete.Enabled = false;
            Client.tbFam.Text = (FamCl);
            Client.tbName.Text = (NameCl);
            Client.tbOtch.Text = (OtchCl);
            Client.mtbNum.Text = (NumCl);
            Client.ShowDialog();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            ClientForm Client = new ClientForm();
            Client.btnAdd.Enabled = false;
            Client.btnUpdate.Enabled = false;
            Client.btnDelete.Enabled = true;
            Client.ShowDialog();
        }
    }
    
}
