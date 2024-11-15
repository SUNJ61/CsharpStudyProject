using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;
using static System.Console;

namespace _0712_Csharp
{
    #region 인터페이스에 인터페이스 상속
    //interface Ilogger //메세지를 띄운다.
    //{
    //    void WriteLog(string message);
    //}
    //interface IFormattable : Ilogger //서식대로 메세지를 출력하려고 상속을 받음
    //{
    //    void WriteLog(string format, params Object[] args); //상속을 받았다, 그러면서 매개변수가 달라짐.
    //}
    //class ConsoleLogger2 : IFormattable
    //{
    //    public void WriteLog(string message)
    //    {
    //        WriteLine($"1 : {DateTime.Now.ToLocalTime()} : {message}"); //함수가 불려진 시간과 메세지를 출력한다.
    //    }

    //    public void WriteLog(string format, params object[] args)
    //    {
    //        String message = String.Format(format, args);
    //        WriteLine($"2 : {DateTime.Now.ToLocalTime()} : {message}");
    //    }
    //}
    #endregion
    #region 여러개의 인터페이스 상속
    //interface IRunnable
    //{
    //    void Run();
    //}
    //interface IFlyable
    //{
    //    void Fly();
    //}
    //class FlyingCar : IRunnable, IFlyable //클래스 내에서 여러개의 인터페이스를 상속 받을 수 있다.
    //{
    //    public void Run() //즉, 다양한 기능을 인터페이스로 분류하고 하나의 클래스에서 모두 불러와 합칠 수 있다.
    //    {
    //        WriteLine("Run!Run!");
    //    }
    //    public void Fly() //또한 불러오는 인터페이스의 함수의 기능을 마음대로 추가할 수 있다.
    //    {
    //        WriteLine("Fly!Fly!");
    //    }
    //}
    #endregion
    #region 추상클래스
    //abstract class AbstractBase // 추상클래스는 인터페이스와 달리 함수의 선언이 가능하다. 인터페이스처럼 선언된 함수를 가질수도 있다.
    //{
    //    protected void PrivateMethodA() //추상클래스의 속한 함수들은 구현이 가능하다.
    //    {
    //        WriteLine("AbstractBase.PrivateMethodA()");
    //    }
    //    public void PublicMethodB()
    //    {
    //        WriteLine("AbstractBase.PublicMethodB()");
    //    }
    //    protected void PrivateMethodC() //추상클래스의 속한 함수들은 구현이 가능하다.
    //    {
    //        WriteLine("AbstractBase.PrivateMethodC()");
    //    }
    //    public abstract void AbstractMethodA(); //추상매소드, 추상매소드는 인터페이스 처럼 선언만 가능하다.
    //}

    //class Derived : AbstractBase
    //{
    //    public override void AbstractMethodA() //추상클래스의 선언만 된 함수를 재정의 해주어야 한다.
    //    {
    //        WriteLine("Derived.PrivateMethodA()"); //추상클래스에서 선언된 함수에 기능을 추가 할 수있다.
    //        PrivateMethodA(); // 추상클래스의 함수를 불러 올 수 있다. 이 선언된 함수를 자식클래스에서 재정의 한다면
    //        PrivateMethodC(); // 부모클래스에 있는 함수가 가려진다.
    //    }
    //    public void PrivateMethodC()
    //    {
    //        WriteLine("Derived.PrivateMethodC()");
    //    }
    //}
    #endregion
    #region 프로퍼티
    //class MyClass
    //{
    //    private int myField;
    //    public int GetMyField() //보호된 변수를 읽기 위해 접근 가능한 함수를 만들었다.
    //    {
    //        return myField;
    //    }
    //    public void SetMyField(int myField) //보호된 변수를 변경하기위해 접근 가능한 함수를 만들었다.
    //    {
    //        this.myField = myField; // 클래스 필드 = 함수에 들어온 변수
    //    }
    //}

    //class YourClass
    //{
    //    private int yourField;
    //    public int YourField //함수안에 get, set모두 정의하지 않아도 된다. 둘중 하나만 정의해도 됨.
    //    {
    //        get { return yourField; } //읽어오는 프로퍼티 (get)
    //        set { yourField = value; } //수정하는 프로퍼티 (set)
    //    }
    //}
    #endregion
    #region 프로퍼티 예제 + 프로퍼티와 생성자
    //class BirthdayInfo
    //{
    //    private string name; //멤버필드는 private선언, 소문자로 선언한다.
    //    private DateTime birthday;
    //    public string Name
    //    {
    //        //get { return name; }
    //        //set { name = value; }
    //        get;
    //        set;
    //    }
    //    public DateTime Birthday
    //    {
    //        //get { return birthday; }
    //        //set { birthday = value; }
    //        get;
    //        set;
    //    }

