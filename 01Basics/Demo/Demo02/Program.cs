using System;

/*
 * nameof 返回的是字符串(命名空间、类型名、类型成员、变量名)
 */

namespace Demo02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stu = new Student();
            Console.WriteLine(nameof(Student.Name));
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
    }
}