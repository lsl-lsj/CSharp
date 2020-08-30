using System;
using System.Collections;

/*
 * IEnumerable接口与foreach循环
 */

namespace Demo05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ExampleCollection ec = new ExampleCollection();
            foreach (var item in ec)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class Enumerator : IEnumerator
    {
        private string[] _str;
        private int _currentIndex;

        public Enumerator(string[] src)
        {
            _str = src;
            _currentIndex = -1;
        }

        public object Current { get; private set; }

        public bool MoveNext()
        {
            if (++_currentIndex >= _str.Length)
            {
                Current = null;
                return false;
            }
            Current = _str[_currentIndex];
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

    internal class ExampleCollection : IEnumerable
    {
        private string[] arraySrc = { "red", "blue", "green", "gray" };

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(arraySrc);
        }
    }
}