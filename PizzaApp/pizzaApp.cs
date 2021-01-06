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
        public List<Ingredient> ingredients = new List<Ingredient>();
        public List<Pizza> Pizzas = new List<Pizza>();
        public pizzaApp()
        {
            InitializeComponent();
        }

        public ListViewItem item;

        private void pizzaMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem i in pizzaMenu.SelectedItems)
            {
                Pizza pizza = Pizzas[pizzaMenu.Items.IndexOf(i)];
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
            populateLists(loader);
        }
        private string ingredientList(string needIngredients, List<Ingredient> allIngredients)
        {
            string str = "";
            string[] newIngredients = needIngredients.Split(',');
            foreach(string ingredient in newIngredients)
            {
                str = str + allIngredients.ElementAt(Convert.ToInt32(ingredient)).name + ", ";
            }
            return str;
        }

        private void populateLists(XMLLoader loader) // XMLLoader loader
        {
            foreach(Ingredient ing in loader.Ingredients.Ingredient)
            {
                ingredients.Add(ing);
            }
            foreach (Pizza m_product in loader.Pizzas.Pizza) // køere gennem alle produkter
            {
                ListViewItem Item = new ListViewItem(m_product.name); // Laver nyt listviewitem til produkt or giver den navnet på produktet

                Item.SubItems.Add(ingredientList(m_product.ingredients, ingredients)); // Giver listviewitemet ingredienser
                Item.SubItems.Add(m_product.price); // og pris
                pizzaMenu.Items.Add(Item); // Putter data på spreadsheet
                Pizzas.Add(m_product);
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
        public class OrderItem
        {
            public string name; // Navn på pizza
            public int price; // Pris på pizza
            public List<Ingredient> ingredients; // Ingredienser i pizza
            public void setValues(string Name, string Price, List<Ingredient> Ingredients) // Metode til at give values to name, price og ingredients køres efter objectet er initialiseret 
            {
                name = Name;
                price = Convert.ToInt32(Price);
                ingredients = Ingredients;
            }
        }

        private void addPizzaButton_Click(object sender, EventArgs e)
        {
            Extra extra = new Extra(ingredients, loader);
            extra.Show();
        }
    }
}
