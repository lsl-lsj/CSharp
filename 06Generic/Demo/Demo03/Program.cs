using System;

/*
 * 泛型参数的输入与输出
 */

namespace Demo03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITest1<FootBall> t1 = new Test1<Ball>();
            ITest2<Ball> t2 = new Test2<FootBall>();
        }
    }

    internal class Ball
    {
    }

    internal class FootBall : Ball
    {
    }

    internal interface ITest1<in T>
    {
    }// 逆变

    internal interface ITest2<out T>
    {
    }// 协变

    internal class Test1<T> : ITest1<T>
    {
    }

    internal class Test2<T> : ITest2<T>
    {
    }
}