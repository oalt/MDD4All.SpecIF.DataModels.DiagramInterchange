/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MDD4All.SVG.DataModels;
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange
{
    public class SpecIfMetadata : Metadata
    {
        [XmlElement("diagram", Namespace = "https://specif.de/v1.1/schema-DI")]
        public Diagram Diagram { get; set; } = null;

        [XmlElement("shape", Namespace = "https://specif.de/v1.1/schema-DI")]
        public Shape Shape { get; set; } = null;

        [XmlElement("edge", Namespace = "https://specif.de/v1.1/schema-DI")]
        public Edge Edge { get; set; } = null;
    }
}
