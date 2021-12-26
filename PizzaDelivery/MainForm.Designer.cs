namespace PizzaDelivery
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSelectYourOrder = new System.Windows.Forms.TabPage();
            this.groupBoxPizza = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelPizzaList = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxDrinks = new System.Windows.Forms.GroupBox();
            this.textBoxWaterQty = new System.Windows.Forms.TextBox();
            this.textBoxRootBeerQty = new System.Windows.Forms.TextBox();
            this.textBoxSpriteQty = new System.Windows.Forms.TextBox();
            this.textBoxGingerAleQty = new System.Windows.Forms.TextBox();
            this.textBoxIcedTeaQty = new System.Windows.Forms.TextBox();
            this.textBoxDietCokeQty = new System.Windows.Forms.TextBox();
            this.textBoxCokeQty = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.checkBoxWater = new System.Windows.Forms.CheckBox();
            this.checkBoxRootBeer = new System.Windows.Forms.CheckBox();
            this.checkBoxSprite = new System.Windows.Forms.CheckBox();
            this.checkBoxGingerAle = new System.Windows.Forms.CheckBox();
            this.checkBoxIcedTea = new System.Windows.Forms.CheckBox();
            this.checkBoxDietCoke = new System.Windows.Forms.CheckBox();
            this.checkBoxCoke = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxOtherItems = new System.Windows.Forms.GroupBox();
            this.checkBoxSourCreamDip = new System.Windows.Forms.CheckBox();
            this.checkBoxBBQDip = new System.Windows.Forms.CheckBox();
            this.checkBoxGarlicDip = new System.Windows.Forms.CheckBox();
            this.checkBoxCheesyGarlicBread = new System.Windows.Forms.CheckBox();
            this.checkBoxOnionRings = new System.Windows.Forms.CheckBox();
            this.checkBoxPoutine = new System.Windows.Forms.CheckBox();
            this.checkBoxChickenWings = new System.Windows.Forms.CheckBox();
            this.buttonConfirmOrder = new System.Windows.Forms.Button();
            this.tabPageConfirmOrder = new System.Windows.Forms.TabPage();
            this.groupAmount = new System.Windows.Forms.GroupBox();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.labelPVN = new System.Windows.Forms.Label();
            this.textBoxPVN = new System.Windows.Forms.TextBox();
            this.labelAmountBeforeTaxes = new System.Windows.Forms.Label();
            this.textBoxAmountBeforeTaxes = new System.Windows.Forms.TextBox();
            this.logoConfirmOrder = new System.Windows.Forms.PictureBox();
            this.buttonClearOrder = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.listViewOrderList = new System.Windows.Forms.ListView();
            this.columnHeaderItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelOrderList = new System.Windows.Forms.Label();
            this.tabPageMakePayment = new System.Windows.Forms.TabPage();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonSubmitOrder = new System.Windows.Forms.Button();
            this.groupBoxPaymentInfo = new System.Windows.Forms.GroupBox();
            this.textBoxCVC = new System.Windows.Forms.MaskedTextBox();
            this.textBoxExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCardNr = new System.Windows.Forms.MaskedTextBox();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labelCVC = new System.Windows.Forms.Label();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.textBoxAmountPaid = new System.Windows.Forms.TextBox();
            this.labelAmountPaid = new System.Windows.Forms.Label();
            this.textBoxAmountDue = new System.Windows.Forms.TextBox();
            this.labelAmountDue = new System.Windows.Forms.Label();
            this.labelCardNr = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.groupBoxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPhoneNr = new System.Windows.Forms.MaskedTextBox();
            this.labelNotice = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNr = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelAdminLogin = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPageSelectYourOrder.SuspendLayout();
            this.groupBoxPizza.SuspendLayout();
            this.groupBoxDrinks.SuspendLayout();
            this.groupBoxOtherItems.SuspendLayout();
            this.tabPageConfirmOrder.SuspendLayout();
            this.groupAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoConfirmOrder)).BeginInit();
            this.tabPageMakePayment.SuspendLayout();
            this.groupBoxPaymentInfo.SuspendLayout();
            this.groupBoxCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageSelectYourOrder);
            this.tabControl.Controls.Add(this.tabPageConfirmOrder);
            this.tabControl.Controls.Add(this.tabPageMakePayment);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.tabControl.ItemSize = new System.Drawing.Size(280, 50);
            this.tabControl.Location = new System.Drawing.Point(20, 273);
            this.tabControl.Margin = new System.Windows.Forms.Padding(25, 10, 0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(15, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(964, 1850);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageSelectYourOrder
            // 
            this.tabPageSelectYourOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tabPageSelectYourOrder.Controls.Add(this.groupBoxPizza);
            this.tabPageSelectYourOrder.Controls.Add(this.groupBoxDrinks);
            this.tabPageSelectYourOrder.Controls.Add(this.buttonExit);
            this.tabPageSelectYourOrder.Controls.Add(this.groupBoxOtherItems);
            this.tabPageSelectYourOrder.Controls.Add(this.buttonConfirmOrder);
            this.tabPageSelectYourOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageSelectYourOrder.Location = new System.Drawing.Point(4, 54);
            this.tabPageSelectYourOrder.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSelectYourOrder.Name = "tabPageSelectYourOrder";
            this.tabPageSelectYourOrder.Padding = new System.Windows.Forms.Padding(25, 25, 25, 0);
            this.tabPageSelectYourOrder.Size = new System.Drawing.Size(956, 1792);
            this.tabPageSelectYourOrder.TabIndex = 0;
            this.tabPageSelectYourOrder.Text = "Select Your Order";
            // 
            // groupBoxPizza
            // 
            this.groupBoxPizza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxPizza.CausesValidation = false;
            this.groupBoxPizza.Controls.Add(this.flowLayoutPanelPizzaList);
            this.groupBoxPizza.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxPizza.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold);
            this.groupBoxPizza.Location = new System.Drawing.Point(25, 25);
            this.groupBoxPizza.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxPizza.Name = "groupBoxPizza";
            this.groupBoxPizza.Padding = new System.Windows.Forms.Padding(30, 50, 30, 0);
            this.groupBoxPizza.Size = new System.Drawing.Size(906, 1158);
            this.groupBoxPizza.TabIndex = 0;
            this.groupBoxPizza.TabStop = false;
            this.groupBoxPizza.Text = "Pizza";
            // 
            // flowLayoutPanelPizzaList
            // 
            this.flowLayoutPanelPizzaList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPizzaList.AutoScroll = true;
            this.flowLayoutPanelPizzaList.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanelPizzaList.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelPizzaList.Name = "flowLayoutPanelPizzaList";
            this.flowLayoutPanelPizzaList.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flowLayoutPanelPizzaList.Size = new System.Drawing.Size(906, 1065);
            this.flowLayoutPanelPizzaList.TabIndex = 1;
            this.flowLayoutPanelPizzaList.TabStop = true;
            // 
            // groupBoxDrinks
            // 
            this.groupBoxDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxDrinks.Controls.Add(this.textBoxWaterQty);
            this.groupBoxDrinks.Controls.Add(this.textBoxRootBeerQty);
            this.groupBoxDrinks.Controls.Add(this.textBoxSpriteQty);
            this.groupBoxDrinks.Controls.Add(this.textBoxGingerAleQty);
            this.groupBoxDrinks.Controls.Add(this.textBoxIcedTeaQty);
            this.groupBoxDrinks.Controls.Add(this.textBoxDietCokeQty);
            this.groupBoxDrinks.Controls.Add(this.textBoxCokeQty);
            this.groupBoxDrinks.Controls.Add(this.labelQuantity);
            this.groupBoxDrinks.Controls.Add(this.checkBoxWater);
            this.groupBoxDrinks.Controls.Add(this.checkBoxRootBeer);
            this.groupBoxDrinks.Controls.Add(this.checkBoxSprite);
            this.groupBoxDrinks.Controls.Add(this.checkBoxGingerAle);
            this.groupBoxDrinks.Controls.Add(this.checkBoxIcedTea);
            this.groupBoxDrinks.Controls.Add(this.checkBoxDietCoke);
            this.groupBoxDrinks.Controls.Add(this.checkBoxCoke);
            this.groupBoxDrinks.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxDrinks.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDrinks.Location = new System.Drawing.Point(25, 1208);
            this.groupBoxDrinks.Margin = new System.Windows.Forms.Padding(25, 25, 0, 0);
            this.groupBoxDrinks.Name = "groupBoxDrinks";
            this.groupBoxDrinks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDrinks.Size = new System.Drawing.Size(440, 460);
            this.groupBoxDrinks.TabIndex = 0;
            this.groupBoxDrinks.TabStop = false;
            this.groupBoxDrinks.Text = "Drinks";
            // 
            // textBoxWaterQty
            // 
            this.textBoxWaterQty.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWaterQty.Location = new System.Drawing.Point(309, 380);
            this.textBoxWaterQty.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.textBoxWaterQty.Name = "textBoxWaterQty";
            this.textBoxWaterQty.Size = new System.Drawing.Size(66, 38);
            this.textBoxWaterQty.TabIndex = 15;
            this.textBoxWaterQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWaterQty_KeyPress);
            // 
            // textBoxRootBeerQty
            // 
            this.textBoxRootBeerQty.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRootBeerQty.Location = new System.Drawing.Point(309, 330);
            this.textBoxRootBeerQty.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.textBoxRootBeerQty.Name = "textBoxRootBeerQty";
            this.textBoxRootBeerQty.Size = new System.Drawing.Size(66, 38);
            this.textBoxRootBeerQty.TabIndex = 13;
            this.textBoxRootBeerQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRootBeerQty_KeyPress);
            // 
            // textBoxSpriteQty
            // 
            this.textBoxSpriteQty.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpriteQty.Location = new System.Drawing.Point(309, 280);
            this.textBoxSpriteQty.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.textBoxSpriteQty.Name = "textBoxSpriteQty";
            this.textBoxSpriteQty.Size = new System.Drawing.Size(66, 38);
            this.textBoxSpriteQty.TabIndex = 11;
            this.textBoxSpriteQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSpriteQty_KeyPress);
            // 
            // textBoxGingerAleQty
            // 
            this.textBoxGingerAleQty.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGingerAleQty.Location = new System.Drawing.Point(309, 230);
            this.textBoxGingerAleQty.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.textBoxGingerAleQty.Name = "textBoxGingerAleQty";
            this.textBoxGingerAleQty.Size = new System.Drawing.Size(66, 38);
            this.textBoxGingerAleQty.TabIndex = 9;
            this.textBoxGingerAleQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGingerAleQty_KeyPress);
            // 
            // textBoxIcedTeaQty
            // 
            this.textBoxIcedTeaQty.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIcedTeaQty.Location = new System.Drawing.Point(309, 180);
            this.textBoxIcedTeaQty.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.textBoxIcedTeaQty.Name = "textBoxIcedTeaQty";
            this.textBoxIcedTeaQty.Size = new System.Drawing.Size(66, 38);
            this.textBoxIcedTeaQty.TabIndex = 7;
            this.textBoxIcedTeaQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIcedTeaQty_KeyPress);
            // 
            // textBoxDietCokeQty
            // 
            this.textBoxDietCokeQty.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDietCokeQty.Location = new System.Drawing.Point(309, 130);
            this.textBoxDietCokeQty.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.textBoxDietCokeQty.Name = "textBoxDietCokeQty";
            this.textBoxDietCokeQty.Size = new System.Drawing.Size(66, 38);
            this.textBoxDietCokeQty.TabIndex = 5;
            this.textBoxDietCokeQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDietCokeQty_KeyPress);
            // 
            // textBoxCokeQty
            // 
            this.textBoxCokeQty.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCokeQty.Location = new System.Drawing.Point(309, 80);
            this.textBoxCokeQty.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.textBoxCokeQty.Name = "textBoxCokeQty";
            this.textBoxCokeQty.Size = new System.Drawing.Size(66, 38);
            this.textBoxCokeQty.TabIndex = 3;
            this.textBoxCokeQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCokeQty_KeyPress);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.CausesValidation = false;
            this.labelQuantity.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(282, 28);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(127, 37);
            this.labelQuantity.TabIndex = 0;
            this.labelQuantity.Text = "Quantity";
            // 
            // checkBoxWater
            // 
            this.checkBoxWater.AutoSize = true;
            this.checkBoxWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxWater.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWater.Location = new System.Drawing.Point(40, 382);
            this.checkBoxWater.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxWater.Name = "checkBoxWater";
            this.checkBoxWater.Size = new System.Drawing.Size(181, 35);
            this.checkBoxWater.TabIndex = 14;
            this.checkBoxWater.Text = "Water (1,25€)";
            this.checkBoxWater.UseVisualStyleBackColor = true;
            // 
            // checkBoxRootBeer
            // 
            this.checkBoxRootBeer.AutoSize = true;
            this.checkBoxRootBeer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRootBeer.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRootBeer.Location = new System.Drawing.Point(40, 335);
            this.checkBoxRootBeer.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxRootBeer.Name = "checkBoxRootBeer";
            this.checkBoxRootBeer.Size = new System.Drawing.Size(220, 35);
            this.checkBoxRootBeer.TabIndex = 12;
            this.checkBoxRootBeer.Text = "Root Beer (1,45€)";
            this.checkBoxRootBeer.UseVisualStyleBackColor = true;
            // 
            // checkBoxSprite
            // 
            this.checkBoxSprite.AutoSize = true;
            this.checkBoxSprite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSprite.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSprite.Location = new System.Drawing.Point(40, 282);
            this.checkBoxSprite.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxSprite.Name = "checkBoxSprite";
            this.checkBoxSprite.Size = new System.Drawing.Size(178, 35);
            this.checkBoxSprite.TabIndex = 10;
            this.checkBoxSprite.Text = "Sprite (1,45€)";
            this.checkBoxSprite.UseVisualStyleBackColor = true;
            // 
            // checkBoxGingerAle
            // 
            this.checkBoxGingerAle.AutoSize = true;
            this.checkBoxGingerAle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxGingerAle.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGingerAle.Location = new System.Drawing.Point(40, 232);
            this.checkBoxGingerAle.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxGingerAle.Name = "checkBoxGingerAle";
            this.checkBoxGingerAle.Size = new System.Drawing.Size(225, 35);
            this.checkBoxGingerAle.TabIndex = 8;
            this.checkBoxGingerAle.Text = "Ginger Ale (1,45€)";
            this.checkBoxGingerAle.UseVisualStyleBackColor = true;
            // 
            // checkBoxIcedTea
            // 
            this.checkBoxIcedTea.AutoSize = true;
            this.checkBoxIcedTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxIcedTea.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIcedTea.Location = new System.Drawing.Point(40, 182);
            this.checkBoxIcedTea.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxIcedTea.Name = "checkBoxIcedTea";
            this.checkBoxIcedTea.Size = new System.Drawing.Size(200, 35);
            this.checkBoxIcedTea.TabIndex = 6;
            this.checkBoxIcedTea.Text = "Iced Tea (1,45€)";
            this.checkBoxIcedTea.UseVisualStyleBackColor = true;
            // 
            // checkBoxDietCoke
            // 
            this.checkBoxDietCoke.AutoSize = true;
            this.checkBoxDietCoke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDietCoke.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDietCoke.Location = new System.Drawing.Point(40, 132);
            this.checkBoxDietCoke.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxDietCoke.Name = "checkBoxDietCoke";
            this.checkBoxDietCoke.Size = new System.Drawing.Size(216, 35);
            this.checkBoxDietCoke.TabIndex = 4;
            this.checkBoxDietCoke.Text = "Diet Coke (1,45€)";
            this.checkBoxDietCoke.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoke
            // 
            this.checkBoxCoke.AutoSize = true;
            this.checkBoxCoke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCoke.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoke.Location = new System.Drawing.Point(40, 82);
            this.checkBoxCoke.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxCoke.Name = "checkBoxCoke";
            this.checkBoxCoke.Size = new System.Drawing.Size(166, 35);
            this.checkBoxCoke.TabIndex = 2;
            this.checkBoxCoke.Text = "Coke (1,45€)";
            this.checkBoxCoke.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(425, 1694);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0, 25, 10, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(222, 70);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxOtherItems
            // 
            this.groupBoxOtherItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOtherItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxOtherItems.Controls.Add(this.checkBoxSourCreamDip);
            this.groupBoxOtherItems.Controls.Add(this.checkBoxBBQDip);
            this.groupBoxOtherItems.Controls.Add(this.checkBoxGarlicDip);
            this.groupBoxOtherItems.Controls.Add(this.checkBoxCheesyGarlicBread);
            this.groupBoxOtherItems.Controls.Add(this.checkBoxOnionRings);
            this.groupBoxOtherItems.Controls.Add(this.checkBoxPoutine);
            this.groupBoxOtherItems.Controls.Add(this.checkBoxChickenWings);
            this.groupBoxOtherItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxOtherItems.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOtherItems.Location = new System.Drawing.Point(489, 1208);
            this.groupBoxOtherItems.Margin = new System.Windows.Forms.Padding(0, 25, 25, 0);
            this.groupBoxOtherItems.Name = "groupBoxOtherItems";
            this.groupBoxOtherItems.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOtherItems.Size = new System.Drawing.Size(440, 460);
            this.groupBoxOtherItems.TabIndex = 0;
            this.groupBoxOtherItems.TabStop = false;
            this.groupBoxOtherItems.Text = "Other Items";
            // 
            // checkBoxSourCreamDip
            // 
            this.checkBoxSourCreamDip.AutoSize = true;
            this.checkBoxSourCreamDip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSourCreamDip.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSourCreamDip.Location = new System.Drawing.Point(52, 386);
            this.checkBoxSourCreamDip.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxSourCreamDip.Name = "checkBoxSourCreamDip";
            this.checkBoxSourCreamDip.Size = new System.Drawing.Size(265, 35);
            this.checkBoxSourCreamDip.TabIndex = 22;
            this.checkBoxSourCreamDip.Text = "Sour Cream Dip (Free)";
            this.checkBoxSourCreamDip.UseVisualStyleBackColor = true;
            // 
            // checkBoxBBQDip
            // 
            this.checkBoxBBQDip.AutoSize = true;
            this.checkBoxBBQDip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxBBQDip.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBBQDip.Location = new System.Drawing.Point(52, 335);
            this.checkBoxBBQDip.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxBBQDip.Name = "checkBoxBBQDip";
            this.checkBoxBBQDip.Size = new System.Drawing.Size(190, 35);
            this.checkBoxBBQDip.TabIndex = 21;
            this.checkBoxBBQDip.Text = "BBQ Dip (Free)";
            this.checkBoxBBQDip.UseVisualStyleBackColor = true;
            // 
            // checkBoxGarlicDip
            // 
            this.checkBoxGarlicDip.AutoSize = true;
            this.checkBoxGarlicDip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxGarlicDip.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGarlicDip.Location = new System.Drawing.Point(52, 285);
            this.checkBoxGarlicDip.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxGarlicDip.Name = "checkBoxGarlicDip";
            this.checkBoxGarlicDip.Size = new System.Drawing.Size(204, 35);
            this.checkBoxGarlicDip.TabIndex = 20;
            this.checkBoxGarlicDip.Text = "Garlic Dip (Free)";
            this.checkBoxGarlicDip.UseVisualStyleBackColor = true;
            // 
            // checkBoxCheesyGarlicBread
            // 
            this.checkBoxCheesyGarlicBread.AutoSize = true;
            this.checkBoxCheesyGarlicBread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCheesyGarlicBread.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCheesyGarlicBread.Location = new System.Drawing.Point(52, 234);
            this.checkBoxCheesyGarlicBread.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxCheesyGarlicBread.Name = "checkBoxCheesyGarlicBread";
            this.checkBoxCheesyGarlicBread.Size = new System.Drawing.Size(322, 35);
            this.checkBoxCheesyGarlicBread.TabIndex = 19;
            this.checkBoxCheesyGarlicBread.Text = "Cheesy Garlic Bread (3,00€)";
            this.checkBoxCheesyGarlicBread.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnionRings
            // 
            this.checkBoxOnionRings.AutoSize = true;
            this.checkBoxOnionRings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxOnionRings.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOnionRings.Location = new System.Drawing.Point(52, 182);
            this.checkBoxOnionRings.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxOnionRings.Name = "checkBoxOnionRings";
            this.checkBoxOnionRings.Size = new System.Drawing.Size(239, 35);
            this.checkBoxOnionRings.TabIndex = 18;
            this.checkBoxOnionRings.Text = "Onion Rings (3,00€)";
            this.checkBoxOnionRings.UseVisualStyleBackColor = true;
            // 
            // checkBoxPoutine
            // 
            this.checkBoxPoutine.AutoSize = true;
            this.checkBoxPoutine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxPoutine.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPoutine.Location = new System.Drawing.Point(52, 132);
            this.checkBoxPoutine.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.checkBoxPoutine.Name = "checkBoxPoutine";
            this.checkBoxPoutine.Size = new System.Drawing.Size(196, 35);
            this.checkBoxPoutine.TabIndex = 17;
            this.checkBoxPoutine.Text = "Poutine (3,00€)";
            this.checkBoxPoutine.UseVisualStyleBackColor = true;
            // 
            // checkBoxChickenWings
            // 
            this.checkBoxChickenWings.AutoSize = true;
            this.checkBoxChickenWings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChickenWings.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChickenWings.Location = new System.Drawing.Point(52, 82);
            this.checkBoxChickenWings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxChickenWings.Name = "checkBoxChickenWings";
            this.checkBoxChickenWings.Size = new System.Drawing.Size(265, 35);
            this.checkBoxChickenWings.TabIndex = 16;
            this.checkBoxChickenWings.Text = "Chicken Wings (3,00€)";
            this.checkBoxChickenWings.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmOrder
            // 
            this.buttonConfirmOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirmOrder.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.buttonConfirmOrder.Location = new System.Drawing.Point(677, 1694);
            this.buttonConfirmOrder.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.buttonConfirmOrder.Name = "buttonConfirmOrder";
            this.buttonConfirmOrder.Size = new System.Drawing.Size(252, 70);
            this.buttonConfirmOrder.TabIndex = 23;
            this.buttonConfirmOrder.Text = "Confirm Order";
            this.buttonConfirmOrder.UseVisualStyleBackColor = true;
            this.buttonConfirmOrder.Click += new System.EventHandler(this.buttonConfirmOrder_Click);
            // 
            // tabPageConfirmOrder
            // 
            this.tabPageConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tabPageConfirmOrder.Controls.Add(this.groupAmount);
            this.tabPageConfirmOrder.Controls.Add(this.logoConfirmOrder);
            this.tabPageConfirmOrder.Controls.Add(this.buttonClearOrder);
            this.tabPageConfirmOrder.Controls.Add(this.buttonCheckOut);
            this.tabPageConfirmOrder.Controls.Add(this.listViewOrderList);
            this.tabPageConfirmOrder.Controls.Add(this.labelOrderList);
            this.tabPageConfirmOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageConfirmOrder.ForeColor = System.Drawing.Color.Black;
            this.tabPageConfirmOrder.Location = new System.Drawing.Point(4, 54);
            this.tabPageConfirmOrder.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageConfirmOrder.Name = "tabPageConfirmOrder";
            this.tabPageConfirmOrder.Padding = new System.Windows.Forms.Padding(40, 0, 40, 4);
            this.tabPageConfirmOrder.Size = new System.Drawing.Size(952, 1792);
            this.tabPageConfirmOrder.TabIndex = 0;
            this.tabPageConfirmOrder.Text = "Confirm Your Order";
            // 
            // groupAmount
            // 
            this.groupAmount.Controls.Add(this.labelTotalAmount);
            this.groupAmount.Controls.Add(this.textBoxTotalAmount);
            this.groupAmount.Controls.Add(this.labelPVN);
            this.groupAmount.Controls.Add(this.textBoxPVN);
            this.groupAmount.Controls.Add(this.labelAmountBeforeTaxes);
            this.groupAmount.Controls.Add(this.textBoxAmountBeforeTaxes);
            this.groupAmount.Location = new System.Drawing.Point(392, 582);
            this.groupAmount.Margin = new System.Windows.Forms.Padding(0);
            this.groupAmount.Name = "groupAmount";
            this.groupAmount.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupAmount.Size = new System.Drawing.Size(520, 280);
            this.groupAmount.TabIndex = 1;
            this.groupAmount.TabStop = false;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.ForeColor = System.Drawing.Color.White;
            this.labelTotalAmount.Location = new System.Drawing.Point(90, 210);
            this.labelTotalAmount.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(219, 41);
            this.labelTotalAmount.TabIndex = 0;
            this.labelTotalAmount.Text = "Total Amount:";
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Location = new System.Drawing.Point(286, 211);
            this.textBoxTotalAmount.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(208, 48);
            this.textBoxTotalAmount.TabIndex = 0;
            this.textBoxTotalAmount.TabStop = false;
            // 
            // labelPVN
            // 
            this.labelPVN.AutoSize = true;
            this.labelPVN.ForeColor = System.Drawing.Color.White;
            this.labelPVN.Location = new System.Drawing.Point(195, 137);
            this.labelPVN.Margin = new System.Windows.Forms.Padding(0);
            this.labelPVN.Name = "labelPVN";
            this.labelPVN.Size = new System.Drawing.Size(87, 41);
            this.labelPVN.TabIndex = 0;
            this.labelPVN.Text = "PVN:";
            // 
            // textBoxPVN
            // 
            this.textBoxPVN.Location = new System.Drawing.Point(286, 138);
            this.textBoxPVN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPVN.Name = "textBoxPVN";
            this.textBoxPVN.Size = new System.Drawing.Size(208, 48);
            this.textBoxPVN.TabIndex = 0;
            this.textBoxPVN.TabStop = false;
            // 
            // labelAmountBeforeTaxes
            // 
            this.labelAmountBeforeTaxes.AutoSize = true;
            this.labelAmountBeforeTaxes.ForeColor = System.Drawing.Color.White;
            this.labelAmountBeforeTaxes.Location = new System.Drawing.Point(10, 65);
            this.labelAmountBeforeTaxes.Margin = new System.Windows.Forms.Padding(0);
            this.labelAmountBeforeTaxes.Name = "labelAmountBeforeTaxes";
            this.labelAmountBeforeTaxes.Size = new System.Drawing.Size(325, 41);
            this.labelAmountBeforeTaxes.TabIndex = 0;
            this.labelAmountBeforeTaxes.Text = "Amount before taxes:";
            // 
            // textBoxAmountBeforeTaxes
            // 
            this.textBoxAmountBeforeTaxes.Location = new System.Drawing.Point(286, 66);
            this.textBoxAmountBeforeTaxes.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAmountBeforeTaxes.Name = "textBoxAmountBeforeTaxes";
            this.textBoxAmountBeforeTaxes.Size = new System.Drawing.Size(208, 48);
            this.textBoxAmountBeforeTaxes.TabIndex = 0;
            this.textBoxAmountBeforeTaxes.TabStop = false;
            // 
            // logoConfirmOrder
            // 
            this.logoConfirmOrder.Image = global::PizzaDelivery.Properties.Resources.pizz2;
            this.logoConfirmOrder.Location = new System.Drawing.Point(40, 602);
            this.logoConfirmOrder.Margin = new System.Windows.Forms.Padding(0);
            this.logoConfirmOrder.Name = "logoConfirmOrder";
            this.logoConfirmOrder.Size = new System.Drawing.Size(325, 260);
            this.logoConfirmOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoConfirmOrder.TabIndex = 0;
            this.logoConfirmOrder.TabStop = false;
            // 
            // buttonClearOrder
            // 
            this.buttonClearOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearOrder.Location = new System.Drawing.Point(429, 910);
            this.buttonClearOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClearOrder.Name = "buttonClearOrder";
            this.buttonClearOrder.Size = new System.Drawing.Size(225, 75);
            this.buttonClearOrder.TabIndex = 3;
            this.buttonClearOrder.Text = "Clear Order";
            this.buttonClearOrder.UseVisualStyleBackColor = true;
            this.buttonClearOrder.Click += new System.EventHandler(this.buttonClearOrder_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckOut.Location = new System.Drawing.Point(687, 910);
            this.buttonCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(225, 75);
            this.buttonCheckOut.TabIndex = 2;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // listViewOrderList
            // 
            this.listViewOrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listViewOrderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderItems,
            this.columnHeaderQty,
            this.columnHeaderPrice});
            this.listViewOrderList.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewOrderList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOrderList.HideSelection = false;
            this.listViewOrderList.Location = new System.Drawing.Point(40, 60);
            this.listViewOrderList.Margin = new System.Windows.Forms.Padding(0);
            this.listViewOrderList.Name = "listViewOrderList";
            this.listViewOrderList.Size = new System.Drawing.Size(872, 499);
            this.listViewOrderList.TabIndex = 1;
            this.listViewOrderList.TileSize = new System.Drawing.Size(60, 60);
            this.listViewOrderList.UseCompatibleStateImageBehavior = false;
            this.listViewOrderList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderItems
            // 
            this.columnHeaderItems.Tag = "";
            this.columnHeaderItems.Text = "Items";
            this.columnHeaderItems.Width = 300;
            // 
            // columnHeaderQty
            // 
            this.columnHeaderQty.Tag = "";
            this.columnHeaderQty.Text = "Quantity";
            this.columnHeaderQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderQty.Width = 200;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Tag = "";
            this.columnHeaderPrice.Text = "Price €";
            this.columnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPrice.Width = 200;
            // 
            // labelOrderList
            // 
            this.labelOrderList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOrderList.AutoSize = true;
            this.labelOrderList.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelOrderList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelOrderList.Location = new System.Drawing.Point(44, 15);
            this.labelOrderList.Margin = new System.Windows.Forms.Padding(0);
            this.labelOrderList.Name = "labelOrderList";
            this.labelOrderList.Size = new System.Drawing.Size(156, 41);
            this.labelOrderList.TabIndex = 0;
            this.labelOrderList.Text = "Order List";
            // 
            // tabPageMakePayment
            // 
            this.tabPageMakePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tabPageMakePayment.Controls.Add(this.buttonPay);
            this.tabPageMakePayment.Controls.Add(this.buttonSubmitOrder);
            this.tabPageMakePayment.Controls.Add(this.groupBoxPaymentInfo);
            this.tabPageMakePayment.Controls.Add(this.groupBoxCustomerInfo);
            this.tabPageMakePayment.Location = new System.Drawing.Point(4, 54);
            this.tabPageMakePayment.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageMakePayment.Name = "tabPageMakePayment";
            this.tabPageMakePayment.Padding = new System.Windows.Forms.Padding(25, 15, 25, 0);
            this.tabPageMakePayment.Size = new System.Drawing.Size(952, 1792);
            this.tabPageMakePayment.TabIndex = 0;
            this.tabPageMakePayment.Text = "Make Payment";
            // 
            // buttonPay
            // 
            this.buttonPay.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold);
            this.buttonPay.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonPay.Location = new System.Drawing.Point(425, 1248);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(240, 75);
            this.buttonPay.TabIndex = 12;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonSubmitOrder
            // 
            this.buttonSubmitOrder.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold);
            this.buttonSubmitOrder.Location = new System.Drawing.Point(687, 1248);
            this.buttonSubmitOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSubmitOrder.Name = "buttonSubmitOrder";
            this.buttonSubmitOrder.Size = new System.Drawing.Size(240, 74);
            this.buttonSubmitOrder.TabIndex = 13;
            this.buttonSubmitOrder.Text = "Submit Order";
            this.buttonSubmitOrder.UseVisualStyleBackColor = true;
            this.buttonSubmitOrder.Click += new System.EventHandler(this.buttonSubmitOrder_Click);
            // 
            // groupBoxPaymentInfo
            // 
            this.groupBoxPaymentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxPaymentInfo.Controls.Add(this.textBoxCVC);
            this.groupBoxPaymentInfo.Controls.Add(this.textBoxExpirationDate);
            this.groupBoxPaymentInfo.Controls.Add(this.textBoxCardNr);
            this.groupBoxPaymentInfo.Controls.Add(this.labelExpirationDate);
            this.groupBoxPaymentInfo.Controls.Add(this.labelCVC);
            this.groupBoxPaymentInfo.Controls.Add(this.textBoxChange);
            this.groupBoxPaymentInfo.Controls.Add(this.labelChange);
            this.groupBoxPaymentInfo.Controls.Add(this.textBoxAmountPaid);
            this.groupBoxPaymentInfo.Controls.Add(this.labelAmountPaid);
            this.groupBoxPaymentInfo.Controls.Add(this.textBoxAmountDue);
            this.groupBoxPaymentInfo.Controls.Add(this.labelAmountDue);
            this.groupBoxPaymentInfo.Controls.Add(this.labelCardNr);
            this.groupBoxPaymentInfo.Controls.Add(this.comboBoxPaymentMethod);
            this.groupBoxPaymentInfo.Controls.Add(this.labelPaymentMethod);
            this.groupBoxPaymentInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxPaymentInfo.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold);
            this.groupBoxPaymentInfo.Location = new System.Drawing.Point(25, 637);
            this.groupBoxPaymentInfo.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxPaymentInfo.Name = "groupBoxPaymentInfo";
            this.groupBoxPaymentInfo.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxPaymentInfo.Size = new System.Drawing.Size(902, 580);
            this.groupBoxPaymentInfo.TabIndex = 1;
            this.groupBoxPaymentInfo.TabStop = false;
            this.groupBoxPaymentInfo.Text = "Payment Information";
            // 
            // textBoxCVC
            // 
            this.textBoxCVC.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxCVC.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.textBoxCVC.Location = new System.Drawing.Point(400, 281);
            this.textBoxCVC.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.textBoxCVC.Mask = "000";
            this.textBoxCVC.Name = "textBoxCVC";
            this.textBoxCVC.Size = new System.Drawing.Size(300, 40);
            this.textBoxCVC.TabIndex = 10;
            this.textBoxCVC.Enter += new System.EventHandler(this.maskedTextBox_Enter);
            // 
            // textBoxExpirationDate
            // 
            this.textBoxExpirationDate.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxExpirationDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.textBoxExpirationDate.Location = new System.Drawing.Point(400, 211);
            this.textBoxExpirationDate.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.textBoxExpirationDate.Mask = "00\\/00";
            this.textBoxExpirationDate.Name = "textBoxExpirationDate";
            this.textBoxExpirationDate.Size = new System.Drawing.Size(300, 40);
            this.textBoxExpirationDate.TabIndex = 9;
            this.textBoxExpirationDate.ValidatingType = typeof(System.DateTime);
            this.textBoxExpirationDate.Enter += new System.EventHandler(this.maskedTextBox_Enter);
            // 
            // textBoxCardNr
            // 
            this.textBoxCardNr.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxCardNr.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.textBoxCardNr.Location = new System.Drawing.Point(400, 141);
            this.textBoxCardNr.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.textBoxCardNr.Mask = "0000 0000 0000 0000";
            this.textBoxCardNr.Name = "textBoxCardNr";
            this.textBoxCardNr.PromptChar = ' ';
            this.textBoxCardNr.ResetOnPrompt = false;
            this.textBoxCardNr.Size = new System.Drawing.Size(300, 40);
            this.textBoxCardNr.TabIndex = 8;
            this.textBoxCardNr.Enter += new System.EventHandler(this.maskedTextBox_Enter);
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpirationDate.Location = new System.Drawing.Point(153, 214);
            this.labelExpirationDate.Margin = new System.Windows.Forms.Padding(0);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(217, 35);
            this.labelExpirationDate.TabIndex = 3;
            this.labelExpirationDate.Text = "*Expiration Date:";
            // 
            // labelCVC
            // 
            this.labelCVC.AutoSize = true;
            this.labelCVC.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCVC.Location = new System.Drawing.Point(286, 284);
            this.labelCVC.Margin = new System.Windows.Forms.Padding(0);
            this.labelCVC.Name = "labelCVC";
            this.labelCVC.Size = new System.Drawing.Size(84, 35);
            this.labelCVC.TabIndex = 2;
            this.labelCVC.Text = "*CVC:";
            // 
            // textBoxChange
            // 
            this.textBoxChange.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChange.Location = new System.Drawing.Point(400, 491);
            this.textBoxChange.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(300, 40);
            this.textBoxChange.TabIndex = 13;
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(261, 494);
            this.labelChange.Margin = new System.Windows.Forms.Padding(0);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(109, 35);
            this.labelChange.TabIndex = 0;
            this.labelChange.Text = "Change:";
            // 
            // textBoxAmountPaid
            // 
            this.textBoxAmountPaid.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmountPaid.Location = new System.Drawing.Point(400, 421);
            this.textBoxAmountPaid.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.textBoxAmountPaid.Name = "textBoxAmountPaid";
            this.textBoxAmountPaid.Size = new System.Drawing.Size(300, 40);
            this.textBoxAmountPaid.TabIndex = 11;
            this.textBoxAmountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmountPaid_KeyPress);
            // 
            // labelAmountPaid
            // 
            this.labelAmountPaid.AutoSize = true;
            this.labelAmountPaid.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountPaid.Location = new System.Drawing.Point(182, 424);
            this.labelAmountPaid.Margin = new System.Windows.Forms.Padding(0);
            this.labelAmountPaid.Name = "labelAmountPaid";
            this.labelAmountPaid.Size = new System.Drawing.Size(188, 35);
            this.labelAmountPaid.TabIndex = 0;
            this.labelAmountPaid.Text = "*Amount Paid:";
            // 
            // textBoxAmountDue
            // 
            this.textBoxAmountDue.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmountDue.Location = new System.Drawing.Point(400, 351);
            this.textBoxAmountDue.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.textBoxAmountDue.Name = "textBoxAmountDue";
            this.textBoxAmountDue.Size = new System.Drawing.Size(300, 40);
            this.textBoxAmountDue.TabIndex = 11;
            // 
            // labelAmountDue
            // 
            this.labelAmountDue.AutoSize = true;
            this.labelAmountDue.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountDue.Location = new System.Drawing.Point(199, 354);
            this.labelAmountDue.Margin = new System.Windows.Forms.Padding(0);
            this.labelAmountDue.Name = "labelAmountDue";
            this.labelAmountDue.Size = new System.Drawing.Size(171, 35);
            this.labelAmountDue.TabIndex = 0;
            this.labelAmountDue.Text = "Amount Due:";
            // 
            // labelCardNr
            // 
            this.labelCardNr.AutoSize = true;
            this.labelCardNr.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNr.Location = new System.Drawing.Point(245, 144);
            this.labelCardNr.Margin = new System.Windows.Forms.Padding(0);
            this.labelCardNr.Name = "labelCardNr";
            this.labelCardNr.Size = new System.Drawing.Size(125, 35);
            this.labelCardNr.TabIndex = 0;
            this.labelCardNr.Text = "*Card Nr:";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPaymentMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaymentMethod.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPaymentMethod.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(400, 70);
            this.comboBoxPaymentMethod.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(300, 41);
            this.comboBoxPaymentMethod.TabIndex = 7;
            this.comboBoxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentMethod_SelectedIndexChanged);
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentMethod.Location = new System.Drawing.Point(132, 73);
            this.labelPaymentMethod.Margin = new System.Windows.Forms.Padding(0);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(238, 35);
            this.labelPaymentMethod.TabIndex = 0;
            this.labelPaymentMethod.Text = "*Payment Method:";
            // 
            // groupBoxCustomerInfo
            // 
            this.groupBoxCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxEmail);
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxPostalCode);
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxPhoneNr);
            this.groupBoxCustomerInfo.Controls.Add(this.labelNotice);
            this.groupBoxCustomerInfo.Controls.Add(this.labelEmail);
            this.groupBoxCustomerInfo.Controls.Add(this.labelPhoneNr);
            this.groupBoxCustomerInfo.Controls.Add(this.labelPostalCode);
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxAddress);
            this.groupBoxCustomerInfo.Controls.Add(this.labelAddress);
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxLastName);
            this.groupBoxCustomerInfo.Controls.Add(this.labelLastName);
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxFirstName);
            this.groupBoxCustomerInfo.Controls.Add(this.labelFirstName);
            this.groupBoxCustomerInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxCustomerInfo.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold);
            this.groupBoxCustomerInfo.Location = new System.Drawing.Point(25, 25);
            this.groupBoxCustomerInfo.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            this.groupBoxCustomerInfo.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxCustomerInfo.Size = new System.Drawing.Size(902, 587);
            this.groupBoxCustomerInfo.TabIndex = 0;
            this.groupBoxCustomerInfo.TabStop = false;
            this.groupBoxCustomerInfo.Text = "Customer Information";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.textBoxEmail.Location = new System.Drawing.Point(240, 492);
            this.textBoxEmail.MaxLength = 100;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(400, 40);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.textBoxPostalCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.textBoxPostalCode.Location = new System.Drawing.Point(240, 345);
            this.textBoxPostalCode.Mask = "\\LV-0000";
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.PromptChar = ' ';
            this.textBoxPostalCode.Size = new System.Drawing.Size(400, 40);
            this.textBoxPostalCode.TabIndex = 4;
            this.textBoxPostalCode.Enter += new System.EventHandler(this.maskedTextBox_Enter);
            // 
            // textBoxPhoneNr
            // 
            this.textBoxPhoneNr.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.textBoxPhoneNr.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.textBoxPhoneNr.Location = new System.Drawing.Point(240, 420);
            this.textBoxPhoneNr.Mask = "+371 0000 0000";
            this.textBoxPhoneNr.Name = "textBoxPhoneNr";
            this.textBoxPhoneNr.PromptChar = ' ';
            this.textBoxPhoneNr.Size = new System.Drawing.Size(400, 40);
            this.textBoxPhoneNr.TabIndex = 5;
            this.textBoxPhoneNr.Enter += new System.EventHandler(this.maskedTextBox_Enter);
            // 
            // labelNotice
            // 
            this.labelNotice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNotice.AutoSize = true;
            this.labelNotice.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.labelNotice.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNotice.Location = new System.Drawing.Point(304, 61);
            this.labelNotice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(336, 33);
            this.labelNotice.TabIndex = 0;
            this.labelNotice.Text = "Fields with ( * ) are required.";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(89, 495);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(110, 35);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "*E-mail:";
            // 
            // labelPhoneNr
            // 
            this.labelPhoneNr.AutoSize = true;
            this.labelPhoneNr.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNr.Location = new System.Drawing.Point(59, 423);
            this.labelPhoneNr.Margin = new System.Windows.Forms.Padding(0);
            this.labelPhoneNr.Name = "labelPhoneNr";
            this.labelPhoneNr.Size = new System.Drawing.Size(145, 35);
            this.labelPhoneNr.TabIndex = 0;
            this.labelPhoneNr.Text = "*Phone Nr:";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostalCode.Location = new System.Drawing.Point(36, 350);
            this.labelPostalCode.Margin = new System.Windows.Forms.Padding(0);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(171, 35);
            this.labelPostalCode.TabIndex = 0;
            this.labelPostalCode.Text = "*Postal code:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(240, 278);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAddress.MaxLength = 93;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(400, 40);
            this.textBoxAddress.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(74, 277);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(130, 35);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "*Address:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(240, 205);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLastName.MaxLength = 49;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(400, 40);
            this.textBoxLastName.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(51, 205);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(156, 35);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "*Last name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(240, 132);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFirstName.MaxLength = 49;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(400, 40);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(48, 133);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(160, 35);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "*First name:";
            // 
            // labelAdminLogin
            // 
            this.labelAdminLogin.AutoSize = true;
            this.labelAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminLogin.Location = new System.Drawing.Point(5, 9);
            this.labelAdminLogin.Margin = new System.Windows.Forms.Padding(0);
            this.labelAdminLogin.Name = "labelAdminLogin";
            this.labelAdminLogin.Size = new System.Drawing.Size(166, 35);
            this.labelAdminLogin.TabIndex = 1;
            this.labelAdminLogin.Text = "Admin Log In";
            this.labelAdminLogin.Click += new System.EventHandler(this.labelAdminLogin_Click);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::PizzaDelivery.Properties.Resources.pizz_logo;
            this.logo.Location = new System.Drawing.Point(284, 25);
            this.logo.Margin = new System.Windows.Forms.Padding(284, 25, 305, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(424, 238);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PizzaDelivery.Properties.Resources.pizza_seamless_pattern_vector_pizza_pattern_abstract_background_background_useful_restaurant_identity_packaging_89205691;
            this.ClientSize = new System.Drawing.Size(1002, 709);
            this.Controls.Add(this.labelAdminLogin);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Delivery";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageSelectYourOrder.ResumeLayout(false);
            this.groupBoxPizza.ResumeLayout(false);
            this.groupBoxDrinks.ResumeLayout(false);
            this.groupBoxDrinks.PerformLayout();
            this.groupBoxOtherItems.ResumeLayout(false);
            this.groupBoxOtherItems.PerformLayout();
            this.tabPageConfirmOrder.ResumeLayout(false);
            this.tabPageConfirmOrder.PerformLayout();
            this.groupAmount.ResumeLayout(false);
            this.groupAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoConfirmOrder)).EndInit();
            this.tabPageMakePayment.ResumeLayout(false);
            this.groupBoxPaymentInfo.ResumeLayout(false);
            this.groupBoxPaymentInfo.PerformLayout();
            this.groupBoxCustomerInfo.ResumeLayout(false);
            this.groupBoxCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSelectYourOrder;
        private System.Windows.Forms.TabPage tabPageConfirmOrder;
        private System.Windows.Forms.TabPage tabPageMakePayment;
        private System.Windows.Forms.Label labelOrderList;
        private System.Windows.Forms.Button buttonConfirmOrder;
        private System.Windows.Forms.ListView listViewOrderList;
        private System.Windows.Forms.ColumnHeader columnHeaderItems;
        private System.Windows.Forms.ColumnHeader columnHeaderQty;
        private System.Windows.Forms.GroupBox groupBoxDrinks;
        private System.Windows.Forms.GroupBox groupBoxOtherItems;
        private System.Windows.Forms.CheckBox checkBoxWater;
        private System.Windows.Forms.CheckBox checkBoxRootBeer;
        private System.Windows.Forms.CheckBox checkBoxSprite;
        private System.Windows.Forms.CheckBox checkBoxGingerAle;
        private System.Windows.Forms.CheckBox checkBoxIcedTea;
        private System.Windows.Forms.CheckBox checkBoxDietCoke;
        private System.Windows.Forms.CheckBox checkBoxCoke;
        private System.Windows.Forms.TextBox textBoxWaterQty;
        private System.Windows.Forms.TextBox textBoxRootBeerQty;
        private System.Windows.Forms.TextBox textBoxSpriteQty;
        private System.Windows.Forms.TextBox textBoxGingerAleQty;
        private System.Windows.Forms.TextBox textBoxIcedTeaQty;
        private System.Windows.Forms.TextBox textBoxDietCokeQty;
        private System.Windows.Forms.TextBox textBoxCokeQty;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.CheckBox checkBoxSourCreamDip;
        private System.Windows.Forms.CheckBox checkBoxBBQDip;
        private System.Windows.Forms.CheckBox checkBoxGarlicDip;
        private System.Windows.Forms.CheckBox checkBoxCheesyGarlicBread;
        private System.Windows.Forms.CheckBox checkBoxOnionRings;
        private System.Windows.Forms.CheckBox checkBoxPoutine;
        private System.Windows.Forms.CheckBox checkBoxChickenWings;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.TextBox textBoxAmountBeforeTaxes;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label labelPVN;
        private System.Windows.Forms.TextBox textBoxPVN;
        private System.Windows.Forms.Label labelAmountBeforeTaxes;
        private System.Windows.Forms.Button buttonClearOrder;
        private System.Windows.Forms.GroupBox groupBoxPaymentInfo;
        private System.Windows.Forms.GroupBox groupBoxCustomerInfo;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNr;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.TextBox textBoxAmountPaid;
        private System.Windows.Forms.Label labelAmountPaid;
        private System.Windows.Forms.TextBox textBoxAmountDue;
        private System.Windows.Forms.Label labelAmountDue;
        private System.Windows.Forms.Label labelCardNr;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Button buttonSubmitOrder;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox logoConfirmOrder;
        private System.Windows.Forms.GroupBox groupBoxPizza;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.Label labelCVC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPizzaList;
        private System.Windows.Forms.Label labelAdminLogin;
        private System.Windows.Forms.GroupBox groupAmount;
        private System.Windows.Forms.MaskedTextBox textBoxPostalCode;
        private System.Windows.Forms.MaskedTextBox textBoxPhoneNr;
        private System.Windows.Forms.MaskedTextBox textBoxCVC;
        private System.Windows.Forms.MaskedTextBox textBoxExpirationDate;
        private System.Windows.Forms.MaskedTextBox textBoxCardNr;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}