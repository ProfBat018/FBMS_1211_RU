using Adapter.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter.Services.Classes
{
    public class XMLAdapter<T> : IXMLAdapter<T>
    {
        public string ConvertToXml(string json)
        {
            T info = JsonSerializer.Deserialize<T>(json);

            using StringWriter fs = new();

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            serializer.Serialize(fs, info);


            return fs.ToString();
        }
    }
}
