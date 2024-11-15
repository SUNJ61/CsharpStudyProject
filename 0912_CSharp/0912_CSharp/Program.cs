using System.Buffers;
using System.Collections;
using static System.Console;

namespace _0912_CSharp
{
    #region 인터페이스
    interface ICar //인터페이스 구현해보기
    {
        void Go();
    }
    class Car : ICar
    {
        public void Go() => WriteLine("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야 한다.");
    }


    public interface IRepository //인터페이스형식 객체에 인스턴스 담기
    {
        void Get();
    }
    public class Repository : IRepository //인터페이스는 클래스에 상속된 이후로 부터 객체 생성이 가능해진다.
    {
        public void Get() => WriteLine("Get() 메소드를 구현해야 합니다.");
    }


    interface IBattery //생성자의 매개변수에서 인터페이스 사용하기.
    {
        string GetName(); //string 반환
    }
    class Good : IBattery
    {
        public string GetName() => "Good";
    }
    class Bad : IBattery
    {
        public string GetName() => "Bad";
    }


    interface IAnimal
    {
        void Eat();
    }
    interface IDog
    {
        void Yelp();
    }
    class Dog : IAnimal, IDog//인터페이스를 이용한 다중 상속 (하나의 클래스에 여러개의 부모가 존재), 이때 두 인터페이스에 같은 이름의 메소드가 존재할 경우 명시적으로 함수에 표시해주어야 한다.
    {
        public void Eat() => WriteLine("먹음"); //만약 둘다 Eat함수였다면 -> void IAnimal.Eat()
        public void Yelp() => WriteLine("짖음"); //만약 둘다 Eat함수였다면 -> void IDog.Eat() 
    }


    public class Toilet : IDisposable //닷넷에 내장된 IDisposable 인터페이스 사용하기.
    {
        public void Dispose()
        {
            Console.WriteLine("[3] 닫기");
        }
    }


