using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0723_Csharp
{
    internal class SubMethod
    {
        #region 일반화 프로그래밍
        //public void CopyArray<T>(T[] source, T[] target) //T라는 변수명을 붙여준다. T = template, T는 자료형을 미리 결정하지 않는다.
        //{//T는 컴파일 할 때 입력된 자료형을 그대로 따라간다.
        //    for (int i = 0; i < source.Length; i++)
        //    {
        //        target[i] = source[i]; //배열 복사
        //    }
        //}//자료형당 하나씩 객체생성, 그 뒤에 같은 자료형을 쓰면 생성 했던 객체 재활용.

        //public void CopyArray(double[] source, double[] target) //기존 모든 자료형에 대해 함수를 만들어야 함.
        //{
        //    for (int i = 0; i < source.Length; i++)
        //    {
        //        target[i] = source[i]; //배열 복사
        //    }
        //}
        //public void CopyArray(string[] source, string[] target)
        //{
        //    for (int i = 0; i < source.Length; i++)
        //    {
        //        target[i] = source[i]; //배열 복사
        //    }
        //}
        #endregion
        #region

        #endregion
    }
}
