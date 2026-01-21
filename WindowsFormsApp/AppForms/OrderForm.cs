using Cosmetic.AppControls;
using Cosmetic.AppModels;
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
using WindowsFormsApp;

namespace Cosmetic.AppForms
{
    public partial class OrderForm : ParentForm
    {
        public OrderForm()
        {
            InitializeComponent();
            ContextManager.orderForm = this;
            ShowAddOrderButton();
        }

        private void ShowAddOrderButton()
        {
            addOrderButton.Visible = ContextManager.user.IsAdmin();
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Shown(object sender, EventArgs e)
        {
            FormManager.PrepareForm("Заказы");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContextManager.productForm.Show();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            CreateUpdateOrderForm createUpdateOrder = new CreateUpdateOrderForm();
            DialogResult saved = createUpdateOrder.ShowDialog();

            if (saved == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            ClearOrders();
            ShowOrders();
        }

        private void ShowOrders()
        {
            List<Order> orders = Program.context.Orders.OrderBy(o => o.OrderDate).ToList();
            foreach (Order order in orders)
            {
                flowLayoutPanel1.Controls.Add(new OrderUserControl(order));
            }
        }

        private void ClearOrders()
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
