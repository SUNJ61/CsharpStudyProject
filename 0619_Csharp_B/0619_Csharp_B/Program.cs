using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Reflection.Emit;
using Microsoft.SqlServer.Server;

namespace _0619_Csharp_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 조건문 예제 (자의가 많이 포함된.)
            //while (true) 
            //    {
            //        WriteLine("영문 대문자 또는 소문자 하나를 입력하세요. ~를 입력하면 종료됩니다.");
            //        char c = Convert.ToChar(ReadLine());

            //        if (c >= 'A' && c <= 'Z')
            //        {
            //            WriteLine($"{c}는 대문자 입니다.");
            //        }
            //        else if (c >= 'a' && c <= 'z')
            //        {
            //            WriteLine($"{c}는 소문자 입니다.");
            //        }
            //        else if (c == '~')
            //        {
            //            WriteLine("종료합니다.");
            //            break;
            //        }
            //        else
            //        {
            //            WriteLine("영어가 아닙니다.");
            //        }
            //    }

            //Write("문자를 입력하세요. (y/n/c) : "); //일반 적인 if문
            //char input = Convert.ToChar(ReadLine());
            //if(input == 'y')
            //{
            //    WriteLine("yes");
            //}
            //else if (input == 'n')
            //{
            //    WriteLine("no");
            //}
            //else
            //{
            //    WriteLine("cancel");
            //}

            //Write("문자를 입력하세요. (y/n/c) : "); //중첩 if문 -> if문 안에 if문 넣기
            //char input1 = Convert.ToChar(ReadLine());
            //if (input1 == 'y')
            //{
            //    WriteLine("yes");
            //}
            //else
            //{
            //    if (input1 == 'n')
            //    {
            //        WriteLine("no");
            //    }
            //    else
            //    {
            //        WriteLine("cancel");
            //    }
            //}

            //Write("점수 : "); //중첩 예제
            //int score  = int.Parse(ReadLine());
            //string grade = "";

            //if (score >= 90)
            //{
            //    grade = "금메달";
            //}
            //else
            //{
            //    if(score >= 80)
            //    {
            //        grade = "은메달";
            //    }
            //    else
            //    {
            //        if(score >= 70)
            //        {
            //            grade = "동메달";
            //        }
            //        else
            //        {
            //            grade = "참가상";
            //        }
            //    }
            //}
            //WriteLine($"{grade}를(을) 수상했습니다.");

            //Write("정수 입력 : _\b");
            //int a = int.Parse(ReadLine());

            //if(a % 2 == 0)
            //{
            //    WriteLine("짝수");
            //}
            //else
            //{
            //    WriteLine("홀수");
            //}

            //if (a % 3 == 0)
            //{
            //    WriteLine("3의 배수");
            //}
            //else if (a % 5 == 0)
            //{
            //    WriteLine("5의 배수");
            //}
            //else if (a % 7 == 0)
            //{
            //    WriteLine("7의 배수");
            //}
            //else
            //{
            //    WriteLine("3,5,7의 배수가 아닌수.");
            //}
            #endregion
            #region 스위치 문
            //Write("정수를 입력 하시오 : "); //입력한 정수의 case의 결과를 도출.
            //int answer = int.Parse(ReadLine());

            //switch (answer)
            //{
            //    case 1:
            //        WriteLine("1을 선택했습니다.");
            //        break;

            //    case 2:
            //        WriteLine("2을 선택했습니다.");
            //        break;

            //    case 3:
            //        WriteLine("3을 선택했습니다.");
            //        break;

            //    default:
            //        WriteLine("1~3사이를 입력하세요.");
            //        break;
            //}

            //char ch;
            //WriteLine("아침은 m을 립력, 점심은 a를 입력, 저녁은 e를 입력하시오.");
            //ch = Convert.ToChar(ReadLine());
            //switch(ch) //대소문자 어느 것을 입력해도 원하는 결과를 가져올 수 있음.
            //{
            //    case 'm':
            //    case 'M':
            //        WriteLine("Good Morning");
            //        break;
            //    case 'a':
            //    case 'A':
            //        WriteLine("Good Afternoon");
            //        break;
            //    case 'e':
            //    case 'E':
            //        WriteLine("Good Evening");
            //        break;
            //    default: // if문의 else와 같은 용도로 쓰인다.
            //        WriteLine("다른걸 입력하셨습니다.");
            //        break; 
            //}

            //WriteLine("오늘 날씨는 어떤가요? (맑음, 흐림, 비, 눈, ...)");
            //string wether = ReadLine(); //예제

            //switch(wether)
            //{
            //    case "맑음":
            //        Console.WriteLine("오늘 날씨는 맑군요.");
            //        break;
            //    case "흐림":
            //        Console.WriteLine("오늘 날씨는 흐리군요.");
            //        break;
            //    case "비":
            //        Console.WriteLine("오늘 날씨는 비가 오는군요.");
            //        break;
            //    default:
            //        Console.WriteLine("혹시 눈이 내리나요?");
            //        break;
            //}
            #endregion
            #region for문(반복문)
            //for (int i = 0 ; i<3 ; i++) //지정된 조건을 만족 할때까지 해당 함수내 명령어를 반복한다.
            //{
            //    Console.WriteLine("안녕하세요.");
            //}

            //int num = 100;
            //int total = 0;
            ////   초기화 , 조건 ,증감식
            //for (var i = 0; i < 100; i++)
            //{
            //    num--;
            //    total++;
            //}
            //Console.WriteLine(num);
            //Console.WriteLine(total);

            //Write("몇단의 구구단을 출력하시겠습니까? : ");
            //int dan = int.Parse(Console.ReadLine());
            //for(int i = 1; i<10; i++)
            //{
            //    Console.WriteLine($"{dan} * {i} = {dan*i}");
            //}
            //WriteLine("======================================");
            //for (int i = 9; i > 0; i--)
            //{
            //    Console.WriteLine($"{dan} * {i} = {dan * i}");
            //}

            //int sum = 0; //100까지의 짝수의 합.
            //for(int i = 1; i<=100 ; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //WriteLine(sum);

            //int sum1 = 0;
            //int sum2 = 0;
            //for (int i = 1 ; i <=5 ; i++)
            //{
            //    Console.Write($"{i}\t");
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 1; i <=100; i++)
            //{
            //    sum1 += i;
            //}
            //WriteLine($"1부터 100까지의 합은 {sum1}이다.");
            //for (int i = 0 ; i<=0 ; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        sum2 += i;
            //    }
            //}
            //WriteLine($"1부터 100까지의 짝수의 합은 {sum2}이다.");
            #endregion
            #region 연습문제
            //WriteLine("사각형의 너비를 입력하시오.");
            //string width = ReadLine();
            //WriteLine("사각형의 높이를 입력하시오.");
            //string height = ReadLine();

            //int w = int.Parse(width);
            //int h = int.Parse(height);

            //int result = w * h;
            //WriteLine($"사각형의 넓이는 {result} 이다.");
            //float b = 3.14f;

            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Write("*");
            //    }
            //    WriteLine("");
            //}

            //for (int i = 5; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Write("*");
            //    }
            //    WriteLine("");
            //}
            #endregion
            int a = 7;
            float b = 3.14f;
            double c = (double)a*b;
            WriteLine(c);
        }
    }
}
