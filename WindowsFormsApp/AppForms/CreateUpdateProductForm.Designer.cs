namespace Cosmetic.AppForms
{
    partial class CreateUpdateProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label articleLabel;
            System.Windows.Forms.Label productNameIdLabel;
            System.Windows.Forms.Label unitOfMeasureIdLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label maxProductDiscountAmountLabel;
            System.Windows.Forms.Label manufacturerIdLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label productQuantityInStockLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label photoLabel;
            this.medvedeva_vy_cosmeticDataSet = new Cosmetic.medvedeva_vy_cosmeticDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.TableAdapterManager();
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.productNameIdComboBox = new System.Windows.Forms.ComboBox();
            this.productNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitOfMeasureIdComboBox = new System.Windows.Forms.ComboBox();
            this.unitOfMeasureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.maxProductDiscountAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.manufacturerIdComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productQuantityInStockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.productNameTableAdapter = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.ProductNameTableAdapter();
            this.unitOfMeasureTableAdapter = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.UnitOfMeasureTableAdapter();
            this.manufacturerTableAdapter = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.ManufacturerTableAdapter();
            this.supplierTableAdapter = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.SupplierTableAdapter();
            this.categoryTableAdapter = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.CategoryTableAdapter();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            articleLabel = new System.Windows.Forms.Label();
            productNameIdLabel = new System.Windows.Forms.Label();
            unitOfMeasureIdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            maxProductDiscountAmountLabel = new System.Windows.Forms.Label();
            manufacturerIdLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            productQuantityInStockLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medvedeva_vy_cosmeticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxProductDiscountAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityInStockNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.openFileDialogButton);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2.Controls.Add(articleLabel);
            this.splitContainer1.Panel2.Controls.Add(this.articleTextBox);
            this.splitContainer1.Panel2.Controls.Add(productNameIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.productNameIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(unitOfMeasureIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.unitOfMeasureIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(priceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.priceTextBox);
            this.splitContainer1.Panel2.Controls.Add(maxProductDiscountAmountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.maxProductDiscountAmountNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(manufacturerIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.manufacturerIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(supplierIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.supplierIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(categoryIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.categoryIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(discountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.discountNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(productQuantityInStockLabel);
            this.splitContainer1.Panel2.Controls.Add(this.productQuantityInStockNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(photoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.photoTextBox);
            // 
            // articleLabel
            // 
            articleLabel.AutoSize = true;
            articleLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            articleLabel.Location = new System.Drawing.Point(315, 85);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new System.Drawing.Size(68, 19);
            articleLabel.TabIndex = 0;
            articleLabel.Text = "Артикул:";
            // 
            // productNameIdLabel
            // 
            productNameIdLabel.AutoSize = true;
            productNameIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            productNameIdLabel.Location = new System.Drawing.Point(315, 114);
            productNameIdLabel.Name = "productNameIdLabel";
            productNameIdLabel.Size = new System.Drawing.Size(160, 19);
            productNameIdLabel.TabIndex = 2;
            productNameIdLabel.Text = "Наименование товара:";
            // 
            // unitOfMeasureIdLabel
            // 
            unitOfMeasureIdLabel.AutoSize = true;
            unitOfMeasureIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            unitOfMeasureIdLabel.Location = new System.Drawing.Point(315, 143);
            unitOfMeasureIdLabel.Name = "unitOfMeasureIdLabel";
            unitOfMeasureIdLabel.Size = new System.Drawing.Size(148, 19);
            unitOfMeasureIdLabel.TabIndex = 4;
            unitOfMeasureIdLabel.Text = "Единица измерения:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            priceLabel.Location = new System.Drawing.Point(315, 172);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(47, 19);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Цена:";
            // 
            // maxProductDiscountAmountLabel
            // 
            maxProductDiscountAmountLabel.AutoSize = true;
            maxProductDiscountAmountLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            maxProductDiscountAmountLabel.Location = new System.Drawing.Point(315, 200);
            maxProductDiscountAmountLabel.Name = "maxProductDiscountAmountLabel";
            maxProductDiscountAmountLabel.Size = new System.Drawing.Size(280, 19);
            maxProductDiscountAmountLabel.TabIndex = 8;
            maxProductDiscountAmountLabel.Text = "Размер максимально возможной скидки:";
            // 
            // manufacturerIdLabel
            // 
            manufacturerIdLabel.AutoSize = true;
            manufacturerIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            manufacturerIdLabel.Location = new System.Drawing.Point(315, 230);
            manufacturerIdLabel.Name = "manufacturerIdLabel";
            manufacturerIdLabel.Size = new System.Drawing.Size(119, 19);
            manufacturerIdLabel.TabIndex = 10;
            manufacturerIdLabel.Text = "Производитель:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            supplierIdLabel.Location = new System.Drawing.Point(315, 259);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(89, 19);
            supplierIdLabel.TabIndex = 12;
            supplierIdLabel.Text = "Поставщик:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            categoryIdLabel.Location = new System.Drawing.Point(315, 288);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(129, 19);
            categoryIdLabel.TabIndex = 14;
            categoryIdLabel.Text = "Категория товара:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            discountLabel.Location = new System.Drawing.Point(315, 316);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(156, 19);
            discountLabel.TabIndex = 16;
            discountLabel.Text = "Действующая скидка:";
            // 
            // productQuantityInStockLabel
            // 
            productQuantityInStockLabel.AutoSize = true;
            productQuantityInStockLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            productQuantityInStockLabel.Location = new System.Drawing.Point(315, 343);
            productQuantityInStockLabel.Name = "productQuantityInStockLabel";
            productQuantityInStockLabel.Size = new System.Drawing.Size(128, 19);
            productQuantityInStockLabel.TabIndex = 18;
            productQuantityInStockLabel.Text = "Кол-во на складе:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            descriptionLabel.Location = new System.Drawing.Point(315, 375);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(81, 19);
            descriptionLabel.TabIndex = 20;
            descriptionLabel.Text = "Описание:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            photoLabel.Location = new System.Drawing.Point(315, 404);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(101, 19);
            photoLabel.TabIndex = 22;
            photoLabel.Text = "Изображение:";
            // 
            // medvedeva_vy_cosmeticDataSet
            // 
            this.medvedeva_vy_cosmeticDataSet.DataSetName = "medvedeva_vy_cosmeticDataSet";
            this.medvedeva_vy_cosmeticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.medvedeva_vy_cosmeticDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OfficeTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderStatusTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProductNameTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // articleTextBox
            // 
            this.articleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Article", true));
            this.articleTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.articleTextBox.Location = new System.Drawing.Point(600, 81);
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(340, 26);
            this.articleTextBox.TabIndex = 1;
            this.articleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateGeneral);
            // 
            // productNameIdComboBox
            // 
            this.productNameIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductNameId", true));
            this.productNameIdComboBox.DataSource = this.productNameBindingSource;
            this.productNameIdComboBox.DisplayMember = "ProductName";
            this.productNameIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameIdComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.productNameIdComboBox.FormattingEnabled = true;
            this.productNameIdComboBox.Location = new System.Drawing.Point(600, 110);
            this.productNameIdComboBox.Name = "productNameIdComboBox";
            this.productNameIdComboBox.Size = new System.Drawing.Size(340, 26);
            this.productNameIdComboBox.TabIndex = 3;
            this.productNameIdComboBox.ValueMember = "IdProductName";
            this.productNameIdComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateGeneral);
            // 
            // productNameBindingSource
            // 
            this.productNameBindingSource.DataMember = "ProductName";
            this.productNameBindingSource.DataSource = this.medvedeva_vy_cosmeticDataSet;
            // 
            // unitOfMeasureIdComboBox
            // 
            this.unitOfMeasureIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "UnitOfMeasureId", true));
            this.unitOfMeasureIdComboBox.DataSource = this.unitOfMeasureBindingSource;
            this.unitOfMeasureIdComboBox.DisplayMember = "UnitOfMeasureName";
            this.unitOfMeasureIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitOfMeasureIdComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.unitOfMeasureIdComboBox.FormattingEnabled = true;
            this.unitOfMeasureIdComboBox.Location = new System.Drawing.Point(600, 139);
            this.unitOfMeasureIdComboBox.Name = "unitOfMeasureIdComboBox";
            this.unitOfMeasureIdComboBox.Size = new System.Drawing.Size(340, 26);
            this.unitOfMeasureIdComboBox.TabIndex = 5;
            this.unitOfMeasureIdComboBox.ValueMember = "IdUnitOfMeasure";
            this.unitOfMeasureIdComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateGeneral);
            // 
            // unitOfMeasureBindingSource
            // 
            this.unitOfMeasureBindingSource.DataMember = "UnitOfMeasure";
            this.unitOfMeasureBindingSource.DataSource = this.medvedeva_vy_cosmeticDataSet;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.priceTextBox.Location = new System.Drawing.Point(600, 168);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(340, 26);
            this.priceTextBox.TabIndex = 7;
            this.priceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.priceTextBox_Validating);
            // 
            // maxProductDiscountAmountNumericUpDown
            // 
            this.maxProductDiscountAmountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "MaxProductDiscountAmount", true));
            this.maxProductDiscountAmountNumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.maxProductDiscountAmountNumericUpDown.Location = new System.Drawing.Point(600, 197);
            this.maxProductDiscountAmountNumericUpDown.Name = "maxProductDiscountAmountNumericUpDown";
            this.maxProductDiscountAmountNumericUpDown.ReadOnly = true;
            this.maxProductDiscountAmountNumericUpDown.Size = new System.Drawing.Size(340, 26);
            this.maxProductDiscountAmountNumericUpDown.TabIndex = 9;
            this.maxProductDiscountAmountNumericUpDown.ValueChanged += new System.EventHandler(this.maxProductDiscountAmountNumericUpDown_ValueChanged);
            // 
            // manufacturerIdComboBox
            // 
            this.manufacturerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ManufacturerId", true));
            this.manufacturerIdComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerIdComboBox.DisplayMember = "ManufacturerName";
            this.manufacturerIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerIdComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.manufacturerIdComboBox.FormattingEnabled = true;
            this.manufacturerIdComboBox.Location = new System.Drawing.Point(600, 226);
            this.manufacturerIdComboBox.Name = "manufacturerIdComboBox";
            this.manufacturerIdComboBox.Size = new System.Drawing.Size(340, 26);
            this.manufacturerIdComboBox.TabIndex = 11;
            this.manufacturerIdComboBox.ValueMember = "IdManufacturer";
            this.manufacturerIdComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateGeneral);
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.medvedeva_vy_cosmeticDataSet;
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "SupplierId", true));
            this.supplierIdComboBox.DataSource = this.supplierBindingSource;
            this.supplierIdComboBox.DisplayMember = "SupplierName";
            this.supplierIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierIdComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(600, 255);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(340, 26);
            this.supplierIdComboBox.TabIndex = 13;
            this.supplierIdComboBox.ValueMember = "IdSupplier";
            this.supplierIdComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateGeneral);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.medvedeva_vy_cosmeticDataSet;
            // 
            // categoryIdComboBox
            // 
            this.categoryIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryId", true));
            this.categoryIdComboBox.DataSource = this.categoryBindingSource;
            this.categoryIdComboBox.DisplayMember = "CategoryName";
            this.categoryIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryIdComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.categoryIdComboBox.FormattingEnabled = true;
            this.categoryIdComboBox.Location = new System.Drawing.Point(600, 284);
            this.categoryIdComboBox.Name = "categoryIdComboBox";
            this.categoryIdComboBox.Size = new System.Drawing.Size(340, 26);
            this.categoryIdComboBox.TabIndex = 15;
            this.categoryIdComboBox.ValueMember = "IdCategory";
            this.categoryIdComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateGeneral);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.medvedeva_vy_cosmeticDataSet;
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Discount", true));
            this.discountNumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.discountNumericUpDown.Location = new System.Drawing.Point(600, 313);
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.ReadOnly = true;
            this.discountNumericUpDown.Size = new System.Drawing.Size(340, 26);
            this.discountNumericUpDown.TabIndex = 17;
            // 
            // productQuantityInStockNumericUpDown
            // 
            this.productQuantityInStockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ProductQuantityInStock", true));
            this.productQuantityInStockNumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.productQuantityInStockNumericUpDown.Location = new System.Drawing.Point(600, 342);
            this.productQuantityInStockNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.productQuantityInStockNumericUpDown.Name = "productQuantityInStockNumericUpDown";
            this.productQuantityInStockNumericUpDown.ReadOnly = true;
            this.productQuantityInStockNumericUpDown.Size = new System.Drawing.Size(340, 26);
            this.productQuantityInStockNumericUpDown.TabIndex = 19;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.descriptionTextBox.Location = new System.Drawing.Point(600, 371);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(340, 26);
            this.descriptionTextBox.TabIndex = 21;
            this.descriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateGeneral);
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Photo", true));
            this.photoTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.photoTextBox.Location = new System.Drawing.Point(600, 400);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.ReadOnly = true;
            this.photoTextBox.Size = new System.Drawing.Size(235, 26);
            this.photoTextBox.TabIndex = 23;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.buttonSave.Location = new System.Drawing.Point(319, 444);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(621, 29);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // productNameTableAdapter
            // 
            this.productNameTableAdapter.ClearBeforeFill = true;
            // 
            // unitOfMeasureTableAdapter
            // 
            this.unitOfMeasureTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(841, 400);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(99, 26);
            this.openFileDialogButton.TabIndex = 25;
            this.openFileDialogButton.Text = "Файл";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(476, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 29);
            this.button1.TabIndex = 26;
            this.button1.Text = "Удалить товар";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateUpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 737);
            this.Name = "CreateUpdateProductForm";
            this.Text = "CreateUpdateProductForm";
            this.Load += new System.EventHandler(this.CreateUpdateProductForm_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medvedeva_vy_cosmeticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxProductDiscountAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityInStockNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private medvedeva_vy_cosmeticDataSet medvedeva_vy_cosmeticDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private medvedeva_vy_cosmeticDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private medvedeva_vy_cosmeticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox articleTextBox;
        private System.Windows.Forms.ComboBox productNameIdComboBox;
        private System.Windows.Forms.ComboBox unitOfMeasureIdComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.NumericUpDown maxProductDiscountAmountNumericUpDown;
        private System.Windows.Forms.ComboBox manufacturerIdComboBox;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private System.Windows.Forms.ComboBox categoryIdComboBox;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown;
        private System.Windows.Forms.NumericUpDown productQuantityInStockNumericUpDown;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource productNameBindingSource;
        private medvedeva_vy_cosmeticDataSetTableAdapters.ProductNameTableAdapter productNameTableAdapter;
        private System.Windows.Forms.BindingSource unitOfMeasureBindingSource;
        private medvedeva_vy_cosmeticDataSetTableAdapters.UnitOfMeasureTableAdapter unitOfMeasureTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private medvedeva_vy_cosmeticDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private medvedeva_vy_cosmeticDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private medvedeva_vy_cosmeticDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button openFileDialogButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}