using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DryCleaning
{
    public partial class Zastavka : Form
    {
        public Zastavka()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\DryCleaning.ico");
            Icon = iconForm;
        }
        int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            do
            {
                i++;
                this.Close();
            } while (i == 5);
        }
    }
}
