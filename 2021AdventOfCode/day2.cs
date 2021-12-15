using System;
using System.Collections.Generic;
using System.Text;

namespace _2021AdventOfCode
{
    class day2
    {//part 1

        public List<string> ReturnArray(string file)
        {
            var hold = new List<string>();

            try
            {
                foreach (string line in System.IO.File.ReadLines(file))
                {
                    hold.Add(line);
                    //Console.WriteLine(line);
                }
            }
            catch (InvalidCastException e)
            {

            }
            return hold;
        }

        //part 1&2
        public int returnLocation(List<string> input)
        {
            int depth=0;
            int horizPosition=0;
            int aim = 0;

            foreach (var i in input)
            {
                int hold = i[i.Length - 1] - '0';

                if (i[0] == 'f')
                {
                    horizPosition += hold;
                    depth += aim * hold;
                }
                else if (i[0] == 'u')
                {
                    aim -= hold;
                }
                else
                {
                    aim += hold;
                }
            }
            Console.WriteLine("Ended at " + depth + " depth and " + horizPosition + " position.");
            return depth * horizPosition;
        }


    }
}
