using System;
using static System.Console;
using System.Runtime.CompilerServices;//어트리뷰트를 만들기 위해 선언 (런타임 실시간 컴파일러)
namespace _0807_Csharp
{
    #region 어트리뷰트 (코드 부가정보)
    //class Myclass
    //{
    //    [Obsolete("ldMethod()는 폐기 되었음. NewMethod() 이용 바람")] //어트리뷰트
    //    public void OldMethod()
    //    {
    //        WriteLine("I'm Old");
    //    }
    //    public void NewMethod()
    //    {
    //        WriteLine("I'm new");
    //    }
    //}
    #endregion
    #region 다양한 종류의 어트리뷰트 
    //class Trace
    //{
    //    public static void WriteLine(string message, //매개변수 안에 어트리뷰트를 넣었다. (아래 3개)
    //        [CallerFilePath] string file = "", //경로명 출력 (파일 저장 위치)
    //        [CallerLineNumber] int line = 0, //행의 개수 출력 (몇 번째 줄인지 출력)
    //        [CallerMemberName] string member = "") //namespace명이나 메소드 명이 출력된다. (이 매소드를 호출한게 Main함수여서 Main출력)
    //    {
    //        Console.WriteLine($"{file}(Line :{line} {member} : {message})");
    //    }
    //}
    #endregion
    #region 어트리뷰트 만들기
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple = true)]
    //System.AttributeTargets.Class == 클래스와 관련된 어트리뷰트는 AllowMultiple = true == 어려번 사용할 수 있다.
    //System.AttributeTargets.Method == 매소드와 관련된 어트리뷰트는 AllowMultiple = true == 어려번 사용할 수 있다.
    class History : System.Attribute //어트리뷰트 클래스를 상속 받는다.
    {
        private string programmer;
        public double Version //자동 프로퍼티
        {
            get;
            set;
        }
        public string Changes //자동 프로퍼티
        {
            get;
            set;
        }
        public History(string programmer)
        {
            this.programmer = programmer; //매개변수가 1개인 생성자
            Version = 1.0;
            Changes = "First release";
        }
        public string Programmer
        {
            get { return programmer; }
        }
        public string GetProgrammer()
        {
            return Programmer;
        }
    }
    [History("Sean", Version = 0.1, Changes = "2024-08-06 Created Class Make")]
    [History("Bob", Version = 0.2, Changes = "2024-08-07 Created Func Make")]
    class MyClass
    {
        public void Func()
        {
            WriteLine("Func()");
        }
    }
    #endregion
    #region 쪽지시험
    class Student
    {
        public string Name { get; set; }
        public int Score {  get; set; }
    }
    #endregion
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region 어트리뷰트 (코드 부가정보)
            //Myclass obj = new Myclass();
            //obj.OldMethod(); //출력은 되지만 경고가 뜸.
            //obj.NewMethod();
            #endregion
            #region 다양한 종류의 어트리뷰트
            //Trace.WriteLine("즐거운 유니티와 C# 프로그래밍");
            #endregion
            #region 어트리뷰트 만들기
            //Type type = typeof(MyClass); //오브젝트로 선언되어있다.
            //Attribute[] attributes = Attribute.GetCustomAttributes(type);

            //WriteLine("Myclass change History .....");
            //foreach (Attribute a in attributes)
            //{
            //    if (a is History h)
            //        Console.WriteLine("Ver : {0}, Programmer : {1}, Change : {2}", h.Version, h.Programmer, h.Changes); //h.Programmer, h.GetProgrammer() 둘다 같은 결과
            //}
            #endregion
            #region 쪽지시험
            //List<Student> students = new List<Student>()
            //{
            //    new Student() { Name="John", Score=80 },
            //    new Student() { Name="Steve", Score=99 },
            //    new Student() { Name="Bill", Score=70 },
            //    new Student() { Name="Ram", Score=90 },
            //    new Student() { Name="Ron", Score=60 },
            //};

            //var result = from student in students
            //             group student by student.Score < 80 into s
            //             select new
            //             {
            //                 Group = s.Key == true ? "80점 미만" : "80점 이상",
            //                 st = s
            //             };

            //foreach(var group in result)
            //{
            //    WriteLine($"===={group.Group}====");
            //    foreach(var student in group.st)
            //    {
            //        WriteLine($"{student.Name} {student.Score}");
            //    }
            //}
            #endregion
        }
    }
}
