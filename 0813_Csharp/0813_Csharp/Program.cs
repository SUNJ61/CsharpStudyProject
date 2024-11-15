using static System.Console;
using System.Text.RegularExpressions;

namespace _0813_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 0813내용
            //int[] n = { 1, 2, 3 ,4, 5 };
            //int sum = n.Sum();
            //int count = n.Count();
            //double average = n.Average();
            //int max = n.Max();
            //int min = n.Min();

            //WriteLine($"합 :{sum} 개수 :{count} 평균 :{average} 최대값 :{max}최소값 :{min}");

            //WriteLine("=====================================");

            //var nums = n.Where(it => it % 2 == 0 && it > 3);

            //foreach (int i in nums)
            //    Console.WriteLine(i);

            //WriteLine("=====================================");

            //bool[] blns = { true, false, true, false, true };
            //WriteLine(blns.Count());
            //WriteLine(blns.Count(bln => bln == true));
            //WriteLine(blns.Count(bln => bln == false));
            #endregion
            #region 0814 내용
            ////메서드 구문
            //int[] nums = { 3, 2, 1, 4, 5 };
            //IEnumerable<int> methodS = nums.Where(n => n % 2 == 1).OrderBy(n => n);

            //foreach(var n in methodS)
            //    Console.WriteLine(n);

            //WriteLine("=====================================");
            ////쿼리 구문
            //IEnumerable<int> queryS = from num in nums
            //                          where num % 2 == 1
            //                          orderby num
            //                          select num;

            //foreach (var n in queryS)
            //    Console.WriteLine(n);

            //WriteLine("=====================================");

            //int Abs(int number) => (number < 0) ? -number : number;

            //int min = int.MaxValue;

            //int[] numbers = { 0b1010, 0x14, 0b11110, 0x1B, 0b10001 };
            //int target = 25;
            //int near = default;

            //for(int i = 0; i < numbers.Length; i++) //식을 사용하여 구하기
            //{
            //    int abs = Abs(numbers[i] - target); // 두 수를 뺀 절댓값 구하기 (두수의 차이)
            //    if(abs < min) //절대 값이 이전 차이보다 작다면
            //    {
            //        min = abs; //최소 차이 업데이트
            //        near = numbers[i]; //최소 값 업데이트
            //    }
            //}

            //var minimum = numbers.Min(m => Math.Abs(m - target)); //numbers의 속한 값중에 타겟과 제일 차이가 적으면 그 값을 저장한다.
            //var closest = numbers.First(c => Math.Abs(target - c) == minimum); //numbers의 속한 값중에 타겟과 차이가 가장 적은 값을 저장한다.
            //WriteLine($"{target}과 가장 가까운 값 (식) : {closest} (차이 :{minimum})");
            //WriteLine($"{target}과 가장 가까운 값 (문) : {near} (차이 :{min})");

            //WriteLine("=====================================");

            //int[] data = { 10, 20, 23, 27, 17 };
            //int target = 25;
            //List<int> nears = new List<int>();
            //int min = Int32.MaxValue;

            //for(int i = 0; i < data.Length; i++)
            //{
            //    if (Math.Abs(data[i] - target) < min)
            //    {
            //        min = Math.Abs(data[i] - target);
            //    }
            //}

            //WriteLine($"차이의 최소 값 : {min}");

            //for(int i= 0; i <data.Length; i++)
            //{
            //    if (Math.Abs(data[i] - target) == min)
            //    {
            //        nears.Add(data[i]);
            //    }
            //}

            //foreach (var n in nears)
            //    Console.WriteLine(n);

            //WriteLine("=====================================");

            //int[] s = { 90, 87, 100, 95, 80 };
            //int[] rankings = Enumerable.Repeat(1,5).ToArray();

            //for(int i = 0; i < s.Length; i++)
            //{
            //    rankings[i] = 1;
            //    for(int j = 0; j <s.Length; j++)
            //    {
            //        if (s[i] < s[j])
            //            rankings[i]++;
            //    }
            //}

            //for(int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine($"{s[i], 3}점 : {rankings[i]}등");
            //}

            //WriteLine("=====================================");
            #endregion
            #region 0814 쪽지시험
            string? input = ReadLine();
            WriteLine(Removestring(input));
            #endregion
        }
        #region 0814 쪽지시험
        static string Solution(string phone_number)
        {
            var array = phone_number.Select((e, index) => index >= (phone_number.Length - 4) ? e : '*').ToArray();
            return new string(array);
        }
        static string Removestring(string input)
        {
            string answer = Regex.Replace(input, @"a|e|i|o|u","");
            return answer;
        }
        #endregion
    }
}
