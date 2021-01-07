
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
            this.SuspendLayout();
            // 
            // toppingBox
            // 
            this.toppingBox.FormattingEnabled = true;
            this.toppingBox.Location = new System.Drawing.Point(12, 87);
            this.toppingBox.Name = "toppingBox";
            this.toppingBox.Size = new System.Drawing.Size(140, 109);
            this.toppingBox.TabIndex = 0;
            this.toppingBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.toppingBox_ItemCheck);
            this.toppingBox.SelectedIndexChanged += new System.EventHandler(this.toppingBox_SelectedIndexChanged);
            // 
            // pizzaDough
            // 
            this.pizzaDough.DropDownHeight = 102;
            this.pizzaDough.FormattingEnabled = true;
            this.pizzaDough.IntegralHeight = false;
            this.pizzaDough.ItemHeight = 13;
            this.pizzaDough.Location = new System.Drawing.Point(163, 72);
            this.pizzaDough.Name = "pizzaDough";
            this.pizzaDough.Size = new System.Drawing.Size(133, 21);
            this.pizzaDough.TabIndex = 19;
            this.pizzaDough.Text = "Brød";
            this.pizzaDough.SelectedIndexChanged += new System.EventHandler(this.pizzaDough_SelectedIndexChanged);
            // 
            // pizzaSauce
            // 
            this.pizzaSauce.FormattingEnabled = true;
            this.pizzaSauce.Location = new System.Drawing.Point(163, 99);
            this.pizzaSauce.Name = "pizzaSauce";
            this.pizzaSauce.Size = new System.Drawing.Size(133, 21);
            this.pizzaSauce.TabIndex = 20;
            this.pizzaSauce.Text = "Sovs";
            this.pizzaSauce.SelectedIndexChanged += new System.EventHandler(this.pizzaSauce_SelectedIndexChanged);
            // 
            // pizzaTotal
            // 
            this.pizzaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaTotal.Location = new System.Drawing.Point(158, 30);
            this.pizzaTotal.Name = "pizzaTotal";
            this.pizzaTotal.Size = new System.Drawing.Size(194, 39);
            this.pizzaTotal.TabIndex = 21;
            this.pizzaTotal.Text = "Total: ";
            // 
            // pizzaSize
            // 
            this.pizzaSize.FormattingEnabled = true;
            this.pizzaSize.Location = new System.Drawing.Point(163, 126);
            this.pizzaSize.Name = "pizzaSize";
            this.pizzaSize.Size = new System.Drawing.Size(133, 21);
            this.pizzaSize.TabIndex = 22;
            this.pizzaSize.Text = "Størrelse";
            this.pizzaSize.SelectedIndexChanged += new System.EventHandler(this.pizzaSize_SelectedIndexChanged);
            // 
            // customPizzaButon
            // 
            this.customPizzaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.customPizzaButon.Location = new System.Drawing.Point(163, 153);
            this.customPizzaButon.Name = "customPizzaButon";
            this.customPizzaButon.Size = new System.Drawing.Size(133, 43);
            this.customPizzaButon.TabIndex = 23;
            this.customPizzaButon.Text = "Put i vogn";
            this.customPizzaButon.UseVisualStyleBackColor = true;
            this.customPizzaButon.Click += new System.EventHandler(this.customPizzaButon_Click);
            // 
            // Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 207);
            this.Controls.Add(this.customPizzaButon);
            this.Controls.Add(this.pizzaSize);
            this.Controls.Add(this.pizzaTotal);
            this.Controls.Add(this.pizzaSauce);
            this.Controls.Add(this.pizzaDough);
            this.Controls.Add(this.toppingBox);
            this.Name = "Extra";
            this.Text = "Lav selv pizza";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox toppingBox;
        private System.Windows.Forms.ComboBox pizzaDough;
        private System.Windows.Forms.ComboBox pizzaSauce;
        private System.Windows.Forms.Label pizzaTotal;
        private System.Windows.Forms.ComboBox pizzaSize;
        private System.Windows.Forms.Button customPizzaButon;
    }
}