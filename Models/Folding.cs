using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Folding
    {
        [XmlElement("panels")]
        public Panel Panels { get; set; }
    }
}
