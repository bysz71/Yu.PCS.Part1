using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.PCS.Part1.GotoTest
{
    class Monster
    {
        private string _name;
        private int _speed;

        public Monster()
        {
            string[] names = { "GoblinFighter", "OrgBoneCrusher", "BloodThirstHorne" };
            var rnd = new Random();
            int rndName = rnd.Next(0, 2);
            _name = names[rndName];
            _speed = rnd.Next(6, 12);
        }

        public int GetSpeed()
        {
            return _speed;
        }

        public string GetName()
        {
            return _name;
        }

        public void Howl()
        {
            Console.WriteLine("\"Ahhhh! I am {0}! Die! Warrior! Die!\"", _name);
        }
    }
}
