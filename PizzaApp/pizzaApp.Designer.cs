
namespace PizzaApp
{
    partial class pizzaApp
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
            this.pizzaMenu = new System.Windows.Forms.ListView();
            this.pizzaName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pizzaIngredients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pizzaPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pizzaCart = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isDrink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartLabelName = new System.Windows.Forms.Label();
            this.pizzaTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPrizza = new System.Windows.Forms.Button();
            this.customPizzaButon = new System.Windows.Forms.Button();
            this.pizzaSauce = new System.Windows.Forms.ComboBox();
            this.pizzaDough = new System.Windows.Forms.ComboBox();
            this.drinksMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pizzaSize = new System.Windows.Forms.ComboBox();
            this.drinkSize = new System.Windows.Forms.ComboBox();
            this.addDrink = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pizzaLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.removeFromCart = new System.Windows.Forms.Button();
            this.discountLabel = new System.Windows.Forms.Label();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pizzaMenu
            // 
            this.pizzaMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pizzaName,
            this.pizzaIngredients,
            this.pizzaPrice});
            this.pizzaMenu.FullRowSelect = true;
            this.pizzaMenu.GridLines = true;
            this.pizzaMenu.HideSelection = false;
            this.pizzaMenu.Location = new System.Drawing.Point(216, 69);
            this.pizzaMenu.Name = "pizzaMenu";
            this.pizzaMenu.Scrollable = false;
            this.pizzaMenu.ShowItemToolTips = true;
            this.pizzaMenu.Size = new System.Drawing.Size(357, 269);
            this.pizzaMenu.TabIndex = 5;
            this.pizzaMenu.UseCompatibleStateImageBehavior = false;
            this.pizzaMenu.View = System.Windows.Forms.View.Details;
            this.pizzaMenu.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.pizzaMenu_SelectedIndexChanged);
            this.pizzaMenu.SelectedIndexChanged += new System.EventHandler(this.pizzaMenu_SelectedIndexChanged);
            // 
            // pizzaName
            // 
            this.pizzaName.Text = "Name";
            this.pizzaName.Width = 112;
            // 
            // pizzaIngredients
            // 
            this.pizzaIngredients.Text = "Ingredienser";
            this.pizzaIngredients.Width = 182;
            // 
            // pizzaPrice
            // 
            this.pizzaPrice.Text = "Pris";
            // 
            // pizzaCart
            // 
            this.pizzaCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.price,
            this.isDrink});
            this.pizzaCart.FullRowSelect = true;
            this.pizzaCart.GridLines = true;
            this.pizzaCart.HideSelection = false;
            this.pizzaCart.Location = new System.Drawing.Point(12, 69);
            this.pizzaCart.Name = "pizzaCart";
            this.pizzaCart.Scrollable = false;
            this.pizzaCart.ShowItemToolTips = true;
            this.pizzaCart.Size = new System.Drawing.Size(195, 269);
            this.pizzaCart.TabIndex = 6;
            this.pizzaCart.UseCompatibleStateImageBehavior = false;
            this.pizzaCart.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Navn";
            this.name.Width = 131;
            // 
            // price
            // 
            this.price.Text = "Pris";
            // 
            // isDrink
            // 
            this.isDrink.Width = 0;
            // 
            // cartLabelName
            // 
            this.cartLabelName.AutoSize = true;
            this.cartLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartLabelName.Location = new System.Drawing.Point(12, 12);
            this.cartLabelName.Name = "cartLabelName";
            this.cartLabelName.Size = new System.Drawing.Size(62, 25);
            this.cartLabelName.TabIndex = 9;
            this.cartLabelName.Text = "Vogn";
            // 
            // pizzaTotal
            // 
            this.pizzaTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pizzaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pizzaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pizzaTotal.Location = new System.Drawing.Point(7, 413);
            this.pizzaTotal.Name = "pizzaTotal";
            this.pizzaTotal.Size = new System.Drawing.Size(194, 62);
            this.pizzaTotal.TabIndex = 10;
            this.pizzaTotal.Text = "Total: 0kr";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addPrizza
            // 
            this.addPrizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.addPrizza.Location = new System.Drawing.Point(213, 425);
            this.addPrizza.Name = "addPrizza";
            this.addPrizza.Size = new System.Drawing.Size(133, 48);
            this.addPrizza.TabIndex = 20;
            this.addPrizza.Text = "Tilføj pizza";
            this.addPrizza.UseVisualStyleBackColor = true;
            this.addPrizza.Click += new System.EventHandler(this.addPrizza_Click);
            // 
            // customPizzaButon
            // 
            this.customPizzaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.customPizzaButon.Location = new System.Drawing.Point(213, 350);
            this.customPizzaButon.Name = "customPizzaButon";
            this.customPizzaButon.Size = new System.Drawing.Size(133, 45);
            this.customPizzaButon.TabIndex = 4;
            this.customPizzaButon.Text = "Lav selv pizza";
            this.customPizzaButon.UseVisualStyleBackColor = true;
            this.customPizzaButon.Click += new System.EventHandler(this.addPizzaButton_Click);
            // 
            // pizzaSauce
            // 
            this.pizzaSauce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizzaSauce.FormattingEnabled = true;
            this.pizzaSauce.Location = new System.Drawing.Point(352, 410);
            this.pizzaSauce.Name = "pizzaSauce";
            this.pizzaSauce.Size = new System.Drawing.Size(190, 21);
            this.pizzaSauce.TabIndex = 19;
            // 
            // pizzaDough
            // 
            this.pizzaDough.DropDownHeight = 102;
            this.pizzaDough.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizzaDough.FormattingEnabled = true;
            this.pizzaDough.IntegralHeight = false;
            this.pizzaDough.ItemHeight = 13;
            this.pizzaDough.Location = new System.Drawing.Point(352, 370);
            this.pizzaDough.Name = "pizzaDough";
            this.pizzaDough.Size = new System.Drawing.Size(190, 21);
            this.pizzaDough.TabIndex = 18;
            // 
            // drinksMenu
            // 
            this.drinksMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.drinksMenu.FullRowSelect = true;
            this.drinksMenu.GridLines = true;
            this.drinksMenu.HideSelection = false;
            this.drinksMenu.Location = new System.Drawing.Point(581, 69);
            this.drinksMenu.Name = "drinksMenu";
            this.drinksMenu.Scrollable = false;
            this.drinksMenu.Size = new System.Drawing.Size(182, 269);
            this.drinksMenu.TabIndex = 21;
            this.drinksMenu.UseCompatibleStateImageBehavior = false;
            this.drinksMenu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pris";
            // 
            // pizzaSize
            // 
            this.pizzaSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizzaSize.FormattingEnabled = true;
            this.pizzaSize.Location = new System.Drawing.Point(352, 451);
            this.pizzaSize.Name = "pizzaSize";
            this.pizzaSize.Size = new System.Drawing.Size(190, 21);
            this.pizzaSize.TabIndex = 22;
            // 
            // drinkSize
            // 
            this.drinkSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drinkSize.FormattingEnabled = true;
            this.drinkSize.Location = new System.Drawing.Point(581, 356);
            this.drinkSize.Name = "drinkSize";
            this.drinkSize.Size = new System.Drawing.Size(182, 21);
            this.drinkSize.TabIndex = 23;
            // 
            // addDrink
            // 
            this.addDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.addDrink.Location = new System.Drawing.Point(581, 383);
            this.addDrink.Name = "addDrink";
            this.addDrink.Size = new System.Drawing.Size(182, 48);
            this.addDrink.TabIndex = 24;
            this.addDrink.Text = "Tilføj drikkevare";
            this.addDrink.UseVisualStyleBackColor = true;
            this.addDrink.Click += new System.EventHandler(this.addDrink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Menu";
            // 
            // pizzaLabel
            // 
            this.pizzaLabel.AutoSize = true;
            this.pizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaLabel.Location = new System.Drawing.Point(213, 37);
            this.pizzaLabel.Name = "pizzaLabel";
            this.pizzaLabel.Size = new System.Drawing.Size(47, 20);
            this.pizzaLabel.TabIndex = 27;
            this.pizzaLabel.Text = "Pizza";
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(577, 37);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(89, 20);
            this.drinksLabel.TabIndex = 28;
            this.drinksLabel.Text = "Drikkevarer";
            // 
            // removeFromCart
            // 
            this.removeFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.removeFromCart.Location = new System.Drawing.Point(7, 356);
            this.removeFromCart.Name = "removeFromCart";
            this.removeFromCart.Size = new System.Drawing.Size(87, 48);
            this.removeFromCart.TabIndex = 29;
            this.removeFromCart.Text = "Fjern fra vogn";
            this.removeFromCart.UseVisualStyleBackColor = true;
            this.removeFromCart.Click += new System.EventHandler(this.removeFromCart_Click);
            // 
            // discountLabel
            // 
            this.discountLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountLabel.Enabled = false;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(7, 445);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(194, 30);
            this.discountLabel.TabIndex = 30;
            this.discountLabel.Visible = false;
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.Location = new System.Drawing.Point(280, 21);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(72, 13);
            this.noticeLabel.TabIndex = 31;
            this.noticeLabel.Text = "*Priser for lille.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Brød";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sovs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Størrelse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(578, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Størrelse";
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.orderButton.Location = new System.Drawing.Point(114, 355);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(87, 48);
            this.orderButton.TabIndex = 36;
            this.orderButton.Text = "Bestil";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // pizzaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 484);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.removeFromCart);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.pizzaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDrink);
            this.Controls.Add(this.drinkSize);
            this.Controls.Add(this.pizzaSize);
            this.Controls.Add(this.drinksMenu);
            this.Controls.Add(this.addPrizza);
            this.Controls.Add(this.pizzaSauce);
            this.Controls.Add(this.pizzaDough);
            this.Controls.Add(this.pizzaTotal);
            this.Controls.Add(this.cartLabelName);
            this.Controls.Add(this.pizzaCart);
            this.Controls.Add(this.pizzaMenu);
            this.Controls.Add(this.customPizzaButon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pizzaApp";
            this.Text = "Pizza App";
            this.Load += new System.EventHandler(this.pizzaApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader pizzaName;
        private System.Windows.Forms.ColumnHeader pizzaIngredients;
        private System.Windows.Forms.ColumnHeader pizzaPrice;
        public System.Windows.Forms.ListView pizzaCart;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Label cartLabelName;
        public System.Windows.Forms.Label pizzaTotal;
        public System.Windows.Forms.ListView pizzaMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button addPrizza;
        private System.Windows.Forms.Button customPizzaButon;
        private System.Windows.Forms.ComboBox pizzaSauce;
        private System.Windows.Forms.ComboBox pizzaDough;
        public System.Windows.Forms.ListView drinksMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox pizzaSize;
        private System.Windows.Forms.ComboBox drinkSize;
        private System.Windows.Forms.Button addDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pizzaLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.Button removeFromCart;
        private System.Windows.Forms.ColumnHeader isDrink;
        public System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button orderButton;
    }
}

