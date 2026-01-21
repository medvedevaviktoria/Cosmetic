using Cosmetic.AppConstants;
using Cosmetic.AppForms;
using Cosmetic.AppModels;
using Cosmetic.AppServices;
using System;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp;

namespace Cosmetic.AppControls
{
    public partial class ProductUserControl : UserControl
    {
        private Product _product; 
        public ProductUserControl(Product product)
        {
            InitializeComponent();
            ShowDeleteButton();
            _product = product;
            ShowProductInfo();
            HighlightGreatDiscount();
        }

        private void HighlightGreatDiscount()
        {
            if (_product.Discount > 15)
            {
                this.BackColor = ColorTranslator.FromHtml("#7fff00");
            }
        }

        private void ShowProductInfo()
        {
            labelName.Text = _product.ProductName.ProductName1;
            labelDescription.Text = _product.Description;
            labelManufacturer.Text = $"Производитель: {_product.Manufacturer.ManufacturerName}";
            labelOldPrice.Text = GetOldPrice();
            labelPrice.Text = GetPrice();
            labelId.Text = $"id: {_product.IdProduct}";
            pictureBoxImage.Image = GetImage();
            labelDiscount.Text = $"{_product.Discount} %";
        }

        private string GetOldPrice()
        {
            if (_product.Discount > 0)
            {
                return $"{_product.Price} руб.";
            }
            else return "";
        }

        private string GetPrice()
        {
            double tmpPrice = _product.Price;

            if (_product.Discount > 0)
            {
                tmpPrice = _product.Price * ((100 - _product.Discount) / 100);
            }
            return $"Цена: {tmpPrice:F2} руб.";
        }

        private void ShowDeleteButton()
        {
            buttonDelete.Visible = ContextManager.user.IsAdmin();
        }

        private Image GetImage()
        {
            Image img;
            try
            {
                img = new Bitmap(Image.FromFile(FileManager.GetImagePath(_product.Photo)));
            }
            catch (FileNotFoundException ex)
            {
                img = Image.FromFile(FileManager.GetImagePath(FilePath.defaultPicture));
            }
            return img;
        }

        private void ProductUserControl_Click(object sender, EventArgs e)
        {
            if (!ContextManager.user.IsAdmin())
            {
                return;
            }
            
            CreateUpdateProductForm сreateUpdateProductForm = new CreateUpdateProductForm(_product);

            DialogResult saved = сreateUpdateProductForm.ShowDialog();
            if (saved == DialogResult.OK)
            {
                ContextManager.productForm.RefreshList();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult toBeDeleted = MessageBox.Show("Удалить?", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if (toBeDeleted == DialogResult.OK)
            {
                Product product = Program.context.Products.Where(p => p.IdProduct == _product.IdProduct).FirstOrDefault();

                try
                {
                    Program.context.Products.Remove(_product);
                    Program.context.SaveChanges();
                    ContextManager.productForm.RefreshList();
                    FileManager.DeleteFile(_product.Photo);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Товар заказан. Его нельзя удалить.", "Товар заказан. Его нельзя удалить.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
