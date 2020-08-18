using System;

/*
 * ref按饮用传递的返回值
 */

namespace Demo04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Test1 t1 = new Test1(100);
            Console.Write("初始");
            t1.DisplayValue();

            Console.Write("修改后");
            int x = t1.value;
            x = 200;
            t1.DisplayValue();

            Test2 t2 = new Test2(100);
            Console.Write("初始");
            t2.DisplayValue();

            Console.Write("修改后");
            ref int y = ref t2.value;
            y = 200;
            t2.DisplayValue();
        }
    }

    internal class Test1
    {
        private int _local;

        public Test1(int init)
        {
            _local = init;
        }

        public void DisplayValue()
        {
            Console.WriteLine($"当前的值：{_local}");
        }

        public int value => _local;
    }

    internal class Test2
    {
        private int _local;

        public Test2(int init)
        {
            _local = init;
        }

        public void DisplayValue()
        {
            Console.WriteLine($"当前的值：{_local}");
        }

        public ref int value => ref _local;
    }
}