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
        // XMLLoader loader = XMLLoader.LoadXML("..\\..\\PizzaDatabase.xml");
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
            populateLists();
        }
        private void populateLists() // XMLLoader p_sys
        {
            //Placeholder skal være i xml fil i fremtiden
            PizzaObject Skinke = new PizzaObject(); // Laver pizza object
            Skinke.setValues("Skinke", "49kr", "Bund, Ost, Skinke"); // Giver data til pizza object
            ListViewItem item = new ListViewItem(Skinke.name); // Laver listviewitem object som kan puttes i list i gui
            item.SubItems.Add(Skinke.ingredients); // Giver data til listviewitem object
            item.SubItems.Add(Skinke.price); // --||--
            pizzaMenu.Items.Add(item); // Putter listviewitem object ind i liste på gui

            PizzaObject Hawaii = new PizzaObject();
            Hawaii.setValues("Hawaii", "49kr", "Bund, Ost, Skinke, Ananas");
            item = new ListViewItem(Hawaii.name);
            item.SubItems.Add(Hawaii.ingredients);
            item.SubItems.Add(Hawaii.price);
            pizzaMenu.Items.Add(item);

            //Kode til xml loading, virker ikke
            //    foreach (Pizza m_product in p_sys.Pizzas.Pizza) // køere gennem alle produkter
            //    {
            //        ListViewItem Item = new ListViewItem(m_product.name); // Laver nyt item til produkt
            //        Item.SubItems.Add(m_product.ingredients); // Definere navn
            //        Item.SubItems.Add(m_product.price);
            //        pizzaMenu.Items.Add(Item); // Putter data på spreadsheet
            //    }
            //}
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
    }
}
