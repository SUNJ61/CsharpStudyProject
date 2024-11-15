using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Major
{
    public class MathMatic
    {
        #region 멤버 변수, 전역 변수, 동적할당, 함수 오버로딩
        //public int sum = 0; //멤버 변수 (클래스 MathMatic에 속해있음)
        //public float avg = 0f;
        //public static int total = 0; //멤버 변수가 아니다. 미리 할당되어 있으므로 전역변수에 해당됨. 
        //public int SquareFunction(int x) //멤버 함수 : 동적할당을 해야 호출할 수 있는 함수
        //{
        //    int r = x * x;
        //    return r;
        //}

        //public static float SquareFunction(float x, float y) // 함수 오버로드
        //{//함수명은 같지만 함수에 필요로 하는 매개변수의 갯수나 자료형이 다르면 같은 이름을 허용한다. 
        //    float r = x * y;
        //    return r;
        //}

        //public static float SquareFunction(float x) // 동적할당된 함수, 멤버함수가 아님.
        //{
        //    float r = x * x;
        //    return r;
        //}
        #endregion
        #region 동적할당 예제
        ////public int Max(int x, int y)
        ////{
        ////    return (x > y) ? x : y;
        ////}

        ////public int Min(int x, int y)
        ////{
        ////    if(x < y)
        ////        return x;
        ////    else
        ////        return y;
        ////}

        ////아래의 기능은 내가 만든 함수의 설명을 달아주는 기능이다.
        /////<summary>
        /////두수를 더하여 그결과값을 반환시켜주는 함수
        /////</summary>
        /////<param name="a">첫 번째 매개변수</param>
        /////<param name="b">두 번째 매개변수</param>
        /////<returns>a + b 결과</returns>
        //public static int Addnum(int a, int b)
        //{
        //    return a + b;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="num">음수가 인자 값이면</param>
        ///// <returns>절대값 반환 매서드이다.</returns>
        //public static int Abs(int num)
        //{
        //    return (num < 0) ? num * -1 : num;
        //}
        #endregion
        #region 기본 매개변수와 명명 매개변수
        //public static void Log(string message, byte level = 1)//기본매개변수->매개변수에서 미리 값이 초기화된것
        //{
        //    Console.WriteLine($"{message}, {level}");
        //}

        //public static void Sum(int first, int second)
        //{
        //    Console.WriteLine(first+second);
        //}
        #endregion
        #region 다른 매개변수를 가진 함수 오버로드
        //public static void Multi()
        //{
        //    Console.WriteLine("안녕하세요");
        //}
        //public static void Multi(string ms)
        //{
        //    Console.WriteLine(ms);
        //}
        //public static void Multi(string ms, int count)
        //{
        //    for(int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine($"{ms}");
        //    }
        //}
        #endregion
    }
}
