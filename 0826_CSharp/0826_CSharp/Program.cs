using System.Collections;
using static System.Console;

namespace _0826_CSharp
{
    public class MyList1
    {
        private int[] list;
        public MyList1()
        {
            list = new int[3];
        }
        public int this[int idx]
        {
            get { return list[idx]; }
            set
            {
                if(idx >= list.Length)
                {
                    Array.Resize<int>(ref list, idx + 1);
                    WriteLine($"Array Resized : {list.Length}");
                }
                list[idx] = value;
            }
        }
        public int Length
        {
            get { return list.Length; }
        }
    }

    public class MyList2 : IEnumerable, IEnumerator
    {
        private int[] list;
        private int position = -1;
        public MyList2()
        {
            list = new int[3];
        }
        public int this[int idx]
        {
            get { return list[idx]; }
            set
            {
                if (idx >= list.Length)
                {
                    Array.Resize<int>(ref list, idx + 1);
                    WriteLine($"Array Resized : {list.Length}");
                }
                list[idx] = value;
            }
        }
        public int Length
        {
            get { return list.Length; }
        }

        public object Current
        { get { return list[position]; } }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position == list.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < list.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList1 list1 = new MyList1();

            for (int i = 0; i < 5; i++)
                list1[i] = i;

            for(int i = 0; i < list1.Length; i++)
                Console.WriteLine(list1[i]);


            MyList2 list2 = new MyList2();

            for (int i = 0; i < 5; i++)
                list2[i] = i;
            foreach (int i in list2)
                Console.WriteLine(i);
        }
    }
}
