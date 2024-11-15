using System.Threading.Channels;
using static System.Console;

namespace _0905_CSharp
{
    #region 대리자
    public delegate double DelegateType(double x, double y); //강력한 형식의 대리자.

    public class CarDirver //대리자를 사용해 여러 메소드 다중 호출하기.
    {
        public static void GoF() => WriteLine("직진");
        public static void GoL() => WriteLine("좌회전");
        public static void GoR() => WriteLine("우회전");
    }
    public class Insa
    {
        public void Bye() => WriteLine("잘가");
    }

    public delegate void GoHome(); //위의 메소드 들을 담기위한 대리자 (이와 같은 여러 메소드를 호출라는 대리자는 나중에 이벤트를 담을 때 사용.)

    #endregion
    #region 이벤트
    public class BTN
    {
        public delegate void EventHandler(); //이벤트에 들어올 함수를 대리함. 즉, 대리자와 동일한 조건의 함수만 적용가능 (매개변수가 없고 반환이 없음.)
        public event EventHandler Click; //이벤트를 등록할 변수

        public void OnClick() //사용자가 원하는 조건이 발생했을 경우 호출하여 등록된 이벤트를 발생시킴.
        {
            if (Click != null)
                Click();
        }
    }
    #endregion
    #region 기타 클래스
    // 부분(분할) 클래스 partial 키워드를 사용하여 같은 이름의 클래스를 여러번 선언 가능하다. 즉, 데이터를 나누어 관리 가능.
    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public partial class Person
    {
        public void Print() => WriteLine($"{Name} : {Age}");
    }
    #endregion
    #region 문제
    delegate int MyDelegate(int a, int b); // 람다식을 사용하여 출력

    class Calculator
    {
        //public int Plus(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int Minus(int a, int b)
        //{
        //    return a - b;
        //}

        public int Plus(int a, int b) => a + b;
        public static int Minus(int a, int b) => a - b;
    }

    //delegate int Compare(int a, int b); //Func를 사용하는 함수로 고치기 (2,3번 문제 공용사용)
    #endregion
    internal class Program
    {
        #region 대리자
        public delegate void Say(); //여러 메소드를 호출할 대리자.

