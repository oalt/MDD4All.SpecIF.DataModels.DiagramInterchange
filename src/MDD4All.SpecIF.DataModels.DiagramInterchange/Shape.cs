/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MDD4All.SpecIF.DataModels.DiagramInterchange.DiagramDefinition;
using System.Xml;
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange
{

    [XmlType(TypeName = "shape", Namespace = "https://specif.de/v1.1/schema-DI")]
    [XmlRoot("shape", Namespace = "https://specif.de/v1.1/schema-DI")]
    public class Shape
    {
        public Shape()
        {

        }

        [XmlElement("resourceReference", Namespace = "https://specif.de/v1.1/schema-DI")]
        public ResourceReference ResourceReference { get; set; }

        [XmlElement("Bounds",  Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
        public Bounds Bounds { get; set; }

       
    }
}
