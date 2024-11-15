using System.ComponentModel;
using System.Net;
using System.Numerics;
using System.Threading.Channels;
using static System.Console;

namespace _0725_Csharp
{
    #region 대리자 기초
    //delegate int MyDelegate(int a, int b); //반환형이 int이며 대신하여 매개변수 2개를 받는 대리자.
    ////즉, int형의 매개변수 2개를 입력하는 사건이 일어나면, int형 매개변수 2개를 가진 함수를 대리한다.
    //class Calculator
    //{
    //    public int Plus(int a, int b)
    //    {
    //        return a + b;
    //    }
    //    public int Minus(int a, int b)
    //    {
    //        return a - b;
    //    }
    //}
    #endregion
    #region 코드를 넘기는 대리자 (버블정렬)
    //delegate int Compare(int a, int b); // 조건 : int형 반환, int형 매개변수 2개
    #endregion
    #region 코드를 넘기는 대리자 (모든 자료형을 적용하는 버블정렬)
    //delegate int Compare<T>(T a, T b); // 모든 자료형을 받고 int를 반환하는 함수를 대리할 수 있다.
    #endregion
    #region 대리자 체인
    //delegate void Notify(string message); //반환형이 없고 매개변수가 string1개인 함수를 대리할 수 있다.
    //class Nofier
    //{
    //    public Notify EventOccured;// 대리자 체인 : 대리자 하나가 여러개의 메소드를 동시에 참조할 수 있다.
    //}
    //class EventListener
    //{
    //    private string name;
    //    public EventListener(string name) //생성자 - 객체 생성시 string매개변수 1개가 있다면 name변경
    //    {
    //        this.name = name;
    //    }
    //    public void SomethingHappend(string message)
    //    {
    //        WriteLine($"{name}.SomethingHappend : {message}");
    //    }
    //}
    #endregion
    #region 익명의 메소드
    //delegate int Compare1(int a, int b);
    #endregion
    #region 익명의 메소드 2
    //delegate int Calculator1(int a, int b);
    #endregion
    #region 이벤트
    //delegate void EventHandler(string message);
    //class MyNotifier
    //{
    //    public event EventHandler SomethingHappend;
    //    //event를 붙이면 EventHandler대리자를 받아서 클래스 안에서 한정 사용하겠다. 즉, SomethingHappend는 외부 사용 불가.
    //    //이벤트는 대리자에 envent 키워드로 수식해서 선언한 것이다.
    //    //이벤트가 대리자와 크게 다른점은 바로 이벤트를 외부에서 직접 사용할 수 없다는 것에 있다.
    //    //이벤트는 public으로 선언되어도 자신이 선언한 클래스 외부에서는 호출이 불가능하다.
    //    //반면 event로 선언이 되지 않은 대리자는 public으로 선언되어 있으면 클래스 외부에서도 호출이 가능하다.
    //    public void DoSomethingHappend(int num)
    //    {
    //        int temp = num % 10; //일의 자리수만 남긴다.
    //        if(temp != 0 && temp % 3 == 0) // 0을 제외한 일의 자리수가 3의 배수일 경우
    //        {
    //            SomethingHappend(string.Format($"{num} : 짝")); //대리자에게 원하는 문구를 string으로 전달한다.
    //        }
    //    }
    //}
    #endregion
    #region 문제
    //delegate int MyDelegate1(int a, int b);
    //delegate void MyDelegate(int a);
    //class Market
    //{
    //    public event MyDelegate CustomerEvent;

