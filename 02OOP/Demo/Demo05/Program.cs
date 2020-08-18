using System;
using System.Collections.Generic;
using System.Linq;

/*
 * 封装事件
 */

namespace Demo05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Test t = new Test();
            t.Worked += (k, f) => Console.WriteLine($"你已调用了{f}次实例");
            t.Run();

            List<string> a = new List<string>();
            List<string> b = new List<string>();
        }
    }

    public delegate void DemoEventDelegate(object obj, int count);

    public class Test
    {
        private DemoEventDelegate _myEvent;

        public event DemoEventDelegate Worked
        {
            add
            {
                if (value != null)
                {
                    _myEvent += value;
                }
            }
            remove
            {
                if (value != null)
                {
                    _myEvent -= value;
                }
            }
        }

        private int c = 0;

        public void Run()
        {
            _myEvent?.Invoke(this, ++c);
        }
    }
}