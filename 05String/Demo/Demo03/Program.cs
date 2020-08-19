using System;

/*
 * 字符串隐式转换为自定义类
 */

namespace Demo03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string str = "10026-张三-28-上海";
            Student stu = str;
            Console.WriteLine(stu);
        }
    }

    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public static implicit operator Student(string input)
        {
            string[] stu = input.Split("-");
            if (stu.Length != 4)
                return null;
            return new Student
            {
                ID = Int32.Parse(stu[0]),
                Name = stu[1],
                Age = Convert.ToInt32(stu[2]),
                City = stu[3]
            };
        }

        public override string ToString()
        {
            return $"学号: {ID}\n姓名: {Name}\n年龄: {Age}\n城市: {City}";
        }
    }
}