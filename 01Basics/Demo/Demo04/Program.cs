using System;
using System.Collections.Generic;
using System.Linq;

/*
 *生成图案
 */

namespace Demo04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            for (int i = 1; i < 9; i++)
            {
                string s1 = "";
                for (int j = 0; j < i; j++)
                {
                    s1 += "*";
                }
                s1 = s1.PadRight(8);
                string s2 = new string(s1.Reverse().ToArray());

                list.Add(s1 + s2);
            }

            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}