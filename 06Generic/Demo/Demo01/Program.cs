using System;
/*
 *泛型约束
 */
namespace Demo01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Test<int, Person> t = new Test<int, Person>();
            t.start();
        }
    }

    internal class Test<T, K>
        where T : struct
        where K : class, new()
    {
        public void start()
        {
            string CheckType(Type type) => type.FullName;
            Console.WriteLine($"T的类型是 {CheckType(typeof(T))}");
            Console.WriteLine($"K的类型是 {CheckType(typeof(K))}");
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
        }
    }
}