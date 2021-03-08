using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceOpera.Mechanics
{
    class Ship
    {
        string Name { get; set; }
        TriStepValue Hp { get; set; }
        int Price { get; set; }
        TriStepValue Shield { get; set; }
        TriStepValue Cargo { get; set; }
        int ShieldTime { get; set; }
        Dictionary<SkillName, Skill> Skills { get; set; }
        List<Room> Rooms { get; set; } 

        public Ship(string name, TriStepValue hp, int price, Dictionary<SkillName, Skill> skills)
        {
            this.Hp = hp;
            this.Name = name;
            this.Price = price;
            this.Skills = skills;

            this.Shield = new TriStepValue(0, 0, 0);
            this.Cargo = new TriStepValue(0, 0, 0);
            recalculate();
        }

        public Ship(string name, TriStepValue hp, int price, Dictionary<SkillName, Skill> skills, List<Room> rooms)
        {
            this.Name = name;
            this.Hp=hp;
            this.Price = price;
            this.Skills = skills;
            this.Rooms = rooms;
            this.Shield = new TriStepValue(0, 0, 0);
            this.Cargo = new TriStepValue(0, 0, 0);
            recalculate();
        }

        public void recalculate()
        {
            foreach(Room room in Rooms)
            {
                Module module = room.Module;
                Hp.ModifiedValue += module.HpModification;
                Shield.ModifiedValue += module.ShieldModification;
                Cargo.ModifiedValue += module.CargoModificatio;

                foreach(SkillName name in module.SkillModification.Keys)
                {
                    Skills[name].Modifier = room.Module.SkillModification[name];
                }
                
            }
            Hp.CurrentValue = Hp.ModifiedValue;
            Shield.CurrentValue = Shield.ModifiedValue;
            Cargo.CurrentValue = Cargo.ModifiedValue;
        }

    }
}
