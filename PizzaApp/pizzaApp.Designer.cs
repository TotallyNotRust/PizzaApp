﻿
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
            this.pizzaTextBody = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addPizzaButton = new System.Windows.Forms.Button();
            this.pizzaMenu = new System.Windows.Forms.ListView();
            this.pizzaName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pizzaIngredients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pizzaPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pizzaCart = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuLabelName = new System.Windows.Forms.Label();
            this.infoLabelName = new System.Windows.Forms.Label();
            this.cartLabelName = new System.Windows.Forms.Label();
            this.pizzaTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pizzaDough = new System.Windows.Forms.ComboBox();
            this.pizzaSauce = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pizzaTextBody
            // 
            this.pizzaTextBody.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pizzaTextBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pizzaTextBody.Location = new System.Drawing.Point(213, 110);
            this.pizzaTextBody.Name = "pizzaTextBody";
            this.pizzaTextBody.Size = new System.Drawing.Size(378, 227);
            this.pizzaTextBody.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 55);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(378, 45);
            this.label1.TabIndex = 3;
            // 
            // addPizzaButton
            // 
            this.addPizzaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.addPizzaButton.Location = new System.Drawing.Point(213, 356);
            this.addPizzaButton.Name = "addPizzaButton";
            this.addPizzaButton.Size = new System.Drawing.Size(133, 48);
            this.addPizzaButton.TabIndex = 4;
            this.addPizzaButton.Text = "Extra";
            this.addPizzaButton.UseVisualStyleBackColor = true;
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
            this.pizzaMenu.Location = new System.Drawing.Point(600, 55);
            this.pizzaMenu.Name = "pizzaMenu";
            this.pizzaMenu.Scrollable = false;
            this.pizzaMenu.Size = new System.Drawing.Size(357, 414);
            this.pizzaMenu.TabIndex = 5;
            this.pizzaMenu.UseCompatibleStateImageBehavior = false;
            this.pizzaMenu.View = System.Windows.Forms.View.Details;
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
            this.price});
            this.pizzaCart.FullRowSelect = true;
            this.pizzaCart.GridLines = true;
            this.pizzaCart.HideSelection = false;
            this.pizzaCart.Location = new System.Drawing.Point(12, 55);
            this.pizzaCart.Name = "pizzaCart";
            this.pizzaCart.Scrollable = false;
            this.pizzaCart.Size = new System.Drawing.Size(195, 368);
            this.pizzaCart.TabIndex = 6;
            this.pizzaCart.UseCompatibleStateImageBehavior = false;
            this.pizzaCart.View = System.Windows.Forms.View.Details;
            this.pizzaCart.SelectedIndexChanged += new System.EventHandler(this.pizzaCart_SelectedIndexChanged);
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
            // menuLabelName
            // 
            this.menuLabelName.AutoSize = true;
            this.menuLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabelName.Location = new System.Drawing.Point(576, 12);
            this.menuLabelName.Name = "menuLabelName";
            this.menuLabelName.Size = new System.Drawing.Size(66, 25);
            this.menuLabelName.TabIndex = 7;
            this.menuLabelName.Text = "Menu";
            // 
            // infoLabelName
            // 
            this.infoLabelName.AutoSize = true;
            this.infoLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabelName.Location = new System.Drawing.Point(211, 12);
            this.infoLabelName.Name = "infoLabelName";
            this.infoLabelName.Size = new System.Drawing.Size(47, 25);
            this.infoLabelName.TabIndex = 8;
            this.infoLabelName.Text = "Info";
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
            this.pizzaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaTotal.Location = new System.Drawing.Point(12, 434);
            this.pizzaTotal.Name = "pizzaTotal";
            this.pizzaTotal.Size = new System.Drawing.Size(194, 39);
            this.pizzaTotal.TabIndex = 10;
            this.pizzaTotal.Text = "Total: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pizzaDough
            // 
            this.pizzaDough.DropDownHeight = 102;
            this.pizzaDough.FormattingEnabled = true;
            this.pizzaDough.IntegralHeight = false;
            this.pizzaDough.ItemHeight = 13;
            this.pizzaDough.Location = new System.Drawing.Point(401, 356);
            this.pizzaDough.Name = "pizzaDough";
            this.pizzaDough.Size = new System.Drawing.Size(190, 21);
            this.pizzaDough.TabIndex = 18;
            this.pizzaDough.Text = "Brød";
            // 
            // pizzaSauce
            // 
            this.pizzaSauce.FormattingEnabled = true;
            this.pizzaSauce.Location = new System.Drawing.Point(401, 410);
            this.pizzaSauce.Name = "pizzaSauce";
            this.pizzaSauce.Size = new System.Drawing.Size(190, 21);
            this.pizzaSauce.TabIndex = 19;
            this.pizzaSauce.Text = "Sovs";
            this.pizzaSauce.SelectedIndexChanged += new System.EventHandler(this.pizzaSauce_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(213, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 48);
            this.button1.TabIndex = 20;
            this.button1.Text = "Tilføj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pizzaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pizzaSauce);
            this.Controls.Add(this.pizzaDough);
            this.Controls.Add(this.pizzaTotal);
            this.Controls.Add(this.cartLabelName);
            this.Controls.Add(this.infoLabelName);
            this.Controls.Add(this.menuLabelName);
            this.Controls.Add(this.pizzaCart);
            this.Controls.Add(this.pizzaMenu);
            this.Controls.Add(this.addPizzaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pizzaTextBody);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pizzaApp";
            this.Text = "Pizza App";
            this.Load += new System.EventHandler(this.pizzaApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pizzaTextBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPizzaButton;
        private System.Windows.Forms.ColumnHeader pizzaName;
        private System.Windows.Forms.ColumnHeader pizzaIngredients;
        private System.Windows.Forms.ColumnHeader pizzaPrice;
        private System.Windows.Forms.ListView pizzaCart;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Label menuLabelName;
        private System.Windows.Forms.Label infoLabelName;
        private System.Windows.Forms.Label cartLabelName;
        private System.Windows.Forms.Label pizzaTotal;
        private System.Windows.Forms.ListView pizzaMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox pizzaDough;
        private System.Windows.Forms.ComboBox pizzaSauce;
        private System.Windows.Forms.Button button1;
    }
}

