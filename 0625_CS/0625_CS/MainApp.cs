using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Yunse_IT;

namespace _0625_CS
{
    internal class MainApp
    {
        #region 재귀 함수
        //static void Recursive(int n) //함수가 끝나기전 다시 자신을 호출하여 무한 루프가 됨.
        //{ // 탈출조건을 만들어야함.
        //    if (n <= 0)
        //        return;
        //    WriteLine($"재귀함수호출 {n}");
        //    Recursive(n-1);
        //}

        //static int Factorial(int n)
        //{
        //    if (n == 0)
        //        return 1; // 함수는 발동된 순서의 역순으로 끝난다. n = 0 -> 1 -> 2 순으로 함수가 끝남
        //    else
        //        return n * Factorial(n-1); //결국 4를 넣었으면 4 * 3 * 2 * 1 이 출력
        //}
        //static int MyPower(int num, int cnt)
        //{
        //    if(cnt==0)
        //    {
        //        return 1;
        //    }
        //    return num*MyPower(num, --cnt);
        //}
        #endregion

        static int Test(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            else
            {
                return 2 * Test(--a);
            }

        }
        public static void Main(string[] args)
        {
            #region 정적변수와 동적변수의 차이
            //Calculater.avg = 0f; // 정적 변수라서 메모리에 미리 할당되어있음. 한번만 할당가능.

            //Calculater cal = new Calculater(); // 동적할당을 해주었다.
            //cal.Sum = 0; // 멤버 변수 or 동적 변수
            //WriteLine(cal.Add(1,2));

            //Calculater cal2 = new Calculater(); //사용자가 할당 하고 싶은만큼 객체를 할당할 수있다.
            //cal2.Sum = 0;
            //WriteLine(cal2.Add(10, 20));

            //Calculater cal3 = new Calculater(); //사용자가 할당 하고 싶은만큼 객체를 할당할 수있다.
            //cal3.Sum = 0;
            //WriteLine(cal3.Add(100, 200));

            //WriteLine(Calculater.Divide(30,3));
            //WriteLine(Calculater.Divide(300, 3));
            #endregion
            #region 재귀 함수
            //Recursive(3);
            //WriteLine($"1! = {Factorial(1)}");
            //WriteLine($"2! = {Factorial(2)}");
            //WriteLine($"3! = {Factorial(3)}");
            //WriteLine($"4! = {Factorial(4)}");
            //WriteLine(MyPower(2,5));
            #endregion
            WriteLine("2의 몇승을 출력할까요?");
            Write("입력:");
            int a = int.Parse(ReadLine());
            WriteLine($"출력 : {Test(a)}");
        }
    }
}
