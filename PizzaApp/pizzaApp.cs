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

        public void populateLists()
        {
            // Looper gennem ingredienser og putter dem i en liste
            foreach (Ingredient ing in loader.Ingredients.Ingredient)
            {
                ingredients.Add(ing);
            }
            // Lopper gennem Pizzaer og putter dem i en liste
            foreach (Pizza m_product in loader.Pizzas.Pizza) // køere gennem alle produkter
            {
                ListViewItem Item = new ListViewItem(m_product.name); // Laver nyt listviewitem til produkt or giver den navnet på produktet

                Item.SubItems.Add(ingredientList(m_product.ingredients, ingredients)); // Giver listviewitemet ingredienser
                Item.SubItems.Add(getPizzaPrice(m_product)); // og pris
                pizzaMenu.Items.Add(Item); // Putter data på spreadsheet
                pizzas.Add(m_product);
            }
            // Looper gennem brød, sovs, størrelser og drikkevare og putter dem på forskellige lister
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
            // Tager en string med id på forskellige ingredienser i formatet x,x,x or returner navnene på ingredienser i samme format
            string str = "";
            string[] newIngredients = needIngredients.Split(',');
            foreach (string ingredient in newIngredients)
            {
                if (ingredient != "")
                str += allIngredients.ElementAt(Convert.ToInt32(ingredient)).name + ", ";
            }
            return str;
        }
        #region getPizzaPrice
        // Regner prisen på en pizza class
        public string getPizzaPrice(Pizza pizza)
        {
            return getPizzaPrice(pizza, 0);
        }
       
        public string getPizzaPrice(Pizza pizza, int extra)
        {
            int price = 0;
            // Regner prisen på ingredienser
            if (pizza.ingredients != null)
                foreach (string i in pizza.ingredients.Split(','))
                {
                    if (i != "")
                        price += Convert.ToInt32(ingredients[Convert.ToInt32(i)].price);
                }
            // Regner pris på kryderier
            if (pizza.spices != null)
                foreach (string i in pizza.spices.Split(','))
                {
                    if (i != "")
                        price += Convert.ToInt32(loader.Spices.Spice[Convert.ToInt32(i)].price);
                }
            // Udregner pris på sovs, dej, og størrelse
            if (pizza.sauce != null)
                price += Convert.ToInt32(loader.Sauces.Sauce[Convert.ToInt32(pizza.sauce)].price);
            if (pizza.dough != null)
                price += Convert.ToInt32(loader.Doughs.Dough[Convert.ToInt32(pizza.dough)].price);
            if (pizza.size != -1)
                price += Convert.ToInt32(loader.Sizes.Size[Convert.ToInt32(pizza.size)].price);

            return Convert.ToString(price + extra) + "kr";
        }
        #endregion

        private void pizzaMenu_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Når brugeren klikker på en ny pizza i ListView'et ændre den værdien i sovs, dej og strørrelse dropdown menuer
            if(e.IsSelected)
            {
                pizzaDough.SelectedIndex = Convert.ToInt32(pizzas[pizzaMenu.SelectedIndices[0]].dough);
                pizzaSauce.SelectedIndex = Convert.ToInt32(pizzas[pizzaMenu.SelectedIndices[0]].sauce);
                if (Convert.ToInt32(pizzas[pizzaMenu.SelectedIndices[0]].size) >= 0)
                    pizzaSize.SelectedIndex = Convert.ToInt32(pizzas[pizzaMenu.SelectedIndices[0]].size);
                else
                    // Hvis ikke pizzaen har en størrelse bliver den sat til lille som standard
                    pizzaSize.SelectedIndex = 2;
            }
        }

        private void populateLists(XMLLoader loader) // XMLLoader loader
        {
            // Loader alle ingredienser i en liste
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
            // Loader dej og sovs og putter dem i deres dropdown menuer
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
            // Åbner "Lav selv pizza" menuen
            if (pizzaMenu.SelectedIndices.Count > 0)
            {
                Extra extra = new Extra(ingredients, loader, pizzas[pizzaMenu.SelectedIndices[0]], this);
                extra.Show();
            }
            else
            {
                Extra extra = new Extra(ingredients, loader, null, this);
                extra.Show();
            }
        }

        private void addDrink_Click(object sender, EventArgs e)
        {
            if (drinksMenu.SelectedIndices.Count > 0)
            {
                if (drinkSize.SelectedIndex >= 0)
                {
                    // Laver en ny instance af drink class og putter den i vognen
                    Drink Drink = new Drink();
                    Drink.price = loader.Drinks.Drink[drinksMenu.SelectedIndices[0]].price;
                    Drink.name = loader.Drinks.Drink[drinksMenu.SelectedIndices[0]].name;
                    Drink.size = drinkSize.SelectedIndex;
                    ListViewItem Item = new ListViewItem(Drink.name);
                    Item.SubItems.Add(Convert.ToString((Convert.ToInt32(Drink.price) + Convert.ToInt32(loader.Sizes.Size[drinkSize.SelectedIndex].price))) + "kr");
                    Item.SubItems.Add("true");
                    pizzaCart.Items.Add(Item);

                    cart.drinkList = Drink;
                }
                else MessageBox.Show("Vælg venligst en størrelse");
            }
            else MessageBox.Show("Vælg venligst en drikkevare");
        }

        private void addPrizza_Click(object sender, EventArgs e)
        {
            // Tjekker om brugeren har valgt pizza og størrelse
            if (pizzaMenu.SelectedIndices.Count >= 1)
            {
                if (pizzaSize.SelectedIndex >= 0)
                {
                    // Laver kopi af den pizza som er valgt og putter den i vognen
                    Pizza Pizza = new Pizza();
                    Pizza.name = pizzaMenu.Items[pizzaMenu.SelectedIndices[0]].Text;
                    Pizza.ingredients = loader.Pizzas.Pizza[pizzaMenu.SelectedIndices[0]].ingredients;
                    Pizza.sauce = loader.Pizzas.Pizza[pizzaMenu.SelectedIndices[0]].sauce;
                    Pizza.dough = loader.Pizzas.Pizza[pizzaMenu.SelectedIndices[0]].dough;
                    Pizza.pId = loader.Pizzas.Pizza[pizzaMenu.SelectedIndices[0]].pId;
                    Pizza.spices = loader.Pizzas.Pizza[pizzaMenu.SelectedIndices[0]].spices;
                    Pizza.size = pizzaSize.SelectedIndex;
                    ListViewItem Item = new ListViewItem(loader.Sizes.Size[pizzaSize.SelectedIndex].name + " " + Pizza.name.ToLower());
                    Item.SubItems.Add(getPizzaPrice(Pizza));
                    Item.SubItems.Add("false");
                    pizzaCart.Items.Add(Item);

                    cart.pizzaList = Pizza;

                }
                // Hvis brugeren ikke har valgt det han skal, kommer der en tekst boks og siger hvad de har glemt
                else MessageBox.Show("Vælg venligst en størrelse");
            }
            else MessageBox.Show("Vælg venligst en pizza");

        }

        private void removeFromCart_Click(object sender, EventArgs e)
        {
            if (pizzaCart.SelectedIndices.Count > 0)
            {
                // Tjekker om brugeren har valgt en pizza eller en drikkevare og fjerner den fra listen
                if (pizzaCart.Items[pizzaCart.SelectedIndices[0]].SubItems[2].Text == "false")
                {
                    cart.PizzaList.RemoveAt(cart.PizzaListNames.IndexOf(pizzaCart.Items[pizzaCart.SelectedIndices[0]].SubItems[0].Text));
                    cart.PizzaListNames.RemoveAt(cart.PizzaListNames.IndexOf(pizzaCart.Items[pizzaCart.SelectedIndices[0]].SubItems[0].Text));
                }
                else
                {
                    cart.DrinkList.RemoveAt(cart.DrinkListNames.IndexOf(pizzaCart.Items[pizzaCart.SelectedIndices[0]].SubItems[0].Text));
                    cart.DrinkListNames.RemoveAt(cart.DrinkListNames.IndexOf(pizzaCart.Items[pizzaCart.SelectedIndices[0]].SubItems[0].Text));
                }
                pizzaCart.Items.RemoveAt(pizzaCart.SelectedIndices[0]);
                // Opdatere prisen
                cart.getPrice();
            }
        }

        public class Cart
        {
            #region variables
            // Sætter diverse variabler
            private pizzaApp app;
            public List<string> PizzaListNames = new List<string>();
            public List<Pizza> PizzaList = new List<Pizza>();
            public Pizza pizzaList { get { return null; } set { PizzaList.Add(value); PizzaListNames.Add(loader.Sizes.Size[value.size].name + " " + value.name.ToLower()); getPrice(); } }
            public List<string> DrinkListNames = new List<string>();
            public List<Drink> DrinkList = new List<Drink>();
            public Drink drinkList { get { return null; } set { DrinkList.Add(value); DrinkListNames.Add(value.name); getPrice(); } }
            public XMLLoader loader = XMLLoader.LoadXML("..\\..\\PizzaDatabase.xml");
            public void init(pizzaApp App)
            {
                app = App;
            }
            #endregion

            private int applySale()
            {
                // Tjekker om brugeren kvalificere for rabat
                int greatestAmount = 0;
                int eligablePizzas = 0;
                if (PizzaList.Count >= 2 && DrinkList.Count >= 2)
                {
                    foreach (Pizza pizza in PizzaList)
                    {
                        if (Convert.ToInt32(loader.Doughs.Dough[Convert.ToInt32(pizza.dough)].price) > greatestAmount)
                        {
                            greatestAmount = Convert.ToInt32(loader.Doughs.Dough[Convert.ToInt32(pizza.dough)].price);
                        }
                        if (pizza.size == 0)
                        {
                            eligablePizzas += 1;
                        }
                    }
                }
                // Hvis brugeren kvalificere ændre den teksten på rabat label
                if (eligablePizzas >= 2)
                {
                    app.discountLabel.Text = "-" + greatestAmount + "kr rabat";
                    app.discountLabel.Visible = true;
                    return greatestAmount;
                }
                // Ellers gemmer den label
                else
                {
                    app.discountLabel.Visible = false;
                    return 0;
                }
            }

            public string getPrice()
            {
                // Udregner prisen på vognen
                int Discount = applySale();
                int price = 0;
                foreach (Pizza pizza in PizzaList)
                {
                    price += Convert.ToInt32(app.getPizzaPrice(pizza).Split('k')[0]);
                }

                foreach (Drink drink in DrinkList)
                {
                    price += Convert.ToInt32(drink.price);
                    price += Convert.ToInt32(loader.Sizes.Size[drink.size].price);
                }
                // Ændre label med pris og returner prisen
                app.pizzaTotal.Text = "Total: " + (price-Discount) + "kr";
                return "" + price + "kr";
            }
            public bool isEmpty()
            {
                return PizzaList.Count > 0 || DrinkList.Count > 0;
            }
        }

        private void pizzaMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ændre lav selv pizza knappen når brugeren klikker på en pizza
            if (pizzaMenu.SelectedIndices.Count > 0)
            {
                customPizzaButon.Text = "Rediger pizza";
            }
            else
            {
                customPizzaButon.Text = "Lav selv pizza";
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (cart.isEmpty())
            {
                var x = MessageBox.Show("Ordrer placeret");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vælg mindst en pizza eller drikkevarer");
            }
        }
    }
}
