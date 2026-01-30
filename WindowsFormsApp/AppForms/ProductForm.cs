using Cosmetic.AppControls;
using Cosmetic.AppModels;
using Cosmetic.AppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace Cosmetic.AppForms
{
    public partial class ProductForm : ParentForm
    {
        private List<Product> _products;
        public ProductForm()
        {
            InitializeComponent();
            ContextManager.productForm = this;
            comboBoxDiscount.SelectedIndex = 0;
            if (ContextManager.user != null)
            {
                ShowAddProductButton();
                ShowOrderButton();
                ShowAdvancedPanel();
            }
        }

        private void ShowAdvancedPanel()
        {
            advancedPanel.Visible = (ContextManager.user.IsAdmin() || ContextManager.user.IsManager());
        }

        private void ShowOrderButton()
        {
            buttonOrders.Visible = (ContextManager.user.IsAdmin() || ContextManager.user.IsManager());
        }

        private void ShowAddProductButton()
        {
            buttonAdd.Visible = ContextManager.user.IsAdmin();
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ProductForm_Shown(object sender, EventArgs e)
        {
            FormManager.PrepareForm("Товары");
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void SelectProducts()
        {
            string searchInput = textBoxSearch.Text.Trim();
            bool lessInput = radioButtonLess.Checked;

            IQueryable<Product> tmpProducts = Program.context.Products;

            if (!String.IsNullOrEmpty(searchInput))
            {
                tmpProducts = tmpProducts.Where(obj=> DbFunctions.Like(obj.ProductName.ProductName1, "%" + searchInput + "%"));
            }

            if (lessInput)
            {
                tmpProducts = tmpProducts.OrderBy(p => p.Price);
            }
            else
            {
                tmpProducts = tmpProducts.OrderByDescending(p => p.Price);
            }

            if (comboBoxDiscount.SelectedIndex > 0)
            {
                switch (comboBoxDiscount.SelectedIndex)
                {
                    case 1:
                        tmpProducts = tmpProducts.Where(p => p.Discount < 10);
                        break;
                    case 2:
                        tmpProducts = tmpProducts.Where(p => p.Discount >= 10 && p.Discount < 15);
                        break;
                    case 3:
                        tmpProducts = tmpProducts.Where(p => p.Discount >= 15);
                        break;
                }
            }

            labelCount.Text = $"Найдено: {tmpProducts.Count()} из {Program.context.Products.Count()}";

            _products = tmpProducts.ToList();
        }

        private void ShowProducts()
        {
            foreach (Product product in _products)
            {
                flowLayoutPanel1.Controls.Add(new ProductUserControl(product));
            }
        }

        private void ClearProducts()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        public void RefreshList()
        {
            ClearProducts();
            SelectProducts();
            ShowProducts();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void radioButtonMore_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void radioButtonLess_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreateUpdateProductForm createUpdateProductForm = new CreateUpdateProductForm();
            DialogResult saved = createUpdateProductForm.ShowDialog();
            if (saved == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }
    }
}
