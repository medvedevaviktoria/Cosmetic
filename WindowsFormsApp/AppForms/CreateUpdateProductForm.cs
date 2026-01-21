using Cosmetic.AppModels;
using Cosmetic.AppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public CreateUpdateProductForm(Product product)
        {
            InitializeComponent();
            _product = product;
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

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Исправьте ошибки в форме перед сохранением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string newFileName = SaveImage();
                photoTextBox.Text = newFileName;
                DeleteOldPhoto();
                FillModelFields();
                if (_product.IsNew())
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

        private void DeleteOldPhoto()
        {
            if (!string.IsNullOrEmpty(_product.Photo))
            {
                FileManager.DeleteFile(_product.Photo);
            }
        }

        private string SaveImage()
        {
            // PKGH Файл не выбирали, но нажали кнопку "Сохранить"
            if (string.IsNullOrEmpty(openFileDialog1.FileName) || openFileDialog1.FileName == "openFileDialog1")
            {
                return "";
            }
            
            Image originalImage = Image.FromFile(openFileDialog1.FileName);

            Dictionary<string, int> newImageSize = GetNewImageSize(originalImage);

            // PKGH Создаем изображение не более максимальных размеров.
            Bitmap resizedImage = new Bitmap(originalImage, newImageSize["width"], newImageSize["height"]);
            string fileName = Guid.NewGuid().ToString().Substring(0, 8) + ".jpg"; // PKGH Генерация уникального имени файла. Длина - 8 символов.
            string savePath = FileManager.GetImagePath(fileName);

            // PKGH Сохраняем изображение
            resizedImage.Save(savePath);
            // PKGH Освобождаем ресурсы
            originalImage.Dispose();
            resizedImage.Dispose();
            return fileName;
        }

        private Dictionary<string, int> GetNewImageSize(Image originalImage)
        {
            int maxWidth = 300;
            int maxHeight = 200;

            float ratioX = (float)maxWidth / originalImage.Width;
            float ratioY = (float)maxHeight / originalImage.Height;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalImage.Width * ratio);
            int newHeight = (int)(originalImage.Height * ratio);

            Dictionary<string, int> result = new Dictionary<string, int>();
            result.Add("width", newWidth);
            result.Add("height", newHeight);

            return result;
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

        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Изображения (*.jpg; *.jpeg)|*.jpg;*.jpeg";

            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                photoTextBox.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void ValidateGeneral(object sender, CancelEventArgs e)
        {
            FormManager.ValidateGeneral(sender, e);
        }

        private void priceTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormManager.ValidateGeneral(sender, e);

            Regex regex = new Regex(@"^\d+(\.\d{1,2})?$");
            CultureInfo culture = CultureInfo.InvariantCulture; // PKGH '.' - десятичный разделитель.
            float val;
            if (!regex.IsMatch(priceTextBox.Text))
            {
                e.Cancel = true; // PKGH Предотвратить потерю фокуса.
                FormManager.ErrorProvider.SetError(priceTextBox, "Допустимо неотрицательное число. Не более двух знаков после запятой. Десятичный разделитель - точка."); // PKGH показать подсказку.
            }
            else if (float.TryParse(priceTextBox.Text, NumberStyles.Float, culture, out val) && val == 0f)
            {
                e.Cancel = true; // PKGH Предотвратить потерю фокуса.
                FormManager.ErrorProvider.SetError(priceTextBox, "Вы бесплатно раздаете?"); // PKGH показать подсказку.
            }
        }
    }
}
