using System.ComponentModel;
using static System.Console;

namespace _0829_Csharp
{
    #region 생성자와 속성(프로퍼티)
    //class Car
    //{
    //    public string Name { get; private set; }
    //    public Car(string name) //생성자로 속성에 대한 유효성 검사
    //    {
    //        if(string.IsNullOrEmpty(name))
    //        {
    //            throw new ArgumentNullException();
    //        }
    //        this.Name = name;
    //    }
    //}

    //class Pet
    //{
    //    /// <summary>
    //    /// 몸무게
    //    /// </summary>
    //    public int Weight { get; set; } //메서드로 속성값 초기화 하기.

    //    /// <summary>
    //    /// 먹이를 주면 몸무게 증가
    //    /// </summary>
    //    /// <param name="weight"></param>
    //    public void Feed(int weight)
    //    {
    //        Weight += weight;
    //    }
    //}

    //class Fish
    //{
    //    public int Weight { get; set; } = 50; //속성(프로퍼티) 선언과 동시에 초기화 하기
    //    public void Feed(int weight) => Weight += weight;
    //}

    //class Person //속성에서 ?.와 ??연산자를 함께 사용
    //{
    //    public string Name { get; set; }
    //    public Address Address { get; set; }
    //}
    //class Address
    //{
    //    public string Street { get; set; } = "알 수 없음";
    //}
    #endregion
    #region 인덱서
    //class Catalog //정수형 인덱서 만들기.
    //{
    //    public string this[int index] //인덱서는 이름을 저장하지 않고 this를 사용한다.
    //    {
    //        get
    //        {
    //            return (index % 2 == 0) ? $"{index} : 짝수 반환" : $"{index} : 홀수 반환";
    //        }
    //    }
    //}

    //class Developer //인덱서로 여러 값 주고 받기
    //{
    //    private string name;
    //    public string this[int index] //인덱서 (각 인덱스마다 입력된 string 값을 저장하는 역할)
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //}
    #endregion
    #region 문제
    delegate int MyDelegate(int a, int b); //1번 문제

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    delegate int Compare(int a, int b); //2번 문제

    delegate int Compare<T>(T a, T b); //3번 문제
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 생성자와 속성(프로퍼티)
            //Car car = new Car("자동차");
            //Console.WriteLine(car.Name);
            //Console.WriteLine(new Car("").Name); //예외 처리 발생

            //Pet pet = new Pet();
            //pet.Weight = 50;
            //pet.Feed(10);
            //Console.WriteLine(pet.Weight);

            //var fish =new Fish();
            //fish.Weight = 10;
            //fish.Feed(15);
            //Console.WriteLine(fish.Weight);

            //var people = new Person[] { new Person { Name = "RedPlus"}, null }; //people에 이름만 저장한 객체와 아무것도 저장하지않은 null객체 생성 (총 2개)

            //ProcessPeople(people);

            //void ProcessPeople(IEnumerable<Person> peopleArray) //배열에 담긴 모든 데이터를 출력하는 함수
            //{
            //    foreach(var person in peopleArray)
            //    {
            //        Console.WriteLine($"{person?.Name ?? "아무개"}은(는)" + $"{person?.Address?.Street ?? "아무곳"}에 삽니다."); //이름 데이터가 없으면 아무개가 나오고 주소데이터가 없으면 아무곳이 출력.
            //    }
            //}

            //var otherPeople = null as Person[]; //null을 넣은 otherPeople데이터 생성

            //Console.WriteLine($"첫번째 사람 : {otherPeople?[0]?.Name ?? "없음"}"); //데이터가 없으면 = null이면 "없음"을 출력
            #endregion
            #region 인덱서
            //Catalog catalog = new Catalog();
            //Console.WriteLine(catalog[0]);
            //Console.WriteLine(catalog[1]);
            //Console.WriteLine(catalog[2]);

            //var developers = new Developer();
            //developers[0] = "백승수";
            //Console.WriteLine(developers[0]);
            //developers[1] = "이세영";
            //Console.WriteLine(developers[1]);
            #endregion
            #region 문제
            Calculator cal = new Calculator();
            MyDelegate plus = cal.Plus;
            Console.WriteLine(plus(1, 2));
            MyDelegate minus = Calculator.Minus;
            Console.WriteLine(minus(10, 5));

            int[] array = { 3, 7, 4, 2, 10, 1, 5, 15, 8 };

            Console.WriteLine("오름차순");
            BubbleSort(array, new Compare(AscendCompare));
            foreach (int a in array)
                Write($"{a} ");

            Console.WriteLine();

            Console.WriteLine("내림차순");
            BubbleSort(array, new Compare(DescendCompare));
            foreach (int a in array)
                Write($"{a} ");

            Console.WriteLine();

            int[] array1 = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort<int>(array1, new Compare<int>(AscendCompare));

            for (int i = 0; i < array1.Length; i++)
                Console.Write($"{array1[i]} ");

            string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };

            Console.WriteLine("\nSorting descending...");
            BubbleSort<string>(array2, new Compare<string>(DescendCompare));


            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");

            Console.WriteLine();
            #endregion
        }
        #region 문제
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

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int temp;

            for (int i = 0; i < DataSet.Length; i++)
            {
                for (int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) == 1)
                    {
                        temp = DataSet[j];
                        DataSet[j] = DataSet[j + 1];
                        DataSet[j + 1] = temp;
                    }
                }
            }
        }

        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);   
        }

        static int DescendCompare<T>(T a, T b) where T :IComparable<T>
        {
            return b.CompareTo(a);
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            T temp;

            for (int i = 0; i < DataSet.Length; i++)
            {
                for (int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) == 1)
                    {
                        temp = DataSet[j];
                        DataSet[j] = DataSet[j + 1];
                        DataSet[j + 1] = temp;
                    }
                }
            }
        }
        #endregion
    }
}
