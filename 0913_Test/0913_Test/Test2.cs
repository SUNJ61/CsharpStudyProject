using static System.Console;

namespace _0913_Test
{
    internal class Test2
    {
        //static void Main(string[] args)
        //{
        //    List<int> list = new List<int> { 1, 2, 3, 5, 7, 10, 13, 15, 18, 23, 25, 27, 30, 32, 33 };
        //    int target = 30;
        //    Console.WriteLine($"이진 탐색 실행... 타겟 '{target}' 찾기");
        //    Console.WriteLine($"탐색 실행 결과 :{BinarySearch(list, target)}");
        //}

        static bool BinarySearch(List<int> list, int target)
        {
            int first = 0;
            int last = list.Count - 1;
            while (first <= last)
            {
                int mid = (first + last) / 2;

                if (list[mid] == target)
                {
                    Console.WriteLine($"타겟이 {mid}번 인덱스에 존재합니다.");
                    return true;
                }
                else
                {
                    if (list[mid] < target)
                    {
                        first = mid + 1;
                    }
                    else
                    {
                        last = mid -1;
                    }
                }
            }
            return false;
        }
    }
}
