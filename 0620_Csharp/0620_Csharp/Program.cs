using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0620_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 반복문 2중 for문
            //for (int i = 2; i < 10; i++) //이중 for문 구구단 출력
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        WriteLine($"{i} * {j} = {i * j}");
            //    }
            //    WriteLine("");
            //}

            //for (int i = 9; i > 0; i--) //이중 for문 구구단 출력
            //{
            //    for (int j = 9; j > 0; j--)
            //    {
            //        WriteLine($"{i} * {j} = {i * j}");
            //    }
            //    WriteLine("");
            //}

            //WriteLine("정수 2개를 입력하시오."); // 원하는 구구단 범위 출력
            //Write("첫번째 정수입력 : ");
            //int a = int.Parse(Console.ReadLine());
            //Write("첫번째 정수입력 : ");
            //int b = int.Parse(Console.ReadLine());

            //for( int i = a ; i <= b ; i++)
            //{
            //    for( int j = 1; j < 10 ; j++)
            //    {
            //        WriteLine($"{i} * {j} = {i * j}");
            //    }
            //    Console.WriteLine("");
            //}
            #endregion
            #region 무한 루프
            //int i = 0;
            //for ( ; ; ) // while(true)도 있음.
            //{
            //    Console.WriteLine("무한 루프");
            //    i++;
            //    if(i==100)
            //    {
            //        break;
            //    }
            //}

            //int fact = 0; //팩토리얼 만들기
            //for(int i = 1; i <=4; i++)
            //{
            //    Write($"{i}! = ");
            //    fact = 1;
            //    for(int j = 1; j<=i ; j++)
            //    {
            //        fact = fact * j;
            //    }
            //    WriteLine($"{fact,2}");
            //}

            //for(int i = 2 ; i <= 9 ; i++) //구구단 가로 출력
            //{
            //    Write($"{i, 4}단 ");
            //}
            //WriteLine("");
            //for (int i = 1; i<=9 ; i++)
            //{
            //    for(int j =2 ; j<=9 ; j++)
            //    {
            //        Write($"{j}*{i}={j*i,2} ");
            //    }
            //    WriteLine("");
            //}
            #endregion
            #region while과 do문
            //int count = 0;
            //while (count++ < 3) //조건이 참이 될 때까지 반복
            //{
            //    Console.WriteLine("안녕");
            //}

            //int i = 1;
            //while (i++ <= 5)
            //{
            //    WriteLine($"카운트 : {i-1}");
            //}

            //int dan = 2;
            //int i = 1;
            //while (dan++ < 10) //이중 while문
            //{
            //    while (i++ < 10)
            //    {
            //        WriteLine($"{dan - 1}*{i - 1}={(dan - 1) * (i - 1)}");
            //    }
            //    i = 1;
            //    WriteLine();
            //}

            //int dan = 2; //가로로 출력
            //int i = 1;
            //while (i++ < 10) //이중 while문
            //{
            //    while (dan++ < 10)
            //    {
            //        Write($"{dan - 1}*{i - 1}={(dan - 1) * (i - 1)}\t");
            //    }
            //    dan = 2;
            //    WriteLine();
            //}

            //int sum = 0;
            //const int N = 100;
            //int i = 1;
            //while (i <= N) // 100까지의 짝수의 합
            //{
            //    if (i % 17 == 0)
            //    { 
            //    sum += i;
            //    }
            //    i++;
            //}
            //WriteLine(sum);

            //int first = 0;//피보나치 수열 -> 첫번째 두번째 숫자는 0과 1이여야 한다.
            //int second = 1;

            //while (second <= 20)
            //{
            //    WriteLine(second);
            //    int temp = first + second;
            //    first = second;
            //    second = temp;
            //}

            //int count = 0; //do while문 예제
            //do
            //{
            //    WriteLine("ㅎㅇ");
            //    count++;
            //} while (count < 3);

            //int sum = 0;
            //int i = 1;

            //do
            //{
            //    if (i % 3 == 0 && i % 4 == 0)
            //    {
            //        sum += i;
            //    }
            //    i++;
            //} while (i <= 100);

            //WriteLine(sum);
            #endregion
            #region foreach문과 배열
            ////자바,c# 배열 선언 -> 자료형[] 형태로 선언. c,c++은 자료형 이름[] 형태로 선언.
            //string[] names = new string[3]; //3개의 값을 저장하겠다 선언, 동적할당.(인덱스 2까지 할당됨.)
            //names[0] = "C#"; //1차원 배열이다.
            //names[1] = "ASP.NET";
            //names[2] = "유니티 엔진"; //이런 형식을 더 많이 사용한다.

            //for(int i = 0; i < names.Length ; i++)
            //{
            //    WriteLine(names[i]);
            //}

            //WriteLine("foreach 출력");

            //foreach (string name in names) // 조건문 증감식 필요 x
            //{
            //    WriteLine(name); //실행문에서 배열의 값을 출력 할 때foreach에서 지정한 변수를 사용한다.
            //}

            //string[] name2 = { "주현영", "박은비", "최수희" };//컴파일러는 169~173줄에 코드처럼 이해함

            //for (int i = 0; i < name2.Length; i++)
            //{
            //    WriteLine(name2[i]); // 데이터가 있는만큼 반복
            //}

            //foreach (string name in name2)
            //{
            //    WriteLine(name);
            //}

            //string str = "ABC123"; //string자체도 배열.
            //foreach (var c in str) //var가 자동으로 char로 인식됨. char로 선언해도 가능.
            //{
            //    Console.WriteLine($"{c}"); //string을 char로 분해하여 출력가능.
            //}
            #endregion
            #region 1차원 배열
            //int[] arr = new int[10]; //10개의 공간을 할당, 40byte를 사용.

            //WriteLine("for문 출력");
            //for (int i = 0; i < 10; i++)
            //{
            //    arr[i] = (i+1)*10;
            //    Write($"arr[{i}] =  {arr[i]}\t");
            //}

            //WriteLine("\nforeach문 출력");
            //foreach (int i in arr)
            //{
            //    int n = 1;
            //    Write($"arr[{n}] =  {i}\t");
            //    n++;
            //}
            #endregion
            #region 배열 연습문제
            ////1차원 배열을 100으로 초기화 하고
            ////배열을 1부터 100까지 채운다.
            ////배열안에 값을 3의 배수와 7의 배수로 초기화 해서 출력하시오.

            //int[] arr = new int[100];
            //for (int i = 1; i < (arr.Length+1); i++)
            //{
            //    arr[i-1] = i;
            //}
            //foreach (int i in arr)
            //{
            //    if(i % 3 == 0 && i % 7 == 0)
            //    {
            //        WriteLine($"3의 배수 이면서 7의 배수 : {i}");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        WriteLine($"3의 배수 : {i}");
            //    }
            //    else if (i % 7 == 0)
            //    {
            //        WriteLine($"7의 배수 : {i}");
            //    }
            //    else
            //    {
            //    }
            //}
            #endregion
            #region break, continue
            //int sum = 0; //break는 반복문을 빠져나감.
            //while(true)
            //{
            //    if(sum >= 500)
            //    {
            //        break;
            //    }
            //    sum += 1;
            //}
            //WriteLine(sum);

            //for (int i = 1; i <= 5; i++) // continue는 하고있던 반복을 중지하고 다음반복 실행.
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    WriteLine(i);
            //}

            //int sum = 0; //continue사용으로 3의 배수합 구하기
            //for(int i = 1; i <=100; i++)
            //{
            //    if(i%3==0)
            //    {
            //        continue;
            //    }
            //    sum += i;
            //}
            //WriteLine(sum);

            //구구단 1단부터 9단까지 짝수만 출력
            //2단은 2까지, 4단은 4까지 이러한 형식으로 출력하기.
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        if (i % 2 == 1)
            //            continue;
            //        if(i < j)
            //            break;

            //        Write($"{i} * {j} = {i * j}\t");
            //    }
            //    WriteLine("");
            //}

            //for (int i = 1; i < 10; i++) //번외
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        if (j % 2 == 1)
            //            continue;
            //        if (j < i)
            //        {
            //            Write("     \t");
            //            continue;
            //        }

            //        Write($"{j}*{i}={i * j}\t");
            //    }
            //    WriteLine("");
            //}
            #endregion
            #region 장난감
            //for (int i = 1; i < 6; i++) // 삼각형 출력하기
            //{
            //    for (int j = 5; j > i; j--)
            //    {
            //        Write(" "); //빈공간
            //    }
            //    for (int k = 1; k <= 2 * i; k++)
            //    {
            //        Write("*"); //별
            //    }
            //    WriteLine(""); // 줄바꿈
            //}

            //for (int i = 0 ; i <= 5; i++) // 사이사이 빈 삼각형 출력
            //{
            //    for (int j = 5; j > i; j--)
            //    {
            //        Write(" "); //빈공간
            //    }
            //    for (int k = 0; k <= (2 * i) + 1; k++)
            //    {
            //        if(k % 2 == 0)
            //            Write("*"); //별
            //        else
            //            Write(" "); //빈공간
            //    }
            //    WriteLine(""); // 줄바꿈
            //}


            #endregion
            #region 문제능력기르기 제일 간단하게 코딩하기
            ///*
            //5천원을 가지고 크림빵(500원),새우깡(700),콜라(400) 잔돈을 남기지 않고 세가지 물건을 하나이상
            //구매할 때의 경우의 수를 나타내어라.
            //*/
            //int mn = 0, cr = 500, sp = 700, co = 400;
            //Write("금액입력 : ");
            //mn = int.Parse(ReadLine());

            //for (int i = 1; i <= (mn / cr); i++)
            //{
            //    for (int j = 1; j <= (mn / sp); j++)
            //    {
            //        for (int k = 1; k <= (mn / co); k++)
            //        {
            //            if (mn == i * cr + j * sp + k * co)
            //            {
            //                WriteLine($"크림빵 : {i}새우깡 : {j}콜라 : {k}");
            //            }
            //        }
            //    }
            //}

            ///*
            //길이 10인배열 선언, 10개 입력, 홀짝 구분지어 출력, 홀 먼저 출력
            //*/

            //int[] arr = new int[10];
            //WriteLine("정수를 10번 입력하시오.");
            //for (int i = 0; i<10 ; i++)
            //{
            //    arr[i] = int.Parse(ReadLine());
            //}

            //Write("홀수 출력 : ");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (arr[i] % 2 == 1)
            //    {
            //        Write($"{arr[i]} ");
            //    }
            //}

            //Write("\n짝수 출력 : ");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        Write($"{arr[i]} ");
            //    }
            //}

            ///*
            //10진수 -> 이진수 변환 프로그램
            //*/

            Write("십진수 하나를 입력하시오 :"); //미완
            int a = int.Parse(Console.ReadLine());
            int l;

            if (a < 2)
                l = 1;
            else if (a < 4)
                l = 2;
            else if (a < 8)
                l = 3;
            else if (a < 16)
                l = 4;
            else if (a < 32)
                l = 5;

            int[] ch = new int[l];

            int k = 0;
            int i = 0;

            while (true)
            {
                k = (a % 2);
                a = (a / 2);
                ch[i] = k;
                if (a == 1 || a == 0)
                {
                    ch[i] = k;
                    break;
                }
                i++;
            }

            for (int j = 0; j < l ; j++)
            {
                Write(ch[j]);
            }

            //int n;
            //string bin;

            //Write("십진수 하나를 입력하시오 :"); // 이진수 변경 프로그램 변경 명령어를 쓰는게 되네;;
            //n = int.Parse(ReadLine());
            //bin =Convert.ToString(n,2);

            //WriteLine($"{bin}");
            #endregion
            #region 배열
            ////리스트 기본
            //var list = new List<string> { "배열", "리스트", "사전" }; //리스트는 형변환이 자유롭다.
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            ////딕셔너리 한쌍의 키와 값을 가지고 있다. -> 키를 통해서 값을 찾는다.
            //var dic = new Dictionary<int, string> { { 0, "배열" }, { 1, "리스트" }, { 2, "사전" } };
            //foreach (var pair in dic)
            //{
            //    WriteLine($"{pair.Key} - {pair.Value}");
            //}
            #endregion
        }
    }
}
