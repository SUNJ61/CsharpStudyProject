using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YunSe_it;
using System.ComponentModel;

namespace _0621_Csharp
{
    internal class MainApp4
    {
        public static int Main(string[] args)
        {
            WriteLine("출력?"); // 이외의 숫자를 리턴 받으면 불완전하게 종료됨을 의미함.

            Calculator calculator = new Calculator();
            //calculator클래스를 동적할당해서 해당 클래스의 명령어를 사용할 수 있게 한다.

            WriteLine("Add 함수 호출과 반환 : {0}",calculator.Add(3,4));
            //변수.Add로 호출할 수 있음 즉, 사용자가 지정한 하나의 변수가 됨.
            WriteLine("Multi 함수 호출과 반환 : {0}",Calculator.Multi(3,4));
            //Calculator에서 static을 붙이면 바로 클래스명.매소드로 함수를 호출할 수 있다.
            //즉, static은 동적할당으로 미리 해당 함수를 자동으로 호출한다.
            //static을 사용하지 않으면 위 Add함수와 같이 동적할당의 과정을 거쳐야한다.

            return 0; // 컴파일러가 0을 리턴 받으면 이상없이 실행된걸 의미함.
        }
    }
}
