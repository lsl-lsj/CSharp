using System;

/*
 * 将抽象类作为类型的约束
 */

namespace Demo05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITest<Animal> t = new Test<Animal>();
            t.DoWork(new Fox());
            t.DoWork(new Tiger());
            t.DoWork(new Chicken());
            t.DoWork(new Snake());
        }
    }

    /// <summary>
    /// 公共基类
    /// </summary>
    public abstract class Animal
    {
        public abstract void CheckIn();
    }

    /// <summary>
    /// 狐狸
    /// </summary>
    public class Fox : Animal
    {
        public override void CheckIn()
        {
            Console.WriteLine("这是一只狐狸");
        }
    }

    /// <summary>
    /// 蛇
    /// </summary>
    public class Snake : Animal
    {
        public override void CheckIn()
        {
            Console.WriteLine("这是一只蛇");
        }
    }

    /// <summary>
    /// 老虎
    /// </summary>
    public class Tiger : Animal
    {
        public override void CheckIn()
        {
            Console.WriteLine("这是一只老虎");
        }
    }

    /// <summary>
    /// 鸡
    /// </summary>
    public class Chicken : Animal
    {
        public override void CheckIn()
        {
            Console.WriteLine("这是一只鸡");
        }
    }

    public interface ITest<in T>
    {
        void DoWork(T t);
    }

    public class Test<T> : ITest<T>
        where T : Animal
    {
        public void DoWork(T t)
        {
            t.CheckIn();
        }
    }
}