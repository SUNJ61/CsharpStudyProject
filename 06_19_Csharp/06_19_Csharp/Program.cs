using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_19_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 세가지 논리 연산자
            //var i = 3;
            //var j = 5;
            //var r = false;

            //r = (i == 3) && (j != 3);
            //WriteLine(r);
            //r = (i != 3) || (j == 3);
            //WriteLine(r);
            //r = (i >= 5);
            //WriteLine($"{!r}");

            //WriteLine(true && false);
            //WriteLine(1 == 1 || 1 != 1);
            //WriteLine(!(1 == 1));
            #endregion
            #region 오버플로우와 이진수에서 양수 음수
            //byte a = 255; //byte의 최대값
            //sbyte b = 127; //sbyte의 최대값
            //a++; //a에 1을 더하여 오버플로우 발생, 1만큼 초과하여 최소값의 첫번째 값이 출력. -> 0
            //b++;//b에 1을 더하여 오버플로우 발생, 1만큼 초과하여 최소값의 첫번째 값이 출력. -> -128
            //WriteLine($"byte 오버플로우 : {a}, sbyte 오버플로우 : {b}");
            ////이진 표현에서 가장 앞 비트는 양수, 음수를 나타냄.
            ////양수는 1, 음수는 0이다. (양수, 음수표현 자리수를 초과하는 값은 버린다. -> 10 이면 0이됨.)
            ////이진 표현에서 양수 <-> 음수 변경은 (보수 +1)의 값을 가진다. (더하면 0이되어야 하기 때문.)
            #endregion
            #region 비트 연산자
            //byte x = 0b1010;
            //byte y = 0b1100;
            //WriteLine($"{Convert.ToString(x,2)} -> {x}");
            //WriteLine($"{Convert.ToString(y,2)} -> {y}");
            //WriteLine($"논리곱 : {Convert.ToString(x&y,2)} -> {x&y}");
            //WriteLine($"논리합 : {Convert.ToString(x|y,2)} -> {x|y}");
            //WriteLine($"베타적 논리합 : {Convert.ToString(x^y,2).PadLeft(4,'0')} -> {x^y}");

            //byte x1 = 0b_0000_1010; //양수 음수 반전 ~
            //WriteLine($"{Convert.ToString(x1,2).PadLeft(8,'0')} -> {x1,3}");
            //WriteLine($"~로 음수로 반전 한 값 : " +
            //    $"{Convert.ToString((byte)~x1,2).PadLeft(8,'0')} -> {~x1,3}");

            //var xx = Convert.ToInt32("1010", 2);
            //var yy = Convert.ToInt32("0101", 2);

            //var and = xx & yy; //논리곱
            //var or = xx | yy; //논리합
            //var xor = xx ^ yy; //베타적 논리합
            //var not = ~xx; // 역(not)

            //WriteLine($"{and} : {Convert.ToString(and,2)}");
            //WriteLine($"{or} : {Convert.ToString(or,2)}");
            //WriteLine($"{xor} : {Convert.ToString(xor,2)}");
            //WriteLine($"{not} : {Convert.ToString(not,2)}");
            #endregion
            #region 시프트 연산자
            //int n = 2;
            //WriteLine(n<<1); //왼쪽으로 초과된 쉬프트도 사라진다.
            //WriteLine(n>>1); 

            //int n1 = 32;
            //WriteLine($"{n1 >> 1}"); //오른쪽 쉬프트는 음수를 다루지 않는다.
            //WriteLine($"{n1 >> 2 }"); //즉 오른쪽으로 초과된 비트는 사라진다.

            //byte n2 = 4;
            //byte n3 = 4;
            //byte n4 = 4;
            //byte n5 = 4;
            //byte n6 = 4;
            //n2 &= 5; // 0100 & 0101
            //n3 |= 1; // 0100 | 0001
            //n4 ^= 2; // 0100 ^ 0010
            //n5 <<= 1; // n5 * (2^1)
            //n6 >>= 1; // n6 / (2^1)
            //WriteLine(n2); //and
            //WriteLine(n3); //or
            //WriteLine(n4); //xor
            //WriteLine(n5); //left shift
            //WriteLine(n6); //right shift
            #endregion
            #region 기타 연산자
            //int n = int.Parse(ReadLine()); //조건 연산자, 형태는 -> 조건 ? 옳은 결과 : 거짓 결과 이다.
            //string result = (n % 2 == 0) ? "짝수" : "홀수";
            //WriteLine($"{n}은(는) {result}입니다.");

            //const int MAX_SIZE = 20;
            //int page = 0;
            //page = 10;
            //page = (page > MAX_SIZE) ? MAX_SIZE : page;
            //WriteLine(page);
            //page = 50;
            //page = (page > MAX_SIZE) ? MAX_SIZE : page;
            //WriteLine(page);

            //var num = -21;
            //var abs = (num<0)? -num : num;
            //WriteLine($"{num}의 절대값 : {abs}");

            //WriteLine("Sizeof(데이터 형식)"); //size of 연산자는 메모리의 크기를 알려준다.
            //WriteLine($"char 형식 : {sizeof(char)}byte");
            //WriteLine($"int 형식 : {sizeof(int)}byte");
            //WriteLine($"long 형식 : {sizeof(long)}byte");
            //WriteLine($"float 형식 : {sizeof(float)}byte");
            //WriteLine($"double 형식 : {sizeof(double)}byte");
            #endregion
            #region 제어문
            //순차문 -> 위에서부터 아래로 차례로 실행하는 구문.
            //조건문 -> 조건에 맞는 구문만 실행하게 한다.
            //int k = 90;
            //int e = 75;
            //int m = 80;
            //int tot = k + e + m;
            //double avg = tot / 3.0;
            //if (avg >= 90)
            //    WriteLine("수");
            //else if (avg >= 80) //else if면 참이 되면 아래의 조건문들에서 빠져나온다. 
            //    WriteLine("우"); 
            //else if (avg >= 70) //if를 사용했다면 모든 조건문들을 검사하고 결과를 출력한다.
            //    WriteLine("미");
            //else if (avg >= 60)
            //    WriteLine("양");
            //else // 60점 미만
            //    WriteLine("가");

            //Write("국어 점수 입력 : ");
            //int kor = int.Parse(ReadLine());
            //Write("영어 점수 입력 : ");
            //int eng = int.Parse(ReadLine());
            //Write("수학 점수 입력 : ");
            //int math = int.Parse(ReadLine());

            //int total = kor + eng + math;
            //double aver = total / 3.0;

            //WriteLine($"총점 : {total}  평균 : {aver.ToString("0.00")}");

            //if(aver >= 90)
            //    WriteLine("A학점");
            //else if (aver >= 80)
            //    WriteLine("B학점");
            //else if (aver >= 70)
            //    WriteLine("C학점");
            //else if (aver >= 60)
            //    WriteLine("D학점");
            //else
            //    WriteLine("F학점(재수강)");

            //bool bin = false;
            //if (!bin) //if조건문안에는 true값만 들어가야한다.
            //{
            //    WriteLine($"bin : false -> ! -> true");
            //}

            //Write("정수를 입력 : "); //삼항 연산자을 이용하여 설계
            //int nn = int.Parse(ReadLine());
            //if ((nn>=0) ? true : false)
            //{
            //    WriteLine($"양수 : {nn}");
            //}
            //else
            //{
            //    WriteLine($"음수 : {nn}");
            //}//if문과 삼항연산자를 같이쓰면 획기적으로 코드를 줄일수있다.

            //Write("정수 입력 : ");
            //int n1 = int.Parse(ReadLine());
            //WriteLine((n1%2 == 0) ? $"짝수 출력 : {n1}" : $"홀수 출력 : {n1}");
            //Write("정수 입력 : ");
            //int n3 = int.Parse(ReadLine());
            //WriteLine((n3 % 2 == 0) ? $"짝수 출력 : {n3}" : $"홀수 출력 : {n3}");

            //Write("정수 입력 : ");
            //int n2 = int.Parse(ReadLine());
            //WriteLine((n2 >= 0) ? $"정수 출력 : {n2}" : $"홀수 출력 : {-n2}");
            #endregion
        }
    }
}
