using System;
using static System.Console;

namespace _0701_Csharp_info
{
    internal class Product
    {
        private int Price = 100;
        public ref int GetPrice()
        {
            return ref Price; // 주소에만 접근 가능하고 선언된 자료형에 접근이 되지 않아 외부에서 가격 수정이 불가능하다.
        }
        public void Print()
        {
            WriteLine($"Price : {Price}");
        }
    }
}
