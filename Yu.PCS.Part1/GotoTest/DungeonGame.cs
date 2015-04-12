using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.PCS.Part1.GotoTest
{
    class DungeonGame
    {
        private int _weight;
        private int _speed;

        public DungeonGame()
        {
            _weight = 0;
            _speed = 10;
        }

        private void CalculateSpeed()
        {
            _speed -= _weight / 20;
            Console.WriteLine("Your current speed is {0} since you are carrying {1}kg of stuff" , _speed , _weight);
        }

        private bool WarriorRun()
        {
            var monster = new Monster();
            monster.Howl();
            System.Console.WriteLine("A {0} appeared and start chasing you at a speed of {1}!", monster.GetName(), monster.GetSpeed());
            if (_speed < monster.GetSpeed())
            {
                Console.WriteLine("OMG! You are out runned by the monster...");
                return false;
            }
            Console.WriteLine("You are running faster than the monster, the monster had to give up...");
            return true;
        }

        public void PlayGame()
        {
            System.Console.WriteLine("Ok, warrior, this heavy statue looks very valuable, would you like to take it?(y/n)");
            if (Console.Read() == 'n')
                goto labelRun;      //here we go the 'goto' using
            var rnd = new Random();
            int statueWeight = rnd.Next(10, 40);
            System.Console.WriteLine("You picked up the statue, it's about {0}kg." , statueWeight);
            _weight += statueWeight;
            //and where the 'goto' jumping to
            //if the warrior which is you chose not to take the statue, you jumped to here which skipped the weight adds process
            //so you are running faster which is less likely to get killed by monster
        labelRun:                   
            CalculateSpeed();
            if (WarriorRun() == true)
            {
                Console.WriteLine("You survived, congratulations!");
                return;
            }
            else
            {
                Console.WriteLine("You died, game over!");
            }       
        }
    }
}
