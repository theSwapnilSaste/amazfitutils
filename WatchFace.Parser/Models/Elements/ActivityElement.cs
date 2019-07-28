﻿namespace WatchFace.Parser.Models.Elements
{
    public class ActivityElement : ContainerElement
    {
        public ActivityElement(Parameter parameter, Element parent = null, string name = null) :
            base(parameter, parent, name) { }

        public StepsElementP Steps { get; set; }
        public StepsGoalElement StepsGoal { get; set; }
        public CaloriesElement Calories { get; set; }
        public PulseElement Pulse { get; set; }
        public DistanceElement Distance { get; set; }
        public ImageElement CircleRange { get; set; }

        protected override Element CreateChildForParameter(Parameter parameter)
        {
            if (Header.HeaderSize == 60)
            {
                switch (parameter.Id)
                {
                    case 5:
                        Steps = new StepsElementP(parameter, this);
                        return Steps;
                    case 3:
                        Pulse = new PulseElement(parameter, this);
                        return Pulse;
                    case 9:
                        CircleRange = new ImageElement(parameter, this);
                        return CircleRange;
                }
            }
            else
            {
                switch (parameter.Id)
                {
                    case 1:
                        Steps = new StepsElementP(parameter, this);
                        return Steps;
                    case 2:
                        StepsGoal = new StepsGoalElement(parameter, this);
                        return StepsGoal;
                    case 3:
                        Calories = new CaloriesElement(parameter, this);
                        return Calories;
                    case 4:
                        Pulse = new PulseElement(parameter, this);
                        return Pulse;
                    case 5:
                        Distance = new DistanceElement(parameter, this);
                        return Distance;
                }
            }

            return base.CreateChildForParameter(parameter);
        }
    }
}