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
                    // Console.WriteLine(line);
                }
            }
            catch (InvalidCastException e)
            {

            }
            return hold;
        }

        //part 1
        public int ReturnUsage(List<string> input)
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
            Console.WriteLine("gamma: " + gamma);
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




        public int mostCommon(List<string> input, int placing, int tie)
        {
            int hold = 0;
            foreach (var a in input)
            {
                if (a[placing] == '0')
                    hold--;
                else
                    hold++;
            }

            ///I actually wanted to solve this bit with an equation.
            ///I got somewhere around:
            ///-tie*1+something
            ///-something-hold*total of stuff with tie*1

            if (tie == 0)
            {
                if (hold <= 1)
                    hold = 0;
                else
                    hold = 1;
            }
            else
            {
                if (hold >= 0)
                    hold = 1;
                else
                    hold = 0;
            }
            return hold;
        }
        public int ReturnLifeSupport(List<string> input)
        {

            //OGR
            for (int i = 0; i < input[0].Length - 2; i++)
            {
                //find most common, ties = 1
                int hold= mostCommon(input, i, 1);

                for (int a = 0; a < input.Count; a++)
                {

                }
            }
            //CO2SR
            for (int i = 0; i < input[0].Length - 2; i++)
            {
                //find least common, ties = 0
                int hold = mostCommon(input, i, 0);
                for (int a = 0; a < input.Count; a++)
                {

                }
            }

        }
    }
}
