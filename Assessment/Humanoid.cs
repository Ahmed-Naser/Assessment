using System;

namespace Assessment
{
    internal class Humanoid
    {
        public int value { get; set; }

        public Humanoid()
        {
        }

        public Humanoid(Cooking cooking)
        {
            value = 2;
        }

        public Humanoid(Dancing dancing)
        {
            value = 1;
        }

        internal string ShowSkill()
        {
            switch (value)
            {
                case 1:
                    return "Dancing";
                case 2:
                    return "Cooking";
                default:
                    return "no skill is defined";
            }
        }
    }
}