namespace Inventory_Management_System
{
    partial class SoldItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtExciseDuty = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtTaxableAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrintSave = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receiptBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtInvoice);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtGrandTotal);
            this.groupBox1.Controls.Add(this.txtExciseDuty);
            this.groupBox1.Controls.Add(this.txtVat);
            this.groupBox1.Controls.Add(this.txtTaxableAmount);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnPrintSave);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.cmbProductName);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Sold Items";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 458);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(11, 484);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(132, 23);
            this.txtCustomerName.TabIndex = 27;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(922, 22);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.ReadOnly = true;
            this.txtInvoice.Size = new System.Drawing.Size(99, 23);
            this.txtInvoice.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(922, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 29);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(909, 388);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(125, 23);
            this.txtGrandTotal.TabIndex = 24;
            // 
            // txtExciseDuty
            // 
            this.txtExciseDuty.Location = new System.Drawing.Point(908, 201);
            this.txtExciseDuty.Name = "txtExciseDuty";
            this.txtExciseDuty.ReadOnly = true;
            this.txtExciseDuty.Size = new System.Drawing.Size(125, 23);
            this.txtExciseDuty.TabIndex = 21;
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(908, 330);
            this.txtVat.Name = "txtVat";
            this.txtVat.ReadOnly = true;
            this.txtVat.Size = new System.Drawing.Size(125, 23);
            this.txtVat.TabIndex = 23;
            // 
            // txtTaxableAmount
            // 
            this.txtTaxableAmount.Location = new System.Drawing.Point(909, 271);
            this.txtTaxableAmount.Name = "txtTaxableAmount";
            this.txtTaxableAmount.ReadOnly = true;
            this.txtTaxableAmount.Size = new System.Drawing.Size(125, 23);
            this.txtTaxableAmount.TabIndex = 22;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(908, 141);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(125, 23);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(929, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Grand Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(919, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Taxable Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(941, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "13% VAT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(922, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "5% Excise Duty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(951, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total";
            // 
            // btnPrintSave
            // 
            this.btnPrintSave.Location = new System.Drawing.Point(797, 478);
            this.btnPrintSave.Name = "btnPrintSave";
            this.btnPrintSave.Size = new System.Drawing.Size(99, 29);
            this.btnPrintSave.TabIndex = 14;
            this.btnPrintSave.Text = "Print";
            this.btnPrintSave.UseVisualStyleBackColor = true;
            this.btnPrintSave.Click += new System.EventHandler(this.btnPrintSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(668, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(534, 478);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receiptBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(888, 321);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // receiptBindingSource1
            // 
            this.receiptBindingSource1.DataSource = typeof(BusinessLogicLayer.Receipt);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(922, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 29);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(762, 69);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(132, 23);
            this.txtSubTotal.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(582, 69);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 23);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(400, 70);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(132, 23);
            this.txtPrice.TabIndex = 7;
            // 
            // cmbProductName
            // 
            this.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(190, 69);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(161, 24);
            this.cmbProductName.TabIndex = 6;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(8, 69);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(145, 24);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(798, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "SubTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1094, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel1.Text = "Date";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(190, 484);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(271, 23);
            this.txtAddress.TabIndex = 30;
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "SN.";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            this.snDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "categoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "Category Id";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "categoryname";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "Category Name";
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            this.categorynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product Id";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SoldItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 550);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoldItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoldItems";
            this.Load += new System.EventHandler(this.SoldItems_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Button btnPrintSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtExciseDuty;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtTaxableAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource receiptBindingSource1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}