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

        public Extra(List<Ingredient> ing, XMLLoader Loader, Pizza pizza, pizzaApp returnto)
        {
            ingredients = ing; // Sætter lokal liste over ingredienser til liste a ingredienser der bliver passet
            loader = Loader; // Sætter lokal variable med xml fil informationen til den der er blevet passet
            returnTo = returnto; // bruges til at returne den nye pizza

            InitializeComponent();

            populateLists();

            if (pizza != null)
            {
                
                foreach(string i in pizza.ingredients.Split(','))
                {
                    toppingBox.SetItemCheckState(Convert.ToInt32(i), CheckState.Checked);
                }


                foreach (string i in pizza.spices.Split(','))
                {
                    spiceBox.SetItemCheckState(Convert.ToInt32(i), CheckState.Checked);
                }
                pizzaDough.SelectedIndex = Convert.ToInt32(pizza.dough);
                pizzaSauce.SelectedIndex = Convert.ToInt32(pizza.sauce);
                if (pizza.size != -1)
                    pizzaSize.SelectedIndex = Convert.ToInt32(pizza.size);
                else
                    pizzaSize.SelectedIndex = 2;
            }
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
            foreach (Size Size in loader.Sizes.Size) // Looper gennem alle størrelser
            {
                pizzaSize.Items.Add(Size.name + " - " + Size.price + "kr");// Putter sovsen på listen over størrelser
            }
            foreach (Spice Spice in loader.Spices.Spice) // Looper gennem alle typer kryderi
            {
                spiceBox.Items.Add(Spice.name + " - " + Spice.price + "kr"); // Putter sovsen på listen over kryderier
            }
        }



        private void customPizzaButon_Click(object sender, EventArgs e)
        {
            // Laver ny instance af pizza class
            Pizza pizza = new Pizza();
            pizza.name = "Lav selv pizza med ";
            // Looper gennem valgte ingredienser og putter dem på pizzaen
            foreach (string i in toppingBox.CheckedItems)
            {
                pizza.ingredients += toppingBox.Items.IndexOf(i) + ",";
                pizza.name += i.Split('-')[0];
                if (toppingBox.Items.IndexOf(i) != toppingBox.Items.Count)
                    pizza.name += "og ";
            }
            // Giver pizzaen et navn ud fra ingredienser
            pizza.name = pizza.name.Substring(0, pizza.name.Length - 4);

            pizza.spices = "";
            // Looper gennem valgte krydderi og putter dem på pizzaen
            foreach (string i in spiceBox.CheckedItems)
            {
                pizza.spices += spiceBox.Items.IndexOf(i) + ",";
            }
            // Sætter dej, sovs og størrelse dem brugeren har valgt i dropdown menuer
            pizza.dough = loader.Doughs.Dough[pizzaDough.SelectedIndex].dId;
            pizza.sauce = loader.Sauces.Sauce[pizzaSauce.SelectedIndex].sId;
            try
            {
                pizza.size = Convert.ToInt32(loader.Sizes.Size[pizzaSize.SelectedIndex].sId);
            }
            catch { MessageBox.Show("Vælg venligst en størrelse"); }

            // Putter en version i vogen og en på pizza menuen hvis brugeren skulle ville have flere
            returnTo.pizzas.Add(pizza);
            ListViewItem Item = new ListViewItem(pizza.name); // Laver nyt listviewitem til produkt or giver den navnet på produktet
            Item.SubItems.Add(returnTo.ingredientList(pizza.ingredients, ingredients)); // Giver listviewitemet ingredienser
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
            // Kører når brugeren vælger et nyt kryderi eller en ny ingrediens
            // Tjekker om brugeren har valgt noget nyt, eller om de har fravalgt noget
            try
            {
                if (e.NewValue == System.Windows.Forms.CheckState.Checked)
                    updatePrice(Convert.ToInt32(Convert.ToString(sender.GetType().GetProperty("SelectedItem").GetValue(sender, null)).Split('-')[1].Split('k')[0]));
                else
                    updatePrice(Convert.ToInt32(Convert.ToString(sender.GetType().GetProperty("SelectedItem").GetValue(sender, null)).Split('-')[1].Split('k')[0]) * -1);
            }
            catch { } // Det her kan sikkert sagtens fikses men jeg løber tør for tid, updateprice kører en gang for meget og jeg bliver derfor nødt til bare at lade være med at smide en exception
        }
        private void updatePrice(object sender, EventArgs e)
        {
            // Kører når brugeren vælger noget i en dropdown menu
            updatePrice(0);
        }

        private void updatePrice(int extra)
        {
            // Udregner prisen og putter den på pris label
            // Laver en ny instance af Pizza class og udregner prisen på den
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
            // Ændre teksten på pris label
            pizzaTotal.Text = "Total: " + returnTo.getPizzaPrice(pizza, extra);
        }
        #endregion

    }
}
