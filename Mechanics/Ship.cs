using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceOpera.Mechanics
{
    class Ship
    {
        string name;
        TriStepValue hp;
        int price;
        TriStepValue shield;
        int shieldTime;

        List<Skill> skills;
        LinkedList<Module> currentModules;
        Dictionary<Size, int> availablePlace;

        public Ship(string name, TriStepValue hp, int price, List<Skill> skills, Dictionary<Size, int> availablePlace)
        {
            this.hp = hp;
            this.name = name;
            this.price = price;
            this.skills = skills;
            this.availablePlace = availablePlace;
            this.shield = new TriStepValue(0, 0, 0);
        }

        public Ship(string name, TriStepValue hp, int price, List<Skill> skills, Dictionary<Size, int> availablePlace, LinkedList<Module> currentModules)
        {
            this.name = name;
            this.hp=hp;
            this.price = price;
            this.skills = skills;
            this.availablePlace = availablePlace;
            this.currentModules = currentModules;
            this.shield = new TriStepValue(0, 0, 0);
        }



    }
}
