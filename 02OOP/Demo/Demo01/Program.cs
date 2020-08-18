using System;

/*
 * 结构类型 定义构造函数
 */

namespace Demo01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 创建结构类实例

            // 方式1 -- 这种方式不能在成员后面加{ get; set; }
            Rectangle r1;
            r1.Width = 1;
            r1.Height = 2;

            // 方式2
            Rectangle r2 = new Rectangle() { Width = 1, Height = 2 };

            // 方式3
            Rectangle r3 = new Rectangle();
            r3.Height = 2;
            r3.Width = 1;

            // 方式4
            Rectangle r4 = new Rectangle(1, 2);

            Test t = new Test("t");
            Console.WriteLine(t.Name);
        }
    }

    internal struct Rectangle
    {
        public int Width;
        public int Height;

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }
    }

    internal class Test
    {
        public string Name;

        public Test(string name)
        {
            Name = name;
        }
    }
}