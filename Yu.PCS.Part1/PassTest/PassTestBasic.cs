using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.PCS.Part1.PassTest
{
    class PassTestBasic
    {
        public static void Test()
        {
            System.Console.WriteLine("...This test is to pass different kinds of parameters into a method, change their values and see if it effects original values...");

            int i = 100;
            int[] arr = { 1, 2, 3 };
            System.Console.WriteLine("Original i: " + i);
            StdLib.StdLib.WriteArrayLine(arr,' ',"Original arr: ");

            TestMethod(i, arr);

            System.Console.WriteLine("Original i (after TestMethod): " + i);
            StdLib.StdLib.WriteArrayLine(arr,' ',"Original arr (after TestMethod): ");
            System.Console.WriteLine();

            TestMethodRef(ref i, arr);

            System.Console.WriteLine("Original i (after TestMethodRef): " + i);
            StdLib.StdLib.WriteArrayLine(arr, ' ', "Original arr (after TestMethodRef): ");
            System.Console.WriteLine();

            int m;
            TestMethodOut(out m);
            System.Console.WriteLine("m was uninitiated, untill 'out'ed by TestMethodOut().\nm: " + m);
            System.Console.WriteLine();

        }

//--this method tests the parameters passed by value and passed by reference
        private static void TestMethod(int i, int[] arr)
        {
            System.Console.WriteLine("...TestMethod in...");
            i += 100;
            System.Console.WriteLine("Local i: {0} \nOriginal i should not change (pass by value)", i);

            for (int count = 0; count < arr.Length; count++)
                arr[count] += 100;

            System.Console.Write("Local arr: ");
            StdLib.StdLib.WriteArrayLine(arr);
            System.Console.WriteLine("Original is should change (pass by reference)");
            System.Console.WriteLine("...TestMethod out...");
        }

//--this method tests the parameters with 'ref' keyword prefix
//!!the 'ref' keyword is allowed to prefix a parameter passed by reference, but it does NOT change anything
        private static void TestMethodRef(ref int i, int[] arr)
        //private static void TestMethodRef(ref int i)
        {
            System.Console.WriteLine("...TestMethodRef in...");
            i += 100;

            for (int count = 0; count < arr.Length; count++)
                arr[count] += 100;

            System.Console.WriteLine("Local i is now: {0}.\nOriginal i should be: 200.",i);
            StdLib.StdLib.WriteArrayLine(arr,' ',"Local arr is now: ");
            System.Console.WriteLine("Original arr should be 201 202 203");
            System.Console.WriteLine("..TestMethodRef out...");
        }
//--this method tests the 'out' prefix
        private static void TestMethodOut(out int m)
        {
            System.Console.WriteLine("...TestMethodOut in...");
            m = 100;
            System.Console.WriteLine("...TestMethodOut out...");
        }
    }
}