    //    public void BuySomething(int Custom)
    //    {
    //        if (Custom == 30)
    //            CustomerEvent(Custom);
    //    }
    //}
    #endregion
    internal class Mainapp
    {
        #region 코드를 넘기는 대리자 (버블정렬)
        //static int AscendCompare(int a, int b) //오름차순 메소드
        //{
        //    if (a > b)
        //        return 1; //a가 크면 1 반환
        //    else if (a == b)
        //        return 0; //a와 b가 같으면 0반환
        //    else
        //        return -1; //a가 작으면 -1반환
        //}
        //static int DescendCompare(int a, int b) //내림차순 메소드
        //{
        //    if (a > b)
        //        return -1; //a가 크면 -1 반환
        //    else if (a == b)
        //        return 0; //a와 b가 같으면 0반환
        //    else
        //        return 1; //a가 작으면 1반환
        //}
        //static void BubbleSort(int[]DataSet, Compare compare) //버블정렬 : 가장 낮은 인덱스부터 차례로 비교하여 정렬
        //{
        //    int i;
        //    int j;
        //    int temp;
        //    for(i = 0; i< DataSet.Length; i++) //한번 비교하면 비교 횟수 1번 줄어든다.
        //    {
        //        for (j = 0; j < DataSet.Length - (i + 1); j++)
        //        { // 비교된 두 인덱스의 값을 바꾸는 코드
        //            if (compare(DataSet[j], DataSet[j + 1]) == 1) //대리자로 값 비교하여 정렬 함수에서 바꿔야 하면 1 반환됨.
        //            {//비교후 j가 최대로 늘어 났을 때 j인덱스에는 가장 큰값이 들어감.
        //                temp = DataSet[j + 1];
        //                DataSet[j + 1] = DataSet[j];
        //                DataSet[j] = temp;
        //            }
        //        }
        //    }
        //}
        #endregion
        #region 코드를 넘기는 대리자 (모든 자료형을 적용하는 버블정렬)
        //static int AscendCompare<T>(T a, T b) where T : IComparable<T> //IComparable<T>라는 인터페이스를 써야함.
        //{//오름차순 정렬, 반드시 IComparable 선언된 선언부를 구현해야한다.
        //    return a.CompareTo(b); //a와 b를 비교하여 a가 크면 1을 반환.
        //}
        //static int DescendCompare<T>(T a, T b) where T : IComparable<T> //내림차순 메소드
        //{//내림차순 메소드
        //    return a.CompareTo(b) * -1; //내림차순은 오름차순과 반대 되는 값을 출력해야하므로 -1을 곱함.
        //}
        //static void BubbleSort<T>(T[] DataSet, Compare<T> compare) //버블정렬 : 가장 낮은 인덱스부터 차례로 비교하여 정렬
        //{
        //    int i;
        //    int j;
        //    T temp;
        //    for (i = 0; i < DataSet.Length; i++) //한번 비교하면 비교 횟수 1번 줄어든다.
        //    {
        //        for (j = 0; j < DataSet.Length - (i + 1); j++)
        //        { // 비교된 두 인덱스의 값을 바꾸는 코드
        //            if (compare(DataSet[j], DataSet[j + 1]) == 1) //대리자로 값 비교하여 정렬 함수에서 바꿔야 하면 1 반환됨.
        //            {//비교후 j가 최대로 늘어 났을 때 j인덱스에는 가장 큰값이 들어감.
        //                temp = DataSet[j + 1];
        //                DataSet[j + 1] = DataSet[j];
        //                DataSet[j] = temp;
        //            }
        //        }
        //    }
        //}
        #endregion
        #region 익명의 메소드
        //static void BubbleSort(int[] DataSet, Compare1 compare) //버블정렬
        //{
        //    int i;
        //    int j;
        //    int temp;
        //    for (i = 0; i < DataSet.Length; i++)
        //    {
        //        for (j = 0; j < DataSet.Length - (i + 1); j++)
        //        {
        //            if (compare(DataSet[j], DataSet[j + 1]) == 1) 
        //            {
        //                temp = DataSet[j + 1];
        //                DataSet[j + 1] = DataSet[j];
        //                DataSet[j] = temp;
        //            }
        //        }
        //    }
        //}
        #endregion
        #region 이벤트
        //static public void MyHandler(string message)
        //{
        //    WriteLine(message);
        //}
        #endregion
        #region 문제
        //static public void Myevent(int Custom)
        //{
        //    WriteLine($"축하합니다! {Custom}번째 고객이벤트에 당첨되셨습니다.");
        //}
        #endregion
        static void Main(string[] args)
        {
            #region 대리자 기초
            //Calculator a = new Calculator(); //동적할당
            //MyDelegate Callback; //대리자 생성.
            //Callback = new MyDelegate(a.Plus); //대리할 객체 할당 및 어떠한 함수를 대리 할지 선언.
            ////해당 대리자는 int형 매개변수를 2개 입력 받는 함수를 대리할 수 있다. 또한 함수의 반환형도 같아야 한다.
            ////즉, 객체에 속한 조건에 맞는 함수만 대리 가능.
            //WriteLine(Callback(3,4));

            //Callback = new MyDelegate(a.Minus);
            //WriteLine(Callback(4,3));
            #endregion
            #region 코드를 넘기는 대리자 (버블정렬)
            //int[] a = { 5, 1, 3, 2, 4, 7, 6 };
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Write(a[i]);
            //}
            //WriteLine();
            //WriteLine("오름차순");
            //BubbleSort(a, new Compare(AscendCompare)); //오름차순 정렬, 대리자가 기억할 함수 선언(코드 뭉치를 매개변수로 넘김)
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Write(a[i]);
            //}
            //WriteLine();
            //WriteLine("내림차순");
            //BubbleSort(a, new Compare(DescendCompare)); //내림차순 정렬, 대리자가 기억할 함수 선언
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Write(a[i]);
            //}
            #endregion
            #region 코드를 넘기는 대리자 (모든 자료형을 적용하는 버블정렬)
            //string[] a = { "abc", "def", "ghi", "jkl", "mno" };
            //BubbleSort<string>(a, new Compare<string>(DescendCompare));
            //for(int i = 0; i < a.Length; i++)
            //{
            //    WriteLine(a[i]);
            //}
            //decimal[] b = { 3.141592m, 4.141592m, 1.141592m, 2.141592m, 5.141592m };
            //BubbleSort<decimal>(b, new Compare<decimal>(AscendCompare));
            //for (int i = 0; i < b.Length; i++)
            //{
            //    WriteLine(b[i]);
            //}
            #endregion
            #region 대리자 체인
            //Nofier notifier = new Nofier(); //대리자가 선언되어있는 클래스의 객체를 생성한다.

            //EventListener listener1 = new EventListener("Listener1"); //문자를 출력하는 객체를 생성한다.
            //EventListener listener2 = new EventListener("Listener2");
            //EventListener listener3 = new EventListener("Listener3");

            //notifier.EventOccured += listener1.SomethingHappend; //문자를 출력하는 객체의 함수를 객체에 속한 대리자에 넣는다.
            //notifier.EventOccured += listener2.SomethingHappend;
            //notifier.EventOccured += listener3.SomethingHappend;
            //notifier.EventOccured("You've got mail"); //대리자에게 문자를 입력한다.
            //WriteLine(); //문자를 출력하는 객체들의 함수를 이용하여 대리자가 받은 문자를 출력한다.

            //notifier.EventOccured =  //문자를 출력하는 객체를 객체에 속한 대리자에 한번에 넣는다
            //    new Notify(listener1.SomethingHappend) + new Notify(listener3.SomethingHappend); 
            //notifier.EventOccured("Nuclear launch detected"); //대리자에게 문자를 입력한다.
            //WriteLine(); //문자를 출력하는 객체들이 대리자가 받은 문자를 출력한다.

            //Notify notify1 = new Notify(listener1.SomethingHappend);//객체 생성, 함수 대로 이름 생성.{name}.SomethingHappend:{message}
            //Notify notify2 = new Notify(listener2.SomethingHappend);//{listener2}.SomethingHappend : {} < null값

            //notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
            ////생성된 객체 2개를 Notify로 형변환하여 대리자에 넣는다.
            //notifier.EventOccured("Fire!"); //문자를 출력하는 객체들이 대리자가 받은 문자를 출력한다.
            //WriteLine();

            //notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            ////대리자에 넣은 notify2 객체를 Notify로 형변환하여 삭제한다.
            //notifier.EventOccured("RPG"); //문자를 출력하는 객체가 대리자가 받은 문자를 출력한다.
            #endregion
            #region 익명의 메소드
            //int[] arr1 = { 3,7,4,2,9 };
            //WriteLine("익명의 함수로 버블정렬 오름차순하기");
            //BubbleSort(arr1, delegate (int a, int b) //대리자에 직접 함수를 작성해 넣었다. 선언되지 않은 익명의 함수.
            //{//오름 차순 함수 메소드와 똑같음.
            //    if (a > b) return 1;
            //    else if (a == b) return 0;
            //    else return -1;
            //});//한번 쓰고 버릴 기능들을 익명의 함수로 처리하여 사용한다. 

            //for(int i = 0; i < arr1.Length ;i++)
            //    WriteLine(arr1[i]);

            //WriteLine("익명의 함수로 버블정렬 내림차순하기");
            //BubbleSort(arr1, delegate (int a, int b)
            //{
            //    if (a > b) return -1;
            //    else if (a == b) return 0;
            //    else return 1;
            //});

            //for (int i = 0; i < arr1.Length; i++)
            //    WriteLine(arr1[i]);
            #endregion
            #region 익명의 메소드 2
            //Calculator1 cal;
            //cal = delegate(int a, int b)
            //{
            //    return (a + b);
            //};
            //WriteLine(cal(3,4));

            //cal = delegate (int a, int b)
            //{
            //    return (a - b);
            //};
            //WriteLine(cal(10, 4));
            #endregion
            #region 이벤트
            //MyNotifier myNotifier = new MyNotifier();
            //myNotifier.SomethingHappend += new EventHandler(MyHandler); //EventHandler대리자에 MyHandler기능 삽입
            //for (int i = 0; i < 30; i++)
            //{
            //    myNotifier.DoSomethingHappend(i);//DoSomethingHappend함수 안에 SomethingHappend가 속함.
            //}//즉, 함수안에 대리자가 있어 대리자에게 원하는 문구를 전달.
            #endregion
            #region 문제
            //MyDelegate1 Callback;

            //Callback = delegate (int a, int b)
            //{
            //    return (a + b);
            //};
            //WriteLine(Callback(3,4));

            //Callback = delegate (int a, int b)
            //{
            //    return (a - b);
            //};
            //WriteLine(Callback(7, 5));
            //WriteLine();

            //Market market = new Market();

            //market.CustomerEvent += new MyDelegate(Myevent);

            //market.CustomerEvent += new MyDelegate(delegate (int custom)
            //{
            //    WriteLine($"축하합니다! {custom}번째 고객이벤트에 당첨되셨습니다.");
            //});

            //for (int i = 0; i<100; i+=10)
            //    market.BuySomething(i);
            #endregion
        }
    }
}
