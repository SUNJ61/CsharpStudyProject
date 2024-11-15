using System;
using System.Collections; // IEnumerable ,IEnumerator 사용하기 위해 컬렉션 선언
using static System.Console;

namespace _0723_Csharp
{
    #region 인덱서 foreach로 출력하기.
    //class MyList : IEnumerator, IEnumerable
    //{
    //    private int[] array;
    //    int position = -1; //인덱스는 0이 초기값이라 -1로 선언
    //    public MyList()
    //    {
    //        WriteLine("void 생성자 호출");
    //        array = new int[5];
    //        WriteLine($"{array.Length}");
    //    }
    //    public int this[int idx] //인덱서, 프로퍼티에서 인덱스를 관리한다.
    //    {
    //        get { return array[idx]; }
    //        set
    //        {
    //            if(idx >= array.Length) //배열 범위를 벗어나면
    //            {//<int> 는 해당 변수를 컴파일할 때<자료형>으로 형변환한다.
    //                Array.Resize<int>(ref array, idx+1); // array의 주소를 받아서 해당 배열의 길이를 idx +1 만큼으로 다시 정의 한다.
    //                WriteLine($"{array.Length}");
    //            }
    //            array[idx] = value;
    //        }
    //    }
    //    public int Length
    //    {
    //        get { return array.Length; }
    //    }

    //    public object Current //IEnumerator의 멤버이며 프로퍼티이다. -> 2번째 실행.
    //    {//IEnumerator로 상속 받은 Current프로퍼티는 position에 해당하는 배열 값을 반환한다.
    //        get { return array[position]; }
    //    }

    //    public IEnumerator GetEnumerator() //IEnumerable의 멤버 -> 3번째 실행. IEnumerable 상속 선언이 없어도 컴파일러가 상속을 알려줌.
    //    {//GetEnumerator() 메소드는 IEnumerator형식의 객체
    //        return this; // 반복적으로 IEnumerator에서 받은 값을 MyList클래스로 반환.
    //    }

    //    public bool MoveNext() //IEnumerator의 멤버 -> 1번째로 실행.
    //    {//position의 값을 배열의 최대 크기까지 하나씩 증가시키는 메소드
    //        if (position == array.Length -1) //position이 배열의 최대 인덱스와 같아진다면
    //        {
    //            Reset();
    //            return false; //모든 인덱스를 다 돌았으므로 종료
    //        }
    //        position++; //position이 배열의 최대 인덱스까지 안갔을 때 하나씩 증가시킨다.
    //        return (position < array.Length); //position이 배열의 최대 인덱스 보다 작을 경우 true.
    //    }

    //    public void Reset() //MoveNext() 가 false를 반환하면 실행.
    //    {
    //        position = -1; //position을 초기화.
    //    }
    //}

    //class MyEnumerator //IEnumerable 상속 선언이 없어도 컴파일러가 상속을 알려줌.
    //{
    //    int[] numbers = { 1, 2, 3, 4 };
    //    public IEnumerator GetEnumerator() //클래스에 GetEnumerator()가 있으면 객체에 foreach를 사용할 수 있다.
    //    {
    //        yield return numbers[0];
    //        yield return numbers[1];
    //        yield return numbers[2];
    //        yield break; //GetEnumerator() 메소드를 종료시킴
    //        yield return numbers[3]; //코드 실행 x
    //    }
    //}
    #endregion
    #region 모든 자료형을 담는 배열 <T> 이용
    //class MyList<T>
    //{
    //    private T[] array;
    //    int position = -1; //인덱스는 0이 초기값이라 -1로 선언
    //    public MyList()
    //    {
    //        WriteLine("void 생성자 호출");
    //        array = new T[5];
    //        WriteLine($"초기 array.Length : {array.Length}");
    //    }
    //    public T this[int idx] //인덱서, 프로퍼티에서 인덱스를 관리한다.
    //    {
    //        get { return array[idx]; }
    //        set
    //        {
    //            if (idx >= array.Length) //배열 범위를 벗어나면
    //            {//<int> 는 해당 변수를 컴파일할 때<자료형>으로 형변환한다.
    //                Array.Resize<T>(ref array, idx + 1); // array의 주소를 받아서 해당 배열의 길이를 idx +1 만큼으로 다시 정의 한다.
    //                //WriteLine($"{array.Length}");
    //            }
    //            array[idx] = value;
    //        }
    //    }
    //    public int Length
    //    {
    //        get { return array.Length; }
    //    }
    #region T 자료형을 사용한 객체에 foreach로 접근 가능하게 하는 인터페이스
    //public object Current //IEnumerator의 멤버이며 프로퍼티이다. -> 2번째 실행.
    //{//IEnumerator로 상속 받은 Current프로퍼티는 position에 해당하는 배열 값을 반환한다.
    //    get { return array[position]; }
    //}

