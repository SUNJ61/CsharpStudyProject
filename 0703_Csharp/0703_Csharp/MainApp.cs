using System;
using static System.Console;
using System.Threading.Tasks;
using System.Numerics;
using System.Xml.Serialization;

namespace _0703_Csharp
{
    #region 인스턴스 필드와 정적 필드 (선언)
    class MyClass
    {
        public int a; //인스턴스 필드
        public int b; //인스턴스 필드
    }

    class YourClass
    {
        public static int a; //정적 필드
        public static int b; //정적 필드
    }
    #endregion
    #region 객체 복사하기 (선언)
    public class Paste()
    {
        public int MyField1;
        public int MyField2;
        public Paste newPaste()
        {
            Paste newSource = new Paste(); //객체를 힙에 새로 할당
            newSource.MyField1 = this.MyField1; //자신의 멤버를 일일이 복사한다.
            newSource.MyField2 = this.MyField2;
            return newSource;
        }
    }
    #endregion
    #region this키워드 (선언)
    class Emeloyee()
    {
        private string Name;
        private string Position;

        public void SetName(string Name) //보호된 변수를 외부에서 수정하기 위한 매소드
        {
            this.Name = Name; //매개변수와 멤버변수가 같기때문에 멤버변수 앞에 this(= 본인 클래스명)를 붙여 알려준다.
        }
        public string GetName() // 보호된 변수를 외부에 반환하기 위한 매소드
        {
            return Name;
        }
        public void SetPosition(string Position)
        {
            this.Position = Position;
        }
        public string GetPosition()
        {
            return Position;
        }
    }
    #endregion
    #region this 생성자 (선언)
    class YouClass //this 생성자 없이 생성자 만들기
    {
        public int a, b, c;
        public YouClass()
        {
            this.a = 5425;
        }
        public YouClass(int b) :this()
        {
            //this.a = 5425;
            this.b = b;
        }
        public YouClass(int b, int c) :this(b)
        {
            //this.a = 5425; //매개변수 달라져 새 생성자에서 계속 선언함에 따라 비효율적임.
            //this.b = b;
            this.c = c;
        }
    }
    class My1Class //this 생성자를 사용하여 생성자 만들기
    {
        public int a, b, c;

        public My1Class()
        {
            this.a = 5425;
        }
        public My1Class(int b) :this() // this() : 매개변수가 없는 기본생성자를 호출
        {
            this.b= b;
        }

