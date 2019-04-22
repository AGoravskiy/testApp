using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Panel
    {
        [XmlElement("item")]
        public item Item { get; set; }
    }
}
