using System;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using static System.Console;

namespace _0729_Csharp
{
    #region 람다식
    //delegate int Calculator(int a, int b);
    //delegate void DoSomething();
    //delegate string Concat(string[] str);
    #endregion
    #region 람다식을 이용한 클래스
    //class FriendList
    //{
    //    private List<string> list = new List<string>();
    //    public void Add(string name) => list.Add(name);
    //    public void Remove(string name) => list.Remove(name);
    //    public void PrintAll()
    //    {
    //        foreach(var s in list)
    //            WriteLine(s);
    //    }
    //    public FriendList() => WriteLine("FriendList()"); // void 생성자.
    //    ~FriendList() => WriteLine("~FriendList()");
    //    public int Capacity //속성 프로퍼티
    //    {
    //        get => list.Capacity;
    //        set => list.Capacity = value;
    //    }
    //    public string this[int index] //인덱서 프로퍼티
    //    {
    //        get => list[index];
    //        set => list[index] = value;
    //    }
    //}
    #endregion
    #region 문제
    //delegate void Lambda(int a);
    //public delegate float CtDelegate(int a, int b);
    //public class Myclass
    //{
    //    public static float Divide(int a, int b) //일회용으로 바꾸기
    //    {
    //        return (float)(a / b);
    //    }
    //}
    #endregion
    #region 버블정렬 일반화
    delegate int Compare<T>(T a, T b) where T : IComparable<T>;
    #endregion
        public class Mainapp
    {
        public static void Main(string[] args)
        {
            #region 람다식
            //Calculator calc = delegate (int a, int b) //익명의 메소드
            //{
            //    return a + b;
            //};
            //WriteLine($"3 + 4 = {calc(3,4)}");

            //Calculator calc2 = (int a, int b) => a - b; //익명의 메소드 (람다식 표현 (매개변수 목록) => return할 식) 
            //WriteLine($"10 - 4 = {calc2(10, 4)}");

            //DoSomething DoIt = () => //익명의 메소드(람다식을 사용하여 매개변수가 없는 void반환형 만들기.)
            //{
            //    WriteLine("뭔가를 ");
            //    WriteLine("출력 해보자!");
            //};
            //DoIt(); //호출시 선언한 함수, 두개의 문장이 출력된다.

            //Concat concat = (arr) =>
            //{
            //    string result = "";
            //    foreach (string str in arr)
            //    {
            //        result += str;
            //    }
            //    return result;
            //};

            //WriteLine(concat(args)); //ㄹㅈㄷ 이거 안해주는거 봐ㅋㅋ
            #endregion
            #region Func와 Action
            //Func<int> func1 = () => 10; // 매개변수가 없는 int형 반환, Func는 결과를 반환 받는다.
            //WriteLine($"func1 = {func1()}");

            //Func<int, int> func2 = (x) => x * 2; //매개변수가 int 1개고 반환형이 int. Func<매개변수형, 반환형>
            //WriteLine($"func2 : {func2(4)}");

            //Func<double, double, double> func3 = (x, y) => x / y; //매개변수가 double 2개고 반환형이 double.
            //WriteLine($"func3 : {func3(22.0, 7.0)}"); //Func<매개변수형 1, 매개변수형 2, 반환형>

            //Action act1 = () => WriteLine("Action()"); //매개 변수가 없고, 반환형이 없다.
            //act1(); //바로 설정한 메소드가 출력됨.

            //int result = 0;
            //Action<int> act2 = (x) => result = x * x; //매개변수가 int 1개, 반환형이 없다.
            //act2(3); //매개변수 3 대입.
            //WriteLine($"result = {result}"); //익명의 메소드가 일어나, result에 9가 대입됨.

            //Action<double, double> act3 = (x, y) =>
            //{
            //    double pi = x / y;
            //    WriteLine($"Action<T1,T2>({x},{y}) = {pi}");
            //};
            //act3(22.0, 7.0);
            #endregion
            #region 람다식을 이용한 클래스
            //FriendList friendList = new FriendList(); //void 생성, void 생성자 출력
            //friendList.Add("Eney"); //friendList에 이름 추가
            //friendList.Add("Meeny");
            //friendList.Add("Miny");
            //friendList.Remove("Eney");//friendList에 추가된 이름 삭제.
            //friendList.PrintAll(); // 클래스 안에 메소드 호출. friendList 전부 출력
            //WriteLine($"{friendList.Capacity}");// 현재 클래스안 리스트 크기 출력
            ////list의 크기는 초기에 4로 설정, 점점 크기가 커질 수록 2배수 만큼 커진다 (4, 8, 16 ....)
            ////즉, 지금은 list의 크기가 4보다 커지지 않았으므로 4가 출력되고, 그 이상의 갯수가 리스트에 추가되면
            ////리스트는 4에서 8로 증가하여 8을 출력할 것이다.
            //friendList.Capacity = 10;
            ////리스트 크기 10으로 재설정. 코드 상으로 변화 시켰기 때문에 10으로 강제 할당 가능.
            ////이후 배열내부의 속성의 갯수가 10개가 초과하게 되면 2배로 늘어나 크기는 20으로 늘어난다.
            //WriteLine($"{friendList.Capacity}"); //리스트 크기 재설정후 리스트 크기 출력
            //WriteLine($"{friendList[0]}"); //현재 0번째 인덱스의 이름 출력 (인덱서 프로퍼티로 출력함)
            //friendList[0] = "Moe"; //현재 0번째 인덱스의 이름을 Moe로 설정함 (인덱서 프로퍼티로 set함)
            //friendList.PrintAll(); //리스트에 있는 모든 이름 출력.
            #endregion
            #region 문제
            //int[] intValues = { 1, 2, 3 };
            //double[] doubleValues = { 1.1, 2.2, 3.3 };

            //PrintValue(intValues);
            //PrintValue(doubleValues);

            //int[] array = { 11, 22, 33, 44, 55 }; //이렇게 하면안됨 ㅋㅋ
            //foreach(int a in array)
            //{
            //    Lambda lambda = (int a) =>
            //    {
            //        WriteLine(a * a);
            //    };

            //    lambda(a);
            //}

            //foreach (int a in array) //람다식으로 고치기 이전 코드
            //{
            //    Action action = () => WriteLine(a * a);
            //    action.Invoke(); // Invoke() Action안에 정의되어있는 함수.
            //}


            //foreach (int a in array) //람다식으로 고치기 이전 코드
            //{
            //    Action action = new Action
            //    (
            //        delegate() // 이것 또한 Action에서만 가능한 선언 형식.
            //        {
            //            Console.WriteLine(a*a);
            //        }
            //    );
            //    action.Invoke(); // Invoke() Action안에 정의되어있는 함수.
            //}

            //CtDelegate del = (int a, int b) => { return (float)a / b; };
            //float result = del(10, 4);
            //WriteLine("Result: " + result);

            //Func<int, int, float> Divide = (int a, int b) =>
            //{
            //    return (float)a / b;
            //};
            //float res = Divide(10, 4);
            //WriteLine("Result: " + res);
            #endregion
            #region dynamic, default로 계산 일반화 프로그래밍
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //double[] arr2 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            //float[] arr3 = { 2.1f, 3.2f, 4.3f, 5.4f, 6.5f };

            //SumProgram<int>(arr1, arr1.Length);
            //SumProgram<double>(arr2, arr2.Length);
            //SumProgram<float>(arr3, arr3.Length);
            #endregion
            #region 버블정렬 일반화
            int[] array1 = { 3, 7, 4, 2, 10 };
            string[] array2 = { "mno", "abc", "ghi" ,"def","jkl"};
            
            BubbleSort<int>(array1, (x,y) => x.CompareTo(y));
            BubbleSort<string>(array2, (x, y) => x.CompareTo(y));

            foreach(int i in array1)
            {
                WriteLine(i);
            }
            WriteLine("==========================================");
            foreach (string s in array2)
            {
                WriteLine(s);
            }

            BubbleSort<int>(array1, (x, y) => -x.CompareTo(y));
            BubbleSort<string>(array2, (x, y) => -x.CompareTo(y));

            WriteLine("==========================================");
            foreach (int i in array1)
            {
                WriteLine(i);
            }
            WriteLine("==========================================");
            foreach (string s in array2)
            {
                WriteLine(s);
            }
            #endregion
        }
        #region 문제
        //static void PrintValue<T>(T[] values)
        //{
        //    foreach (T i in values)
        //    {
        //        WriteLine(i);
        //    }
        //}
        #endregion
        #region dynamic, default로 계산 일반화 프로그래밍
        //static void SumProgram<T>(T[] values, int Lenght)
        //{
        //    T sum = default(T); //default(T) 변수를 일반화 하지 않는다. 값이 들어오면 형을 결정한다.
        //    T avg = default(T);

        //    foreach (T i in values)
        //    {
        //        sum += (dynamic)i;
        //        //dynamic컴파일러가 컴파일하고 나서도 형을 결정하지 않는다. 형은 동적 할당 할 때 실시간으로 한다.
        //    }
        //    avg = (dynamic)sum / Lenght;

        //    WriteLine($"합계 : {sum}");
        //    WriteLine($"평균 : {avg}");
        //}
        #endregion
        #region 버블정렬 일반화
        static void BubbleSort<T>(T[] DataSet, Compare<T> comparer) where T : IComparable<T>
        {
            T temp = default(T);
            for (int i = 0; i < DataSet.Length - 1; i++)
            {
                for (int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (comparer(DataSet[j], DataSet[j + 1]) > 0)
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
