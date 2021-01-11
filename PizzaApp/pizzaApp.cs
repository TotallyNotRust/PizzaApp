using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xmlLoader;

namespace PizzaApp
{
    public partial class pizzaApp : Form
    {
        XMLLoader loader = XMLLoader.LoadXML("..\\..\\PizzaDatabase.xml");
        public List<Pizza> pizzas = new List<Pizza>();
        public List<Ingredient> ingredients = new List<Ingredient>();
        public List<Sauce> sauces = new List<Sauce>();
        public List<Dough> doughs = new List<Dough>();
        public Cart cart = new Cart();

        public string returnValue { get; set; }

        public void populateLists()
        {
            foreach (Ingredient ing in loader.Ingredients.Ingredient)
            {
                ingredients.Add(ing);
            }
            foreach (Pizza m_product in loader.Pizzas.Pizza) // køere gennem alle produkter
            {
                ListViewItem Item = new ListViewItem(m_product.name); // Laver nyt listviewitem til produkt or giver den navnet på produktet

                Item.SubItems.Add(ingredientList(m_product.ingredients, ingredients)); // Giver listviewitemet ingredienser
                Item.SubItems.Add(getPizzaPrice(m_product)); // og pris
                pizzaMenu.Items.Add(Item); // Putter data på spreadsheet
                pizzas.Add(m_product);
            }

            foreach (Dough Dough in loader.Doughs.Dough)
            {
                pizzaDough.Items.Add(Dough.name + " - " + Dough.price + "");
            }
            foreach (Sauce Sauce in loader.Sauces.Sauce)
            {
                pizzaSauce.Items.Add(Sauce.name + " - " + Sauce.price + "kr");
            }
            foreach (xmlLoader.Size Size in loader.Sizes.Size)
            {
                pizzaSize.Items.Add(Size.name + " - " + Size.price + "kr");
                drinkSize.Items.Add(Size.name + " - " + Size.price + "kr");
            }
            foreach (Drink Drink in loader.Drinks.Drink)
            {
                ListViewItem Item = new ListViewItem(Drink.name);
                Item.SubItems.Add(Drink.price + "kr");
                drinksMenu.Items.Add(Item);
            }

        }

        public pizzaApp()
        {
            InitializeComponent();
            cart.init(this);
        }

        private void pizzaApp_Load(object sender, EventArgs e)
        {
            populateLists();
        }

        public string ingredientList(string needIngredients, List<Ingredient> allIngredients)
        {
            string str = "";
            string[] newIngredients = needIngredients.Split(',');
            foreach (string ingredient in newIngredients)
            {
                str = str + allIngredients.ElementAt(Convert.ToInt32(ingredient)).name + ", ";
            }
            return str;
        }

        public string getPizzaPrice(Pizza pizza)
        {
            int price = 0;
            foreach (string i in pizza.ingredients.Split(','))
            {
                if (i != "")
                    price += Convert.ToInt32(ingredients[Convert.ToInt32(i)].price);
            }
            price += Convert.ToInt32(loader.Sauces.Sauce[Convert.ToInt32(pizza.sauce)].price);
            price += Convert.ToInt32(loader.Doughs.Dough[Convert.ToInt32(pizza.dough)].price);

            return Convert.ToString(price) + "kr";
        }

        private void pizzaMenu_SelectedIndexChanged(object sender, EventArgs e)
        {      // Skal ændres til ItemCheck
            try
            {
                pizzaDough.SelectedIndex = Convert.ToInt32(pizzas[pizzaMenu.SelectedIndices[0]].dough);
                pizzaSauce.SelectedIndex = Convert.ToInt32(pizzas[pizzaMenu.SelectedIndices[0]].sauce);
                if (Convert.ToInt32(pizzas[pizzaMenu.SelectedIndices[0]].size) >= 0)
                    pizzaSize.SelectedIndex = Convert.ToInt32(pizzas[pizzaMenu.SelectedIndices[0]].size);
                else
                    pizzaSize.SelectedIndex = 2;
            }
            catch { }
        }

