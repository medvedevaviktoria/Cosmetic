namespace Cosmetic.AppControls
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOldPrice = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(20, 14);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(117, 115);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelPrice.Location = new System.Drawing.Point(4, 90);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 19);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Цена:";
            this.labelPrice.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelManufacturer.Location = new System.Drawing.Point(4, 64);
            this.labelManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(119, 19);
            this.labelManufacturer.TabIndex = 7;
            this.labelManufacturer.Text = "Производитель:";
            this.labelManufacturer.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelDescription.Location = new System.Drawing.Point(4, 35);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(124, 19);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Описание товара";
            this.labelDescription.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelName.Location = new System.Drawing.Point(4, 9);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(156, 19);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Наименование товара";
            this.labelName.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelOldPrice);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelManufacturer);
            this.panel1.Location = new System.Drawing.Point(161, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 115);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // labelOldPrice
            // 
            this.labelOldPrice.AutoSize = true;
            this.labelOldPrice.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOldPrice.ForeColor = System.Drawing.Color.Red;
            this.labelOldPrice.Location = new System.Drawing.Point(151, 90);
            this.labelOldPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOldPrice.Name = "labelOldPrice";
            this.labelOldPrice.Size = new System.Drawing.Size(39, 18);
            this.labelOldPrice.TabIndex = 10;
            this.labelOldPrice.Text = "Цена";
            this.labelOldPrice.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.buttonDelete.Location = new System.Drawing.Point(526, 79);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 30);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelDiscount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(838, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 115);
            this.panel2.TabIndex = 10;
            this.panel2.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // labelDiscount
            // 
            this.labelDiscount.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.labelDiscount.Location = new System.Drawing.Point(12, 54);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(110, 45);
            this.labelDiscount.TabIndex = 1;
            this.labelDiscount.Text = "%";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDiscount.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Размер скидки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.labelId.Location = new System.Drawing.Point(843, 130);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 15);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "id:";
            this.labelId.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxImage);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(988, 145);
            this.Click += new System.EventHandler(this.ProductUserControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelOldPrice;
    }
}
