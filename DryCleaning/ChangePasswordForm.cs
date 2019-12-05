using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DryCleaning
{ 
    public partial class ChangePasswordForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public ChangePasswordForm()
        {
            InitializeComponent();
            lblNewPassword.Text = "Введите новый пароль";
            lblRepNewPassword.Text = "Повторите новый пароль";
            btnChangePassword.Text = "Сменить пароль";
            tbNewPassword.PasswordChar = '*';
            tbRepNewPassword.PasswordChar = '*';
        }

        private string GetHash(string input) //Хэширование пароля в БД
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                if (tbNewPassword.Text == tbRepNewPassword.Text)
                {
                    string passwordHash = GetHash(tbNewPassword.Text);
                    {
                        var sqlCommand = new SqlCommand("Sotr_Password_Update", database.DatabaseSQL());
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@Password_Sotr", passwordHash);
                        sqlCommand.Parameters.AddWithValue("@Login_Sotr", Program.Autoriz_Sotr);
                        sqlCommand.ExecuteNonQuery();

                    }
                    MessageBox.Show("Пароль изменен");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Парооль не изменен " + ex.Message);
            }
            database.DatabaseSQL().Close();

        }
    }
}