    //public IEnumerator GetEnumerator() //IEnumerable의 멤버 -> 3번째 실행. IEnumerable 상속 선언이 없어도 컴파일러가 상속을 알려줌.
    //{//GetEnumerator() 메소드는 IEnumerator형식의 객체
    //    return this; // 반복적으로 IEnumerator에서 받은 값을 MyList클래스로 반환.
    //}

    //public bool MoveNext() //IEnumerator의 멤버 -> 1번째로 실행.
    //{//position의 값을 배열의 최대 크기까지 하나씩 증가시키는 메소드
    //    if (position == array.Length - 1) //position이 배열의 최대 인덱스와 같아진다면
    //    {
    //        Reset();
    //        return false; //모든 인덱스를 다 돌았으므로 종료
    //    }
    //    position++; //position이 배열의 최대 인덱스까지 안갔을 때 하나씩 증가시킨다.
    //    return (position < array.Length); //position이 배열의 최대 인덱스 보다 작을 경우 true.
    //}

    //public void Reset() //MoveNext() 가 false를 반환하면 실행.
    //{
    //    position = -1; //position을 초기화.
    //}
    #endregion
    //}
    #endregion
    #region Array class T형식의 조건
    //class StructArray<T> where T : struct //형식 매개변수 제약시키기, T는 반드시 값형식이여야 한다는 조건.
    //{//즉, 이 클래스는 값형식의 데이터만 받는다. 참조형식의 데이터는 받지 않음.
    //    public T[] Array { get; set; } //자동 프로퍼티
    //    public StructArray(int size)
    //    {
    //        Array = new T[size];
    //    }
    //}

