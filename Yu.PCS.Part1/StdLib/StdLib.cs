using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.PCS.Part1.StdLib
{
    class StdLib
    {
        public static void WriteArrayLine(int[] arr, char gap = ' ' , string prefix = "")
        {
            Console.Write(prefix);
            WriteArray(arr, gap);
            Console.Write("\n");
        }

        public static void WriteArray(int[] arr, char gap = ' ')
        {
            for (int cnt = 1; cnt <= arr.Length; cnt++) {
                System.Console.Write(arr[cnt-1]);
                if (cnt != arr.Length)
                    System.Console.Write(gap);
            }
        }
    }
}
