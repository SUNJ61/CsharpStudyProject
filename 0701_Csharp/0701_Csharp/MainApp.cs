using static System.Console;
using System;
using _0701_Csharp_jumbo;
using _0701_Csharp_info;

namespace _0701_Csharp
{
    internal class MainApp
    {
        public static void Main(string[] args)
        {
            #region 주소 전달(참조) : main
            //int i = 1;
            //int j = 10;

            //Swap(ref i,ref j); //주소를 전달한다. (ref : 주소 값 전달)
            //WriteLine($"메인에서 호출 : i = {i}, j = {j}"); // 주소값이 swap함수안에서 바뀌어서 메인에서도 값이 바뀜

            //SomeClass obj = new SomeClass();
            ////int res = obj.SomeMethod(); 주소값이 반환 되기 때문에 int 로 받으면 오류가 발생한다.
            //ref int result = ref obj.SomeMethod(); //이와 같이 주소를 참조하는 참조형 변수를 사용해야한다. 
            //WriteLine(result); //result는 참조 지역 변수이다. (참조형이며 지역 변수임.)

            //Product carrot = new Product();
            //ref int ref_localPrice = ref carrot.GetPrice();
            //int normal_localPrice = carrot.GetPrice();

            //carrot.Print(); //Product 클래스에 있는 Price를 출력
            //WriteLine($"ref Local Price : {ref_localPrice}"); // Product 클래스에 있는 Price의 주소의 값을 받아 출력
            //WriteLine($"normal_Local Price : {normal_localPrice}"); // Product 클래스에 있는 Price의 값을 받아 출력

            //ref_localPrice = 200; // Product 클래스에서 Price의 변수의 주소값에 속한 값을 200으로 변경.

            //carrot.Print(); // Product 클래스에 있는 Price의 값을 출력 (위에서 값이 바뀌어 200 출력)
            //WriteLine($"ref Local Price : {ref_localPrice}"); // 위에서 값을 변경했음.
            //WriteLine($"normal_Local Price : {normal_localPrice}"); // 초기에 받은 Price의 값을 저장한 후 변경이 없음. 
            #endregion
            #region 결과 값이 여러개인 매서드 (main)
            //int a = 20, b = 3;
            //int c = 0, d = 0;
            //WriteLine($"나누기 전 : 몫 -> {c}, 나머지 -> {d}");

            //Divide(a, b,ref c,ref d);
            //WriteLine($"나눈 후 : 몫 -> {c}, 나머지 -> {d}");

            //Divide_out(a, b, out c, out d);
            //WriteLine($"나눈 후 : 몫 -> {c}, 나머지 -> {d}");

            //if (DateTime.TryParse("2024/12/25", out var xmas))
            //    WriteLine(xmas); //string값이 실제 날짜 형식으로 바뀌어 출력 된다. (tryparse함수안에서 out으로 저장하여 출력)

            //WriteLine(GDTF(1)); 정수 날짜 변환
            //WriteLine(GDTF(8760/2));
            //WriteLine(GDTF(8760));
            #endregion
            #region 문자 관련 구조체
            //char a = 'A', b = 'a';
            //char c = '1', d = '\t';

            //if (Char.IsUpper(a))
            //    WriteLine($"{a}는 대문자");
            //if (Char.IsUpper(b))
            //    WriteLine($"{b}는 소문자");
            //if (Char.IsNumber(c))
            //    WriteLine($"{c}는 숫자형");
            //if (Char.IsWhiteSpace(d))
            //    WriteLine($"{d}는 공백 문자");

            //WriteLine(Char.ToLower(a)); //대문자를 소문자로
            //WriteLine(Char.ToUpper(b)); //소문자를 대문자로

            //string s = "abc";
            //if (Char.IsUpper(s[0]))
            //    WriteLine("첫글자는 대문자이다.");
            //else
            //    WriteLine("첫 글자는 소문자이다.");

            //WriteLine(Char.MaxValue); // ?
            //WriteLine(Char.MinValue); // 안뜸
            #endregion
            #region 열거형 형식 사용하기
            //ForegroundColor = ConsoleColor.Blue;
            //WriteLine("Blue");
            //ResetColor();

            //BackgroundColor = ConsoleColor.Yellow;
            //ForegroundColor = ConsoleColor.Red;
            //WriteLine("Red");
            //ResetColor();

            //Item item =new Item();
            //item = Item.HP;
            //switch (item)
            //{
            //    case Item.HP:
            //        WriteLine("아이템 회복");
            //        break;
            //    case Item.SPEED:
            //        WriteLine("스피드 증가");
            //        break;
            //    case Item.WEAPON:
            //        WriteLine("무기 강화");
            //        break;
            //    case Item.GRENADE:
            //        WriteLine("슈류탄 보유");
            //        break;
            //}
            //WriteLine(item+2); //출력은 WEAPON, 컴파일러는 1로 이해하여 2를 더하면 3의 인덱스를 가진 WEAPON이 출력.

            //Animal animal = Animal.TIGER;
            //WriteLine(animal);

            //if(animal == Animal.TIGER)
            //    WriteLine("호랑이");

            //WriteLine((int)Ani.Monkey); // monkey의 인덱스 출력
            #endregion
            #region 연습문제
            //Write("수를 입력하시오 : ");
            //string input = ReadLine();
            //double arg = Convert.ToDouble(input);

            //WriteLine($"결과 : {Square(arg)}");

            //double mean = 0;

            //Mean(1, 2, 3, 4, 5, out mean);
            //WriteLine($"평균 {mean}");

            //int a = 3, b = 4;
            //int resultA = 0;

            //Plus(a, b, out resultA);

            //WriteLine($"{a} + {b} = {resultA}");

            //double x = 2.4;
            //double y = 3.1;
            //double resultB = 0;

            //Plus(x, y, out resultB);
            //WriteLine($"{x} + {y} = {resultB}");
            #endregion
            #region 가변 길이의 인수 혹은 가변길이 매개변수
            //int total = 0;
            //total = Sum(1, 2);
            //WriteLine($"{total}");
            //total = Sum(1, 2, 3, 4);
            //WriteLine($"{total}");
            //total = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9);
            //WriteLine($"{total}");
            #endregion
            #region 로컬 함수
            ////로컬 함수는 매소드 안에서 선언되고 매소드 안에서 사용되는 특별한함수.
            ////클래스 멤버가 아니기 때문에 매소드가 아니라 함수라고 부른다.
            //WriteLine(ToLowerTostring("Hello"));
            //WriteLine(ToLowerTostring("GOOD MORNING!"));
            #endregion
        }

