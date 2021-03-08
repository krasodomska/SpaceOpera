using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceOpera.Mechanics
{
    class TriStepValue
    {
        public int BaseValue { get; set; }
        public int CurrentValue { get; set; }
        public int ModifiedValue { get; set; }

        public TriStepValue(int baseValue, int currentValue, int modifiedValue)
        {
            BaseValue = baseValue;
            CurrentValue = currentValue;
            ModifiedValue = modifiedValue;
        }

    }
}
