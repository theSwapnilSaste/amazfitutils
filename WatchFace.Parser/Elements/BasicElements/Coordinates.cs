﻿using WatchFace.Parser.Attributes;

namespace WatchFace.Parser.Elements.BasicElements
{
    public class Coordinates
    {
        [ParameterId(1)]
        public long X { get; set; }

        [ParameterId(2)]
        public long Y { get; set; }

        [ParameterId(3)]
        public long X2 { get; set; }

        [ParameterId(4)]
        public long Y2 { get; set; }

        [ParameterId(5)]
        public long X3 { get; set; }
    }
}