using System.Runtime.InteropServices;
using System.Windows.Markup;
using System.Xml.Linq;
using static System.Console;
using static System.Math;

namespace _0626_CS
{
    internal class Program
    {
        #region struct-구조체 선언 (함수)
        //static void Print(string name, int age)
        //    => WriteLine($"{name}은(는) {age}살 입니다.");
        //static void Print(Member member)
        //    => WriteLine($"{member.Name}은(는) {member.Age}살 입니다.");
        #endregion
        #region 전역, 지역 변수 (함수)
        //static string ms = "전역 변수"; // class내에서의 전역변수 (더 넓게 보면 지역 변수임, 클래스 안에서만 볼땐 전역 변수)
        //static void Showms()
        //{
        //    string ms = "지역 변수"; // 이 함수안에서만 사용하는 되는 지역변수
        //    WriteLine(ms);
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Math 클래스와 랜덤 클래스
            //WriteLine($"자연로그 : {Math.E}");
            //WriteLine($"원주율 : {Math.PI}");
            //WriteLine($"-10의 절댓값 : {Math.Abs(-10)}");
            //WriteLine($"{Math.Max(3,5)}");
            //WriteLine($"{Math.Min(3,5)}");
            //WriteLine($"2의 10승 : {Math.Pow(2,10)}");
            //WriteLine($"3.15를 소수점 둘째 자리에서 반올림 : {Math.Round(3.15,1)}");
            //WriteLine($"{Math.Round(1.1F)}"); //반올림
            //WriteLine($"{Math.Ceiling(1.1F)}"); //올림
            //WriteLine($"{Math.Floor(1.1F)}"); //내림
            //WriteLine($"{Math.Sqrt(9)}"); // -> 같은 입력이면 일정한 값 출력 : 순수 함수
            //WriteLine($"{new Random().Next()}");// -> 같은 입력이어도 다른 값 출력 : 비순수 함수
            //WriteLine($"{new Random().Next()}");
            //WriteLine(Pow(2,10)); // using static System.Math로 Math 클래스 명 생략가능.

            //Random random = new Random(); //random변수에 Random 클래스 동적 할당.
            //for (int i = 0; i < 10; i++)
            //{
            //    int ran = random.Next();
            //    WriteLine($"Next() : {ran}");
            //}

            //WriteLine();

            //for (int i = 0; i < 10; i++)
            //{
            //    int ran = random.Next(1,5+1); // 1~5사이의 랜덤 값이 출력 (인덱스 값이라서 뒷부분에 1을 더해 줘야한다.)
            //    WriteLine($"Next() : {ran}"); // 여기서 1은 시작 값이다. (범위에 0이 있으면 0을 제외하고 1~4를 뽑는다.)
            //}

            //WriteLine();

            //for (int i = 0; i < 10; i++)
            //{
            //    int ran = random.Next(5); // 함수가 오버로딩 되어있다, 함수에 입력하는 값이 계속 변함.
            //    WriteLine($"Next() : {ran}"); // 즉, 5는 0부터 시작된 범위이다.
            //}

            //WriteLine();

            //for (int i = 0; i < 10; i++)
            //{
            //    int ran = new Random().Next();
            //    WriteLine($"Next() : {ran}"); //랜덤인데 고정값이 아닌데요? 출력할때마다 달라짐 흠..
            //}
            #endregion
            #region 랜덤 함수 에제
            /*
            랜덤값 1에서 100까지 100개의 1차원 배열에 저장 , 저장한후 2의배수와 6의 배수만 출력
            */

            //Random random = new Random();
            //int ran = random.Next();
            //int[] box = new int[100];

            //for(int i = 0; i < box.Length; i++)
            //{
            //    box[i] = random.Next(1,100+1);
            //    if (box[i] % 6 == 0)
            //        WriteLine($"6의 배수 : {box[i]}");
            //    else if (box[i] % 2 == 0)
            //        WriteLine($"2의 배수 : {box[i]}");
            //}
            #endregion
            #region nameof연산자
            //WriteLine(nameof(System)); // 클래스나 매서드 이름을 문자열로 가져온다. 리펙토링 할때 유용
            #endregion
            #region struct-구조체
            //Point point;
            //point.x = 100;
            //point.y = 200;
            //WriteLine($"{point.x}, {point.y}");

