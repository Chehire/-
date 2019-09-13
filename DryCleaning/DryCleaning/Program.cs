using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DryCleaning
{
    static class Program
    {
        public static int ID_Position;
        public static int ID_Sotr;
        public static int ID_Dolj;
        public static int ID_Company=1;
        public static int ID_Service;
        public static int ID_Client;
        public static int ID_Check;
        public static int ID_Card;
        public static int ID_Licenziat;
        public static int ID_Licenzia;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Zastavka());
            Application.Run(new MainForm());
           // Application.Run(new SignInForm());

        }
    }
}
