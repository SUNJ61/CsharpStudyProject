using System;
using static System.Console;

namespace _0701_Csharp_jumbo
{
    public class SomeClass
    {
        int SomeValue = 10;
        public ref int SomeMethod()
        {
            return ref SomeValue; //참조형 데이터로 반환
        }
    }
}
