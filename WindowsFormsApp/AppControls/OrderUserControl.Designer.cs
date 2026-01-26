namespace Cosmetic.AppControls
{
    partial class OrderUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.officeLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.orderIdlabel = new System.Windows.Forms.Label();
            this.labelSostav = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelPriceWithoutDiscount = new System.Windows.Forms.Label();
            this.labelPriceWithDiscount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deliveryDateLabel);
            this.panel1.Location = new System.Drawing.Point(620, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 133);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.order_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата доставки заказа";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.order_Click);
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.Location = new System.Drawing.Point(12, 52);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(100, 31);
            this.deliveryDateLabel.TabIndex = 5;
            this.deliveryDateLabel.Text = "Дата ";
            this.deliveryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deliveryDateLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelPriceWithDiscount);
            this.panel2.Controls.Add(this.labelPriceWithoutDiscount);
            this.panel2.Controls.Add(this.labelFIO);
            this.panel2.Controls.Add(this.labelSostav);
            this.panel2.Controls.Add(this.orderDateLabel);
            this.panel2.Controls.Add(this.officeLabel);
            this.panel2.Controls.Add(this.statusLabel);
            this.panel2.Controls.Add(this.orderIdlabel);
            this.panel2.Location = new System.Drawing.Point(7, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 162);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.order_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.buttonDelete.Location = new System.Drawing.Point(620, 140);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(133, 27);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(3, 44);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(75, 13);
            this.orderDateLabel.TabIndex = 3;
            this.orderDateLabel.Text = "Дата заказа:";
            this.orderDateLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // officeLabel
            // 
            this.officeLabel.AutoSize = true;
            this.officeLabel.Location = new System.Drawing.Point(3, 81);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(41, 13);
            this.officeLabel.TabIndex = 2;
            this.officeLabel.Text = "Адрес:";
            this.officeLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 63);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Статус:";
            this.statusLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // orderIdlabel
            // 
            this.orderIdlabel.AutoSize = true;
            this.orderIdlabel.Location = new System.Drawing.Point(3, 6);
            this.orderIdlabel.Name = "orderIdlabel";
            this.orderIdlabel.Size = new System.Drawing.Size(19, 13);
            this.orderIdlabel.TabIndex = 0;
            this.orderIdlabel.Text = "Id:";
            this.orderIdlabel.Click += new System.EventHandler(this.order_Click);
            // 
            // labelSostav
            // 
            this.labelSostav.AutoSize = true;
            this.labelSostav.Location = new System.Drawing.Point(3, 25);
            this.labelSostav.Name = "labelSostav";
            this.labelSostav.Size = new System.Drawing.Size(46, 13);
            this.labelSostav.TabIndex = 11;
            this.labelSostav.Text = "Состав:";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(3, 101);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 12;
            this.labelFIO.Text = "ФИО:";
            // 
            // labelPriceWithoutDiscount
            // 
            this.labelPriceWithoutDiscount.AutoSize = true;
            this.labelPriceWithoutDiscount.Location = new System.Drawing.Point(3, 119);
            this.labelPriceWithoutDiscount.Name = "labelPriceWithoutDiscount";
            this.labelPriceWithoutDiscount.Size = new System.Drawing.Size(99, 13);
            this.labelPriceWithoutDiscount.TabIndex = 13;
            this.labelPriceWithoutDiscount.Text = "Цена(без скидки):";
            // 
            // labelPriceWithDiscount
            // 
            this.labelPriceWithDiscount.AutoSize = true;
            this.labelPriceWithDiscount.Location = new System.Drawing.Point(3, 139);
            this.labelPriceWithDiscount.Name = "labelPriceWithDiscount";
            this.labelPriceWithDiscount.Size = new System.Drawing.Size(99, 13);
            this.labelPriceWithDiscount.TabIndex = 14;
            this.labelPriceWithDiscount.Text = "Цена(со скидкой):";
            // 
            // OrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDelete);
            this.Margin = new System.Windows.Forms.Padding(50, 0, 0, 20);
            this.Name = "OrderUserControl";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.Size = new System.Drawing.Size(762, 177);
            this.Click += new System.EventHandler(this.order_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label orderIdlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelPriceWithDiscount;
        private System.Windows.Forms.Label labelPriceWithoutDiscount;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelSostav;
    }
}
