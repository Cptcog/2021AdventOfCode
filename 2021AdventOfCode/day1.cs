using System;
using System.Collections.Generic;
using System.Text;

namespace _2021AdventOfCode
{
    class day1
    {
        //part 1 & 2
        public List<int> ReturnArray(string file)
        {
            var hold = new List<int>();

            try
            {
                foreach (string line in System.IO.File.ReadLines(file))
                {
                    hold.Add(Int32.Parse(line));
                   // Console.WriteLine(line);
                }
            }
            catch (InvalidCastException e)
            {

            }

            return hold;

        }
        //part 1
        public int getDepthCount(List<int> hold) {
            int? prev=null;
            int count=0;

            foreach (int i in hold)
            {
                if (prev != null)
                {
                    if (i > prev)
                        count++;
                }
                prev = i;
            }
            return count;
        }
        //part 2
        public int getSlidingWindowDepthCount(List<int> hold)
        {
            int? prev = null;
            int count = 0;

            for (int i=2; i<hold.Count; i++ )
            {
                int a = hold[i-2];
                int b = hold[i-1];
                int c = hold[i];
                //Console.WriteLine("a:"+a+" b:"+b+" c:"+c);
                int d = a + b + c;
                //Console.WriteLine(d);
                if (prev != null)
                    if (d > prev)
                        count++;
                prev = d;
                //Console.WriteLine(prev);
            }

            return count;
        }
    }
}
