//using static System.Console;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;
//using System.Runtime.InteropServices;

//namespace _06_14_Csharp
//{
//    internal class MainApp
//    {
//        static void Main(string[] args)
//        {
//            #region 자료형 int와 const

//            ////integer를 줄여서 int라고 작성.
//            //int num1 = 20;
//            //int num2 = 30;

//            //WriteLine("num1 : {0}\nnum2 : {1}\n",num1,num2);
//            //WriteLine($"num1 : {num1}\nnum2 : {num2}\n");

//            //num1 = 100; num2 = 200;
//            //WriteLine($"num1 : {num1}\nnum2 : {num2}\n");

//            ////변수의 반대는 상수 constant -> 항상 일정한 값.
//            //const int MAX = 100;
//            //WriteLine($"MAX : {MAX}");

//            #endregion
//            #region 데이터 자료형 종류

//            //int number; //선언 작업
//            //number = 30; // 초기화 작업
//            //int number2 = number; //선언과 동시에 초기화 작업

//            ////WriteLine($"number2 : {number2}");

//            //const double PI = 3.141592; //8byte 실수형 자료형.
//            //int r = 4;
//            //double k = r * r * PI;
//            ////WriteLine($"원의 넓이 : {k}");

//            //string SchoolNumber = "98-123456789";
//            //string JuminNumber = "030127-1234567";
//            //WriteLine($"학번:{SchoolNumber}, 주민등록번호:{JuminNumber}");

//            #endregion
//            #region bool 자료형과 object자료형
//            //bool Isjump = false;
//            //WriteLine($"논리값 : {!Isjump}"); //!는 역(NOT)을 의미한다.
//            //Isjump = true;
//            //WriteLine($"논리값 : {!Isjump}");

//            //int n1 = 20, n2 = 30; //,는 이어지는 내용에서 사용.
//            //WriteLine(n1<n2); //비교 연산자를 사용하여 결과값이 bool로 나옴.

//            //bool IsCorrect = n1 > n2;
//            //WriteLine(IsCorrect);

//            //object obj = 21;
//            //object obj2 = 3.14;
//            //object obj3 = "Hi Hello";
//            //object obj4 = false;

//            //WriteLine($"{obj}, {obj2}, {obj3}, {obj4}");
//            //object는 모든 데이터 자료형의 조상이다.
//            //object는 값형식이 아니라 참조형식이다.
//            //object는 박싱 언박싱 현상이 일어난다.
//            //object와 다른 자료형은 연산이 되지 않는다.

//            //int a = 123;
//            //object b = (object)a; //박싱이 일어난다. -> a에 담긴 값을 다른공간(힙)에 저장하고 그 주소값을 가진다. -> 주소가 됨.
//            //int c = (int)b; //언박싱이 일어난다. -> b주소에 담긴 값을 언박싱해서 선언한 공간(스택)에 저장한다. -> 값이 됨.

//            //WriteLine($"{a}, {b}, {c}");

//            #endregion
//            #region 상황에 따른 데이터 선언

//            //string name = "Lee Hae Jun"; //이름
//            //int age = 25; //나이
//            //string job = "학생"; //직업
//            //double heihgt = 181.1; //키
//            //double weight = 74.2; //몸무게
//            //string hobby = "발로란트, 컴퓨터 하드웨어 검색"; //취미

//            //WriteLine($"이름 : {name}\n나이 : {age}\n직업 : {job}\n키 : {heihgt}\n몸무게 : {weight}\n취미 : {hobby}\n");

//            #endregion
//        }
//    }
//}