    //class RefArray<T> where T : class //T는 반드시 참조형식의 데이터이여야한다는 조건.
    //{
    //    public T[] Array { get; set; } //자동 프로퍼티
    //    public RefArray(int size)
    //    {
    //        Array = new T[size];
    //    }
    //}
    //class Base { }
    //class Derived : Base { }
    //class BaseArray<U> where U : Base //T의 또다른 형식의 매개변수U, U를 상속한 클래스여야 한다는 조건.
    //{
    //    public U[] Array { get; set; }
    //    public BaseArray(int size)
    //    {
    //        Array = new U[size];
    //    }
    //    public void CopyArray<T>(T[] Source) where T : U
    //    {
    //        Source.CopyTo(Array, 0); //Source 배열을 인덱스 0부터 Array배열에 복사한다.
    //    }
    //}
    #endregion
    #region 일반화 프로그래밍 (T로 선언된 배열)
    class MyList<T> : IEnumerator<T>, IEnumerable<T>
    {
        private T[] array;
        int position = -1; //인덱스는 0이 초기값이라 -1로 선언
        public MyList()
        {
            WriteLine("void 생성자 호출");
            array = new T[5];
            WriteLine($"{array.Length}");
        }
        public T this[int idx] //인덱서, 프로퍼티에서 인덱스를 관리한다.
        {
            get { return array[idx]; }
            set
            {
                if (idx >= array.Length) //배열 범위를 벗어나면
                {
                    Array.Resize<T>(ref array, idx + 1); // array의 주소를 받아서 해당 배열의 길이를 idx +1 만큼으로 다시 정의 한다.
                    WriteLine($"{array.Length}");
                }
                array[idx] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }

        public T Current //제네릭 형태의 배열 일경우
        {//제네릭일 경우 두번째로 실행
            get { return array[position]; } //array[position] 값을 반환
        }

        object IEnumerator.Current //제네릭 형태의 배열이 아닐 경우
        {//제네릭아닐 경우 두번째로 실행
            get { return array[position]; } //array[position]을 오브젝트로 반환
        }

        public void Dispose()
        {

        }

        public IEnumerator<T> GetEnumerator() //IEnumerator에 있는 GetEnumerator(), 제네릭 형태의 배열 일경우
        { //제네릭일 경우 세번째로 실행
            return this; //클래스로 값 반환.
        }

        public bool MoveNext() //첫번째로 실행
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator() //IEnumerable에 있는 GetEnumerator() , 제네릭 형태의 배열이 아닌경우
        { ////제네릭이 아닐 경우 세번째로 실행
            return this; // 클래스로 값 반환.
        }
    }
    #endregion
    internal class Program
    {
        #region class T형식의 조건
        //public static T CreatInstance<T>() where T : new()
        //{//T는 반드시 매개변수 없는 생성자가 있어야 한다. 즉, void 생성자가 있어야만 한다.
        //    return new T();
        //}
        #endregion
        static void Main(string[] args)
        {
            #region 인덱서 foreach로 출력하기.
            //MyList list = new MyList();
            //for(int i = 0; i<8; i++)
            //{
            //    list[i] = i;
            //    WriteLine($"{list[i]}!");
            //}
            //for(int i =0; i<list.Length; i++)
            //{
            //    Write(list[i]);
            //}
            //WriteLine("================================");
            //foreach (int i in list)
            //{//실행 불가능, foreach는 배열의 경계를 넘어가지 않도록 출력해주지만 아무 객체나 출력이 불가능하다.
            //    WriteLine(i);
            //}//인덱스 프로퍼티에 IEnumerable ,IEnumerator를 상속 시켜주면 해결.
            //WriteLine("================================");
            //var obj = new MyEnumerator();
            //foreach(int i in obj)
            //{
            //    WriteLine(i);
            //}
            #endregion
            #region 일반화 프로그래밍, <T>, 컴파일 할 때 자료형 결정
            //SubMethod method = new SubMethod();//자료형당 하나씩 객체생성, 그 뒤에 같은 자료형을 쓰면 생성 했던 객체 재활용.

            //int[] source = { 1, 2, 3, 4, 5 };
            //int[] target = new int[source.Length];
            //method.CopyArray<int>(source, target); //<>는 컴파일 할 때 형변환 시킨다.
            //foreach (int i in target)
            //{
            //    WriteLine(i);
            //}

            //double[] source1 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            //double[] target1 = new double[source1.Length];
            //method.CopyArray<double>(source1, target1);//입력시 자료형이 모두 알맞다면 쓰지 않아도 된다.
            //foreach (double de in target1)
            //{
            //    WriteLine(de);
            //}

            //string[] source2 = { "하나","둘","셋","넷","다섯" };
            //string[] target2 = new string[source2.Length];
            //method.CopyArray<string>(source2, target2);
            //foreach (string str in target2)
            //{
            //    WriteLine(str);
            //}
            #endregion
            #region 모든 자료형을 담는 배열 <T> 이용
            //MyList<string> str_list = new MyList<string>();
            //str_list[0] = "abc";
            //str_list[1] = "def";
            //str_list[2] = "ghi";
            //for(int i = 0;  i < str_list.Length; i++)
            //{
            //    Console.WriteLine(str_list[i]);
            //}

            //WriteLine("=========================================");

            //MyList<int> int_list = new MyList<int>();
            //for(int i = 0; i < 9; i++)
            //{
            //    int_list[i] = i;
            //    WriteLine(int_list[i]);
            //}
            //foreach(int i in int_list) //해결 안함.
            //    WriteLine(i);
            #endregion
            #region Array class T형식의 조건
            //StructArray<int> a = new StructArray<int>(3);
            //for(int i = 0; i < a.Array.Length; i++) //값 형식의 데이터를 입력
            //{
            //    a.Array[i] = i;
            //    WriteLine(a.Array[i]);
            //}
            //WriteLine("=========================================");

            //RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            //for (int i = 0; i < b.Array.Length; i++) //class, 참조 형식의 데이터를 입력
            //{
            //    b.Array[i] = new StructArray<double>(5 * (i + 1)); //class형식의 데이터를 배열의 저장, 배열안에는 또다른 배열이 입력.
            //    WriteLine(b.Array[i]);
            //}
            //WriteLine("=========================================");

            //BaseArray<Base> c = new BaseArray<Base>(3);
            //c.Array[0] = new Base(); //Base클래스 자체를 입력
            //c.Array[1] = new Derived(); //Base클래스를 상속한 클래스를 입력
            //c.Array[2] = CreatInstance<Base>(); //Base클래스를 반환하는 함수를 입력

            //for (int i = 0; i < c.Array.Length;i++)
            //    WriteLine(c.Array[i]);

            //WriteLine("=========================================");

            //BaseArray<Derived> d = new BaseArray<Derived>(3);
            //d.Array[0] = new Derived(); //Base형식은 여기에 할당할 수 없다, Derived자체를 입력.
            //d.Array[1] = CreatInstance<Derived>(); //Derived를 반환하는 함수를 입력
            //d.Array[2] = CreatInstance<Derived>();

            //for(int i = 0; i < d.Array.Length;i++)
            //    WriteLine(d.Array[i]);
            #endregion
            #region List 클래스 사용법
            //List<int> list = new List<int>();
            //for(int i = 0; i < 5; i++)
            //{
            //    list.Add(i);
            //}
            //foreach(int i in list)
            //    WriteLine($"{i.ToString()}");

            //WriteLine("=======원하는 인덱스 삭제!=======");
            //list.RemoveAt(0);
            //foreach (int i in list)
            //    WriteLine($"{i.ToString()}");

            //WriteLine("=======Insert 원하는 값 삽입!=======");
            //list.Insert(0, 0);
            //foreach (int i in list)
            //    WriteLine($"{i.ToString()}");

            //WriteLine("=======전체 인덱스 삭제!=======");
            //list.Clear();
            //foreach (int i in list)
            //    WriteLine($"{i.ToString()}");
            #endregion
            #region 리스트 [Queue, Stack, Hashtable ,딕셔너리]
            //Queue<int> que = new Queue<int>();
            //que.Enqueue(1);
            //que.Enqueue(2);
            //que.Enqueue(3);
            //que.Enqueue(4);
            //que.Enqueue(5);
            //while(que.Count > 0)
            //    WriteLine(que.Dequeue());

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //while (stack.Count > 0)
            //    WriteLine(stack.Pop());

            //Hashtable<string> hash = new Hashtable<string>(); //Hashtable은 <string>과 함께 사용 불가, 제네릭 리스트가 아님.

            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic["하나"] = "one";
            //dic["둘"] = "two";
            //dic["셋"] = "three";

            //WriteLine(dic["하나"]);
            //WriteLine(dic["둘"]);
            //WriteLine(dic["셋"]);

            //Dictionary<string,int> dic2 = new Dictionary<string,int>(); //인벤토리 할 때 사용.
            //dic2["하나"] = 1;
            //dic2["둘"] = 2;
            //dic2["셋"] = 3;

            //WriteLine($"{dic2["하나"]}+{dic2["둘"]}+{dic2["셋"]} = {dic2["하나"]+ dic2["둘"]+ dic2["셋"]}");
            #endregion
            #region 일반화 프로그래밍 (T로 선언된 배열)
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            foreach (string str in str_list)
                WriteLine(str);

            WriteLine("=========================================");
            MyList<decimal> de_list = new MyList<decimal>();
            de_list[0] = 13.12345689012345678901234m;
            de_list[1] = 19.12345689012345678901234m;
            de_list[2] = 25.12345689012345678901234m;
            foreach (decimal d in de_list)
                WriteLine(d);
            #endregion
            #region 문제

            #endregion
        }
    }
}
