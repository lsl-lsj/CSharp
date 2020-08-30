using System;
using System.Linq;
using System.Text;

/*
 * 将原始序列进行分组
 */

namespace Demo01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student[] stus =
            {
                new Student
                {
                    ID = 201,
                    Name = "小王",
                    Course = "C"
                },
                new Student
                {
                    ID = 202,
                    Name = "小曾",
                    Course = "C++"
                },
                new Student
                {
                    ID = 203,
                    Name = "小吕",
                    Course = "C++"
                },
                new Student
                {
                    ID = 204,
                    Name = "小孙",
                    Course = "C#"
                },
                new Student
                {
                    ID = 205,
                    Name = "小郑",
                    Course = "C"
                },
                new Student
                {
                    ID = 206,
                    Name = "小叶",
                    Course = "C"
                },
                new Student
                {
                    ID = 207,
                    Name = "小苏",
                    Course = "C#"
                },
                new Student
                {
                    ID = 208,
                    Name = "小梁",
                    Course = "Delpi"
                }
            };
            var x = from i in stus
                    select new
                    {
                        i.ID,
                        i.Name
                    };
            foreach (var item in x)
            {
                Console.WriteLine("{0} -- {1}", item.ID, item.Name);
            }

            var result = stus.GroupBy(s => s.Course, (gKey, gItems) => (GroupKey: gKey, ItemCount: gItems.Count(), Items: gItems));

            StringBuilder sb = new StringBuilder();

            Console.WriteLine("学员参与课程汇总：");

            foreach (var g in result)
            {
                sb.AppendFormat("课程：{0}\n", g.GroupKey);
                sb.AppendFormat("参与人数：{0}\n", g.ItemCount);
                sb.AppendLine("名单：");
                foreach (var item in g.Items)
                {
                    sb.AppendFormat("     {0} - {1}\n", item.ID, item.Name);
                }
            }

            Console.WriteLine(sb);
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
    }
}