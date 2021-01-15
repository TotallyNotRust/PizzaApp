using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

namespace xmlLoader
{
    // Laver classes og gør dem klar til at loade xml data
    public class Spice
    {
        [XmlAttribute(AttributeName = "sId")]
        public string sId { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string name { get; set; }
        [XmlAttribute(AttributeName = "price")]
        public string price { get; set; }

        private XMLLoader m_parent;
        public void setParent(XMLLoader p_parent)
        {
            m_parent = p_parent;
        }
    }

    [XmlRoot(ElementName = "spices")]
    public class Spices
    {
        [XmlElement(ElementName = "spice")]
        public List<Spice> Spice { get; set; }
    }

    public class Drink
    {
        [XmlAttribute(AttributeName = "dId")]
        public string dId { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string name { get; set; }
        [XmlAttribute(AttributeName = "price")]
        public string price { get; set; }

        public int size;

        private XMLLoader m_parent;
        public void setParent(XMLLoader p_parent)
        {
            m_parent = p_parent;
        }
    }
    [XmlRoot(ElementName = "drinks")]
    public class Drinks
    {
        [XmlElement(ElementName = "drink")]
        public List<Drink> Drink { get; set; }
    }

    public class Size
    {
        [XmlAttribute(AttributeName = "price")]
        public string price { get; set; }
        [XmlAttribute(AttributeName = "sId")]
        public string sId { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string name { get; set; }

        private XMLLoader m_parent;
        public void setParent(XMLLoader p_parent)
        {
            m_parent = p_parent;
        }
    }

    [XmlRoot(ElementName = "sizes")]
    public class Sizes
    {
        [XmlElement(ElementName = "size")]
        public List<Size> Size { get; set; }
    }

    public class Dough
    {
        [XmlAttribute(AttributeName = "price")]
        public string price { get; set; }
        [XmlAttribute(AttributeName = "dId")]
        public string dId { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string name { get; set; }

        private XMLLoader m_parent;
        public void setParent(XMLLoader p_parent)
        {
            m_parent = p_parent;
        }
    }

    [XmlRoot(ElementName = "doughs")]
    public class Doughs
    {
        [XmlElement(ElementName = "dough")]
        public List<Dough> Dough { get; set; }
    }

    public class Ingredient
    {
        [XmlAttribute(AttributeName = "price")]
        public string price { get; set; }
        [XmlAttribute(AttributeName = "iId")]
        public string iId { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string name { get; set; }

        private XMLLoader m_parent;
        public void setParent(XMLLoader p_parent)
        {
            m_parent = p_parent;
        }
    }

    [XmlRoot(ElementName = "ingredients")]
    public class Ingredients
    {
        [XmlElement(ElementName = "ingredient")]
        public List<Ingredient> Ingredient { get; set; }
    }

    public class Sauce
    {
        [XmlAttribute(AttributeName = "price")]
        public string price { get; set; }
        [XmlAttribute(AttributeName = "sId")]
        public string sId { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string name { get; set; }

        private XMLLoader m_parent;
        public void setParent(XMLLoader p_parent)
        {
            m_parent = p_parent;
        }
    }

    [XmlRoot(ElementName = "sauces")]
    public class Sauces
    {
        [XmlElement(ElementName = "sauce")]
        public List<Sauce> Sauce { get; set; }
    }

    public class Pizza
    {
        [XmlAttribute(AttributeName = "sauce")]
        public string sauce { get; set; }
        
        [XmlAttribute(AttributeName = "dough")]
        public string dough { get; set; }

        [XmlAttribute(AttributeName = "pId")]
        public string pId { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string name { get; set; }
        [XmlAttribute(AttributeName = "ingredients")]
        public string ingredients { get; set; }
        [XmlAttribute(AttributeName = "spices")]
        public string spices { get; set; }

        public int price = 0;

        public int size = -1;

        public int discount = 0;

        private XMLLoader m_parent;
        public void setParent(XMLLoader p_parent)
        {
            m_parent = p_parent;
        }
    }

    [XmlRoot(ElementName = "pizzas")]
    public class Pizzas
    {
        [XmlElement(ElementName = "pizza")]
        public List<Pizza> Pizza { get; set; }
    }

    [XmlRoot(ElementName = "file")]
    public class XMLLoader
    {
        // Laver instance af de forskellige classes
        [XmlElement(ElementName = "pizzas")]
        public Pizzas Pizzas { get; set; }
        [XmlElement(ElementName = "sauces")]
        public Sauces Sauces{ get; set; }
        [XmlElement(ElementName = "ingredients")]
        public Ingredients Ingredients { get; set; }
        [XmlElement(ElementName = "doughs")]
        public Doughs Doughs { get; set; }
        [XmlElement(ElementName = "sizes")]
        public Sizes Sizes { get; set; }
        [XmlElement(ElementName = "drinks")]
        public Drinks Drinks { get; set; }
        [XmlElement(ElementName = "spices")]
        public Spices Spices { get; set; }

        private static String m_path = "";

        public static XMLLoader LoadXML(String path)
        {
            // Loader filen og laver en xml serializer
            m_path = path;
            XmlSerializer serializer = new XmlSerializer(typeof(XMLLoader));
            StreamReader reader = new StreamReader(path);
            XMLLoader m_sys = (XMLLoader)serializer.Deserialize(reader);
            reader.Close();
            m_sys.setParents();
            return m_sys;
        }

        public void setParents()
        {
            // Sætter m_child i de forskellige classes, den kan bruges til at finde hvad classens parent er.
            foreach (Pizza m_child in Pizzas.Pizza)
                m_child.setParent(this);
            foreach (Sauce m_child in Sauces.Sauce)
                m_child.setParent(this);
            foreach (Ingredient m_child in Ingredients.Ingredient)
                m_child.setParent(this);
            foreach (Dough m_child in Doughs.Dough)
                m_child.setParent(this);
            foreach (Size m_child in Sizes.Size)
                m_child.setParent(this);
            foreach (Drink m_child in Drinks.Drink)
                m_child.setParent(this);
            foreach (Spice m_child in Spices.Spice)
                m_child.setParent(this);
        }
    }

}
