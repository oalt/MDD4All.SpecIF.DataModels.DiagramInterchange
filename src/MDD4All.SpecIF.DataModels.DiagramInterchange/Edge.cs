﻿/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MDD4All.SpecIF.DataModels.DiagramInterchange.BaseElements;
using MDD4All.SpecIF.DataModels.DiagramInterchange.DiagramDefinition;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange
{

    [XmlType("edge", Namespace = "https://specif.de/v1.1/schema-DI")]
    public class Edge
    {

        public Edge()
        {

        }

        /// <summary>
        /// null = normal
        /// 'bezier' = Bezier curve
        /// 'rounded' = rounded corners
        /// </summary>
        [XmlAttribute("layoutStyle")]
        public string LayoutStyle { get; set; } = null;

        /// <summary>
        /// null  : no direction
        /// 'unidirectional' : source to target
        /// 'bidirectional' : bidirectional
        /// </summary>
        [XmlAttribute("direction")]
        public string Direction { get; set; } = null;

        [XmlElement("sourceResourceReference")]
        public ResourceReference SourceResourceReference { get; set; }

        [XmlElement("targetResourceReference")]
        public ResourceReference TargetResourceReference { get; set; }

        [XmlArray("statementReferences", Namespace = "https://specif.de/v1.1/schema-DI")]
        public List<SpecIfReferenceBase> References = new List<SpecIfReferenceBase>();

        [XmlArray("waypoints", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
        public List<Waypoint> Waypoints { get; set; } = new List<Waypoint>();
    }
}
