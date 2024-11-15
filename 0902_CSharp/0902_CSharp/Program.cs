using static System.Console;
using System.Collections;
using System.Diagnostics.SymbolStore;
using System.Xml;

namespace _0902_CSharp
{
    internal class Program
    {
        #region 반복기와 yield키워드
        //public class Lan //배열 값을 foreach문으로 출력하기.
        //{
        //    private string[] Lans;

        //    public Lan(int length)
        //    {
        //        Lans = new string [length];
        //    }

        //    public string this[int index]
        //    {
        //        get { return Lans[index]; }
        //        set { Lans[index] = value; }
        //    }

        //    public IEnumerator GetEnumerator()
        //    {
        //        for(int i = 0; i < Lans.Length; i++)
        //            yield return Lans[i];
        //    }
        //}
        #endregion
        #region 대리자(delegate)
        static void Hi() => Console.WriteLine("안녕하세요");
        delegate void SayDelegate();
        #endregion
        static void Main(string[] args)
        {
            #region 반복기와 yield키워드
            //foreach (var item in MultiData()) //반환형이 IEnumerable이여서 반복문에서 반복이 가능, yield return의 개수 만큼 반복
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //foreach (int num in GetNumbers())
            //{
            //    Console.Write($"{num}\t");
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //var lan = new Lan(2);
            //lan[0] = "C";
            //lan[1] = "D";
            //foreach (var lang in lan)
            //{
            //    Console.WriteLine(lang);
            //}

            //Console.WriteLine();

            //int[] num1 = { 1, 2, 3, 4, 5 };

            //foreach(var n in G1(num1, 3))
            //    Console.WriteLine(n);

            //Console.WriteLine();

            //foreach(var n in G2(num1, 3))
            //    Console.WriteLine(n);

            //Console.WriteLine();

            //int count = 7;
            //int i = 0;
            //foreach(var f in GetFibon())
            //{
            //    Console.WriteLine(f);
            //    if(++i > count)
            //    {
            //        break;
            //    }
            //}
            #endregion
            #region 대리자(delegate)
            SayDelegate say = Hi;
            say();

            var hi = new SayDelegate(Hi);
            hi();
            #endregion
        }
        #region 반복기와 yield키워드
        //static IEnumerable MultiData() //반복기를 사용해 문자 출력
        //{
        //    yield return "Hello";
        //    yield return "Hi";
        //    yield return "Bye";
        //}

        //static IEnumerable GetNumbers() //반복기 내부에 for문 사용하기
        //{
        //    yield return 1;
        //    yield return 2;
        //    for(int i = 3; i <= 5; i++)
        //    {
        //        yield return i;
        //    }
        //}

        //static IEnumerable<int> G1(int[] number, int g) //컬렉션<T> 형태로 데이터 반환 -> yield return 사용 x, 리스트 사용 o
        //{ //계속 데이터가 늘어나면 List
        //    List<int> temp = new List<int>();
        //    foreach(var n in number)
        //    {
        //        if(n > g)
        //            temp.Add(n);
        //    }
        //    return temp;
        //}
        //static IEnumerable<int> G2(int[] numbers, int g2) //컬렉션<T> 형태로 데이터 반환 -> yield return사용,  리스트 사용 x
        //{ //데이터가 일회성으로 사용되면 yield return
        //    foreach(var n in numbers)
        //    {
        //        if(n > g2)
        //            yield return n;
        //    }
        //}

        //static IEnumerable<int> GetFibon() //반복기로 피보나치 수열 출력하기.
        //{
        //    int cur = 1;
        //    int next = 1;
        //    yield return cur;
        //    while(true)
        //    {
        //        int temp = cur + next;
        //        cur = next;
        //        next = temp;
        //        yield return cur;
        //    }
        //}
        #endregion
    }
}
