using static System.Console;

namespace _0913_Test
{
    internal class Test1
    {
        //static void Main(string[] args)
        //{
        //    List<int> list = new List<int> { 1, 2, 3, 5, 7, 10, 13, 15, 18, 23, 25, 27, 30, 32, 33 };
        //    int target = 30;
        //    Console.WriteLine($"선형 탐색 실행... 타겟 '{target}' 찾기");
        //    Console.WriteLine($"탐색 실행 결과 :{LineSearch(list, target)}");
        //}

        public static bool LineSearch(List<int> list, int target)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == target)
                {
                    Console.WriteLine($"타겟은 {i}번째 인덱스에 존재합니다.");
                    return true;
                }
            }
            return false;
        }
    }
}
