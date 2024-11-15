using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace _06_14_Csharp
{
    internal class MainApp2
    {
        static void Main(string[] args)//프로그램의 시작점.
        {
            #region 정수로 입력받기
            ////키보드로 부터 입력 받기
            //Write("정수 입력 : ");
            ////정수로 형변환 해서 값을 넘겨준다. -> Console.ReadLine() : 문자열 입력받기. / int.Parse() -> 문자열을 정수로 변환. 
            //int Input = int.Parse(Console.ReadLine());
            //WriteLine($"입력 받은 정수 출력 : {Input}");
            #endregion
            #region 정수를 입력받아서 계산 결과 출력
            //WriteLine("양의 정수를 두번 입력하세요");
            //Write("첫번째 정수 : ");
            //int Input1 = int.Parse(Console.ReadLine());
            //Write("두번째 정수 : ");
            //int Input2 = int.Parse(Console.ReadLine());
            //int Plus = Input1 + Input2;
            //WriteLine($"입력한 두개의 정수의 합은 [{Plus}] 이다.");
            //int M = Input1 - Input2;
            //WriteLine($"입력한 두개의 정수의 차는 [{M}] 이다.");
            //int N = Input1 / Input2;
            //WriteLine($"입력한 두개의 정수의 나눔은 [{N}] 이다.");
            //int n = Input1 % Input2;
            //WriteLine($"입력한 두개의 정수의 나머지는 [{n}] 이다.");
            //int X = Input1 * Input2;
            //WriteLine($"입력한 두개의 정수의 곱은 [{X}] 이다.");
            #endregion
            #region 문자열이나 double의 값 입력받기
            Write("이름 입력 : ");
            string Name = ReadLine();
            Write("나이 입력 : ");
            int age = int.Parse(ReadLine());
            Write("키 입력 : ");
            double height = double.Parse(ReadLine());

            WriteLine($"이름 출력 : {Name}\n나이 출력 : {age}\n키 출력 : {height}");
            #endregion
        }
    }
}
