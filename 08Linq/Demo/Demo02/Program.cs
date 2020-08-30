using System;
using System.Linq;

/*
 * Linq分组查询 返回一哥实现IGrouping接口的实例
 */

namespace Demo02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee[] emps =
            {
                new Employee{Name = "小黄",Department = "财务部"},
                new Employee{Name = "小卢",Department = "开发部"},
                new Employee{Name = "小邢",Department = "开发部"},
                new Employee{Name = "小陈",Department = "财务部"},
                new Employee{Name = "小卜",Department = "公关部"},
                new Employee{Name = "小罗",Department = "仓储部"},
                new Employee{Name = "小许",Department = "开发部"},
                new Employee{Name = "小田",Department = "仓储部"},
            };

            var q = from e in emps
                    group e by e.Department;

            foreach (var item in q)
            {
                Console.WriteLine("{0}: ", item.Key);
                foreach (var t in item)
                {
                    Console.WriteLine(t.Name);
                }
                Console.WriteLine();
            }
        }
    }

    internal class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }
}