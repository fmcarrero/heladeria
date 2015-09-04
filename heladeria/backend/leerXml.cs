using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace heladeria.backend
{
    public class leerXml
    {
        public String leer(String tagName)
        {
            String var = "";
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C:/Users/FranklinMauricio/documents/visual studio 2015/Projects/heladeria/heladeria/backend/data.xml");
            XmlNodeList empresas = xDoc.GetElementsByTagName("empresas");
            XmlNodeList lista = ((XmlElement)empresas[0]).GetElementsByTagName("empresa");

            foreach (XmlElement nodo in lista)

            {
                XmlNodeList nNombre = nodo.GetElementsByTagName(tagName);
                var = nNombre[0].InnerText;

            }
            return var;
        }



    }
}