    public interface IStandard { void Run(); } //인터페이스를 사용하여 멤버이름 강제로 적용하기
    public abstract class KS //추상 클래스
    {
        public abstract void Back();
        public void Left() => WriteLine("좌회전");
    }
    public partial class MyCar : KS  //추상 클래스 상속
    {
        public override void Back() => WriteLine("후진"); //강제 구현
    }
    public partial class MyCar : KS //추상 클래스 상속
    {
        public void Right() => WriteLine("우회전"); //추가로 제작
    }
    public sealed class Car1 : MyCar, IStandard //분할 클래스와, 인터페이스 상속 => sealed 때문에 이 이하로 더이상 상속 불가
    {
        public void Run() => WriteLine("전진"); //인터페이스 구현
    }
    #endregion
    #region 인터페이스 문제 1
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }
    class FlyingCar : IRunnable, IFlyable
    {
        public void Run() => Write("Run! Run! ");
        public void Fly() => Write("Fly! Fly! ");
    }
    #endregion
    #region 인터페이스 문제 4
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public void Display() => WriteLine($"Shape Area Result");
    }

    //위에 추상 클래스 만들기.
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 재귀함수
            //Recursive(3);


            //Console.WriteLine(($"1! = {Factorial(1)}"));
            //Console.WriteLine(($"2! = {Factorial(2)}"));
            //Console.WriteLine(($"3! = {Factorial(3)}"));
            //Console.WriteLine(($"10! = {Factorial(10)}"));


            //for(int i = 1; i<15; i++) //피보나치 수열 증가 로직
            //    Console.Write($"{Fibo(i)} ");
            //Fibo(7); //피보나치 수열 순서를 보기위해 추가
            #endregion
            #region 이진 탐색을 재귀함수로 구현하기
            //List<int> arr = new List<int> { 1, 3, 5, 7, 9, 11, 22, 57, 66 };
            //int idx;

            //idx = BinarySearch(arr, 7, arr.Count);

            //if (idx == -1)
            //    Console.WriteLine("탐색 실패");
            //else
            //    Console.WriteLine($"타겟 저장 인덱스 : {idx} / 해당 인덱스 출력 : {arr[idx]}");
            #endregion
            #region 인터페이스
            //var car = new Car();
            //car.Go(); // 클래스에서 인터페이스를 구현한대로 출력됨.


            //IRepository repository = new Repository(); //인터페이스 형식 객체에 인스턴스 담기 (인터페이스 객체에 해당 인터페이스를 상속한 클래스(인스턴스)를 담아 구현 할 수 있다.)
            //repository.Get();


            //var good = new Program(new Good()); //IBattery를 구현한 Good클래스를 매개변수로 사용
            //good.Run();
            //new Program(new Bad()).Run(); //IBattery를 구현한 Bad클래스를 매개변수로 사용, 생성과 동시에 함수 호출


            //Dog dog = new Dog();
            //dog.Eat(); // 만약 둘다 Eat함수였다면 -> ((IAnimal)dog).Eat();
            //dog.Yelp(); // 만약 둘다 Eat함수였다면 -> ((IDog)dog).Eat();


            //string[] names = {"lee","pack" };
            //foreach (string name in names)
            //    Console.WriteLine(name);

            //IEnumerator list = names.GetEnumerator(); //IEnumerator인터페이스 사용하기. 컬렉션을 순회하는 방법을 정의한 인터페이스 이다.
            //while (list.MoveNext()) //배열을 한칸씩 이동하여 끝까지 가면 정지
            //{
            //    Console.WriteLine(list.Current); //현재 해당되는 데이터 추력
            //}


            //Console.WriteLine("[1] 열기");
            //using (var t = new Toilet()) // using은 IDispose인터페이스로 구현한 함수를 불러온다. t에 Toilet()을 할당 후 아래 프로세스를 종료하면 Dispose() 실행하도록 한다.
            //{
            //    Console.WriteLine("[2] 사용"); //이 프로세스가 불려진 후 Toilet()안에 있는 Dispose()가 실행된다.
            //}


            //Car1 cla =new Car1();
            //cla.Run(); cla.Left(); cla.Right(); cla.Back();
            #endregion
            #region 인터페이스 문제 1
            //FlyingCar car = new FlyingCar(); //메인만 보고 인터페이스 구현 하기 , car객체에 FlyingCar클래스 할당
            //car.Run();
            //car.Fly();
            //IRunnable runnable = car as IRunnable; //car가 상속한 IRunnable인터페이스를 runnable에 할당
            //runnable.Run();

            //IFlyable flyable = car as IFlyable;//car가 상속한 IFlyable인터페이스를 flyable에 할당
            //flyable.Fly();
            #endregion
            #region 인터페이스 문제 4
            Shape circle = new Circle(5);
            circle.Display();
            Console.WriteLine("Circle Area: " + circle.CalculateArea());

            Shape rectangle = new Rectangle(4, 6);
            rectangle.Display();
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());

            #endregion
        }
        #region 재귀함수
        public static void Recursive(int n)
        {
            if (n <= 0)
                return; //무한 재귀를 방지

            Console.WriteLine($"Recursive call! {n}");
            Recursive(n-1); //자기 자신 메소드를 다시 불러옴 -> 재귀
        }


        public static int Factorial(int n)
        {
            if(n == 0)
                return 1;
            else
                return n* Factorial(n-1);
        }


        public static int Fibo(int n) //피보나치 수열, n = 1일 때와 n = 2일 때 값이 정해져 있으면 이후의 값을 n이전의 2개의 값(n-1과 n-2)을 더해 나오는 수이다.
        {
            //Console.WriteLine($"n의 값 <<{n}>>으로 호출 됨"); //피보나치 수열 순서를 보기위해 추가
            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;
            else
                return Fibo(n-1) + Fibo(n-2); //Fibo(n-1)이 쭉 실행 되고, 해당 Fibo(n-1)에 제일 하위 노드인 Fibo(2)부터 파생된 Fibo(n-2)를 출력 (Fibo(2)는 Fibo(n-2)가 없으므로 Fibo(3)부터 출력),
        }
        #endregion
        #region 이진 탐색을 재귀함수로 구현하기
        static int BinarySearch(List<int> list, int target, int last, int first = 0)
        {
            int mid;

            mid = (last + first) / 2;


            if (last < first)
                return -1;

            if (target == list[mid])
            {
                return mid;
            }
            else
            {
                if (target < list[mid])
                    return BinarySearch(list, target, mid - 1);
                else
                    return BinarySearch(list, target, last, mid + 1);
            }
        }
        #endregion
        #region 인터페이스
        private IBattery _battery; //Program클래스 안에서 인터페이스 변수 선언.
        public Program(IBattery battery) //인터페이스를 매개변수로 사용
        {
            _battery = battery; //인터페이스를 구현한 클래스에서 함수를 제공. 
        }
        public void Run() => WriteLine($"{_battery.GetName()} 배터리를 장착한 자동차가 달립니다.");
        #endregion
    }
}
