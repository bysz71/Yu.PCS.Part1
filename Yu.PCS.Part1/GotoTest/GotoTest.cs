using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.PCS.Part1.GotoTest
{
    class GotoTest
    {
        public static void TestGoto()
        {
            System.Console.WriteLine("--GotoTest start--");
            var game = new DungeonGame();
            game.PlayGame();

            System.Console.WriteLine("--GotoTest finished--\n");
        }
    }
}
