﻿using WatchFace.Parser.Attributes;

namespace WatchFace.Parser.Elements.TimeElements
{
    public class AmPm
    {
        [ParameterId(1)]
        public long X { get; set; }

        [ParameterId(2)]
        public long Y { get; set; }

        [ParameterId(3)]
        [ParameterImageIndex]
        public long ImageIndexAMCN { get; set; }

        [ParameterId(4)]
        [ParameterImageIndex]
        public long ImageIndexPMCN { get; set; }

        [ParameterId(5)]
        [ParameterImageIndex]
        public long ImageIndexAMEN { get; set; }

        [ParameterId(6)]
        [ParameterImageIndex]
        public long ImageIndexPMEN { get; set; }
    }
}