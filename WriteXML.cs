using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Learning_unit_4_xml
{
    class WriteXML
    {
        public static void main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);

            XmlElement root = doc.CreateElement("Data");
            doc.AppendChild(root);

            XmlElement item = doc.CreateElement("Item");
            root.AppendChild(item);

            XmlElement name = doc.CreateElement("Name");
            name.InnerText = "Product A";
            item.AppendChild(name);

            XmlElement quantity = doc.CreateElement("Quantity");
            quantity.InnerText = "10";
            item.AppendChild(quantity);

            XmlElement price = doc.CreateElement("Price");
            price.InnerText = "19.99";
            item.AppendChild(price);

            XmlElement store = doc.CreateElement("Electronics");
            store.InnerText = "iOS";
            item.AppendChild(store);

            doc.Save("data2.xml");

            Console.WriteLine("XML file created successfully.");




        }
    }
}
