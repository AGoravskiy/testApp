using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace TestTask.Models
{
    
    public class item
    {
        [XmlAttribute("panelId")]
        public string Id { get; set; }
        [XmlAttribute("panelName")]
        public string PanelName { get; set; }
        [XmlAttribute("minRot")]
        public int MinRot { get; set; }
        [XmlAttribute("maRot")]
        public int MaxRot { get; set; }
        [XmlAttribute("initialRot")]
        public int InitialRot { get; set; }
        [XmlAttribute("startRot")]
        public int StartRot { get; set; }
        [XmlAttribute("endRot")]
        public int EndRot { get; set; }
        [XmlAttribute("hingeOffset")]
        public int HingeOffset { get; set; }
        [XmlAttribute("panelWidth")]
        public double PanelWidth { get; set; }
        [XmlAttribute("panelHeight")]
        public double PanelHeight { get; set; }
        [XmlAttribute("attachedToSide")]
        public int AttachedToSide { get; set; }
        [XmlAttribute("creaseBottom")]
        public double CreaseBottom { get; set; }
        [XmlAttribute("creaseTop")]
        public double CreaseTop { get; set; }
        [XmlAttribute("creaseLeft")]
        public double CreaseLeft { get; set; }
        [XmlAttribute("creaseRight")]
        public double CreaseRight { get; set; }
        [XmlAttribute("ignoreCollisions")]
        public bool IgnoreCollisions { get; set; }
        [XmlAttribute("mouseEnabled")]
        public bool MouseEnabled { get; set; }
        [XmlElement("attachedPanels")]
        public List<item> AttachedPanels { get; set; }

        public item()
        {
            AttachedPanels = new List<item>();
        }
    }
}
