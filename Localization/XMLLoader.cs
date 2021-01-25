using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;

namespace Unity.Utils.Localization
{
    public class XMLLoader
    {
        private XmlDocument xmlDoc = null;
        private string xmlExtension = ".xml";

        public XMLLoader(string locale)
        {
            string fileName = locale + xmlExtension;
            xmlDoc = new XmlDocument();
            try
            {
                TextAsset textAsset = (TextAsset)Resources.Load(locale);
                xmlDoc.LoadXml(textAsset.text);
            }
            catch
            {
                throw new FileNotFoundException("File not found : " + fileName);
            }
        }

        public Dictionary<string, XmlNode[]> loadDictionnary()
        {
            Dictionary<string, XmlNode[]> dictio = new Dictionary<string, XmlNode[]>();
            XmlNodeList list = xmlDoc.DocumentElement.SelectNodes("/entries/entry");
            foreach (XmlNode node in list)
            {
                string key = node.Attributes["name"].Value;
                List<XmlNode> value = new List<XmlNode>();
                foreach (XmlNode subNode in node.ChildNodes)
                {
                    value.Add(subNode);
                }
                dictio.Add(key, value.ToArray());
            }
            return dictio;
        }
    }
}
