using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunSe_it
{
    internal class Calculator //클래스는 관련된 변수와 함수의 묶음
    {
        public int sum = 0;
        public float avg = 0f;
        public int Add (int x, int y) //public이 있어야만 main에서 접근 가능.
        {
        return x + y;
        }

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public static int Multi(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
