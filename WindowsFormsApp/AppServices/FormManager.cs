using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmetic.AppServices
{
    internal class FormManager
    {
        private static ErrorProvider _errorProvider {  get; set; } = new ErrorProvider();

        public static ErrorProvider ErrorProvider { get { return _errorProvider; } }

        public static void PrepareForm(string title, bool showLogoutButton = true)
        {
            ContextManager.parentForm.SetFullNameAndRole();
            ContextManager.parentForm.SetTitle(title);
            if (showLogoutButton )
            {
                ContextManager.parentForm.ShowLogoutButton();
            }
        }

        /// Универсальная проверка поля
        public static void ValidateGeneral(object sender, CancelEventArgs e)
        {
            Control control = (Control)sender;
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                e.Cancel = true; // PKGH Предотвратить потерю фокуса.
                _errorProvider.SetError(control, "Введите корректные данные!"); // PKGH показать подсказку.
            }
            else
            {
                _errorProvider.SetError(control, null); // PKGH Пользователь исправился (он ввел данные), теперь надо очистить сообщение об ошибке.
            }
        }
    }
}
