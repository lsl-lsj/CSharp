using System;
using System.Collections;
using System.Collections.Generic;

/*
 * IEnumerator接口 对集合元素进行枚举
 */

namespace Demo04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Enumerator e = new Enumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
        }
    }

    public class Enumerator : IEnumerator<int>
    {
        private Random rand = null;
        private int count;

        public Enumerator()
        {
            rand = new Random(3);
            count = 0;
            Current = default(int);
        }

        public int Current { get; private set; }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            rand = null;
        }

        public bool MoveNext()
        {
            if (++count > 10)
                return false;
            Current = rand.Next();
            return true;
        }

        public void Reset()
        {
            count = 0;
            Current = default(int);
        }
    }
}