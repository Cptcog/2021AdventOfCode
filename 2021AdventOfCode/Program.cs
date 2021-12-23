using System;

namespace _2021AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            day3 test = new day3();
            var hold= test.ReturnArray(@"C:\Users\tofin\source\repos\2021AdventOfCode\day3Test.txt");
            Console.WriteLine(test.ReturnLifeSupport(hold));
            //Console.WriteLine(test.mostCommon(hold,1,1));
        }
    }
}