    //    public int Age
    //    { //생일과 현재시간의 차이를 나타낸다.
    //        get { return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year; }
    //        /*
    //        DateTime.Now는 현재 시각을 나타내는 DateTime객체를 가져온다.
    //        Sybtract는 현재시각에서 입력받은 변수를 빼서 두날짜 사이의 시간차이를 나타내는 TimeSpan객체를 생성
    //        ticks는 TimeSpan객체의 Ticks속성은 시간 차이를 가장작은 단위로 변환하여 반환, 1틱은 100나노초이다.
    //        이렇게 생성된 Datetime객체는 1900년 1월1일부터 틱수만큼 경과한 시각을 나타낸다.
    //        */
    //    }
    //}
    #endregion
    #region 자동구현 프로퍼티
    //public class NameCard
    //{
    //    private string name;
    //    private string phonenumber;
    //    public string Name
    //    {
    //        //get { return name; }
    //        //set { name = value; }
    //        get; //이런식으로도 선언가능
    //        set;
    //    } = "Unknown"; //입력되지 않았을 때 출력 (닷넷 7.0부터 지원)
    //    public string Phonenumber
    //    {
    //        //get { return phonenumber; }
    //        //set { phonenumber = value; }
    //        get;
    //        set;
    //    } = "000-0000-0000"; //입력되지 않았을 때 출력
    //}//이전예제에 Age를 받아오던 프로퍼티는 내부에 식이 선언 것과 같이 자동구현으로 사용하면 안되는 것도 있다.
    #endregion
    #region 쪽지시험
    //class NameCD
    //{
    //    private int age;
    //    private string name;

    //    public int Age
    //    {
    //        get;
    //        set;
    //    } = 0;
    //    public string Name
    //    {
    //        get;
    //        set;
    //    } = "Unknown";
    //}
    //class A
    //{
    //    private int num1;
    //    private int num2;

    //    public int Num1
    //    {
    //        get;
    //        set;
    //    }
    //    public int Num2
    //    {
    //        get;
    //        set;
    //    }
    //}
    #endregion
    internal class MainApp
    {
        static void Main(String[] args)
        {
            #region 인터페이스에 인터페이스 상속
            //IFormattable logger = new ConsoleLogger2();
            //logger.WriteLog(" The world is not flat");
            //logger.WriteLog($" {1} + {1} = {2}");
            #endregion
            #region 여러개의 인터페이스 상속
            //FlyingCar car = new FlyingCar();
            //car.Run();
            //car.Fly();

            //IRunnable runnable = car as IRunnable; //만든 car객체를 Run함수만 선언한 인터페이스로 형변환 했다. 
            //runnable.Run(); //기능은 그대로 남아 있지만 기존의 클래스의 Fly함수는 사용할 수 없다.
            //IFlyable flyable = car as IFlyable; //만든 car객체를 Fly함수만 선언한 인터페이스로 형변환 했다. 
            //flyable.Fly(); //기능은 그대로 남아 있지만 기존의 클래스의 Fly함수는 사용할 수 없다.
            #endregion
            #region 추상클래스
            //AbstractBase obj = new Derived();
            //obj.AbstractMethodA();
            //WriteLine("");
            //obj.PublicMethodB(); //자식클래스를 통해 부모 클래스의 함수를 불러올 수 있다.
            #endregion
            #region 프로퍼티
            //MyClass obj = new MyClass();
            //obj.SetMyField(3);
            //WriteLine(obj.GetMyField());//현재 c++이나 자바가 접근하는 방법

            //YourClass obj2 = new YourClass();
            //obj2.YourField = 4; //자동으로 set이 불러와짐
            //WriteLine(obj2.YourField); //자동으로 get이 불러와짐
            #endregion
            #region 프로퍼티 에제
            //BirthdayInfo birth = new BirthdayInfo();
            //birth.Name = "우영우"; //클래스안에 보호된 변수에 이름, 생일을 입력
            //birth.Birthday = new DateTime(1991, 6, 28);

            //WriteLine($"Name : {birth.Name}");
            //WriteLine($"Birthday : {birth.Birthday}");
            //WriteLine($"Age : {birth.Age}"); //age는 프로퍼티이긴하지만 은닉되어있지 않다.
            ////get만 있을 경우 그 결과값을 계속 가지고있는다.
            #endregion
            #region 자동구현 프로퍼티
            //NameCard card = new NameCard();
            //WriteLine($"Name : {card.Name}, Phonenumber : {card.Phonenumber}");
            //card.Name = "이해준";
            //card.Phonenumber = "010-7566-0601";
            //WriteLine($"Name : {card.Name}, Phonenumber : {card.Phonenumber}");
            #endregion
            #region 프로퍼티와 생성자 (프로퍼티 예제 사용)
            ///*
            // 기존에는 객체가 생성할 때 매개변수를 받아 객체의 각필드를 초기화 
            // 객체를 생성할 때 각 필드를 초기화 하는 다른 방법은 프로퍼티를 이용한 초기화 방법이다.
            //*/
            //BirthdayInfo birch = new BirthdayInfo() 
            //{
            //    Name = "주현영", Birthday = new DateTime(1995, 3, 27)
            //}; //객체를 만들고 바로 프로퍼티로 내부 필드 초기화, C#은 이방법을 주로 사용

            //WriteLine($"Name : {birch.Name}, Birthday : {birch.Birthday}");
            #endregion
            #region 쪽지시험
            //NameCD MyCard = new NameCD()
            //{
            //    Age = 24, Name = "상현"
            //};
            //WriteLine($"나이 : {MyCard.Age}");
            //WriteLine($"이름 : {MyCard.Name}");
            //A num = new A()
            //{
            //    Num1 = 1, Num2 = 2
            //};
            //WriteLine($"num1 : {num.Num1}, num2 : {num.Num2}");
            #endregion
        }
    }
}
