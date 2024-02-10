using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    internal static class Program
    {
        public static string ConnectionString { get; } = "Data Source= ..\\..\\Database\\PasswordManagerDB.db;";
        public static string DatabaseFilePath = "..\\..\\Database\\";
        public static string DatabaseFileName = "PasswordManagerDB.db";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
