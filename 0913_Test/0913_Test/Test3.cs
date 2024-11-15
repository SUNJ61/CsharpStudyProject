using static System.Console;
using System.Collections;

namespace _0913_Test
{
    internal class Test3
    {
        //static void Main(string[] args)
        //{
        //    List<int> list = Enumerable.Range(1, 100).ToList();
        //    Random rnd = new Random();

        //    MixList(list, rnd);
        //    Console.WriteLine("랜덤 리스트 출력");
        //    foreach (int i in list)
        //        Console.Write(i + " ");

        //    Console.WriteLine();

        //    BubleSort(list);
        //    Console.WriteLine("랜덤 리스트 정렬");
        //    foreach (int i in list)
        //        Console.Write(i + " ");
        //}

        static void MixList(List<int> list, Random random)
        {
            int n = list.Count;
            while(n > 1)
            {
                n--;
                int k = random.Next(n+1);
                int temp = list[k];
                list[k] = list[n];
                list[n] = temp;
            }
        }

        static void BubleSort(List<int> list)
        {
            int temp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - (i+1); j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
    }
}
