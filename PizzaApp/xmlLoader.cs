using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

namespace xmlLoader
{
    public class Drink
    {
        [XmlAttribute(AttributeName = "dId")]
        public string dId { get; set; }
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

        public int price = 0;

        public int size = -1;

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

        private static String m_path = "";

        public static XMLLoader LoadXML(String path)
        {
            m_path = path;
            XmlSerializer serializer = new XmlSerializer(typeof(XMLLoader));
            StreamReader reader = new StreamReader(path);
            XMLLoader m_sys = (XMLLoader)serializer.Deserialize(reader);
            reader.Close();
            m_sys.setParents();
            return m_sys;
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLLoader));
            StreamWriter writer = new StreamWriter(m_path);
            serializer.Serialize(writer, this);
            writer.Close();
        }

        public void setParents()
        {
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
        }
    }

}
