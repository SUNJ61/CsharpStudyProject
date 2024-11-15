using System.Threading.Channels;
using static System.Console;

namespace _0820_Csharp
{
    #region 클래스 오버라이드
    //class My { }
    //class Your
    //{
    //    public override string ToString()
    //    {
    //        return "새로운 반환 문자열 지정";
    //    }
    //}
    #endregion
    #region 배열 형식의 필드
    //class Sc
    //{
    //    private string[] we = { "일", "월", "화", "수", "목", "금", "토" };
    //    public void Printwe()
    //    {
    //        foreach (var d in we)
    //        {
    //            Console.Write($"{d}\t");
    //        }
    //        WriteLine();
    //    }
    //}
    #endregion
    #region 여러가지 형태의 필드 선언, 초기화 참조구현하기
    //class Person
    //{
    //    private string n = "박용준";
    //    private const int a = 21;
    //    private readonly string nn = "RedPlus";
    //    private string[] _web = { "닷넷코리아", "비주얼아카데미" };
    //    private object all = DateTime.Now.ToShortTimeString();

    //    public void Show()
    //    {
    //        string r = $"{n},{a},{nn},{String.Join(",", _web)}, " + $"{Convert.ToDateTime(all).ToShortTimeString()}";
    //        WriteLine(r);
    //    }
    //}
    #endregion
    #region 생성자
    class My1
    {
        private string _name;
        private int _age;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public My1(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public void PrintMy()
        {
            WriteLine($"이름 : {_name}, 나이 : {_age}");
        }
    }

    public class Circle
    {
        private int _radius;
        public int Radius
        {
            get { return _radius * _radius * (int)Math.PI;}
            set { _radius = value; }
        }
        public Circle(int radius)
        {
            _radius = radius;
        }
    }
    class Log
    {
        public Log()
        {
            WriteLine("기본 생성자 실행");
        }
        public Log(string message)
        {
            WriteLine("오버로드된 생성자 실행 :" + message);
        }
    }
    class Person
    {
        private string name;

        public Person()
        {
            name = "홍길동";
        }
        public Person(string n)
        {
            name = n;
        }
        public string Name
        {
            get { return name; }
        }
    }
    class PersonS
    {
        private static readonly string _Name; //static으로 선언된 읽기전용 정적 변수
        private int _Age;

        static PersonS() { _Name = "홍길동"; } //읽기 전용 변수는 생성자에서 초기화, 정적변수이기 때문에 static을 붙여 사용해야한다. = 정적 생성자
        public PersonS() { _Age = 21; } //인스턴스 생성자는 인스턴스로 초기화
        public PersonS(int Age)
        {
            _Age = Age;
        }
        public static void Show()
        {
            WriteLine($"이름 : {_Name}");
        }
        public void Print()
        {
            WriteLine($"나이 : {_Age}");
        }
    }
    #endregion
    internal class Program
    {
        //static string Globlavariable = "전역변수";
        static void Main(string[] args)
        {
            //Class1 one = new Class1();
            //Class2 two = new Class2();

            //one.Hi();
            //two.Hello();

            //string localVeriable = "지역변수";
            //WriteLine(Globlavariable);
            //WriteLine(localVeriable);
            //Test();

            #region 클래스 오버라이드
            //My my = new My();
            //WriteLine(my);
            //Your your = new Your();
            //WriteLine(your);
            #endregion
            #region 배열 형식의 필드
            //Sc s = new Sc();
            //s.Printwe();
            #endregion
            #region 여러가지 형태의 필드 선언, 초기화 참조구현하기
            //Person person = new Person();
            //person.Show();
            #endregion
            #region 생성자
            My1 my1 = new My1("백승수", 21);
            my1.PrintMy();
            my1.Age = 25;
            my1.Name = "이해준";
            my1.PrintMy();

            var circle1 = new Circle(10);
            WriteLine(circle1.Radius);
            circle1.Radius = 5;
            WriteLine(circle1.Radius);

            Log log1 = new Log();
            Log log2 = new Log("C#");
            Log log3 = new Log("ASP.NET");

            Person p1 = new Person();
            WriteLine(p1.Name);
            Person p2 = new Person();
            WriteLine(p2.Name);
            Person p3 = new Person("백두산");
            WriteLine(p3.Name);
            Person p4 = new Person("임꺽정");
            WriteLine(p4.Name);

            PersonS.Show(); //정적 멤버 호출 (정적 생성자는 이미 메모리상에서 호출 되었다.)
            (new PersonS()).Print(); //인스턴스 멤버 호출 (보이드 생성자 = 기본생성자 호출)
            (new PersonS(22)).Print(); //인스턴스 멤버 호출 (매개변수가 1개인 생성자 호출)
            #endregion
        }
        //static void Test() => WriteLine(Globlavariable);
    }
}