        private static void Hello() { Console.WriteLine("Hello"); }
        private static void Hi() { Console.WriteLine("Hi"); }
        #endregion
        #region Action, Func, Predicate 대리자
        static IEnumerable<int> FindNum(Predicate<int> predicate) //predicate 제네릭 대리자를 이용한 값 출력
        {
            for (int i = 1; i <= 100; i++)
            {
                if (predicate(i))
                {
                    yield return i;
                }
            }
        }
        #endregion
        #region Predicate 문제
        static IEnumerable<int> Find(int[] arr,Predicate<int> predicate)
        {
            foreach(int n in arr)
            {
                if(predicate(n))
                {
                    yield return n;
                }
            }
        }
        #endregion
        #region 메소드의 매개변수로 메소드 전달하기
        static int StringLenght(string data) => data.Length;
        static void StringLenghtPrint(Func<string, int> stringLenght, string message)
            => WriteLine($"메세지의 크기는 {stringLenght(message)}입니다."); //Func로 받은 함수에 string값 message을 대입후 int를 반환 받음.
        #endregion
        static void Main(string[] args)
        {
            #region 대리자
            ////강력한 형식의 대리자.
            //DelegateType pow = Math.Pow; 
            //double actual = pow(2, 10); //Pow함수를 대신하였다.
            //Console.WriteLine(actual);

            ////대리자를 사용해 여러 메소드 다중 호출하기.
            //CarDirver.GoL(); //따로 출력
            //CarDirver.GoF();
            //CarDirver.GoR();

            //GoHome go = new GoHome(CarDirver.GoL); //하나의 대리자 선언 (대리자에 메소드 1개를 넣었다.)
            //go += new GoHome(CarDirver.GoF); //같은 대리자에 메소드 추가
            //go += new GoHome(CarDirver.GoR); //같은 대리자에 메소드 추가
            //go += new GoHome(CarDirver.GoL); //같은 대리자에 메소드 추가
            //go += new GoHome(CarDirver.GoL); //같은 대리자에 해당 메소드 삭제
            //go(); //대리자 출력 (저장된 메소드 순서대로 전부 출력)

            //Say say;
            //say = new Say(Hi);
            //say += new Say(Hello);
            //say();

            //Insa insa = new Insa();
            //Say say2 = new Say(insa.Bye);
            //say2 += new Say(insa.Bye);
            //say2();
            #endregion
            #region Action, Func, Predicate 대리자
            //// Action은 반환 값이 없는 메소드를 대신 호출
            //Action<string> printf = WriteLine; 
            //printf("매서드 대신 호출");

            //// Func는 반환 값이 있는 메소드를 대신 호출 (Func<매가변수 형식 , 반환값 형식>)
            //Func<int, int> abs = Math.Abs; 
            //Console.WriteLine(abs(-10));

            //Func<double, double, double> pow = Math.Pow;
            //Console.WriteLine(pow(2, 20)); //2의 20승 출력

            //Func<string, string> toLower = str => str.ToLower();
            //Console.WriteLine(toLower("ABCDEFGHIJKLNMOPQRSTUVWXYZ")); //소문자로 변경

            //Func<int, int> unknown = delegate(int x) { return x * x; }; //익명의 메소드(무명 메소드) 담기.
            //Console.WriteLine(unknown(2));

            //Func<int, double> lam = x => x / (double)2; //람다식 담기.
            //Console.WriteLine(lam(3));

            //Func<int> getNum1 = delegate () { return 1234; }; //무명
            //Func<int> getNum2 = () => 1234; //람다

            //Func<int, int> add1 = delegate (int x) { return x+1; }; //무명
            //Func<int, int> add2 = x => x + 1; //람다

            //Func<string, string, string> plus1 = delegate (string a, string b) { return a + b; }; //무명
            //Func<string, string, string> plus2 = (a, b) => $"{a} {b}"; //람다

            //Console.WriteLine(getNum1()); //람다가 편하므로 람다를 사용하기.
            //Console.WriteLine(getNum2());

            //Console.WriteLine(add1(10));
            //Console.WriteLine(add2(10));

            //Console.WriteLine(plus1("ABC", "DEF"));
            //Console.WriteLine(plus2("DEF", "ABC"));


            ////Predicate는 로직을 수행하고 결과가 true인지 false인지 반환하는 대리자. 
            //Predicate<string> isNullorEmpty = string.IsNullOrEmpty; //입력된 string 값이 null인지 아닌지 판단하는 함수
            //Console.WriteLine(isNullorEmpty("Not Null"));

            //Predicate<Type> isPrimitive = t => t.IsPrimitive;
            //Console.WriteLine(isPrimitive(typeof(int)));

            ////제네릭 대리자를 이용한 값 출력
            //var num = FindNum(f => f % 33 == 0); //FindNum 함수에 f => f % 33 == 0 의 로직을 넣어 참인 것만 num에 저장 (f에는 i가 대입)
            //foreach (int i in num)
            //    Console.WriteLine(i);
            #endregion
            #region Predicate 문제
            //int[] arr = new int[10];

            //Console.WriteLine("총 10개의 숫자 입력");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("입력: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("홀수\n");
            //var num1 = Find(arr, (f =>  f % 2 == 0));
            //foreach(int n in num1)
            //    Console.WriteLine(n);

            //Console.Write("짝수\n");
            //var num2 = Find(arr, (f => f % 2 == 1));
            //foreach(int n in num2)
            //    Console.WriteLine(n);
            #endregion
            #region 메소드의 매개변수로 메소드 전달하기
            //StringLenghtPrint(StringLenght, "안녕하실랑가"); //StringLenghtPrint의 첫번째 매개변수는 Func이다. Func는 매개변수가 string이고 반환이 int인 모든 함수, 람다식을 받을 수 있어 StringLenght를 적용하였다.
            #endregion
            #region 이벤트
            //BTN btn = new BTN();

            //btn.Click += Hi1; //해당 클래스에 이벤트가 발생하면 실행할 메소드 등록
            //btn.Click += Hi2; //해당 클래스에 이벤트가 발생하면 실행할 메소드 등록

            //btn.OnClick(); //이벤트 발생
            #endregion
            #region 기타 클래스
            //Person person = new Person();

            //person.Name = "Lee";
            //person.Age = 26;

            //person.Print();
            #endregion
            #region 문제
            // 1번 람다식을 사용하는 문제로 바꾸기
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(7, 5));



            //2번 Func를 사용하여 바꾸기
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, AscendCompare);

            for (int i = 0; i<array.Length; i++)
                Console.Write($"{array[i]} ");

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending...");
            BubbleSort(array2, DescendCompare);            

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");

            Console.WriteLine();


            //3번 Func를 사용하여 바꾸기
            int[] array3 = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(array3, delegate (int a, int b)
            {
                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            for (int i = 0; i < array3.Length; i++)
                Console.Write($"{array3[i]} ");

            int[] array4 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending...");
            BubbleSort(array4, delegate (int a, int b)
            {
                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            for (int i = 0; i < array4.Length; i++)
                Console.Write($"{array4[i]} ");

            Console.WriteLine();

            #endregion
        }
        #region 이벤트
        static void Hi1() => WriteLine("안녕1");
        static void Hi2() => WriteLine("안녕2");
        #endregion
        #region 문제
        //2번,3번 문제 함수
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static void BubbleSort(int[] DataSet, Func<int,int,int> Comparer) //2,3번 공통 사용
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        #endregion
    }
}
