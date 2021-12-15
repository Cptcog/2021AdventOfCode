using System;

namespace _2021AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            day2 test = new day2();
            var hold= test.ReturnArray(@"D:\Documents\VSRepo\2021AdventOfCode\day2.txt");
            Console.WriteLine(test.returnLocation(hold)+ " is final location!");
        }
    }
}
