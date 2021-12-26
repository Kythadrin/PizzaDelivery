namespace PizzaDelivery
{
    partial class AdminMenuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.textBoxPizzaName = new System.Windows.Forms.TextBox();
            this.textBoxPizzaPrice = new System.Windows.Forms.TextBox();
            this.buttonSavePizza = new System.Windows.Forms.Button();
            this.dataGridViewOrdersList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaDataSet = new PizzaDelivery.pizzaDataSet();
            this.ordersTableAdapter = new PizzaDelivery.pizzaDataSetTableAdapters.ordersTableAdapter();
            this.groupBoxAddPizza = new System.Windows.Forms.GroupBox();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnListViewItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coulumnListViewQuanty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnListViewPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPizzaImage = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet)).BeginInit();
            this.groupBoxAddPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPizzaImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonUploadImage.Location = new System.Drawing.Point(45, 202);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(150, 40);
            this.buttonUploadImage.TabIndex = 1;
            this.buttonUploadImage.Text = "Upload image";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // textBoxPizzaName
            // 
            this.textBoxPizzaName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPizzaName.Location = new System.Drawing.Point(45, 248);
            this.textBoxPizzaName.Name = "textBoxPizzaName";
            this.textBoxPizzaName.Size = new System.Drawing.Size(150, 32);
            this.textBoxPizzaName.TabIndex = 2;
            // 
            // textBoxPizzaPrice
            // 
            this.textBoxPizzaPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPizzaPrice.Location = new System.Drawing.Point(45, 286);
            this.textBoxPizzaPrice.Name = "textBoxPizzaPrice";
            this.textBoxPizzaPrice.Size = new System.Drawing.Size(150, 32);
            this.textBoxPizzaPrice.TabIndex = 3;
            // 
            // buttonSavePizza
            // 
            this.buttonSavePizza.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePizza.Location = new System.Drawing.Point(66, 331);
            this.buttonSavePizza.Name = "buttonSavePizza";
            this.buttonSavePizza.Size = new System.Drawing.Size(110, 40);
            this.buttonSavePizza.TabIndex = 4;
            this.buttonSavePizza.Text = "Save";
            this.buttonSavePizza.UseVisualStyleBackColor = true;
            this.buttonSavePizza.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewOrdersList
            // 
            this.dataGridViewOrdersList.AllowUserToAddRows = false;
            this.dataGridViewOrdersList.AutoGenerateColumns = false;
            this.dataGridViewOrdersList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrdersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderDataGridViewImageColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn,
            this.cardnrDataGridViewTextBoxColumn});
            this.dataGridViewOrdersList.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrdersList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrdersList.GridColor = System.Drawing.Color.Black;
            this.dataGridViewOrdersList.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewOrdersList.Name = "dataGridViewOrdersList";
            this.dataGridViewOrdersList.RowHeadersWidth = 51;
            this.dataGridViewOrdersList.RowTemplate.Height = 24;
            this.dataGridViewOrdersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrdersList.Size = new System.Drawing.Size(1178, 344);
            this.dataGridViewOrdersList.TabIndex = 5;
            this.dataGridViewOrdersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderList_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDataGridViewImageColumn
            // 
            this.orderDataGridViewImageColumn.DataPropertyName = "order";
            this.orderDataGridViewImageColumn.HeaderText = "order";
            this.orderDataGridViewImageColumn.MinimumWidth = 6;
            this.orderDataGridViewImageColumn.Name = "orderDataGridViewImageColumn";
            this.orderDataGridViewImageColumn.Visible = false;
            this.orderDataGridViewImageColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            this.paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            this.paymentmethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // cardnrDataGridViewTextBoxColumn
            // 
            this.cardnrDataGridViewTextBoxColumn.DataPropertyName = "card_nr";
            this.cardnrDataGridViewTextBoxColumn.HeaderText = "card_nr";
            this.cardnrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cardnrDataGridViewTextBoxColumn.Name = "cardnrDataGridViewTextBoxColumn";
            this.cardnrDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.pizzaDataSet;
            // 
            // pizzaDataSet
            // 
            this.pizzaDataSet.DataSetName = "pizzaDataSet";
            this.pizzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxAddPizza
            // 
            this.groupBoxAddPizza.Controls.Add(this.buttonSavePizza);
            this.groupBoxAddPizza.Controls.Add(this.textBoxPizzaPrice);
            this.groupBoxAddPizza.Controls.Add(this.textBoxPizzaName);
            this.groupBoxAddPizza.Controls.Add(this.buttonUploadImage);
            this.groupBoxAddPizza.Controls.Add(this.pictureBoxPizzaImage);
            this.groupBoxAddPizza.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddPizza.Location = new System.Drawing.Point(58, 382);
            this.groupBoxAddPizza.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.groupBoxAddPizza.Name = "groupBoxAddPizza";
            this.groupBoxAddPizza.Padding = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.groupBoxAddPizza.Size = new System.Drawing.Size(240, 390);
            this.groupBoxAddPizza.TabIndex = 6;
            this.groupBoxAddPizza.TabStop = false;
            this.groupBoxAddPizza.Text = "Add pizza";
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnListViewItem,
            this.coulumnListViewQuanty,
            this.columnListViewPrice});
            this.listViewOrder.Font = new System.Drawing.Font("Calibri", 14F);
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(325, 425);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(863, 328);
            this.listViewOrder.TabIndex = 8;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnListViewItem
            // 
            this.columnListViewItem.Text = "Item";
            this.columnListViewItem.Width = 500;
            // 
            // coulumnListViewQuanty
            // 
            this.coulumnListViewQuanty.Text = "Quantity";
            this.coulumnListViewQuanty.Width = 150;
            // 
            // columnListViewPrice
            // 
            this.columnListViewPrice.Text = "Price";
            this.columnListViewPrice.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order info";
            // 
            // pictureBoxPizzaImage
            // 
            this.pictureBoxPizzaImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPizzaImage.Location = new System.Drawing.Point(45, 46);
            this.pictureBoxPizzaImage.Name = "pictureBoxPizzaImage";
            this.pictureBoxPizzaImage.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxPizzaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPizzaImage.TabIndex = 0;
            this.pictureBoxPizzaImage.TabStop = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(1064, 360);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(124, 42);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.ClientSize = new System.Drawing.Size(1209, 623);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.groupBoxAddPizza);
            this.Controls.Add(this.dataGridViewOrdersList);
            this.Name = "AdminMenuForm";
            this.Text = "Admin menu";
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet)).EndInit();
            this.groupBoxAddPizza.ResumeLayout(false);
            this.groupBoxAddPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPizzaImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPizzaImage;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.TextBox textBoxPizzaName;
        private System.Windows.Forms.TextBox textBoxPizzaPrice;
        private System.Windows.Forms.Button buttonSavePizza;
        private System.Windows.Forms.DataGridView dataGridViewOrdersList;
        private pizzaDataSet pizzaDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private pizzaDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxAddPizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn orderDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnrDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnListViewItem;
        private System.Windows.Forms.ColumnHeader coulumnListViewQuanty;
        private System.Windows.Forms.ColumnHeader columnListViewPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
    }
}