            //BusinessCard bs;
            //bs.name = ReadLine();
            //bs.age = int.Parse(ReadLine());
            //bs.address = ReadLine();
            //WriteLine($"\n이름 : {bs.name}\n나이 : {bs.age}\n주소 : {bs.address}");

            //Product p = new Product();
            //p.Id = 1;
            //p.Title = "좋은 책";
            //p.Price = 10000M;

            //string message = $"번호 : {p.Id}\n상품 명 : {p.Title}\n가격 : {p.Price}";
            //WriteLine(message);

            //BCard bc;
            //bc.Name = "백승수";
            //bc.Age = 17;
            //Array.Print(bc.Name, bc.Age);

            //BCard[] bca = new BCard[2]; //구조체 배열 선언
            //bca[0].Name = "이세영"; bca[0].Age = 102;
            //bca[1].Name = "권경민"; bca[1].Age = 31;

            //for (int i = 0; i < bca.Length; i++)
            //{
            //    Array.Print(bca[i].Name, bca[i].Age);
            //}

            //string name = "백승수";
            //int age = 21;
            //Print(name, age);

            //Member m;
            //m.Name = "이세영";
            //m.Age = 100;
            //Print(m);
            #endregion
            #region 전역, 지역 변수
            //Showms(); //지역 변수 출력 -> 함수내에서 전역변수명과 같은 지역변수가 선언되면 전역변수가 가려진다.
            //WriteLine(ms); //전역 변수 출력
            #endregion
            #region 로컬함수
            //void Display(string text) //매서드 내에서만 사용되는 또 다른 함수
            //{
            //    WriteLine(text);
            //}

            //Display("로컬함수");

            //int Add(int a, int b) => a + b;
            //decimal Subract(decimal x, decimal y) => x - y;
            //WriteLine($"3 + 5 = {Add(3,5)}");
            //WriteLine($"34.56 - 12.34 = {Subract(34.56m,12.34m)}");
            #endregion
            #region cmd활용
            //foreach (string arg in args) //cmd창에서 해당 파일 exe 위치로 이동(cd명령어 이용), 파일명쓰고 띈다음 입력 값 작성 
            //{
            //    WriteLine(arg); //디버그 -> 디버그 속성에 명령줄 인자에 입력값 적고 실행하면 같은 효과를 볼수있다.
            //}

            //int first = int.Parse(args[0]); //디버그 -> 디버그 속성에 명령줄 인자에 10 20 작성
            //int second = Convert.ToInt32(args[1]);
            //WriteLine(first+second);
            #endregion
            #region 내장형 구조체
            //TimeSpan dday = Convert.ToDateTime("2024-12-25") - DateTime.Now; //시간 정보를 나타내는 내장형 구조체
            //WriteLine($"{DateTime.Now.Year}년도 크리스마스는 {(int)dday.TotalDays}일 남았다.");

            //TimeSpan times = DateTime.Now - Convert.ToDateTime("1999-06-01");
            //WriteLine($"내가 지금까지 며칠 살아 왔는가? {(int)times.TotalDays}일");
            #endregion
        }
    }
    #region struct-구조체 선언 (구조체)
    //struct Point
    //{
    //    public int x;
    //    public int y;
    //}

    //struct BusinessCard
    //{
    //    public string name;
    //    public int age;
    //    public string address;
    //}

    //struct Product //클래스 외부에도 선언이 가능하다. 구조체 내부에 함수 선언이 가능하다.
    //{
    //    public int Id;
    //    public string Title;
    //    public decimal Price;
    //}

    //struct BCard
    //{
    //    public string Name;
    //    public int Age;
    //}

    //public class Array
    //{
    //    public static void Print(string name, int age)
    //        => WriteLine($"{name}은(는) {age}살 입니다."); // =>는 {}와 똑같이 작동한다.
    //}

    //struct Member
    //{
    //    public string Name;
    //    public int Age;
    //}
    #endregion
}

