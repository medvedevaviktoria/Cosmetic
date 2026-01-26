using Cosmetic.AppForms;
using Cosmetic.AppModels;
using Cosmetic.AppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace Cosmetic.AppControls
{
    public partial class OrderUserControl : UserControl
    {
        private Order _order;
        public OrderUserControl(Order order)
        {
            InitializeComponent();
            _order = order;
            ShowData();
            ShowDeleteButton();
        }

        private void ShowDeleteButton()
        {
            buttonDelete.Visible = ContextManager.user.IsAdmin();
        }

        private void ShowData()
        {
            orderIdlabel.Text = "ID: " + _order.IdOrder.ToString();
            deliveryDateLabel.Text = string.Format("{0:dd.MM.yyyy}", _order.OrderDeliveryDate); ;
            orderDateLabel.Text = "Дата заказа: " + string.Format("{0:dd.MM.yyyy}", _order.OrderDate);
            officeLabel.Text = $"Адрес пункта выдачи: {Program.context.Offices.Where(o => o.IdOffice == _order.OfficeId).FirstOrDefault().OfficeAddress}";
            statusLabel.Text = "Статус заказа: " + _order.OrderStatus.OrderStatusName;
            labelFIO.Text = $"ФИО: {_order.User.UserFullName}";
            GetOrderSostav();
            labelPriceWithoutDiscount.Text = "Цена(без скидки): " + _order.TotalPriceWithoutDiscount.ToString() + "руб.";
            labelPriceWithDiscount.Text = "Цена(со скидкой): " + _order.TotalPriceWithDiscount.ToString() + "руб.";
        }

        private void GetOrderSostav()
        {
            var tmpOrderProducts = Program.context.OrderProducts.Where(o => o.OrderId == _order.IdOrder).ToList();

            foreach (var orderProduct in tmpOrderProducts)
            {
                var product = orderProduct.Product;
                labelSostav.Text += $" | {product.ProductName.ProductName1} x{orderProduct.Amount} ";
            }
        }

        private void order_Click(object sender, EventArgs e)
        {
            if (!ContextManager.user.IsAdmin() && !ContextManager.user.IsManager())
            {
                return;
            }

            CreateUpdateOrderForm createUpdateOrderForm = new CreateUpdateOrderForm(_order);

            DialogResult saved = createUpdateOrderForm.ShowDialog();
            if (saved == DialogResult.OK)
            {
                ContextManager.orderForm.RefreshList();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult toBeDeleted = MessageBox.Show("Удалить?", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (toBeDeleted == DialogResult.OK)
            {
                Order order = Program.context.Orders.Where(o => o.IdOrder == _order.IdOrder).FirstOrDefault();
                try
                {
                    Program.context.Orders.Remove(_order);
                    Program.context.SaveChanges();
                    ContextManager.orderForm.RefreshList();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Не удалось удалить заказ.", " Не удалось удалить заказ.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}