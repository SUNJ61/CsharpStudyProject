using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("이름을 입력하시오 : ");
            string Name = ReadLine();
            Write("학과를 입력하시오 : ");
            string Sw = ReadLine();
            Write("학년을 입력하시오 : ");
            int Stu = int.Parse(ReadLine());
            Write("C언어 점수를 입력하시오 : ");
            int Cnum = int.Parse(ReadLine());
            Write("C++ 점수를 입력하시오 : ");
            int Cplus = int.Parse(ReadLine());
            Write("C# 점수를 입력하시오 : ");
            int Csharp = int.Parse(ReadLine());

            WriteLine($"이름 : {Name}");
            WriteLine($"학년 : {Stu}학년");
            WriteLine($"학과 : {Sw}");
            WriteLine($"점수 합계 : {Cnum+Cplus+Csharp}점");
            double avg = (Cnum + Cplus + Csharp) / 3;
            avg = Math.Round(avg, 2);
            WriteLine($"점수 평균 : {avg}점");

        }
    }
}
