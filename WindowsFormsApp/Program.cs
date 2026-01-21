using Cosmetic.AppForms;
using Cosmetic.AppModels;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    internal static class Program
    {
        public static ContextDB context = new ContextDB();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!context.Database.Exists())
            {
                MessageBox.Show("Ошибка соединения с базой данных", "Ошибка соединения с базой данных", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
