using Major;
using static System.Console;

namespace _0624_NETcore
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 멤버 변수, 전역 변수, 동적할당, 함수 오버로드
            //MathMatic.total = 0; // 클래스명.변수명으로 사용가능하다. (Major에서 미리 할당됬기 때문이다.)
            //MathMatic math = new MathMatic(); //math라는 변수를 할당했다.
            //math.sum = 1+10; //Major에서 동적할당 x, 멤버 변수이기때문에 위에 할당하는 작업이 필요하다.
            //math.avg = 0f; //Major에서 동적할당 x, 멤버 변수이기때문에 위에 할당하는 작업이 필요하다.

            //WriteLine(MathMatic.SquareFunction(20.0f)); //전역함수, 클래스명.함수명으로 사용가능하다.
            //WriteLine(math.SquareFunction(10)); //멤버함수, 위에 math변수로 할당하는 작업 필요하다.
            #endregion
            #region 함수 예제
            //WriteLine(math.Max(3, 5));
            //WriteLine(math.Min(-3, -5));

            //int a = 3;
            //int b = 5;
            //int c = MathMatic.Addnum(3, 5);
            //WriteLine($"{a}+{b}={c}");
            #endregion
            #region 기본 매개변수와 명명된 매개변수
            //MathMatic.Log("디버그"); // 기본매개변수에 해당된 곳에 아무것도 넣지 않을 경우 설정한 값 출력
            //MathMatic.Log("에러",4);

            //MathMatic.Sum(10, 20); //함수에 선언된 매개변수의 이름을 값에 선언하여 입력할 경우
            //MathMatic.Sum(first: 10, second: 20); //순서를 바꿔 입력해도 올바른 값이 출력된다.
            //MathMatic.Sum(second: 20, first: 10);
            #endregion
            #region 다른 매개변수를 가진 함수 오버로드
            //MathMatic.Multi();
            //MathMatic.Multi("반갑습니다.");
            //MathMatic.Multi("또 만나요",3);
            #endregion

        }
    }

    class Testcode
    {
        public static void test()
        {

        }
    }
}