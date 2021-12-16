using System;

namespace _2021AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            day3 test = new day3();
            var hold= test.ReturnArray(@"D:\Documents\VSRepo\2021AdventOfCode\day3.txt");
            Console.WriteLine(test.mostCommon(hold, 0, 1));
            //Console.WriteLine(test.test(hold));
        }
    }
}
