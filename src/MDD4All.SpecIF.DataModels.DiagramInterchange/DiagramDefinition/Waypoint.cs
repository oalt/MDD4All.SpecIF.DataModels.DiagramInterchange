﻿/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using System.Xml.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramInterchange.DiagramDefinition
{
    [XmlRoot("waypoint", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
    public class Waypoint
    {
        [XmlAttribute("x")]
        public double X { get; set; }

        [XmlAttribute("y")]
        public double Y { get; set; }


    }
}
