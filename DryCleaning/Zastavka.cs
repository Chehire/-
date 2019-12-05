using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DryCleaning
{
    public partial class Zastavka : Form
    {
        DataBase_Configuration data = new DataBase_Configuration();

        public Zastavka()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\DryCleaning.ico");
            Icon = iconForm;
        }

        private void constate(bool value)
        {
            Action action = () =>
            {
                switch (value)
                {
                    case (true):
                        SignInForm sign = new SignInForm();
                        Close();
                        sign.Show();
                        break;
                    case (false):
                        ConectionForm conection = new ConectionForm();
                        conection.Show();
                        timer1.Enabled = false;
                        this.Hide();
                    break;
                }
            };
            Invoke(action);
        }

        public void Zastavka_Load(object sender, EventArgs e)
        {
            data.conState += constate;
            Thread thread = new Thread(data.Connection_check);
            thread.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 17)
                progressBar1.Value++;
            else
                this.Close();
                
        }
    }
}
