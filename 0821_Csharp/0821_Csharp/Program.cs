using System.Threading.Channels;
using static System.Console;

namespace _0821_Csharp
{
    #region 생성자
    //class Say //this생성자로 다른 생성자 호출
    //{
    //    private string message = "[1]안녕하세요";
    //    public Say() => WriteLine(this.message);

    //    public Say(string meaage) : this() //this()는 매개변수가 없는 생성자인 Say()를 상속 받는다.
    //    {
    //        this.message = meaage;
    //        WriteLine(this.message);
    //    }
    //}
    //class Money //생성자 포워딩
    //{
    //    public Money() : this(1000) { } //보이드 생성자는 매개변수가 1개인 생성자를 상속 받는다.
    //    public Money(int money) => WriteLine("Money : {0:#,###}", money); //매개변수가 1개인 생성자.
    //}
    //public class WhitchService //생성자를 사용하여 읽기전용 필드 초기화
    //{
    //    private readonly string _serviceName; //생성자를 통해서만 읽기전용 필드를 초기할 수 있다. 초기화 하면 상수처럼 된다.
    //    public WhitchService(string serviceName)
    //    {
    //        _serviceName = serviceName;
    //    }
    //    public string ServiceName
    //    {
    //        get { return _serviceName; }
    //    }
    //}
    //class Pet //식 본문 생성자.
    //{
    //    private string _name;

    //    public Pet(string name) => _name = name; //람다식을 사용하여 생성자를 줄여 표현한다. 이것을 식 본문 생성자라고 한다.
    //    public string Name
    //    {
    //        get { return _name; }
    //    }
    //}
    #endregion
    #region 소멸자 (C#은 소멸자가 있긴하지만 가비지콜렉터가 있어 알아서 메모리를 관리한다.)
    //public class DestructorTest
    //{
    //    public DestructorTest() 
    //    {
    //        WriteLine("[1] 생성");
    //    }
    //    public void Run()
    //    {
    //        WriteLine("[2] 실행");
    //    }
    //    ~DestructorTest() //가비지콜렉터가 삭제하기 때문에 실행창에서 해당 문구가 나오지 않는다.
    //    {//프로그래머가 소멸 시점을 모르기 때문에 소멸과 관련된 코드를 실행시키기 어렵다. 이를 해결하기 위해 오브젝트 풀링을 사용했다.
    //        WriteLine("[3] 소멸");
    //    }
    //}
    //public class NewCar //소멸자를 사용하여 클래스 역할 마무리 하기.
    //{
    //    private string _name;
    //    public string Name
    //    {
    //        get{ return _name; }
    //    }
    //    public NewCar()
    //    {
    //        _name = "승용차";
    //    }
    //    public NewCar(string name)
    //    {
    //        _name = name;
    //    }
    //    ~NewCar() //가비지 콜렉터가 처리한다고 하더라도 소멸자는 쓰는것이 좋다.
    //    {
    //        WriteLine($"{_name} 폐차...");
    //    }
    //}
    //public class Car //생성자,메서드,소멸자 함께 사용하기.
    //{
    //    private string color;

    //    public Car()
    //    {
    //        color = "검은";
    //        WriteLine($"{color}색 자동차를 조립합니다.");
    //    }
    //    public Car(string newcolor)
    //    {
    //        color = newcolor;
    //        WriteLine($"{color}색 자동차를 조립합니다.");
    //    }
    //    public string Go //메서드를 프로퍼티로 교체하였음.
    //    {
    //        get { return $"{color}색 자동차가 달립니다."; }
    //    }
    //}
    #endregion
    #region

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 생성자
            //new Say("[2]잘가요"); //상속 받은 보이드 생성자도 같이 호출 된다.

            //var basic = new Money(); //보이드 생성자 호출, 보이드 생성자는 매개변수가 1개인 생정자에 1000을 넣는 것을 상속 받아 출력하기 때문에 1,000출력
            //var bonus = new Money(2000); //매개변수가 1개인 생성자를 호출, 2,000출력

            //var file = new WhitchService("[1] 파일로그");
            //WriteLine(file.ServiceName + " 기능을 실행합니다."); //프로퍼티로 불러옴

            //var db = new WhitchService("[2] DB로그");
            //WriteLine(db.ServiceName + " 기능을 실행합니다."); //프로퍼티로 불러옴

            //var pet = new Pet("야옹이");
            //WriteLine(pet.Name);
            #endregion
            #region 소멸자
            //DestructorTest test = new DestructorTest();
            //test.Run();

            //NewCar car = new NewCar();
            //WriteLine(car.Name);
            //NewCar newcar = new NewCar("캠핑카");
            //WriteLine(newcar.Name);

            //Car car1 = new Car();
            //WriteLine(car1.Go);
            //Car car2 = new Car("하얀");
            //WriteLine(car2.Go);
            //Car car3 = new Car("파란");
            //WriteLine(car3.Go);
            #endregion
            #region

            #endregion
        }
    }
}
