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

        /// string build is a method to get us down to 1 string value.
        /// <param name="input"> passing list of binaries</param>
        /// <param name="placing">which position in the binary</param>
        /// <param name="omit">if 1, we want most common, if 0, we want least common</param>
        /// <returns>the most or least common binary string</returns>
        public List<string> StringBuild(List<string> input, int placing, char omit)
        {
            if (input.Count == 1)
                return input;
            List<string> hold = new List<string>();

            foreach (var a in input)
            {
                var Common= (char)mostCommon(input, placing, omit);
                if (omit == '0')
                        if (a[placing] != Common)
                            hold.Add(a);
                
                if (omit == '1')
                        if (a[placing] == Common)
                            hold.Add(a);
                
            }
            foreach (var a in hold)
                Console.WriteLine(a.ToString());
            return hold;
        }
        
        public int mostCommon(List<string> input, int placing, int tie)
        {
            int hold = 0;
            foreach (var a in input)
            {
                if (a[placing] == '0')
                {
                    hold--;

                }
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
            List<string> holdOGR = new List<string>();

            //OGR
            for (int i = 0; i < input[0].Length - 2; i++)
               holdOGR= StringBuild(input, i, '1');
            int OGR = Convert.ToInt32(holdOGR[0], 2);


            List<string> holdCO2SR = new List<string>();
            //CO2SR
            for (int i = 1; i < input[0].Length - 2; i++)
                holdCO2SR = StringBuild(input, i, '0');
            int CO2SR = Convert.ToInt32(holdCO2SR[0], 2);

            return OGR * CO2SR;

        }
    }
}
