using System;

/*
 * 在委托类型中使用泛型
 */

namespace Demo04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Del<int, double, string> Test = (a, b) =>
            {
                return $"type = {a.GetType().Name}, value = {a}\ntype = {b.GetType().Name}, value = {b}";
            };

            Console.WriteLine(Test(350, 2.0));
        }

        public delegate R Del<in T, in K, out R>(T t, K k)
            where T : struct
            where K : struct;
    }
}