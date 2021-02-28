using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SpaceOpera.Mechanics
{
    class Skill
    {
        private SkillName name;

        public SkillName GetName()
        {
            return name;
        }

        public void SetName(SkillName value)
        {
            name = value;
        }

        private int modifier;

        public int GetModifier()
        {
            return modifier;
        }

        public void SetModifier(int value)
        {
            modifier = value;
        }

        private int value;

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        public Skill(SkillName name, int value, int modifier)
        {
            this.SetName(name);
            this.SetValue(value);
            this.SetModifier(modifier);
        }


        public int roll()
        {
            bool rollAgain = true;
            int result = 0;
            int baseRoll;
            while (rollAgain)
            {
                baseRoll = Utility.GetInstance().random.Next(1, GetValue());
                result += baseRoll;
                if (baseRoll != GetValue() - 1) rollAgain = false;
            }
            return result + GetModifier();
        }

    }
}
