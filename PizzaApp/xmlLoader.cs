using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

namespace xmlLoader
{
    public class Pizza
    {
        [XmlAttribute(AttributeName = "price")]
        public string price { get; set; }

        [XmlAttribute(AttributeName = "pId")]
        public string pId { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string name { get; set; }
        [XmlAttribute(AttributeName = "ingredients")]
        public string ingredients { get; set; }

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
    public class XMLLoader
    {
        [XmlElement(ElementName = "pizzas")]
        public Pizzas Pizzas { get; set; }

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
        }
    }

}
