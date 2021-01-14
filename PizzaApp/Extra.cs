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
        pizzaApp returnTo;

        public Extra(List<Ingredient> ing, XMLLoader Loader, pizzaApp returnto)
        {
            ingredients = ing; // Sætter lokal liste over ingredienser til liste a ingredienser der bliver passet
            loader = Loader; // Sætter lokal variable med xml fil informationen til den der er blevet passet
            returnTo = returnto; // bruges til at returne den nye pizza

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
            foreach (Spice Spice in loader.Spices.Spice)
            {
                spiceBox.Items.Add(Spice.name + " - " + Spice.price + "kr");
            }
        }

        public string ingredientList(string needIngredients, List<Ingredient> allIngredients)
        {
            string str = "";
            string[] newIngredients = needIngredients.Split(',');
            foreach (string ingredient in newIngredients)
            {
                if (ingredient != "")
                    str += allIngredients.ElementAt(Convert.ToInt32(ingredient)).name + ", ";
            }
            return str;
        }

        private void customPizzaButon_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza();
            pizza.name = "Lav selv pizza med ";
            foreach (string i in toppingBox.CheckedItems)
            {
                pizza.ingredients += toppingBox.Items.IndexOf(i) + ",";
                pizza.name += i.Split('-')[0];
                if (toppingBox.Items.IndexOf(i) != toppingBox.Items.Count)
                    pizza.name += "og ";
            }
            pizza.spices = "";
            foreach (string i in spiceBox.CheckedItems)
            {
                pizza.spices += spiceBox.Items.IndexOf(i) + ",";
            }
            pizza.name.Substring(0, pizza.name.Length - 3);
            pizza.dough = loader.Doughs.Dough[pizzaDough.SelectedIndex].dId;
            pizza.sauce = loader.Sauces.Sauce[pizzaSauce.SelectedIndex].sId;
            pizza.size = Convert.ToInt32(loader.Sizes.Size[pizzaSize.SelectedIndex].sId);

            returnTo.pizzas.Add(pizza);
            ListViewItem Item = new ListViewItem(pizza.name); // Laver nyt listviewitem til produkt or giver den navnet på produktet
            Item.SubItems.Add(ingredientList(pizza.ingredients, ingredients)); // Giver listviewitemet ingredienser
            Item.SubItems.Add(returnTo.getPizzaPrice(pizza)); // og pris
            returnTo.pizzaMenu.Items.Add(Item); // Putter data på spreadsheet
            Item = new ListViewItem(loader.Sizes.Size[pizza.size].name + " " + pizza.name.ToLower()); // Laver nyt listviewitem til produkt or giver den navnet på produktet
            Item.SubItems.Add(returnTo.getPizzaPrice(pizza)); // og pris
            Item.SubItems.Add("false");
            returnTo.pizzaCart.Items.Add(Item);
            returnTo.cart.pizzaList = pizza;
            this.Close();
        }
        #region opdater label med pris
        private void updatePrice(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == System.Windows.Forms.CheckState.Checked)
                updatePrice(Convert.ToInt32(Convert.ToString(sender.GetType().GetProperty("SelectedItem").GetValue(sender, null)).Split('-')[1].Split('k')[0]));
        }
        private void updatePrice(object sender, EventArgs e)
        {
            updatePrice(0);
        }

        private void updatePrice(int extra)
        {
            
            Pizza pizza = new Pizza();
            pizza.name = "Lav selv pizza med ";
            foreach (string i in toppingBox.CheckedItems)
            {
                pizza.ingredients += toppingBox.Items.IndexOf(i) + ",";
            }
            pizza.spices = "";
            foreach (string i in spiceBox.CheckedItems)
            {
                pizza.spices += spiceBox.Items.IndexOf(i) + ",";
            }
            if (pizzaDough.SelectedIndex != -1)
                pizza.dough = loader.Doughs.Dough[pizzaDough.SelectedIndex].dId;
            if (pizzaSauce.SelectedIndex != -1)
                pizza.sauce = loader.Sauces.Sauce[pizzaSauce.SelectedIndex].sId;
            if (pizzaSize.SelectedIndex != -1)
                pizza.size = Convert.ToInt32(loader.Sizes.Size[pizzaSize.SelectedIndex].sId);

            pizzaTotal.Text = "Total: " + returnTo.getPizzaPrice(pizza, extra);
        }
        #endregion

    }
}
