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
        //public Cart cart = new classes.Cart();

        public string returnValue { get; set; }


        public void populateLists() // XMLLoader loader
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
                pizzaDough.Items.Add(Dough.name);
            }
            foreach (Sauce Sauce in loader.Sauces.Sauce)
            {
                pizzaSauce.Items.Add(Sauce.name);
            }

        }


        public pizzaApp()
        {
            InitializeComponent();
        }

        public ListViewItem item;

        private void pizzaMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem i in pizzaMenu.SelectedItems)
            {
                Pizza pizza = pizzas[pizzaMenu.Items.IndexOf(i)];
                pizzaHeader.Text = i.Text;
                pizzaTextBody.Text = pizza.ingredients;
                item = i;
            }
        }

        private void pizzaCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pizzaApp_Load(object sender, EventArgs e)
        {
            populateLists();

        }
        public string ingredientList(string needIngredients, List<Ingredient> allIngredients)
        {
            string str = "";
            string[] newIngredients = needIngredients.Split(',');
            foreach(string ingredient in newIngredients)
            {
                str = str + allIngredients.ElementAt(Convert.ToInt32(ingredient)).name + ", ";
            }
            return str;
        }

        public string getPizzaPrice(Pizza pizza)
        {
            int price = 0;
            foreach(string i in pizza.ingredients.Split(','))
            {
                if (i != "")
                    price += Convert.ToInt32(ingredients[Convert.ToInt32(i)].price);
            }
            price += Convert.ToInt32(loader.Sauces.Sauce[Convert.ToInt32(pizza.sauce)].price);
            price += Convert.ToInt32(loader.Doughs.Dough[Convert.ToInt32(pizza.dough)].price);

            return Convert.ToString(price) + "kr";
        }

        private void populateLists(XMLLoader loader) // XMLLoader loader
        {
            foreach(Ingredient ing in loader.Ingredients.Ingredient)
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

            foreach(Dough Dough in loader.Doughs.Dough)
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
    }

}

namespace classes
{
    class Cart
    {
        public List<Pizza> List = new List<Pizza>();
        public ComboBox Chart;
        public void init(ComboBox chart)
        {
            Chart = chart;
        }

        public string getPrice()
        {
            XMLLoader loader = XMLLoader.LoadXML("..\\..\\PizzaDatabase.xml");
            int price = 0;
            foreach (Pizza pizza in List)
            {
                foreach (string i in pizza.ingredients.Split(','))
                {
                    if (i != "")
                        price += Convert.ToInt32(loader.Ingredients.Ingredient[Convert.ToInt32(i)].price);
                }
                price += Convert.ToInt32(loader.Sauces.Sauce[Convert.ToInt32(pizza.sauce)].price);
                price += Convert.ToInt32(loader.Doughs.Dough[Convert.ToInt32(pizza.dough)].price);
            }

            return "" + price + "kr";
        }
    }
}
