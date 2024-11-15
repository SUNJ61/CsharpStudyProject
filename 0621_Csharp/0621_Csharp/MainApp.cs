//using System;
//using static System.Console;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net;

//namespace _0621_Csharp
//{
//    internal class MainApp
//    {
//        #region 함수(매서드) 만들기
//        //static void Func1() //함수 정의
//        //{
//        //    WriteLine("어서오세요.");
//        //}

//        //static int Add(int n1, int n2)
//        //{
//        //    //리턴은 함수를 빠져나가거나, 함수를 빠저나갈때 값을 반환한다.
//        //    return n1 + n2;
//        //}

//        //static int Minus(int n1, int n2)
//        //{
//        //    return n1 - n2;
//        //}

//        //static string Method()
//        //{
//        //    string str = ReadLine();
//        //    return str;
//        //}

//        //static int Max(int x, int y)
//        //{
//        //    return (x > y ? x : y);
//        //}

//        //static int Min(int x, int y)
//        //{
//        //    if (x < y)
//        //    {
//        //        return x;
//        //    }
//        //    else
//        //    {
//        //        return y;
//        //    }
//        //}
//        #endregion
//        #region 문제 함수 만들기
//        //static int Input()
//        //{
//        //    Write("정수를 입력하시오 : ");
//        //    int i = int.Parse(Console.ReadLine());
            
//        //    return i;
//        //}

//        //static void Dan(int i, int j)
//        //{
//        //    if (i>j)
//        //    {
//        //        int temp = i;
//        //        i = j;
//        //        j = temp;
//        //    }
//        //    for (int k=i; k<=j;k++)
//        //    {
//        //        for(int t=1; t<10;t++)
//        //        {
//        //            Write($"{k}*{t}={k*t} ");
//        //        }
//        //        WriteLine();
//        //    }
//        //}


//        #endregion
//        public static void Main(string[] args)
//        {
//            #region 매개변수
//            //if (args.Length == 0) //매개변수 값 체크.
//            //{
//            //    WriteLine("사용법 : _0621_Csharp.exe<이름>");
//            //    return; //함수를 빠져나간다.
//            //}
//            //WriteLine("Hello,{0}!", args[0]);
//            #endregion
//            #region 함수 호출
//            //Func1(); //함수 호출 (기능만 있음.)

//            //int result = Add(1, 2); // Add함수의 n1에 1 n2에 2가 들어가고 return 값이 반환된다.
//            //WriteLine(result); // 함수에서 변수를 반환.

//            //int result1 = Minus(2, 1);
//            //WriteLine(result1);

//            //WriteLine("이름을 입력하시오."); 함수는 하나의 기능만 가지도록 설계해야한다.
//            //string result3 = Method();
//            //WriteLine(result3);

//            //WriteLine(Max(3,5));
//            //WriteLine(Min(-3,-5));
//            #endregion
//            #region 문제 함수 호출
//            //int i = Input(); //정수 입력해서 구구단 출력
//            //int j = Input();
//            //Dan(i, j);


//            #endregion
//        }
//    }
//}