        #region 주소 전달(참조) : fuction
        //public static void Swap(ref int a,ref int b) // 주소 값을 받아서 실행한다. (ref : 주소 값 전달)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //    WriteLine($"매서드에서 호출 : i = {a}, j = {b}"); // 주소는 전역에 영향을 준다.
        //}
        #endregion
        #region 결과 값이 여러개인 매서드 (function)
        //static void Divide(int a, int b,ref int c, ref int d)//c : 몫 결과 값,d : 나머지 결과 값
        //{
        //    c = a / b; //c는 주소값을 참조해 몫 결과 값을 저장
        //    d = a % b; //d는 주소값을 참조해 나머지 결과 값을 저장
        //}

        //static void Divide_out(int a, int b, out int c, out int d)//out을 써도 ref와 마찬가지로 결과 값 전달 가능.
        //{ // ref와 out은 출력 전용 매개변수이다.
        //    c = a / b; 
        //    d = a % b; 
        //}

        //static DateTime GDTF(int number)
        //{
        //    return (new DateTime(2024,1,1,0,0,0).AddHours(--number));
        //}
        #endregion
        #region 열거형 선언
        //enum Item
        //{
        //    HP = 1,
        //    SPEED, //자동으로 2
        //    WEAPON, //자동으로 3
        //    GRENADE //자동으로 4
        //}

        //enum Animal { MOUSE,COW,TIGER }

        //enum Ani
        //{
        //    Horse,
        //    Sheep = 5,
        //    Monkey
        //}
        #endregion
        #region 연습문제 선언
        //static double Square(double arg)
        //{
        //    double result = arg * arg;
        //    return result;
        //}

        //public static void Mean(double a, double b, double c, double d, double e, out double mean)
        //{
        //    mean = (a + b + c + d + e) / 5;
        //}

        //public static void Plus(int a, int b, out int c)
        //{
        //    c = a + b;
        //}

        //public static void Plus(double x, double y, out double c)
        //{
        //    c = x + y;
        //}
        #endregion
        #region 가변 길이의 인수 혹은 가변길이 매개변수
        //static int Sum(params int[] args) //입력 받는 길이를 예측하지 못할 때 params를 자료형 앞에 붙여 쓴다.
        //{
        //    int sum = 0;
        //    foreach (int arg in args)
        //        sum += arg;
        //    return sum;
        //}
        #endregion
        #region 로컬함수 선언
        //static string ToLowerTostring(string input) //클래스에 속한 멤버함수
        //{
        //    var arr = input.ToCharArray(); // 입력을 char배열로 받아 var에 저장

        //    for(int i = 0; i<arr.Length; i++)
        //    {
        //        arr[i] = ToLowerChar(i); // 대소문자 검사 -> 소문자로 바뀐다.
        //    }

        //    char ToLowerChar(int i) //로컬함수 - 매소드안에 선언된 함수
        //    {
        //        if (arr[i] < 65 || arr[i] > 90) //A~Z의 아스키 값 65~90 을 제외하고 그대로 출력
        //            return arr[i];
        //        else // 위에서 남은 65~90에 32 더하기 -> 소문자 출력, a~z 아스키 코드 값 : 97~122
        //            return (char)(arr[i]+32);
        //    }

        //    return new string(arr);
        //}
        #endregion
    }
}
