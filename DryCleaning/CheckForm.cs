using System;
using System.Data;
using System.Drawing;
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
            ShowCombobox();
            tbSum.Text = (Cena * nudKolichecstvo.Value).ToString();
            mtbDate.Text = dtpDate.Value.ToString();
            
        }

        private void ShowCombobox()
        {
            database.DatabaseSQL().Open();
            cbFIOKas.DataSource = database.TableFill("select [Fam_Sotr]+' '+[Name_Sotr]+' ' +[Otch_Sotr] as Kassir from [dbo].[Sotr] where [Dolj_ID]  = '4'", database.DatabaseSQL()).Tables[0];
            cbFIOKas.DisplayMember = "Kassir";
            cbService.DataSource = database.TableFill("select [Service_Name] as Service from [Price_List]", database.DatabaseSQL()).Tables[0];
            cbService.DisplayMember = "Service";
            cbFIOCln.DataSource = database.TableFill("select  [Fam_Client]+' '+[Name_Client]+' ' +[Otch_Client] +' '+[Nomer_Client] as Client from [dbo].[Client]", database.DatabaseSQL()).Tables[0];
            cbFIOCln.DisplayMember = "Client";
            database.DatabaseSQL().Close();

        }

        private void cbFIOKas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                database.DatabaseSQL().Open();
                SqlCommand sqlCommand = new SqlCommand($"select [ID_Sotr] from [dbo].[Sotr] where [Fam_Sotr]+' '+[Name_Sotr]+' ' +[Otch_Sotr] = '{cbFIOKas.Text}'", database.DatabaseSQL());
                Program.ID_Sotr = (int)sqlCommand.ExecuteScalar();
                database.DatabaseSQL().Close();
        }
            catch
            {
            }
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                database.DatabaseSQL().Open();
                SqlCommand sqlCommand = new SqlCommand($"select [ID_Service] from [dbo].[Price_List] where [Service_Name] = '{cbService.Text}'", database.DatabaseSQL());
                Program.ID_Service = (int)sqlCommand.ExecuteScalar();
                var command = new SqlCommand($"select [Price] from [dbo].[Price_List] where [Service_Name] = '{cbService.Text}'", database.DatabaseSQL());
                Cena = (int)command.ExecuteScalar();
                database.DatabaseSQL().Close();
            }
            catch
            {
            }
            tbSum.Text = (Cena * nudKolichecstvo.Value).ToString();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            mtbDate.Text = dtpDate.Value.ToShortDateString()+dtpDate.Value.ToLongTimeString();
        }

        private void nudKolichecstvo_ValueChanged(object sender, EventArgs e)
        {
            tbSum.Text = (Cena * nudKolichecstvo.Value).ToString();
        }

        private void cbFIOCln_SelectedIndexChanged(object sender, EventArgs e)     
        {
            try
            {
                database.DatabaseSQL().Open();
                {
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Client] from [dbo].[Client] where [Fam_Client]+' '+[Name_Client]+' ' +[Otch_Client]+' '+[Nomer_Client] = '{cbFIOCln.Text}'", database.DatabaseSQL());
                    Program.ID_Client = (int)sqlCommand.ExecuteScalar();
                }
                database.DatabaseSQL().Close();
            }
            catch
            {
            }
        }

        private void btnAddCheck_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            {
                try
                { 
                    SqlCommand sqlCommand = new SqlCommand("Check_Insert", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Sotr_ID", Program.ID_Sotr);
                    sqlCommand.Parameters.AddWithValue("@Service_ID", Program.ID_Service);
                    sqlCommand.Parameters.AddWithValue("@Kolichestvo", nudKolichecstvo.Value);
                    sqlCommand.Parameters.AddWithValue("@Sum", Convert.ToInt32(tbSum.Text));
                    sqlCommand.Parameters.AddWithValue("@Date", Convert.ToDateTime(mtbDate.Text));
                    sqlCommand.Parameters.AddWithValue("@Client_ID", Program.ID_Client);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Чек добавлен");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Чек не добавлен " + ex.Message);
                }
            }
            database.DatabaseSQL().Close();
        }

        private void btnUpdateCheck_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            {
                try
                {

                    SqlCommand sqlCommand = new SqlCommand("Check_Update", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Check", Program.ID_Check);
                    sqlCommand.Parameters.AddWithValue("@Sotr_ID", Program.ID_Sotr);
                    sqlCommand.Parameters.AddWithValue("@Service_ID", Program.ID_Service);
                    sqlCommand.Parameters.AddWithValue("@Kolichestvo", nudKolichecstvo.Value);
                    sqlCommand.Parameters.AddWithValue("@Sum", Convert.ToInt32(tbSum.Text));
                    sqlCommand.Parameters.AddWithValue("@Date", Convert.ToDateTime(mtbDate.Text));
                    sqlCommand.Parameters.AddWithValue("@Client_ID", Program.ID_Client);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Чек изменен");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Чек не изменен " + ex.Message);
                }
                database.DatabaseSQL().Close();
            }
            
        }

        private void btnDeleteCheck_Click(object sender, EventArgs e)
        {

            database.DatabaseSQL().Open();
            {
                try
                {
                    if (Program.ID_Dolj == 1)
                    {
                        SqlCommand sqlCommand = new SqlCommand("Check_Delete", database.DatabaseSQL());
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@ID_Check", Program.ID_Check);
                        sqlCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand sqlCommand = new SqlCommand("Check_Logical_Delete", database.DatabaseSQL());
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@ID_Check", Program.ID_Check);
                        sqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Чек удален");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Чек не удален" + ex.Message);
                }
                database.DatabaseSQL().Close();
            }
            
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientForm Client = new ClientForm();
            Client.btnUpdate.Enabled = false;
            Client.btnDelete.Enabled = false;
            Client.ShowDialog();
            ShowCombobox();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {   
            string FamCl = "",
                   NameCl="",
                   OtchCl="",
                   NumCl="";
            database.DatabaseSQL().Open();
            {
                    SqlCommand sqlCommand = new SqlCommand($"select [ID_Client] from [dbo].[Client] where [Fam_Client]+' '+[Name_Client]+' ' +[Otch_Client] +' '+[Nomer_Client] = '{cbFIOCln.Text}'", database.DatabaseSQL());
                    Program.ID_Client = (int)sqlCommand.ExecuteScalar();
                    SqlCommand sqlFam = new SqlCommand($"select [Fam_Client] from [dbo].[Client] where [ID_Client] = '{Program.ID_Client.ToString()}'", database.DatabaseSQL());
                    FamCl = (string)sqlFam.ExecuteScalar();
                    SqlCommand sqlName = new SqlCommand($"select [Name_Client] from [dbo].[Client] where [ID_Client] = '{Program.ID_Client.ToString()}'", database.DatabaseSQL());
                    NameCl = (string)sqlName.ExecuteScalar();
                    SqlCommand sqlNum = new SqlCommand($"select [Nomer_Client] from [dbo].[Client] where [ID_Client] = '{Program.ID_Client.ToString()}'", database.DatabaseSQL());
                    NumCl = (string)sqlNum.ExecuteScalar();
                    SqlCommand sqlOtch = new SqlCommand($"select [Otch_Client] from [dbo].[Client] where [ID_Client] = '{Program.ID_Client.ToString()}'", database.DatabaseSQL());
                    OtchCl = (string)sqlOtch.ExecuteScalar();
            }
            database.DatabaseSQL().Close();
            ClientForm Client = new ClientForm();
            Client.btnAdd.Enabled = false;
            Client.btnUpdate.Enabled = true;
            Client.btnDelete.Enabled = false;
            Client.tbFam.Text = (FamCl);
            Client.tbName.Text = (NameCl);
            Client.tbOtch.Text = (OtchCl);
            Client.mtbNum.Text = (NumCl);
            Client.ShowDialog();
            ShowCombobox();

        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            ClientForm Client = new ClientForm();
            Client.btnAdd.Enabled = false;
            Client.btnUpdate.Enabled = false;
            Client.btnDelete.Enabled = true;
            Client.ShowDialog();
            ShowCombobox();
        }
    }
    
}
