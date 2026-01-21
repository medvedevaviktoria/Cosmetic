using Cosmetic.AppForms;
using Cosmetic.AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp;

namespace Cosmetic.AppServices
{
    internal class AuthManager
    {

        public static void Login(string login, string password)
        {
            var user = Program.context.Users
                .Where(u => u.Login == login && u.Password == password)
                .FirstOrDefault();

            if (user == null)
            {
                throw new Exception();
            }

            ContextManager.user = user;
            var productForm = new ProductForm();
            ContextManager.productForm.Show();
            ContextManager.loginForm.Hide();
        }

        public static void Logout(ParentForm form)
        {
            ContextManager.user = null;
            form.Hide();
            ContextManager.loginForm.Show();
        }
    }
}