        public My1Class(int b, int c) :this(b) // this(b) : 매개변수가 b인 생성자를 호출
        {
            this.c = c;
        }
    }
    #endregion
    #region 접근 한정자(선언)
    class WaterHeater //비데 물온도 조절
    {
        protected int temperature;
        public void SetTemperature(int temperature)
        {
            if(temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range"); //예외처리 (이상온도 제어), 이상온도가 나오면 try구문에 던짐
            }
            this.temperature = temperature;
        }
        internal void TurnOnWater()
        {
            WriteLine($"Turn on water : {temperature}º");
        }
    }
    #endregion
    internal class MainApp
    {
        public static void Main(string[] args)
        {
            #region 인스턴스 필드와 정적 필드 (메인)
            //MyClass my = new MyClass();
            //my.a = 10;
            //my.b = 20;

            //YourClass.a = 10; // static으로 선언한 필드는 프로그램 전체에 걸쳐 하나밖에 존재하지 않는다.
            //YourClass.b = 20; // 즉, 프로그램 전체에 공유해야하는 변수가 있다면 정적필드를 이용한다.

            //WriteLine($"a : {my.a} b : {my.b}");
            //WriteLine($"a : {YourClass.a} b : {YourClass.b}");
            #endregion
            #region 객체 복사하기 (메인)
            //WriteLine("----------------------------swallowCopy---------------------------------");
            //{ //아래와 위 각각 서로 다른 공간을 만들기 위해 중괄호를 침
            //    Paste source = new Paste();
            //    source.MyField1 = 10;
            //    source.MyField2 = 20;

            //    Paste target = source; //객체의 복사가 일어났다.  얕은 복사
            //    target.MyField2 = 30; // source.myfield2, target.myfield2 는 같은 주소를 가지기 때문에 둘다 30으로 바뀐다.

            //    WriteLine($"source : {source.MyField1},{source.MyField2}");
            //    WriteLine($"target : {target.MyField1},{target.MyField2}");
            //}
            //WriteLine("----------------------------deepCopy------------------------------------");
            //{
            //    Paste source = new Paste();
            //    source.MyField1 = 10;
            //    source.MyField2 = 20;

            //    Paste target = source.newPaste(); //객체의 복사가 일어났다.  얕은 복사
            //    target.MyField2 = 30; // source.myfield2, target.myfield2 는 같은 주소를 가지기 때문에 둘다 30으로 바뀐다.

            //    WriteLine($"source : {source.MyField1},{source.MyField2}");
            //    WriteLine($"target : {target.MyField1},{target.MyField2}");
            //}
            #endregion
            #region this키워드 (메인)
            //Emeloyee pooh = new Emeloyee();
            //pooh.SetName("pooh");
            //pooh.SetPosition("Waiter");

            //WriteLine($"이름 : {pooh.GetName()}, 직업 : {pooh.GetPosition()}");

            //Emeloyee tigger = new Emeloyee();
            //tigger.SetName("호랑이");
            //tigger.SetPosition("동물");
            //WriteLine($"이름 : {tigger.GetName()}, 직업 : {tigger.GetPosition()}");
            #endregion
            #region this 생성자 (메인)
            //YouClass youClass = new YouClass();
            //WriteLine(youClass.a);
            //YouClass youClass1 = new YouClass(10);
            //WriteLine($"{youClass1.a} {youClass1.b}");
            //YouClass youClass2 = new YouClass(10,30);
            //WriteLine($"{youClass2.a} {youClass2.b} {youClass2.c}");

            //My1Class my1Class = new My1Class(50,70);
            //WriteLine($"{my1Class.a} {my1Class.b} {my1Class.c}");
            #endregion
            #region 접근 한정자(메인)
            //try //오류가 발생할 만한 지역에 try구문을 사용한다.
            //{
            //    WaterHeater heater = new WaterHeater();
            //    heater.SetTemperature(20);
            //    heater.TurnOnWater();
            //    heater.SetTemperature(-2);
            //    heater.TurnOnWater();

            //    heater.SetTemperature(50);
            //    heater.TurnOnWater();
            //}
            //catch (Exception e) //던진 구문을 받아서 출력함
            //{
            //    WriteLine($"{e.Message}");
            //}
            #endregion
            #region 가위바위보 게임
            //int ran = 0;
            //int Sel = 0;
            //string[] choice = { "가위", "바위", "보" };
            //ran = (new Random()).Next(1,4);

            //Write("1(가위) 2(바위) 3(보) 입력 : \b");
            //Sel = Convert.ToInt32(ReadLine());

            //WriteLine($"사용자 : {choice[Sel-1]}");
            //WriteLine($"컴퓨터 : {choice[ran-1]}");

            //if(Sel == ran)
            //    Console.WriteLine("비김");
            //else
            //{
            //    switch(Sel)
            //    {
            //        case 1:
            //            Console.WriteLine((ran == 3) ? "승" : "패");
            //            break;
            //        case 2:
            //            Console.WriteLine((ran == 1) ? "승" : "패");
            //            break;
            //        case 3:
            //            Console.WriteLine((ran == 2) ? "승" : "패");
            //            break;
            //    }
            //}
            #endregion
            #region 쪽지시험
            //long[] longArray = { 1, 2, 3, 4 };
            //for(int i = 0;  i < longArray.Length; i++)
            //{
            //    longArray[i] += 1;
            //    WriteLine(longArray[i]);
            //}
            #endregion
        }
    }
}
