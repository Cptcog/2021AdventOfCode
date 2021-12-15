using System;
using System.Collections.Generic;
using System.Text;

namespace _2021AdventOfCode
{
    class day3
    {
        public List<string> ReturnArray(string file)
        {
            var hold = new List<string>();

            try
            {
                foreach (string line in System.IO.File.ReadLines(file))
                {
                    hold.Add(line);
                    Console.WriteLine(line);
                }
            }
            catch (InvalidCastException e)
            {

            }
            return hold;
        }
        public int returnUsage(List<string> input)
        {
            //get gamma
            string gamma = "";
            for (int i = 0; i < input[0].Length; i++)
            {
                int hold = 0;
                foreach (var a in input)
                {
                    if (a[i] == '0')
                        hold--;
                    else
                        hold++;
                }
                if (hold > 0)
                    gamma += "1";
                else
                    gamma += "0";
            }
            Console.WriteLine("gamma: "+gamma);
            //get epsilon
            string epsilon = "";
            for (int i = 0; i < gamma.Length; i++)
            {
                if (gamma[i] == '0')
                    epsilon += '1';
                else
                    epsilon += '0';
            }
            Console.WriteLine("epsilon: " + epsilon);

            return Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);
        }
    }
}
