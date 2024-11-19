using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Files
{
    internal class XmlFile
    {
        public static XDocument ConvertFromObjToXml(List<Teacher> listeacher)
        {
            XDocument xmList = new XDocument(
                new XElement("school",
                    new XElement(listeacher[0].Name, listeacher[0].Subject,
                        new XElement(listeacher[0].students[0].Name, listeacher[0].students[0].Grade),
                        new XElement(listeacher[0].students[1].Name, listeacher[0].students[1].Grade)
                ),
                    new XElement(listeacher[1].Name, listeacher[1].Subject,
                        new XElement(listeacher[1].students[0].Name, listeacher[1].students[0].Grade),
                        new XElement(listeacher[1].students[1].Name, listeacher[1].students[1].Grade)
                )
        
                    )

        );

            return xmList;

        }
        public static void SaveXml(XDocument scool)
        {
            
            foreach(var x in scool.Elements())
            {
                Console.WriteLine(x.ToString());
            }
            scool.Save("scool.xml");
        }
    }
}
