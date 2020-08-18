using System;

/*
 * 自定义特性类
 */

namespace Demo09
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class DescriptionAttribute : Attribute
    {
        public string Description { get; set; }
    }

    public class OrderDate
    {
        [Description(Description = "订单ID")]
        public int ID { get; set; }

        [Description(Description = "添加时间")]
        public DateTime AddTime { get; set; }

        [Description(Description = "价格")]
        public double Price { get; set; }
    }
}