/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange.BaseElements
{
    public abstract class SpecIfDiagramInterchangeBase
    {
        [XmlAttribute("id")]
        public string ID { get; set; } = null;
    }
}
