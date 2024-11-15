using System;
using static System.Console;
using System.Collections;


namespace _0724_Csharp
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;  
        public MyList()
        {
            Console.WriteLine($"void 생성자 호출");
            array = new T[5];
            Console.WriteLine($"{array.Length}");
        }
        public T this[int idx]
        {
            get { return array[idx]; }
            set
            {
                if (idx >= array.Length)
                {
                    Array.Resize<T>(ref array, idx + 1);
                    Console.WriteLine($"{array.Length}");
                }
                array[idx] = value;
            }

        }
        public int Length
        {
            get { return array.Length; }
        }

        public T Current
        {
            get { return array[position]; }
        }

        object IEnumerator.Current
        {
            get { return array[position]; }
        }

        public void Dispose()
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
    internal class Mainapp
    {
        static void Main(string[] args)
        {
            MyList<double> list = new MyList<double>();
            list[0] = 1.1;
            list[1] = 1.2;
            list[2] = 1.3;
            list[3] = 1.4;

            foreach (double item in list)
            {
                Console.WriteLine(item);
            }
            WriteLine("==============================================");

            MyList<string> list1 = new MyList<string>();
            list1[0] = "하나";
            list1[1] = "둘";
            list1[2] = "셋";
            list1[3] = "넷";
            list1[4] = "다섯";
            list1[5] = "여섯";
            list1[6] = "일곱";

            foreach (string item1 in list1)
            {
                Console.WriteLine(item1);
            }
        }
    }
}
