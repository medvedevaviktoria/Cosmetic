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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            ContextManager.parentForm = this;
            HideLogoutButton();
        }

        private void HideLogoutButton()
        {
            buttonExit.Visible = false;
        }
        public void ShowLogoutButton()
        {
            buttonExit.Visible = true;
        }

        public void SetFullNameAndRole()
        {
            labelFIO.Text = ContextManager.user.UserFullName;
            labelRole.Text = ContextManager.user.Role.RoleName;
        }

        public void SetTitle(string title)
        {
            string tmpTilte = "ООО \"Красота\": " + title;
            this.Text = tmpTilte;
            labelHeader.Text = tmpTilte;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthManager.Logout(this);
        }
    }
}
