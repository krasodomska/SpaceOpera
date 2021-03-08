using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceOpera.Mechanics
{
    class Module
    {
        public Module(string name, Size size, Dictionary<SkillName, int> skillModification, int cargoModificatio, int hpModification, int shieldModification, Weapon weapon)
        {
            Name = name;
            Size = size;
            SkillModification = skillModification;
            CargoModificatio = cargoModificatio;
            HpModification = hpModification;
            ShieldModification = shieldModification;
            Weapon = weapon;
        }

        public Module(string name, Size size, Dictionary<SkillName, int> skillModification, int cargoModificatio, int hpModification, int shieldModification)
        {
            Name = name;
            Size = size;
            SkillModification = skillModification;
            CargoModificatio = cargoModificatio;
            HpModification = hpModification;
            ShieldModification = shieldModification;
            Weapon = new Weapon();
        }




        public string Name { get; set; }
        public Size Size { get; set; }
        public Dictionary<SkillName, int> SkillModification { get; set; }
        public int CargoModificatio { get; set; }
        public int HpModification { get; set; }
        public int ShieldModification { get; set; }
        Weapon Weapon { get; set; }

    }
}
