namespace PizzaDelivery
{
    partial class ListItemsPizza
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.labelQty = new System.Windows.Forms.Label();
            this.radioButtonSize50 = new System.Windows.Forms.RadioButton();
            this.radioButtonSize35 = new System.Windows.Forms.RadioButton();
            this.radioButtonSize20 = new System.Windows.Forms.RadioButton();
            this.labelSize = new System.Windows.Forms.Label();
            this.radioButtonSuasageCrust = new System.Windows.Forms.RadioButton();
            this.radioButtonCheesyCrust = new System.Windows.Forms.RadioButton();
            this.radioButtonNormalCrust = new System.Windows.Forms.RadioButton();
            this.labelCrust = new System.Windows.Forms.Label();
            this.panelCrust = new System.Windows.Forms.Panel();
            this.panelSize = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panelCrust.SuspendLayout();
            this.panelSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(202, 40);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(156, 37);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Pizza name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.labelPrice.ForeColor = System.Drawing.Color.Olive;
            this.labelPrice.Location = new System.Drawing.Point(226, 77);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(104, 49);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(25, 25);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox.Location = new System.Drawing.Point(357, 138);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(18, 17);
            this.checkBox.TabIndex = 6;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // textBoxQty
            // 
            this.textBoxQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxQty.Location = new System.Drawing.Point(287, 131);
            this.textBoxQty.MaxLength = 2;
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(25, 26);
            this.textBoxQty.TabIndex = 7;
            this.textBoxQty.Text = "1";
            this.textBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQty_KeyPress);
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelQty.Location = new System.Drawing.Point(205, 134);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(76, 20);
            this.labelQty.TabIndex = 8;
            this.labelQty.Text = "Quantity:";
            // 
            // radioButtonSize50
            // 
            this.radioButtonSize50.AutoSize = true;
            this.radioButtonSize50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSize50.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSize50.Location = new System.Drawing.Point(19, 131);
            this.radioButtonSize50.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonSize50.Name = "radioButtonSize50";
            this.radioButtonSize50.Size = new System.Drawing.Size(159, 33);
            this.radioButtonSize50.TabIndex = 9;
            this.radioButtonSize50.Text = "50Ø (15,00€)";
            this.radioButtonSize50.UseVisualStyleBackColor = true;
            // 
            // radioButtonSize35
            // 
            this.radioButtonSize35.AutoSize = true;
            this.radioButtonSize35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSize35.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSize35.Location = new System.Drawing.Point(19, 88);
            this.radioButtonSize35.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonSize35.Name = "radioButtonSize35";
            this.radioButtonSize35.Size = new System.Drawing.Size(147, 33);
            this.radioButtonSize35.TabIndex = 10;
            this.radioButtonSize35.Text = "35Ø (7,00€)";
            this.radioButtonSize35.UseVisualStyleBackColor = true;
            // 
            // radioButtonSize20
            // 
            this.radioButtonSize20.AutoSize = true;
            this.radioButtonSize20.Checked = true;
            this.radioButtonSize20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSize20.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSize20.Location = new System.Drawing.Point(19, 45);
            this.radioButtonSize20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonSize20.Name = "radioButtonSize20";
            this.radioButtonSize20.Size = new System.Drawing.Size(147, 33);
            this.radioButtonSize20.TabIndex = 11;
            this.radioButtonSize20.TabStop = true;
            this.radioButtonSize20.Text = "20Ø (4,00€)";
            this.radioButtonSize20.UseVisualStyleBackColor = true;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(13, 5);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(129, 35);
            this.labelSize.TabIndex = 12;
            this.labelSize.Text = "Pizza size:";
            // 
            // radioButtonSuasageCrust
            // 
            this.radioButtonSuasageCrust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonSuasageCrust.AutoSize = true;
            this.radioButtonSuasageCrust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSuasageCrust.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.radioButtonSuasageCrust.Location = new System.Drawing.Point(17, 133);
            this.radioButtonSuasageCrust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonSuasageCrust.Name = "radioButtonSuasageCrust";
            this.radioButtonSuasageCrust.Size = new System.Drawing.Size(114, 33);
            this.radioButtonSuasageCrust.TabIndex = 13;
            this.radioButtonSuasageCrust.Text = "Sausage";
            this.radioButtonSuasageCrust.UseVisualStyleBackColor = true;
            // 
            // radioButtonCheesyCrust
            // 
            this.radioButtonCheesyCrust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonCheesyCrust.AutoSize = true;
            this.radioButtonCheesyCrust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCheesyCrust.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.radioButtonCheesyCrust.Location = new System.Drawing.Point(17, 90);
            this.radioButtonCheesyCrust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCheesyCrust.Name = "radioButtonCheesyCrust";
            this.radioButtonCheesyCrust.Size = new System.Drawing.Size(104, 33);
            this.radioButtonCheesyCrust.TabIndex = 14;
            this.radioButtonCheesyCrust.Text = "Cheesy";
            this.radioButtonCheesyCrust.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormalCrust
            // 
            this.radioButtonNormalCrust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonNormalCrust.AutoSize = true;
            this.radioButtonNormalCrust.Checked = true;
            this.radioButtonNormalCrust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNormalCrust.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.radioButtonNormalCrust.Location = new System.Drawing.Point(17, 47);
            this.radioButtonNormalCrust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonNormalCrust.Name = "radioButtonNormalCrust";
            this.radioButtonNormalCrust.Size = new System.Drawing.Size(108, 33);
            this.radioButtonNormalCrust.TabIndex = 15;
            this.radioButtonNormalCrust.TabStop = true;
            this.radioButtonNormalCrust.Text = "Normal";
            this.radioButtonNormalCrust.UseVisualStyleBackColor = true;
            // 
            // labelCrust
            // 
            this.labelCrust.AutoSize = true;
            this.labelCrust.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrust.Location = new System.Drawing.Point(11, 7);
            this.labelCrust.Name = "labelCrust";
            this.labelCrust.Size = new System.Drawing.Size(84, 35);
            this.labelCrust.TabIndex = 16;
            this.labelCrust.Text = "Crust:";
            // 
            // panelCrust
            // 
            this.panelCrust.Controls.Add(this.labelCrust);
            this.panelCrust.Controls.Add(this.radioButtonSuasageCrust);
            this.panelCrust.Controls.Add(this.radioButtonCheesyCrust);
            this.panelCrust.Controls.Add(this.radioButtonNormalCrust);
            this.panelCrust.Location = new System.Drawing.Point(218, 172);
            this.panelCrust.Name = "panelCrust";
            this.panelCrust.Size = new System.Drawing.Size(156, 181);
            this.panelCrust.TabIndex = 17;
            // 
            // panelSize
            // 
            this.panelSize.Controls.Add(this.radioButtonSize50);
            this.panelSize.Controls.Add(this.radioButtonSize35);
            this.panelSize.Controls.Add(this.radioButtonSize20);
            this.panelSize.Controls.Add(this.labelSize);
            this.panelSize.Location = new System.Drawing.Point(12, 174);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(187, 179);
            this.panelSize.TabIndex = 18;
            // 
            // ListItemsPizza
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelSize);
            this.Controls.Add(this.panelCrust);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxImage);
            this.Margin = new System.Windows.Forms.Padding(20, 25, 20, 0);
            this.Name = "ListItemsPizza";
            this.Size = new System.Drawing.Size(400, 353);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panelCrust.ResumeLayout(false);
            this.panelCrust.PerformLayout();
            this.panelSize.ResumeLayout(false);
            this.panelSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.RadioButton radioButtonSize50;
        private System.Windows.Forms.RadioButton radioButtonSize35;
        private System.Windows.Forms.RadioButton radioButtonSize20;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.RadioButton radioButtonSuasageCrust;
        private System.Windows.Forms.RadioButton radioButtonCheesyCrust;
        private System.Windows.Forms.RadioButton radioButtonNormalCrust;
        private System.Windows.Forms.Label labelCrust;
        private System.Windows.Forms.Panel panelCrust;
        private System.Windows.Forms.Panel panelSize;
    }
}
