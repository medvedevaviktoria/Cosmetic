using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetic.AppServices
{
    internal class FormManager
    {

        public static void PrepareForm(string title, bool showLogoutButton = true)
        {
            ContextManager.parentForm.SetFullNameAndRole();
            ContextManager.parentForm.SetTitle(title);
            if (showLogoutButton )
            {
                ContextManager.parentForm.ShowLogoutButton();
            }
        }
    }
}
