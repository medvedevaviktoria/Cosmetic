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
    public partial class CreateUpdateProductForm : ParentForm
    {
        private Product _product;
        public CreateUpdateProductForm()
        {
            InitializeComponent();
            _product = new Product();
        }

        private void CreateUpdateProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_cosmeticDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.medvedeva_vy_cosmeticDataSet.Category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_cosmeticDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.medvedeva_vy_cosmeticDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_cosmeticDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.medvedeva_vy_cosmeticDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_cosmeticDataSet.UnitOfMeasure". При необходимости она может быть перемещена или удалена.
            this.unitOfMeasureTableAdapter.Fill(this.medvedeva_vy_cosmeticDataSet.UnitOfMeasure);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medvedeva_vy_cosmeticDataSet.ProductName". При необходимости она может быть перемещена или удалена.
            this.productNameTableAdapter.Fill(this.medvedeva_vy_cosmeticDataSet.ProductName);
            FillForm();
        }

        private void FillForm()
        {
            articleTextBox.Text = _product.Article;
            productNameIdComboBox.SelectedValue = _product.ProductNameId;
            unitOfMeasureIdComboBox.SelectedValue= _product.UnitOfMeasureId;
            priceTextBox.Text = _product.Price.ToString("F2");
            maxProductDiscountAmountNumericUpDown.Value = _product.MaxProductDiscountAmount;
            manufacturerIdComboBox.SelectedValue = _product.ManufacturerId;
            supplierIdComboBox.SelectedValue = _product.SupplierId;
            categoryIdComboBox.SelectedValue = _product.CategoryId;
            discountNumericUpDown.Value = (decimal)_product.Discount;
            productQuantityInStockNumericUpDown.Value = _product.ProductQuantityInStock;
            descriptionTextBox.Text = _product.Description;
            photoTextBox.Text = _product.Photo;
        }

        private void CreateUpdateProductForm_Shown(object sender, EventArgs e)
        {
            FormManager.PrepareForm("Добавить/Редактировать товар", false);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                FillModelFields();
                if (_product.isNew())
                {
                    Program.context.Products.Add(_product);
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
            _product.Article = articleTextBox.Text;
            _product.ProductNameId = (int)productNameIdComboBox.SelectedValue;
            _product.UnitOfMeasureId = (int)unitOfMeasureIdComboBox.SelectedValue;
            float.TryParse(priceTextBox.Text, out float result);
            _product.Price = result;
            _product.MaxProductDiscountAmount = (int)maxProductDiscountAmountNumericUpDown.Value;
            _product.ManufacturerId = (int)manufacturerIdComboBox.SelectedValue;
            _product.SupplierId = (int)supplierIdComboBox.SelectedValue;
            _product.CategoryId = (int)categoryIdComboBox.SelectedValue;
            _product.Discount = (float)discountNumericUpDown.Value;
            _product.ProductQuantityInStock = (int)productQuantityInStockNumericUpDown.Value;
            _product.Description = descriptionTextBox.Text;
            _product.Photo = photoTextBox.Text;
        }
    }
}
