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
    public partial class CreateUpdateOrderForm : ParentForm
    {
        private Order _order;
        public CreateUpdateOrderForm()
        {
            InitializeComponent();
            _order = new Order();
        }

        public CreateUpdateOrderForm(Order order)
        {
            InitializeComponent();
            orderDateDateTimePicker.Enabled = false;
            userIdComboBox.Enabled = false;
            officeIdComboBox.Enabled = false;
            _order = order;
        }

        private void FillForm()
        {
            idOrderLabel1.Text = _order.IdOrder.ToString();
            orderDateDateTimePicker.Value = _order.OrderDate;
            orderDeliveryDateDateTimePicker.Value = _order.OrderDeliveryDate;
            officeIdComboBox.SelectedValue = _order.OfficeId;
            userIdComboBox.SelectedValue = _order.UserId;
            orderStatusIdComboBox.SelectedValue = _order.OrderStatusId;
        }

        private void CreateUpdateOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_cosmeticDataSet.OrderStatus". При необходимости она может быть перемещена или удалена.
            this.orderStatusTableAdapter.Fill(this.medvedeva_vy_cosmeticDataSet.OrderStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_cosmeticDataSet.Office". При необходимости она может быть перемещена или удалена.
            this.officeTableAdapter.Fill(this.medvedeva_vy_cosmeticDataSet.Office);

            string[] excludedValues = { "a", "b", "c"};
            userBindingSource.DataSource = Program.context.Users.Where(u => !excludedValues.Contains(u.UserFullName)).ToList();
            if (!_order.IsNew())
            {
                FillForm();
            }
        }

        private int GenerateNextReceiptCode()
        {
            Order order = Program.context.Orders.OrderByDescending(o => o.Code).FirstOrDefault();
            return order.Code + 1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Иcправьте ошибки в форме перед сохранением.", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillModelFields();
            try
            {
                if (_order.IsNew())
                {
                    Program.context.Orders.Add(_order);
                }
                Program.context.SaveChanges();
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillModelFields()
        {
            _order.UserId = (int)userIdComboBox.SelectedValue;
            _order.OrderDate = orderDateDateTimePicker.Value;
            _order.OfficeId = (int)officeIdComboBox.SelectedValue;
            _order.OrderDeliveryDate = orderDeliveryDateDateTimePicker.Value;
            _order.OrderStatusId = (int)orderStatusIdComboBox.SelectedValue;
            _order.Code = GenerateNextReceiptCode();
        }

        private void orderDeliveryDateDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (orderDeliveryDateDateTimePicker.Value.Date < orderDateDateTimePicker.Value.Date)
            {
                e.Cancel = true; // PKGH Предотвратить потерю фокуса.
                FormManager.ErrorProvider.SetError(orderDeliveryDateDateTimePicker, "Дата выдачи не может быть меньше даты заказа!");
            }
            else
            {
                FormManager.ErrorProvider.SetError(orderDateDateTimePicker, null);
            }

        }
    }
}
