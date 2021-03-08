using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceOpera.Mechanics
{
    class Room
    {
        public Room(object place, Size size, Module module)
        {
            Place = place;
            Size = size;
            Module = module;
        }

        public object Place { get; set; }
        public Size Size { get; set; }
        public Module Module { get; set; }

    }
}
