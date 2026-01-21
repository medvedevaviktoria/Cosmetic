namespace Cosmetic.AppForms
{
    partial class CreateUpdateOrderForm
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
            System.Windows.Forms.Label idOrderLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label orderDeliveryDateLabel;
            System.Windows.Forms.Label officeIdLabel;
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label orderStatusIdLabel;
            this.medvedeva_vy_cosmeticDataSet = new Cosmetic.medvedeva_vy_cosmeticDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.TableAdapterManager();
            this.officeTableAdapter = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.OfficeTableAdapter();
            this.orderStatusTableAdapter = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.OrderStatusTableAdapter();
            this.userTableAdapter = new Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.UserTableAdapter();
            this.idOrderLabel1 = new System.Windows.Forms.Label();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderDeliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.officeIdComboBox = new System.Windows.Forms.ComboBox();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userIdComboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderStatusIdComboBox = new System.Windows.Forms.ComboBox();
            this.orderStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            idOrderLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            orderDeliveryDateLabel = new System.Windows.Forms.Label();
            officeIdLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            orderStatusIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medvedeva_vy_cosmeticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2.Controls.Add(idOrderLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idOrderLabel1);
            this.splitContainer1.Panel2.Controls.Add(orderDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.orderDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(orderDeliveryDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.orderDeliveryDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(officeIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.officeIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(userIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.userIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(orderStatusIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.orderStatusIdComboBox);
            // 
            // idOrderLabel
            // 
            idOrderLabel.AutoSize = true;
            idOrderLabel.Location = new System.Drawing.Point(435, 163);
            idOrderLabel.Name = "idOrderLabel";
            idOrderLabel.Size = new System.Drawing.Size(22, 15);
            idOrderLabel.TabIndex = 0;
            idOrderLabel.Text = "Id:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(435, 193);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(71, 15);
            orderDateLabel.TabIndex = 2;
            orderDateLabel.Text = "Дата заказа:";
            // 
            // orderDeliveryDateLabel
            // 
            orderDeliveryDateLabel.AutoSize = true;
            orderDeliveryDateLabel.Location = new System.Drawing.Point(435, 222);
            orderDeliveryDateLabel.Name = "orderDeliveryDateLabel";
            orderDeliveryDateLabel.Size = new System.Drawing.Size(123, 15);
            orderDeliveryDateLabel.TabIndex = 4;
            orderDeliveryDateLabel.Text = "Дата доставки заказа:";
            // 
            // officeIdLabel
            // 
            officeIdLabel.AutoSize = true;
            officeIdLabel.Location = new System.Drawing.Point(435, 250);
            officeIdLabel.Name = "officeIdLabel";
            officeIdLabel.Size = new System.Drawing.Size(125, 15);
            officeIdLabel.TabIndex = 6;
            officeIdLabel.Text = "Адрес пункта выдачи:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(435, 279);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(48, 15);
            userIdLabel.TabIndex = 8;
            userIdLabel.Text = "Клиент:";
            // 
            // orderStatusIdLabel
            // 
            orderStatusIdLabel.AutoSize = true;
            orderStatusIdLabel.Location = new System.Drawing.Point(435, 308);
            orderStatusIdLabel.Name = "orderStatusIdLabel";
            orderStatusIdLabel.Size = new System.Drawing.Size(81, 15);
            orderStatusIdLabel.TabIndex = 10;
            orderStatusIdLabel.Text = "Статус заказа:";
            // 
            // medvedeva_vy_cosmeticDataSet
            // 
            this.medvedeva_vy_cosmeticDataSet.DataSetName = "medvedeva_vy_cosmeticDataSet";
            this.medvedeva_vy_cosmeticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.medvedeva_vy_cosmeticDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OfficeTableAdapter = this.officeTableAdapter;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderStatusTableAdapter = this.orderStatusTableAdapter;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.ProductNameTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cosmetic.medvedeva_vy_cosmeticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // officeTableAdapter
            // 
            this.officeTableAdapter.ClearBeforeFill = true;
            // 
            // orderStatusTableAdapter
            // 
            this.orderStatusTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // idOrderLabel1
            // 
            this.idOrderLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "IdOrder", true));
            this.idOrderLabel1.Location = new System.Drawing.Point(576, 163);
            this.idOrderLabel1.Name = "idOrderLabel1";
            this.idOrderLabel1.Size = new System.Drawing.Size(200, 23);
            this.idOrderLabel1.TabIndex = 1;
            this.idOrderLabel1.Text = "--";
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(576, 189);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.orderDateDateTimePicker.TabIndex = 3;
            // 
            // orderDeliveryDateDateTimePicker
            // 
            this.orderDeliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderDeliveryDate", true));
            this.orderDeliveryDateDateTimePicker.Location = new System.Drawing.Point(576, 218);
            this.orderDeliveryDateDateTimePicker.Name = "orderDeliveryDateDateTimePicker";
            this.orderDeliveryDateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.orderDeliveryDateDateTimePicker.TabIndex = 5;
            this.orderDeliveryDateDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.orderDeliveryDateDateTimePicker_Validating);
            // 
            // officeIdComboBox
            // 
            this.officeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "OfficeId", true));
            this.officeIdComboBox.DataSource = this.officeBindingSource;
            this.officeIdComboBox.DisplayMember = "OfficeAddress";
            this.officeIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeIdComboBox.FormattingEnabled = true;
            this.officeIdComboBox.Location = new System.Drawing.Point(576, 247);
            this.officeIdComboBox.Name = "officeIdComboBox";
            this.officeIdComboBox.Size = new System.Drawing.Size(200, 23);
            this.officeIdComboBox.TabIndex = 7;
            this.officeIdComboBox.ValueMember = "IdOffice";
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataMember = "Office";
            this.officeBindingSource.DataSource = this.medvedeva_vy_cosmeticDataSet;
            // 
            // userIdComboBox
            // 
            this.userIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "UserId", true));
            this.userIdComboBox.DataSource = this.userBindingSource;
            this.userIdComboBox.DisplayMember = "UserFullName";
            this.userIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userIdComboBox.FormattingEnabled = true;
            this.userIdComboBox.Location = new System.Drawing.Point(576, 276);
            this.userIdComboBox.Name = "userIdComboBox";
            this.userIdComboBox.Size = new System.Drawing.Size(200, 23);
            this.userIdComboBox.TabIndex = 9;
            this.userIdComboBox.ValueMember = "IdUser";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.medvedeva_vy_cosmeticDataSet;
            // 
            // orderStatusIdComboBox
            // 
            this.orderStatusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "OrderStatusId", true));
            this.orderStatusIdComboBox.DataSource = this.orderStatusBindingSource;
            this.orderStatusIdComboBox.DisplayMember = "OrderStatusName";
            this.orderStatusIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderStatusIdComboBox.FormattingEnabled = true;
            this.orderStatusIdComboBox.Location = new System.Drawing.Point(576, 305);
            this.orderStatusIdComboBox.Name = "orderStatusIdComboBox";
            this.orderStatusIdComboBox.Size = new System.Drawing.Size(200, 23);
            this.orderStatusIdComboBox.TabIndex = 11;
            this.orderStatusIdComboBox.ValueMember = "IdOrderStatus";
            // 
            // orderStatusBindingSource
            // 
            this.orderStatusBindingSource.DataMember = "OrderStatus";
            this.orderStatusBindingSource.DataSource = this.medvedeva_vy_cosmeticDataSet;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.buttonSave.Location = new System.Drawing.Point(438, 344);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(338, 29);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // CreateUpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 737);
            this.Name = "CreateUpdateOrderForm";
            this.Text = "CreateUpdateOrderForm";
            this.Load += new System.EventHandler(this.CreateUpdateOrderForm_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medvedeva_vy_cosmeticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private medvedeva_vy_cosmeticDataSet medvedeva_vy_cosmeticDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private medvedeva_vy_cosmeticDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private medvedeva_vy_cosmeticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idOrderLabel1;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker orderDeliveryDateDateTimePicker;
        private System.Windows.Forms.ComboBox officeIdComboBox;
        private System.Windows.Forms.ComboBox userIdComboBox;
        private System.Windows.Forms.ComboBox orderStatusIdComboBox;
        private medvedeva_vy_cosmeticDataSetTableAdapters.OfficeTableAdapter officeTableAdapter;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private medvedeva_vy_cosmeticDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private medvedeva_vy_cosmeticDataSetTableAdapters.OrderStatusTableAdapter orderStatusTableAdapter;
        private System.Windows.Forms.BindingSource orderStatusBindingSource;
        private System.Windows.Forms.Button buttonSave;
    }
}