using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


class ReadXML
    {
    static void Main(string[] args)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/new 1.xml")
);

        
        XmlNodeList bookNodes = doc.SelectNodes("/Data/Item");

        foreach (XmlNode bookNode in bookNodes)
        {
            string name = bookNode.SelectSingleNode("Name").InnerText;
            int quantity = int.Parse(bookNode.SelectSingleNode("Quantity").InnerText);
            double price = double.Parse(bookNode.SelectSingleNode("Price").InnerText);

            Console.WriteLine($"Name: {name}, Quantity: {quantity}, Price: {price}");
        }
    }
}
