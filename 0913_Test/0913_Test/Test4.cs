using static System.Console;
using System.Collections;

namespace _0913_Test
{
    internal class Test4
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 5, 7, 10, 13, 15, 18, 23, 25, 27, 30, 32, 33 };
            int target = 30;
            int last = list.Count - 1;
            Console.WriteLine($"재귀 함수로 이진 탐색 실행... 타겟 '{target}' 찾기");
            Console.WriteLine($"탐색 실행 결과 :{BinarySearch(list, target, last)}");
        }

        static bool BinarySearch(List<int> list, int target , int last, int first = 0)
        {
            int mid = (first + last) / 2;

            if(first > last)
                return false;

            if (list[mid] == target)
            {
                Console.WriteLine($"타겟이 {mid}번 인덱스에 존재합니다.");
                return true;
            }
            else
            {
                if (list[mid] < target)
                {
                    return BinarySearch(list, target , last, mid +1);
                }
                else
                {
                    return BinarySearch(list, target , mid -1);
                }
            }
        }
    }
}
