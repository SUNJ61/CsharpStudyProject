using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace _0620_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("삼각형의 높이를 입력하세요 : "); //삼각형 만들기
            int h = int.Parse(ReadLine());

            for (int i = 1; i < h; i++)
            {
                for (int j = h; i < j; j--) //빈공간 만들기
                {
                    Write(" "); // i가 늘어나면 조건문에 j가 줄어들 범위가 작아짐 -> 횟수 감소.
                } // n번째 줄은 높이 - n 만큼의 빈공간을 필요로함. -> i ~ h 까지의 반복필요.

                for (int k = 0; k < 2 * i; k++) //별과 빈공간 번갈아가면서 출력하기
                {
                    //n번째 줄은 별이 n개 필요하고. 빈 공간이 n개 필요하다.
                    //즉, 조건에 2배의 i가 필요하다. 2i만큼 반복.
                    if (k % 2 == 0) //짝수일 땐 빈공간
                        Write(" ");
                    else //홀수일 땐 *
                        Write("*");
                }
                WriteLine();
            }

            Write("삼각형의 높이를 입력하세요 : "); //역삼각형 만들기
            int h1 = int.Parse(ReadLine());

            for (int i = 1; i < h1; i++)
            {
                for (int j = h1; h1-i < j; j--) //빈공간 만들기
                { //n번째 줄은 h1 - n개의 빈공간이 필요.
                    Write(" ");
                }

                for (int k = 2*h1; k > 2*i ; k--) //별과 빈공간 번갈아가면서 출력하기
                {
                    if (k % 2 == 0)
                        Write(" ");
                    else
                        Write("*");
                }
                WriteLine();
            }
        }
    }
}
