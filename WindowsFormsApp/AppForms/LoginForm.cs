using Cosmetic.AppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmetic.AppForms
{
    public partial class LoginForm : ParentForm
    {
        public LoginForm()
        {
            InitializeComponent();
            ContextManager.loginForm = this;
            ContextManager.parentForm.SetTitle("Вход");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AuthManager.Login(textBoxLogin.Text.Trim(), textBoxPassword.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Введите данные правильно", "Введите данные правильно", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            AuthManager.Login("c", "c");
        }
    }
}
