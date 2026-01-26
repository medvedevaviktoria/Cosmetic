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
        private List<Order> _orders;
        public OrderForm()
        {
            InitializeComponent();
            ContextManager.orderForm = this;
            comboBoxDiscount.SelectedIndex = 0;
            ShowAdvancedPanel();
        }

        private void ShowAdvancedPanel()
        {
            advancedPanel.Visible = (ContextManager.user.IsAdmin() || ContextManager.user.IsManager());
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
            SelectOrders();
            ShowOrders();
        }

        private void SelectOrders()
        {
            var tmpOrders = Program.context.Orders.ToList();

            if (comboBoxDiscount.SelectedIndex > 0)
            {
                switch (comboBoxDiscount.SelectedIndex)
                {
                    case 1:
                        tmpOrders = tmpOrders.Where(o => o.TotalDiscountPercent < 10).ToList();
                        break;
                    case 2:
                        tmpOrders = tmpOrders.Where(o => o.TotalDiscountPercent >= 10 && o.TotalDiscountPercent < 15).ToList();
                        break;
                    case 3:
                        tmpOrders = tmpOrders.Where(o => o.TotalDiscountPercent >= 15).ToList();
                        break;
                }
            }



            bool lessInput = radioButtonLess.Checked;
            if (lessInput)
            {
                tmpOrders = tmpOrders.OrderBy(o => o.TotalPriceWithDiscount).ToList(); ;
            }
            else
            {
                tmpOrders = tmpOrders.OrderByDescending(o => o.TotalPriceWithDiscount).ToList(); ;
            }

            _orders = tmpOrders;
        }

        private void ShowOrders()
        {
            foreach (Order order in _orders)
            {
                flowLayoutPanel1.Controls.Add(new OrderUserControl(order));
            }
        }

        private void ClearOrders()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void radioButtonLess_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void radioButtonMore_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
