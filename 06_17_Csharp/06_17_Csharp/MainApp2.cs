//using static System.Console;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;
//using System.Deployment.Internal;
//using System.Data;

//namespace _06_17_Csharp
//{
//    internal class MainApp2
//    {
//        public static void Main(string[] args)
//        {
//            #region 자료형의 최대 최소
//            //WriteLine($"int형 최대 값 : {int.MaxValue}, int형 최소 값 : {int.MinValue}");

//            //WriteLine($"uint형 최대 값 : {uint.MaxValue}, uint형 최소 값 : {uint.MinValue}");

//            //WriteLine($"long형 최대 값 : {long.MaxValue}, long형 최소 값 : {long.MinValue}");

//            //WriteLine($"ulong형 최대 값 : {ulong.MaxValue}, ulong형 최소 값 : {ulong.MinValue}");

//            //WriteLine($"short형 최대 값 : {short.MaxValue}, short형 최소 값 : {short.MinValue}");

//            //WriteLine($"ushort형 최대 값 : {ushort.MaxValue}, ushort형 최소 값 : {ushort.MinValue}");
//            #endregion
//            #region 구분자 와 char
//            //int i = 1_000_000;
//            //WriteLine(i);

//            //char ch = 'a'; // 정수형 데이터이지만 문자 하나표현 할때 사용
//            //WriteLine(ch);

//            //string str = "문자열을 저장하는 자료형, 정해진 범위가 없어 저장 범위를 계속 늘릴 수 있음.";
//            //WriteLine(str);

//            #endregion
//            #region Null 가능형식
//            //Null - > 빈공간을 의미한다.
//            //int x = null; -> 에러 발생 , int는 Null을 지원하지 않는다.
//            //int? x = null; //int?는 null을 허용한다.
//            //WriteLine(x); //빈 공간 (여백)출력
//            //double? y = null;//아무런 값을 지정하지 않아 메모리만 차지한다.
//            //WriteLine(y); //값을 정하지 못할 때 주로 사용하여 프로젝트를 수행한다.
//            #endregion
//            #region string 여러줄 저장
//            //string multi = @"
//            //        안녕하세요.
//            //        반갑습니다.
//            //    "; //입력한 그대로 표현한다. 엔터와 모든 이스케이프 시퀸스(ex.\n)도 그대로임 -> 경로표현 가능.
//            //WriteLine(multi);
//            #endregion
//            #region 문자열 보간법
//            //string name = "C#";
//            //string version = "8.0";
//            //WriteLine("{0} {1}", name, version);
//            //string result = String.Format("{0} {1}", name, version);
//            ////복잡한 형식을 꾸밀때 주로 사용, 유니티에서도 사용.
//            //WriteLine(result);
//            //WriteLine($"{name} {version}");
//            #endregion
//            #region 논리 데이터 형식과 상수 const
//            //bool bin = true;
//            //WriteLine(bin);
//            //bin = !bin;
//            //WriteLine(bin);

//            //int n1 = 20, n2 = 20;
//            //bool isCorrect = n1 == n2;
//            //WriteLine(isCorrect);
//            //int n3 = 20, n4 = 40;
//            //isCorrect = n3 != n4;
//            //WriteLine(isCorrect);

//            //const double PI = 3.141592D;
//            //const string SITE_NAME = "닷넷 코리아";

//            //WriteLine(PI + SITE_NAME);
//            #endregion
//            #region 닷넷 데이터 형식과 래퍼 형식
//            ////시스템 클래스 안에 있는 기능들이다. 원래는 System.Char
//            //Char c = 'A';
//            //String s = "안녕하세요";
//            //Boolean b = false;

//            //WriteLine($"{c}\n{s}\n{b}");

//            //int n1 = 1234;
//            //Int32 n2 = 5678;
//            //string str1 = "안녕";
//            //String str2 = "잘가";

//            //WriteLine($"{n1}\n{n2}\n{str1}\n{str2}");

//            //WriteLine(DateTime.Now);
//            //WriteLine($"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}");
//            //WriteLine($"{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}");
//            #endregion
//        }
//    }
//}
