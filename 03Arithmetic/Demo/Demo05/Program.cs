using System;

/*
 * 自定义隐式转换
 */

namespace Demo05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int t = new RectArea(3, 4);
            Console.WriteLine($"长方形的面积为：{t}");
        }
    }

    public class RectArea
    {
        public int Width { get; }
        public int Height { get; }

        public RectArea(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // 添加自定义转化实现
        public static implicit operator int(RectArea r)
        {
            return r.Width * r.Height;
        }
    }
}