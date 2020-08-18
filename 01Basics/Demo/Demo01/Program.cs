using System;

/*
 * c# 指针
 */

namespace Demo01
{
    internal class Program
    {
        public class System { }

        private static unsafe void Main(string[] args)
        {
            //global::System.Version v = new global::System.Version("2.2");
            //Console.WriteLine(v);

            var adc = 1.2d;
            //Console.WriteLine(adc.GetType().FullName);

            var i = 1;

            double* a = &adc;
            int* b = &i;
            IntPtr ptr = (IntPtr)a;
            IntPtr ptr1 = (IntPtr)b;

            Console.WriteLine(ptr.ToString("X"));
            Console.WriteLine(ptr1.ToString("X"));
        }
    }
}