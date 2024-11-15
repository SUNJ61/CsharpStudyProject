using System.Globalization;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Xml.Serialization;
using static System.Console;

namespace _0708_Csharp
{
    #region 클래스 상속 (선언)
    //class Base
    ////sealed class Base //sealed를 사용하면 자식클래스에게 상속을 하지 않을 수 있다.
    //{
    //    protected string Name; //상속된 함수에게 public, 나머지 외부 필드에는 private
    //    protected int PhoneNum;
    //    public Base()
    //    {
    //        Name = string.Empty;
    //        PhoneNum = 0;
    //        WriteLine("Base()");
    //    }
    //    public Base(string Name)
    //    {
    //        this.Name = Name;
    //        WriteLine($"Base() : {Name}");
    //    }
    //    public Base(string Name, int PhoneNum) : this(Name)
    //    {
    //        this.PhoneNum = PhoneNum;
    //        WriteLine($"Base() : {Name},{PhoneNum}");
    //    }
    //    ~Base()
    //    {
    //        WriteLine("~Base()");
    //    }
    //}
    //class Derived : Base //Derived 클래스는 Base클래스를 상속했다. 즉, Base는 부모클래스 Derived는 자식클래스가 된다.
    //{
    //    public Derived() : base()
    //    {
    //        WriteLine($"Derived()");
    //    }
    //    public Derived(string Name) : base(Name) //매개변수가 1개인 부모클래스의 생성자를 호출
    //    {
    //        WriteLine($"Derived() : {Name}");
    //    }
    //    public Derived(string Name, int PhoneNum) : base(Name,PhoneNum) //매개변수가 2개인 부모클래스의 생성자를 호출
    //    {
    //        WriteLine($"Derived() : {Name},{PhoneNum}");
    //    }
    //    public void SetPrint() //info함수
    //    {
    //        WriteLine($"이름 : {Name}, 전화번호 : {PhoneNum}");
    //    }
    //    ~Derived()
    //    {
    //        WriteLine("~Derived()");
    //    }
    //}
    #endregion
    #region 기반(부모)클래스와 파생(자식)클래스 사이의 형식 변환(선언)
    //class Mammal //포유류
    //{
    //    public void Nurse()
    //    {
    //        WriteLine("Nurse()");
    //    }
    //}
    //class Dog : Mammal
    //{
    //    public void Bark()
    //    {
    //        WriteLine("Bark()");
    //    }
    //}
    //class Cat : Mammal
    //{
    //    public void Meow()
    //    {
    //        WriteLine("Meow()");
    //    }
    //}
    #endregion
    #region 클래스 오버라이딩과 다형성 (선언)
    //class ArmorSuite
    //{
    //    public virtual void Initialize() // virtual은 가상 매소드 -> 자식클래스로 오버라이딩될 것을 선언.
    //    {
    //        WriteLine("Armored");
    //    }
    //}
    //class Ironman : ArmorSuite
    //{
    //    public override void Initialize() // 부모클래스 ArmorSuite의 initialize함수를 오버라이딩 했다.
    //    { //즉, 함수를 재정의 하여 다르게 사용할 것이라고 선언 하는 것. (입력 받는 매개변수는 같아야 함)
    //        base.Initialize(); // 부모클래스의 기능을 그대로 사용.
    //        WriteLine("Repulsor Ray Armed"); // 새로운 기능을 추가로 사용함.
    //    }
    //}
    //class WarMarchine : ArmorSuite
    //{
    //    public override void Initialize() // 또 다른 자식클래스에서 오버라이딩.
    //    {//부모클래스의 기능만 상속받고 자식클래스끼리는 기능이 다름.
    //        base.Initialize(); // 부모클래스의 기능을 그대로 사용.
    //        WriteLine("Double Barrel Cannon Armed"); // 새로운 기능을 추가로 사용함.
    //    }
    //}
    #endregion
    #region 매소드 숨기기 (선언)
    //class Base1
    //{
    //    public  void MyMethod()
    //    {
    //        WriteLine("Base1.MyMethod");
    //    }
    //}
    //class Derived1 : Base1
    //{
    //    public new void MyMethod() //new는 부모클래스의 같은 함수를 오버라이딩하고 부모클래스의 함수를 숨겨주는 지시자.
    //    {
    //        WriteLine("Derived.MyMethod()");
    //    }
    //}
    #endregion
    #region 읽기 전용 필드(선언)
    class Configuration
    {
        private readonly int min; // readOnly로 읽기전용 필드 선언 : 생성자에서만 수정이 가능하다.
        private readonly int max;
        public Configuration(int v1, int v2) //외부에서 이 생성자를 통해 보호된 두 변수를 수정 가능하다.
        {
            min = v1; //읽기 전용 필드는 생성자 안에서만 초기화 가능하다.
            max = v2;
        }
        public void ChangeMax(int NewMax)
        {
            //max = NewMax; // 생성자가 아닌 다른 곳에서 값을 수정하려 하면 컴파일에러가 발생한다.
        }
        public void Print()
        {
            WriteLine($"{min} {max}"); //읽기는 가능하다.
        }
    }
    #endregion
    #region 중첩 클래스
    //class Config
    //{
    //    List<ItemValue> listConfig = new List<ItemValue>(); //리스트 내부는 어떤 자료형도 들어 갈 수있다. (클래스도 자료형에 일부)
    //    public void SetConfig(string item, string value)
    //    {
    //        ItemValue iv = new ItemValue(); //리스트 동적할당.
    //        iv.SetValue(this, item, value); //리스트 iv에 Config클래스와 string item, string value를 저장
    //    }

