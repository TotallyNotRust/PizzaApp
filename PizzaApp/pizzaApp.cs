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
        List<Ingredient> ingredients = new List<Ingredient>();
        List<Pizza> Pizzas = new List<Pizza>();
        public pizzaApp()
        {
            InitializeComponent();
        }


        private void pizzaMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void populateLists(XMLLoader p_sys) // XMLLoader p_sys
        {
            foreach(Ingredient ing in p_sys.Ingredients.Ingredient)
            {
                ingredients.Add(ing);
            }
            foreach (Pizza m_product in p_sys.Pizzas.Pizza) // køere gennem alle produkter
            {
                ListViewItem Item = new ListViewItem(m_product.name); // Laver nyt listviewitem til produkt or giver den navnet på produktet

                Item.SubItems.Add(ingredientList(m_product.ingredients, ingredients)); // Giver listviewitemet ingredienser
                Item.SubItems.Add(m_product.price); // og pris
                pizzaMenu.Items.Add(Item); // Putter data på spreadsheet
            }

            foreach(Dough Dough in p_sys.Doughs.Dough)
            {
                pizzaDough.Items.Add(Dough.name);
            }
            foreach (Sauce Sauce in p_sys.Sauces.Sauce)
            {
                pizzaSauce.Items.Add(Sauce.name);
            }

        }
        public class PizzaObject
        {
            public string name; // Navn på pizza
            public string price; // Pris på pizza
            public string ingredients; // Ingredienser i pizza
            public void setValues(string Name, string Price, string Ingredients) // Metode til at give values to name, price og ingredients køres efter objectet er initialiseret 
            {
                name = Name;
                price = Price;
                ingredients = Ingredients;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pizzaSauce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
