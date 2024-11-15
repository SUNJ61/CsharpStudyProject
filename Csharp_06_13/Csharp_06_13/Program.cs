using System;
// System이라는 namespace 기능을 선언, 다음부터 System 선언 생략가능.
using static System.Console;
//정적할당(static) : 메모리가 미리 할당되어 다음 기능을 계속 사용할 수 있음.
/*
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

namespace Csharp_06_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hellow World!");
            //WriteLine -> 콘솔창에 글자나 숫자를 띄워주는 기능을 가진 함수(메소드), 줄바꿈 기능 포함.
            // *;(세미클론) -> 명령이 끝났다는 것을 컴파일러에게 알려주는것
            Console.Write("Hi~~~! ");
            //Write -> 콘솔창에 글자나 숫자를 띄워주는 기능을 가진 함수(메소드), 줄바꿈 기능 없음.
            Console.WriteLine("Every one!");
            */

            Write("Hi~~~! ");
            WriteLine("Every one!");
            WriteLine("연세it 게임 프로그래밍반!");

            WriteLine("c+w+tap으로 WriteLine 불러오기 가능.");
            WriteLine("유니티 게임엔진!");
        }
    }
}
