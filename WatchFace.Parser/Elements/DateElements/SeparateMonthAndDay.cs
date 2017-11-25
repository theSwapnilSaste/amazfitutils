﻿using WatchFace.Parser.Elements.BasicElements;
using WatchFace.Parser.Utils;

namespace WatchFace.Parser.Elements.DateElements
{
    public class SeparateMonthAndDay
    {
        [ParameterId(1)]
        public Number Month { get; set; }

        // TODO: Looks like here should be Id 2 also

        [ParameterId(3)]
        public Number Day { get; set; }
    }
}