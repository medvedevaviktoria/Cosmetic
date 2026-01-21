using Cosmetic.AppConstants;
using Cosmetic.AppModels;
using Cosmetic.AppServices;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
            buttonDelete.Visible = ContextManager.user.isAdmin();
        }

        private Image GetImage()
        {
            Image img;
            try
            {
                img = Image.FromFile(FileManager.GetImagePath(_product.Photo));
            }
            catch (FileNotFoundException ex)
            {
                img = Image.FromFile(FileManager.GetImagePath(FilePath.defaultPicture));
            }
            return img;
        }
    }
}
