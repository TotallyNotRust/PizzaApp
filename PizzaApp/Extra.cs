using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaApp;
using xmlLoader;

namespace PizzaApp
{
    public partial class Extra : Form
    {
        List<Ingredient> ingredients;
        XMLLoader loader;
        public Extra(List<Ingredient> ing, XMLLoader Loader)
        {
            ingredients = ing; // Sætter lokal liste over ingredienser til liste a ingredienser der bliver passet
            loader = Loader; // Sætter lokal variable med xml fil informationen til den der er blevet passet
           
            InitializeComponent();

            populateLists();
        }

        public void populateLists() // Putter ting på lister 
        {
            foreach (Ingredient ing in ingredients) // Looper gennem alle slags ingredienser
            {
                toppingBox.Items.Add(ing.name + " - " + ing.price + "kr"); // Putter ingrediensen på list over ingredienser
            }
            foreach (Dough Dough in loader.Doughs.Dough) // Looper gennem alle slags dej
            {
                pizzaDough.Items.Add(Dough.name + " - " + Dough.price + "kr"); // Putter dejen på listen over deje
            }
            foreach (Sauce Sauce in loader.Sauces.Sauce) // Looper gennem alle slags sovs
            {
                pizzaSauce.Items.Add(Sauce.name + " - " + Sauce.price + "kr"); // Putter sovsen på listen over sovse
            }
            foreach (Size Size in loader.Sizes.Size) 
            {
                pizzaSize.Items.Add(Size.name + " - " + Size.price + "kr");
            }
        }

        public int toppingPrice = 0;
        public void calculatePriceBox(int index, bool newVal)
        {
            toppingPrice = 0;
            List<string> list = new List<string>();
            foreach (string i in toppingBox.CheckedItems) if (toppingBox.Items[index] != i) list.Add(i);
            try { if (!newVal) list.Add(Convert.ToString(toppingBox.Items[index])); }
            catch { }
            foreach (string i in list)
            {
                toppingPrice += Convert.ToInt32(i.Split('-')[1].Remove(i.Split('-')[1].Length - 2));
            }

            setText();
        }

        public void setText()
        {
            pizzaTotal.Text = "Total: " + Convert.ToString(toppingPrice + doughPrice + saucePrice + sizePrice);
        }

        public int saucePrice = 0;
        private void pizzaSauce_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = pizzaSauce.Text;
            saucePrice = Convert.ToInt32(i.Split('-')[1].Remove(i.Split('-')[1].Length - 2));
            setText();
        }

        public int doughPrice = 0;
        private void pizzaDough_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = pizzaDough.Text;
            doughPrice = Convert.ToInt32(i.Split('-')[1].Remove(i.Split('-')[1].Length - 2));
            setText();
        }

        private void toppingBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            calculatePriceBox(e.Index, e.NewValue == System.Windows.Forms.CheckState.Unchecked);
        }

        public int sizePrice = 0;
        private void pizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = pizzaSize.Text;
            sizePrice = Convert.ToInt32(i.Split('-')[1].Remove(i.Split('-')[1].Length - 2));
            setText();
        }

        private void customPizzaButon_Click(object sender, EventArgs e)
        {

        }
    }
}
