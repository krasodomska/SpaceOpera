using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceOpera.Mechanics
{
    struct TriStepValue
    {
        int baseValue;
        int currentValue;
        int modifiedValue;

        public TriStepValue(int baseValue, int currentValue, int modifiedValue)
        {
            this.baseValue = baseValue;
            this.currentValue = currentValue;
            this.modifiedValue = modifiedValue;
        }
    }
}
