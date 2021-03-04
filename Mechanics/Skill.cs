using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SpaceOpera.Mechanics
{
    class Skill
    {
        public Skill( int value, int modifier)
        {
            Modifier = modifier;
            Value = value;
        }

        public int Modifier { get; set; }
        public int Value { get; set; }

        




        public int roll()
        {
            bool rollAgain = true;
            int result = 0;
            int baseRoll;
            while (rollAgain)
            {
                baseRoll = Utility.GetInstance().random.Next(1, Value + 1);
                result += baseRoll;
                if (baseRoll != Value) rollAgain = false;
            }
            return result + Modifier;
        }
  
    }
}
