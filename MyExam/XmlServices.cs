using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyExam
{
    public static class XmlServices
    {
        public static void WriteToXmlFile(string fileName, List<TransportMean> trams)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode xmlD = doc.CreateXmlDeclaration("1.0", "", "");
            doc.AppendChild(xmlD);
            //doc.Load(fileName);

            foreach (TransportMean t in trams)
            {
                //XmlDocument doc = new XmlDocument();
                //doc.Load(fileName);

                XmlNode newTM = doc.CreateElement("TransportMean");
                XmlNode type = doc.CreateElement("Type");
                XmlNode typeValue = doc.CreateTextNode(t.Type.ToString());
                XmlNode color = doc.CreateElement("Color");
                XmlNode colorValue = doc.CreateTextNode(t.Color.ToString());
                XmlNode year = doc.CreateElement("Year");
                XmlNode yearValue = doc.CreateTextNode(t.Year.ToString());
                XmlNode price = doc.CreateElement("Price");
                XmlNode priceValue = doc.CreateTextNode(t.Price.ToString());

                type.AppendChild(typeValue);
                color.AppendChild(colorValue);
                year.AppendChild(yearValue);
                price.AppendChild(priceValue);

                newTM.AppendChild(type);
                newTM.AppendChild(color);
                newTM.AppendChild(year);
                newTM.AppendChild(price);

                doc.DocumentElement.AppendChild(newTM);
                doc.Save(fileName);
            }
        }
    }
}
