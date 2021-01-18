using System;

namespace HandsOnTry
{
    using System.Collections.Generic;

    using HandsOnTry.AlgoExpert.Array;

    class Program
    {
        static void Main(string[] args)
        {
           Console.ReadLine();
           var abc = new ThreeNumberSum();
           var result = abc.FindThreeNumberSum(new[] { 12, 3, 1, 2, -6, 5, -8, 6 }, 0);
        }
    }
}