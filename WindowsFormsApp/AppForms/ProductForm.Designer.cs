namespace Cosmetic.AppForms
{
    partial class ProductForm
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLess = new System.Windows.Forms.RadioButton();
            this.radioButtonMore = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonOrders);
            this.splitContainer2.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(1196, 642);
            this.splitContainer2.SplitterDistance = 80;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(1026, 27);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(148, 29);
            this.buttonOrders.TabIndex = 2;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(866, 27);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(154, 29);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить товар";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxDiscount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 80);
            this.panel1.TabIndex = 0;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(746, 59);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(54, 15);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "Найдено";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Скидка:";
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Items.AddRange(new object[] {
            "Все  диапазоны",
            "0-9,99%",
            "10-14,99%",
            "15% и более"});
            this.comboBoxDiscount.Location = new System.Drawing.Point(286, 34);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(141, 23);
            this.comboBoxDiscount.TabIndex = 3;
            this.comboBoxDiscount.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscount_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(576, 33);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(224, 23);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLess);
            this.groupBox1.Controls.Add(this.radioButtonMore);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стоимость";
            // 
            // radioButtonLess
            // 
            this.radioButtonLess.AutoSize = true;
            this.radioButtonLess.Location = new System.Drawing.Point(6, 22);
            this.radioButtonLess.Name = "radioButtonLess";
            this.radioButtonLess.Size = new System.Drawing.Size(66, 19);
            this.radioButtonLess.TabIndex = 1;
            this.radioButtonLess.Text = "Меньше";
            this.radioButtonLess.UseVisualStyleBackColor = true;
            this.radioButtonLess.CheckedChanged += new System.EventHandler(this.radioButtonLess_CheckedChanged);
            // 
            // radioButtonMore
            // 
            this.radioButtonMore.AutoSize = true;
            this.radioButtonMore.Checked = true;
            this.radioButtonMore.Location = new System.Drawing.Point(86, 22);
            this.radioButtonMore.Name = "radioButtonMore";
            this.radioButtonMore.Size = new System.Drawing.Size(65, 19);
            this.radioButtonMore.TabIndex = 0;
            this.radioButtonMore.TabStop = true;
            this.radioButtonMore.Text = "Больше";
            this.radioButtonMore.UseVisualStyleBackColor = true;
            this.radioButtonMore.CheckedChanged += new System.EventHandler(this.radioButtonMore_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1196, 558);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 737);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.Shown += new System.EventHandler(this.ProductForm_Shown);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.RadioButton radioButtonLess;
        private System.Windows.Forms.RadioButton radioButtonMore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelCount;
    }
}