        private void populateLists(XMLLoader loader) // XMLLoader loader
        {
            foreach (Ingredient ing in loader.Ingredients.Ingredient)
            {
                ingredients.Add(ing);
            }
            foreach (Pizza m_product in pizzas) // køere gennem alle produkter
            {
                ListViewItem Item = new ListViewItem(m_product.name); // Laver nyt listviewitem til produkt or giver den navnet på produktet

                Item.SubItems.Add(ingredientList(m_product.ingredients, ingredients)); // Giver listviewitemet ingredienser
                Item.SubItems.Add(getPizzaPrice(m_product)); // og pris
                pizzaMenu.Items.Add(Item); // Putter data på spreadsheet
            }

            foreach (Dough Dough in loader.Doughs.Dough)
            {
                pizzaDough.Items.Add(Dough.name);
            }
            foreach (Sauce Sauce in loader.Sauces.Sauce)
            {
                pizzaSauce.Items.Add(Sauce.name);
            }

        }

        private void addPizzaButton_Click(object sender, EventArgs e)
        {
            Extra extra = new Extra(ingredients, loader, this);
            extra.Show();
        }

        private void addDrink_Click(object sender, EventArgs e)
        {
            if (drinkSize.SelectedIndex >= 0)
            {
                Drink Drink = loader.Drinks.Drink[drinksMenu.SelectedIndices[0]];
                Drink.price = Convert.ToString(Convert.ToInt32(Drink.price) + Convert.ToInt32(loader.Sizes.Size[drinkSize.SelectedIndex].price));
                ListViewItem Item = new ListViewItem(Drink.name);
                Item.SubItems.Add(Drink.price + "kr");
                Item.SubItems.Add("true");
                pizzaCart.Items.Add(Item);

                cart.drinkList = Drink;
            }
            else MessageBox.Show("Vælg venligst en størrelse");
        }

        private void addPrizza_Click(object sender, EventArgs e)
        {
            if (pizzaMenu.SelectedIndices.Count >= 1)
            {
                if (pizzaSize.SelectedIndex >= 0)
                {
                    Pizza Pizza = loader.Pizzas.Pizza[pizzaMenu.SelectedIndices[0]];
                    Pizza.price = Convert.ToInt32(getPizzaPrice(Pizza).Split('k')[0]);
                    ListViewItem Item = new ListViewItem(Pizza.name);
                    Item.SubItems.Add(Pizza.price + "kr");
                    Item.SubItems.Add("false");
                    pizzaCart.Items.Add(Item);

                    cart.pizzaList = Pizza;

                }
                else MessageBox.Show("Vælg venligst en størrelse");
            }
            else MessageBox.Show("Vælg venligst en pizza");

        }

        private void removeFromCart_Click(object sender, EventArgs e)
        {
            cart.PizzaList.RemoveAt(pizzaCart.SelectedIndices[0]);
            pizzaCart.Items.RemoveAt(pizzaCart.SelectedIndices[0]);
            cart.getPrice();
        }

        public class Cart
        {
            private pizzaApp app;
            public List<Pizza> PizzaList = new List<Pizza>();
            public Pizza pizzaList { get { return null; } set { PizzaList.Add(value); getPrice(); } }
            public List<Drink> DrinkList = new List<Drink>();
            public Drink drinkList { get { return null; } set { DrinkList.Add(value); getPrice(); } }
            public XMLLoader loader = XMLLoader.LoadXML("..\\..\\PizzaDatabase.xml");
            public void init(pizzaApp App)
            {
                app = App;
            }

            public string getPrice()
            {
                int price = 0;
                foreach (Pizza pizza in PizzaList)
                {
                    foreach (string i in pizza.ingredients.Split(','))
                    {
                        if (i != "")
                            price += Convert.ToInt32(loader.Ingredients.Ingredient[Convert.ToInt32(i)].price);
                    }
                    price += Convert.ToInt32(loader.Sauces.Sauce[Convert.ToInt32(pizza.sauce)].price);
                    price += Convert.ToInt32(loader.Doughs.Dough[Convert.ToInt32(pizza.dough)].price);

                    app.pizzaTotal.Text = "Total: " + price;
                }

                foreach (Drink drink in DrinkList)
                {
                    price += Convert.ToInt32(drink.price);

                    app.pizzaTotal.Text = "Total: " + price;
                }

                return "" + price + "kr";
            }
        }
    }
}
