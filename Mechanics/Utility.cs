using System;

namespace SpaceOpera.Mechanics
{
    class Utility
    {
        public Random random;
        private Utility()
        {
            random = new Random();
        }

        private static Utility _instance;
        public static Utility GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Utility();
            }
            return _instance;
        }
    }

}
