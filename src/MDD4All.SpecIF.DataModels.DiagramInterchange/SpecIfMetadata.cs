/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MDD4All.SVG.DataModels;
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange
{
    public class SpecIfMetadata : Metadata
    {
        [XmlElement("shape", Namespace = "https://specif.de/schema/v1.1/DI")]
        public Shape Shape { get; set; } = null;

        [XmlElement("edge", Namespace = "https://specif.de/schema/v1.1/DI")]
        public Edge Edge { get; set; } = null;
    }
}