    //    public string GetConfig(string item)
    //    {
    //        foreach (ItemValue iv in listConfig)
    //        {
    //            if (iv.GetItem() == item) //메인에 입력받은 item과 리스트안에 저장된 item이 같은지 확인.
    //                return iv.GetValue(); //이름이 같으면 저장된 아이템 인덱스에 Value값을 리턴한다.
    //        }
    //        return ""; // foreach가 안돌시 그냥 리턴
    //    }
    //    private class ItemValue //클래스 외부에 보여주기 싫은 정보가 있을 때 사용.
    //    {
    //        private string item;
    //        private string value;
    //        public void SetValue(Config config, string item, string value) //외부의 Config클래스 내용을 참조하기 위해 객체 생성
    //        {
    //            this.item = item; //ItemValue클래스 내 선언된 item변수에 입력받은 item값 저장
    //            this.value = value; //ItemValue클래스 내 선언된 value변수에 입력받은 value값 저장
    //            bool found = false; //아이템을 찾았는지 판별

    //            for (int i = 0; i < config.listConfig.Count; i++) //중첩클래스는 상위클래스 멤버에 자유롭게 접근이 가능.
    //            {
    //                if (config.listConfig[i].item == item) //Config리스트 내 item이 입력된 item과 같은지 확인
    //                {
    //                    config.listConfig[i] = this; //아이템이 같으면 해당 인덱스에 item과 value값 둘다 저장 
    //                    found = true;
    //                    break;
    //                }
    //            }
    //            if (found == false) //같은 아이템을 찾지 못할 경우 리스트 다음 인덱스에 아이템을 추가한다.
    //                config.listConfig.Add(this);
    //        }
    //        public string GetItem()
    //        {
    //            return item;
    //        }
    //        public string GetValue()
    //        {
    //            return value;
    //        }
    //    }
    //}
    #endregion
    #region 분할 클래스(선언)
    //partial class MyClass //같은 클래스를 여러번 나눠서 구현란 클래스를 말한다.
    //{
    //    public void Method1()
    //    {
    //        WriteLine("Method1()");
    //    }
    //    public void Method2()
    //    {
    //        WriteLine("Method1()");
    //    }
    //}
    //partial class MyClass //같은 내용스페이스에 같은 이름의 클래스를 여러번 선언이 가능하고 기능이 이어진다.
    //{
    //    public void Method3() //분할된 클래스에서는 이름이 같은 매소드 선언 불가.
    //    {
    //        WriteLine("Method3()");
    //    }
    //    public void Method4()
    //    {
    //        WriteLine("Method4()");
    //    }
    //}
    #endregion
    #region 확장 매소드 (선언)
    //public static class IntergerExtension //static으로 미리 할당, 정적할당. 나머지는 전부 동적 할당
    //{
    //    public static int Square(this int myInt) //this로 선언된 변수는 메인에서 확장해서 받을 수 있다.
    //    {
    //        return myInt * myInt;
    //    }
    //    public static int Power(this int myInt, int exponent)
    //    {
    //        int result = 1;
    //        for(int i = 0; i< exponent; i++)
    //        {
    //            result *= myInt;
    //        }
    //        return result;
    //    }
    //}
    #endregion
    internal class MainApp
    {
        static void Main(string[] args)
        {
            #region 클래스 상속 (메인)
            //Derived derived = new Derived("홍길동",1234);
            //// 실생시 부모클래스와 자식클래스의 생성자가 모두 호출 된다. (부모 -> 자식순으로 호출)
            //// 자식클래스는 반드시 부모클래스 생성자를 호출 하여서 초기화 해야한다.
            //// 1. 자식클래스에 매개변수 2개 입력하여 객체 생성 2. (Derived(string Name, int PhoneNum) : base(Name,PhoneNum))호출
            //// 3. 부모 클래스 Base(string Name, int PhoneNum) : this(Name)호출. 4. this생성자가 Base(string Name) 호출.
            //// 5. Base(string Name) 생성자 실행 6. Base(string Name, int PhoneNum) 생성자 실행
            //// 7. public Derived(string Name, int PhoneNum) 실행
            //derived.SetPrint();

            //Derived derived1 = new Derived("오태식이");
            //derived1.SetPrint();

            //Derived derived2 = new Derived();
            #endregion
            #region as와 is 기반클래스...형식 변환(메인)
            ////is : 객체가 해당 형식을 검사하여 같은 클래스 특성을 가지는지 판별하여 해당 결과를 bool값으로 변환
            ////as : 형식변환자 같은 역할을 한다. 다만 형식변환자는 변환에 실패하면 예외를 던지고, as는 객체참조를 null로 만든다.

            //Mammal mammal = new Dog(); //mammal은 Mammal의 객체, mammal은 Dog의 특성을 가진다.
            //Dog dog; //Dog클래스의 객체 생성.
            //if(mammal is Dog) // mammal은 Dog클래스의 특성을 가지기 때문에 true
            //{
            //    dog = (Dog)mammal;
            //    dog.Bark();
            //}

            //Mammal mammal1 = new Cat(); //mammal1이라는 객체 생성, mammal1은 Cat의 특성을 가진다. (Mammal 클래스에 속함)
            //Cat cat = mammal1 as Cat; //Cat클래스 객체는 이전 mammal1의 객체를 Cat으로 형변환 한 특징을 가진다.
            //if(cat != null) // mammal1은 Cat의 특성을 가지고 있기 때문에 형변환 가능 null값이 대입 안됨. 
            //{
            //    cat.Meow();
            //}

            //Cat cat2 = mammal as Cat; //cat2객체는 mammal의 객체를 Cat클래스로 형변환한 특징을 가진다.
            //if(cat2 != null) //mammal은 Dog의 특징을 가져서 형변환 불가능
            //    cat2.Meow();
            //else
            //{
            //    Console.WriteLine("cat2 is not a cat");
            //}
            #endregion
            #region 클래스 오버라이딩과 다형성 (메인)
            //WriteLine("Creating ArmorSute");
            //ArmorSuite suite = new ArmorSuite();
            //suite.Initialize();
            //WriteLine();

            //WriteLine("Creating Ironman......");
            //ArmorSuite ironMan = new Ironman();
            //ironMan.Initialize();
            //WriteLine();

            //WriteLine("Creating WarMarchine..");
            //ArmorSuite warmarchine = new WarMarchine();
            //warmarchine.Initialize();
            #endregion
            #region 매소드 숨기기 (메인)
            //Base1 baseObj = new Base1(); // base1타입의 변수로 base1의 MyMethod 호출
            //baseObj.MyMethod(); // 부모 클래스의 매소드 호출

            //Derived1 derivedObj = new Derived1(); // Derived1 타입의 변수로 Derived1의 MyMethod 호출
            //derivedObj.MyMethod(); // 자식 클래스의 매소드 호출

            //Base1 baseOrDerived = new Derived1(); //base1타입의 변수로 Derived의 MyMethod 호출
            //baseOrDerived.MyMethod(); // 부모 클래스 매소드 호출 (다형성을 제공하지 않아 자식 클래스 MyMethod를 호출할 수 없다.)
            #endregion
            #region 읽기 전용 필드(메인)
            //Configuration configuration = new Configuration(10, 20);
            //configuration.Print();
            #endregion
            #region 중첩 클래스 (메인)
            //Config config = new Config();
            //config.SetConfig("Version", "V 5.0");
            //config.SetConfig("Size", "655,324kb");
            //WriteLine(config.GetConfig("Version")); //value출력
            //WriteLine(config.GetConfig("Size")); //value출력

            //config.SetConfig("Version", "V 5.0.1");
            //WriteLine(config.GetConfig("Version"));//value출력
            #endregion
            #region 분할 클래스(메인)
            //MyClass myClass = new MyClass();
            //myClass.Method1();
            //myClass.Method2();
            //myClass.Method3();
            //myClass.Method4();
            #endregion
            #region 확장 매소드 (메인)
            //WriteLine($"3^2 = {3.Square()}"); // 확장된 클래스 내 확장된 함수(static으로 선언된 함수)만 해당된다.
            //WriteLine($"3^4 = {3.Power(4)}"); // this매개변수는 외부에서 받을 수 있다.
            //WriteLine($"2^10 = {2.Power(10)}");// 또한 클래스 명을 붙이지 않아도 불러올 수 있음
            #endregion
        }
    }
}
