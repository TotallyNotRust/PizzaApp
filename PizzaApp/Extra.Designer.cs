
namespace PizzaApp
{
    partial class Extra
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
            this.toppingBox = new System.Windows.Forms.CheckedListBox();
            this.pizzaDough = new System.Windows.Forms.ComboBox();
            this.pizzaSauce = new System.Windows.Forms.ComboBox();
            this.pizzaTotal = new System.Windows.Forms.Label();
            this.pizzaSize = new System.Windows.Forms.ComboBox();
            this.customPizzaButon = new System.Windows.Forms.Button();
            this.spiceBox = new System.Windows.Forms.CheckedListBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.breadLabel = new System.Windows.Forms.Label();
            this.sauceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toppingBox
            // 
            this.toppingBox.FormattingEnabled = true;
            this.toppingBox.Location = new System.Drawing.Point(12, 30);
            this.toppingBox.Name = "toppingBox";
            this.toppingBox.Size = new System.Drawing.Size(140, 109);
            this.toppingBox.TabIndex = 0;
            this.toppingBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.updatePrice);
            // 
            // pizzaDough
            // 
            this.pizzaDough.DropDownHeight = 102;
            this.pizzaDough.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizzaDough.FormattingEnabled = true;
            this.pizzaDough.IntegralHeight = false;
            this.pizzaDough.ItemHeight = 13;
            this.pizzaDough.Location = new System.Drawing.Point(163, 72);
            this.pizzaDough.Name = "pizzaDough";
            this.pizzaDough.Size = new System.Drawing.Size(133, 21);
            this.pizzaDough.TabIndex = 19;
            this.pizzaDough.SelectedIndexChanged += new System.EventHandler(this.updatePrice);
            // 
            // pizzaSauce
            // 
            this.pizzaSauce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizzaSauce.FormattingEnabled = true;
            this.pizzaSauce.Location = new System.Drawing.Point(163, 122);
            this.pizzaSauce.Name = "pizzaSauce";
            this.pizzaSauce.Size = new System.Drawing.Size(133, 21);
            this.pizzaSauce.TabIndex = 20;
            this.pizzaSauce.SelectedIndexChanged += new System.EventHandler(this.updatePrice);
            // 
            // pizzaTotal
            // 
            this.pizzaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaTotal.Location = new System.Drawing.Point(158, 30);
            this.pizzaTotal.Name = "pizzaTotal";
            this.pizzaTotal.Size = new System.Drawing.Size(151, 39);
            this.pizzaTotal.TabIndex = 21;
            this.pizzaTotal.Text = "Total: ";
            // 
            // pizzaSize
            // 
            this.pizzaSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizzaSize.FormattingEnabled = true;
            this.pizzaSize.Location = new System.Drawing.Point(163, 172);
            this.pizzaSize.Name = "pizzaSize";
            this.pizzaSize.Size = new System.Drawing.Size(133, 21);
            this.pizzaSize.TabIndex = 22;
            this.pizzaSize.SelectedIndexChanged += new System.EventHandler(this.updatePrice);
            // 
            // customPizzaButon
            // 
            this.customPizzaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.customPizzaButon.Location = new System.Drawing.Point(163, 211);
            this.customPizzaButon.Name = "customPizzaButon";
            this.customPizzaButon.Size = new System.Drawing.Size(133, 43);
            this.customPizzaButon.TabIndex = 23;
            this.customPizzaButon.Text = "Put i vogn";
            this.customPizzaButon.UseVisualStyleBackColor = true;
            this.customPizzaButon.Click += new System.EventHandler(this.customPizzaButon_Click);
            // 
            // spiceBox
            // 
            this.spiceBox.FormattingEnabled = true;
            this.spiceBox.Location = new System.Drawing.Point(12, 145);
            this.spiceBox.Name = "spiceBox";
            this.spiceBox.Size = new System.Drawing.Size(140, 109);
            this.spiceBox.TabIndex = 24;
            this.spiceBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.updatePrice);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(160, 156);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(48, 13);
            this.sizeLabel.TabIndex = 35;
            this.sizeLabel.Text = "Størrelse";
            // 
            // breadLabel
            // 
            this.breadLabel.AutoSize = true;
            this.breadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadLabel.Location = new System.Drawing.Point(160, 56);
            this.breadLabel.Name = "breadLabel";
            this.breadLabel.Size = new System.Drawing.Size(29, 13);
            this.breadLabel.TabIndex = 36;
            this.breadLabel.Text = "Brød";
            // 
            // sauceLabel
            // 
            this.sauceLabel.AutoSize = true;
            this.sauceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sauceLabel.Location = new System.Drawing.Point(160, 106);
            this.sauceLabel.Name = "sauceLabel";
            this.sauceLabel.Size = new System.Drawing.Size(31, 13);
            this.sauceLabel.TabIndex = 37;
            this.sauceLabel.Text = "Sovs";
            // 
            // Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 268);
            this.Controls.Add(this.sauceLabel);
            this.Controls.Add(this.breadLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.spiceBox);
            this.Controls.Add(this.customPizzaButon);
            this.Controls.Add(this.pizzaSize);
            this.Controls.Add(this.pizzaTotal);
            this.Controls.Add(this.pizzaSauce);
            this.Controls.Add(this.pizzaDough);
            this.Controls.Add(this.toppingBox);
            this.Name = "Extra";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox toppingBox;
        private System.Windows.Forms.ComboBox pizzaDough;
        private System.Windows.Forms.ComboBox pizzaSauce;
        private System.Windows.Forms.Label pizzaTotal;
        private System.Windows.Forms.ComboBox pizzaSize;
        private System.Windows.Forms.Button customPizzaButon;
        private System.Windows.Forms.CheckedListBox spiceBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label breadLabel;
        private System.Windows.Forms.Label sauceLabel;
    }
}