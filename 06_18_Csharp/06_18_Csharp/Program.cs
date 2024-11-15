using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Xml.Schema;

namespace _06_18_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 형변환
            //long L = long.MaxValue;
            //WriteLine(L);
            //long m = long.MinValue;
            //WriteLine(m);
            //int i = (int)L;
            //WriteLine($"{L}의 값을 형변환 : {i}"); //오버플로우 발생. 값이 초과하여 데이터를 잃음.

            //double dn = 33.75678d;
            //int num = (int)dn;
            //WriteLine($"{dn}을 형변환 : {num}"); //오버플로우 발생. 소수 부분의 데이터를 잃어버림.

            //int x = 255; //byt는 0~255까지 표현 가능하기 때문에 255까지는 무사히 형변환 가능.
            //byte y = (byte)x; //0미만이거나 255를 초과하는 순간 오버플로우 발생.
            //WriteLine($"{x}를 형변환 : {y}");

            //byte b = 255;
            //sbyte c = (sbyte)b;
            //WriteLine($"{b}를 형변환 : {c}");

            //int n1 = 1234; //암시적 형변환
            //long n2 = n1; //4바이트인 int형 변수를 8바이트인 long형 변수로 할당, 문제가 생기지 않음.
            //WriteLine(n2); //큰 자료형 변수가 작은 자료형 변수에 할당 되는경우 문제 발생.

            //long n3 = 123456; //명시적 형변환 -> (자료형)변수 형태로 사용할 수 있다.
            //int n4 = (int)n3;
            //WriteLine(n4);

            //double d = 12.34;
            //int i1 = 1234;
            //d = i1;
            //WriteLine("암시적 형식 변환 = " + d);

            //d = 12.34;
            //i1 = (int)d;
            //WriteLine("명시적 형식 변환 = " + i1);

            //string s = "";
            //s = Convert.ToString(d);
            //WriteLine("형식 변환 = " + s);
            #endregion
            #region convert변환 예제
            //Write("정수를 입력하세요 : ");
            //string input = Console.ReadLine();
            //int n = Convert.ToInt32(input);
            //WriteLine($"{n}-{n.GetType()}"); //문자를 넣으면 애러가 난다. parse가 더 간단함.

            //Write("실수를 입력하세요 : ");
            //string input = Console.ReadLine();
            //double PI = Convert.ToDouble(input);
            //WriteLine(PI); //문자 입력시 오류, 해결을 위해 예외 처리를 해야한다.

            //Write("문자를 입력하세요 : ");
            //string input = Console.ReadLine();
            //char c = Convert.ToChar(input);
            //WriteLine(c); //문자열 입력시 오류.
            #endregion
            #region 진수표현
            //byte a = 240; //10진수
            //WriteLine($"a = {a}");
            //byte b = 0b1111_0000; //2진수
            //WriteLine($"b = {b}");
            //byte c = 0XF0; //16진수
            //WriteLine($"c = {c}");
            //uint d = 0x1234_abcd; //16진수
            //WriteLine($"d = {d}");

            //byte x = 10;
            //WriteLine($"십진수 : {x} -> 이진수 {Convert.ToString(x, 2).PadLeft(8, '0')}");
            //WriteLine($"십진수 10을 이진수로 변경 : {Convert.ToString(10,2)}");
            //WriteLine($"이진수 1010을 십진수로 변경 : {Convert.ToInt32("1010",2)}");

            //byte n = byte.Parse(ReadLine());
            //string bin = Convert.ToString(n, 2).PadLeft(8,'0');
            //WriteLine(bin);
            //string hex = Convert.ToString(n, 16);
            //WriteLine(hex);
            //string oct = Convert.ToString(n, 8);
            //WriteLine(oct);
            #endregion
            #region 형식 추론(암시적으로 형식화된 변수 var)
            //var name = "C#";
            //var n1 = 2;
            //var pi = 3.141592;
            //var ch = '나';
            //WriteLine($"[{name}] [{n1}] [{pi}] [{ch}]");

            //var s = ReadLine();
            //var c = Convert.ToChar(Read());
            //WriteLine($"{s} : {s.GetType()}, {c} : {c.GetType()}");

            //WriteLine("아무키나 누르시오.");
            //ConsoleKeyInfo cki = ReadKey(true); //ConsoleKeyInfo 구조체 자료형
            //WriteLine($"{cki.Key}");
            //WriteLine($"{cki.KeyChar}");
            //WriteLine($"{cki.Modifiers}");

            //if(cki.Key == ConsoleKey.Q) //입력을 기다린다는 시점에서 사용하기 까다로울듯
            //{
            //    WriteLine("Q를 입력하셨군요.");
            //}
            //if (cki.Key == ConsoleKey.A)
            //{
            //    WriteLine("A를 입력하셨군요.");
            //}
            #endregion
            #region var와 object 차이점
            //object a = 123;
            //object b = 3.141592345678945678456m;
            //object c = true;
            //object d = "안녕하세요!";

            //WriteLine(a + "\n" + b + "\n" + c + "\n" + d);
            ////var는 값형식으로 받지만 object는 참조 형식으로 받고
            ////기본데이터형 뿐만 아니라 복합 데이터형식으로도 받는다.

            //int a = 123;
            //object b = (object)a; //a에 담긴 데이터를 박싱해서 힙에 저장함.
            //int c = (int)b; //b에 담긴 데이터를 언박싱해서 스택(변수)에 저장함.

            //WriteLine($"{a}\n{b}\n{c}");
            ////object는 박싱 언박싱이 일어나서 var보다 느리다.
            ////이 때문에 대규모 프로젝트에서는 var를 선언하고 var는 클래스 생성자에서 쓸 수 없기 때문에
            //// 매소드 안에 지역변수로 많이 사용한다.
            #endregion
            #region 변수의 기본 default와 튜플 리터럴
            //int i = default;//숫자 데이터의 기본 값은 0 이다.
            //double d = default;
            //char c = default;//문자는 아스키코드 0번(null)이 기본 값이다.
            //string s = default;//문자열은 null을 기본 값으로 가진다.

            //WriteLine($"{i}\n{d}\n{c==Char.MinValue}\n{s==null}");

            //int intd = default(int);
            //WriteLine(intd);

            //bool boold = default(bool);
            //WriteLine(boold);

            //string stringd = default(string);
            //WriteLine(stringd==null);

            //StringBuilder sbd = default(StringBuilder); //using System.Text; 선언 필요.
            //WriteLine(sbd==null);

            //var t = (100, 200); //백터행(배열)처럼 데이터를 여러개 담을 수 있음. = 튜플 리터럴
            //WriteLine(t.Item1);
            //WriteLine(t.Item2);
            //var (x, y) = (300, 400);
            //WriteLine(x+" "+y);
            #endregion
            #region 연산자
            ////단항 연산자에는 양수 음수를 나타내는 +,- 와 형식 변환인 () 연산자와 증감연산자가 있다.
            /////int n1 = 10, n2 = (n1--) + 12;
            //WriteLine(n1);
            //WriteLine(n2)

            ////이항 연산자에는 산술 연산자 +,-,/,*,%가 있다.
            //int a = 5;
            //int b = 3;
            //WriteLine(a+b);
            //WriteLine(a-b);
            //WriteLine(a*b);
            //WriteLine(a/b);
            //WriteLine($"{a} % {b} = {a%b}");

            //int day = 28; // 숫자 + 문자열 보다 문자열 +문자열 출력이 빠르다.
            //WriteLine("2월" + day + "일입니다."); //암시적 변환
            //WriteLine("2월" + day.ToString() + "일입니다."); //명시적 변환
            //WriteLine("2월" + Convert.ToString(day) + "일입니다."); //명시적 변환

            ////삼항 연산자에는 조건 연산자가 있다.
            //bool isCorrect = (1 > 2) ? true : false; // (조건) ? t : f 의 형태로 사용한다.
            //WriteLine(isCorrect);

            ////할당 연산자는 =,+=,-=,*=,/=,%= 가 있다. 이 연산자는 우측에 값을 좌측에 규칙에 맞게 할당한다.

            ////관계형 연산자는 <,>,<=,>=,==,!=가 있고 결과 값은 bool형식으로 나온다.
            ////논리연산자는 $$(and),||(or),!(not)이 있다. 논리연산자는 정수 단위로 연산한다.

            //bool t = true; //and연산자는 둘다 true가 입력되야 결과로 true를 반환한다.
            //bool f = false; //or연산자는 1개라도 true가 입력되면 결과로 true를 반환한다.

            //WriteLine($"true && true -> {t&&t}");
            //WriteLine($"true && flase -> {t&&f}");
            //WriteLine($"flase && true -> {f&&t}");
            //WriteLine($"flase && false -> {f&&f}");

            //int n1 = 10, n2 = 20;
            //WriteLine($"{n1<11 && n2==20}"); //관계연산자 이후 논리 연산자 진행.
            //WriteLine($"{n1>11 && n2==20}");

            //WriteLine($"true || true -> {t || t}");
            //WriteLine($"true || flase -> {t || f}");
            //WriteLine($"flase || true -> {f || t}");
            //WriteLine($"flase || false -> {f || f}");


            #endregion
            #region 소수점 표현
            //double f1 = 23.76123456789d;
            //string result = f1.ToString("0.00"); // 소수점 2째 자리까지 표현
            //WriteLine(f1 + "의 결과 : " + result);

            //decimal dn = 3.14159212345678901234567890123456789m;
            //result = dn.ToString("0.000"); // 소수점 3째 자리까지 표현
            //WriteLine($"{dn}의 결과 : {result}");

            //float pi = 3.1415923456789f;
            //result = pi.ToString("0.000000"); // 소수점 6째 자리까지 표현
            //WriteLine($"{pi}의 결과 : {result}");

            //float f1, f2; // 예제
            //Write("첫번째 실수 입력 : ");
            //f1 = float.Parse(ReadLine());
            //Write("두번째 실수 입력 : ");
            //f2 = float.Parse(ReadLine());
            //WriteLine($"첫번째 입력한 실수 출력 : {f1.ToString("0.0000")}");
            //WriteLine($"두번째 입력한 실수 출력 : {f2.ToString("0.000000")}");

            //double pi = 3.1415921234567890123456789d;// 소수점 표현 다른 방법 1.
            //string result = pi.ToString("n3");
            //WriteLine($"{pi}의 변환 결과 : {result}");

            //result = string.Format("{0:n3}", pi);// 소수점 표현 다른 방법 2.
            //WriteLine($"{pi}의 변환 결과 : {result}");
            #endregion
            #region 조건문
            //float fn1 = 3.151592f;
            //float fn2 = 3.141592f;

            //if (fn1 > fn2)
            //{
            //    WriteLine("fn1이 fn2보다 크다.");
            //}
            //else if (fn1 < fn2)
            //{
            //    WriteLine("fn1이 fn2보다 작다.");
            //}
            //else
            //{
            //    WriteLine("fn1과 fn2가 같다.");
            //}

            //if(fn1 < 3 || fn2 < 3)
            //{
            //    WriteLine("둘중에 하나라도 참이면 실행되는 구문.");
            //}
            #endregion
            
        }
    }
}