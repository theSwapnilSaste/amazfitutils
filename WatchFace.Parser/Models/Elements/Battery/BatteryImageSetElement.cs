﻿using System.Drawing;

namespace WatchFace.Parser.Models.Elements.Battery
{
    public class BatteryImageSetElement : ImageSetElement
    {
        public BatteryImageSetElement(Parameter parameter, Element parent, string name = null) :
            base(parameter, parent, name) { }

        public override void Draw(Graphics drawer, Bitmap[] resources, WatchState state)
        {
            if (ImagesCount == 1)
            {
                if (state.BatteryLevel <= 10) Draw(drawer, resources, 0);
            }
            else
            {
                var imageIndex = state.BatteryLevel * (int) ImagesCount / 100;
                Draw(drawer, resources, imageIndex);
            }
        }
    }
}