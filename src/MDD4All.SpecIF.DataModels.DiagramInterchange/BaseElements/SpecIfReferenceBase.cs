/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange.BaseElements
{
    public abstract class SpecIfReferenceBase
    {
        [XmlAttribute("id")]
        public string IdReference { get; set; } = "";

        [XmlAttribute("revision")]
        public string RevisionReference { get; set; } = "";
    }
}
