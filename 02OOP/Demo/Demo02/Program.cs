using System;

/*
 * 构造函数的相互调用
 */

namespace Demo02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Test t = new Test();

            Console.WriteLine(t.Num);
        }
    }

    internal class Test
    {
        public int Num { get; set; }

        public Test() : this(1000)
        {
        }

        public Test(int num)
        {
            Num = num;
        }
    }
}