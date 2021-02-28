using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceOpera.Mechanics
{
    class Ship
    {
        string name;
        int baseHp;
        int modifiedHp;
        int currentHp;
        int price;
        int shild;
        int shildTime;

        List<Skill> skills;
        LinkedList<Module> currentModules;
        Dictionary<Size, int> availablePlace;

        public Ship(string name, int baseHp, int price, List<Skill> skills, Dictionary<Size, int> availablePlace)
        {
            this.name = name;
            this.baseHp = baseHp;
            this.price = price;
            this.skills = skills;
            this.availablePlace = availablePlace;
        }

        public Ship(string name, int baseHp, int price, List<Skill> skills, Dictionary<Size, int> availablePlace, LinkedList<Module> currentModules)
        {
            this.name = name;
            this.baseHp = baseHp;
            this.price = price;
            this.skills = skills;
            this.availablePlace = availablePlace;
            this.currentModules = currentModules;
        }



    }
}
