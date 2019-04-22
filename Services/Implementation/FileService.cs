using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;
using TestTask.Services.Interfaces;
using TestTask.Models;

namespace TestTask.Services.Implementation
{
    public class FileService: IFileService
    {
        public void Parse(string xml)
        {
            var reader = new StringReader(xml);
            var result = (Folding)new XmlSerializer(typeof(Folding), new XmlRootAttribute("folding")).Deserialize(reader);
        }
    }
}
