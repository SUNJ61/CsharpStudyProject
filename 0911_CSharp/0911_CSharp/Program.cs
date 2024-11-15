using System.Collections;
using static System.Console;

namespace _0911_CSharp
{
    #region 클래스
    abstract class Gen //추상 클래스, 추상클래스가 아닌 부모 클래스는 구현 클래스라 부른다.
    {
        public abstract void SayHu();
    }
    class Person : Gen
    {
        public override void SayHu()
        {
            Console.WriteLine("1+1은? 2");
        }
    }


    public abstract class Shape //추상클래스
    {
        public abstract double GetArea(); //추상 메서드, 구현 강제
    }
    public class Square : Shape
    {
        private int _size;
        public Square(int size)
        {
            _size = size;
        }

        public override double GetArea() //상속으로 인해 구현한 메소드
        {
            return _size * _size;
        }
    }


    class Parent //자식 클래스에만 멤버 상속
    {
        private string _Word;

        protected string Word //프로퍼티를 자식에게 상속
        {
            get { return _Word; }
            set { _Word = value; }
        }
    }
    class Child : Parent
    {
        public void SetWord(string word)
        {
            base.Word = word; //상속된 프로퍼티로 접근
        }
        public string GetWord()
        {
            return Word; //상속된 프로퍼티로 접근
        }
    }


    class Job //기본 클래스의 멤버 숨기기
    {
        public void Work() => Console.WriteLine("프로그래머"); //부모클래스에서 정의된 메소드
    }
    class ChildJob
    {
        public new void Work() => Console.WriteLine("프로게이머"); //자식클래스에서 부모클래스의 메소드를 은닉하고 재정의한 메소드
    }
    #endregion
    #region 메서드 오버라이드
    public class Par //함수 재정의
    {
        public void Say() => Console.WriteLine("부모_안녕");
        public void Run() => Console.WriteLine("부모_달림");
        public virtual void Walk() => Console.WriteLine("부모_걷다");
    }

    public class Ch : Par
    {
        //public void Say() => WriteLine("자식_안녕"); //자동으로 new 처리 해버림
        public new void Run() => WriteLine("자식_달림"); //부모 함수 은닉
        public override void Walk() => WriteLine("자식_걷다"); //함수를 재정의 함.
    }


    class Animal //메소드 오버라이딩 봉인
    {
        public virtual void Eat() => WriteLine("animal Eat"); //부모 함수
    }
    class Cat : Animal
    {
        public override sealed void Eat() => Console.WriteLine("Cat Eat"); //부모 함수 재정의, sealed로 이 함수를 부모로 가진 하위 클래스에서 해당 함수 재정의를 막음.
    }


    class Son
    {
        private string name;
        public Son(string name)
        {
            this.name = name;
        }

        public override string ToString() //기존에 있는 함수 오버라이딩
        {
            return $"[Son 클래스 : {this.name}]";
        }
    }


    public class ParentClass
    {
        public virtual void Hi1() => WriteLine("기본 : hi1");
        public void Hi2() => WriteLine("기본 : hi2");
        public void Hi3() => WriteLine("기본 : hi3");
    }
    public class ChildClass : ParentClass
    {
        public override void Hi1()
        {
            Console.WriteLine("파생 : hi1"); //부모 함수 재정의
        }
        public new void Hi2() => Console.WriteLine("파생 : hi2"); //부모 함수 은닉
        public new void Hi3() => base.Hi3(); //부모 함수를 불러옴
    }

    class Parent1
    {
        public void Say() => Console.WriteLine("부모 말함");
        public void hi() => Console.WriteLine("부모 인사");
        public virtual void walk() => Console.WriteLine("부모 걸음");
    }
    class Child1 : Parent1
    {
        public void Say() => WriteLine("자식 말함"); //새롭게 정의, 부모 함수를 가림
        public new void hi() => WriteLine("자식 인사"); //부모 함수 은닉
        public override void walk() // 부모함수 재정의
        {
            Console.WriteLine("자식 걸음");
        }
    }
    #endregion
    #region 이진 탐색 알고리즘
    /*
    이진 탐색 알고리즘은 오름차순이나 내림차순으로 정렬된 배열의
    중앙 값과 원하는 값을 비교하여 해당 되지 않는 절반을 버린다.
    해당 과정을 계속하며 원하는 값을 찾는 방법
    */
    #endregion
    #region 인덱서 문제
    class MyList1
    {
        private int[] array;

        public MyList1()
        {
            array = new int[3];
        }
        public int this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                    Array.Resize(ref array, index + 1);
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }
    #endregion
    #region 인덱서 일반화 문제
    class MyList<T> : IEnumerator<T>, IEnumerable<T>
    {
        private T[] array;
        int position = -1;

        public MyList()
        {
            array = new T[3];
        }
        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                    Array.Resize(ref array, index + 1);
                array[index] = value;
            }
        }

        public T Current
        {
            get { return array[position]; }
        }

        object IEnumerator.Current
        {
            get { return array[position]; }
        }

        public void Dispose()
        {
            //공란
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if(position == array.Length -1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 클래스
            //var person = new Person(); //추상 클래스, 추상클래스가 아닌 부모 클래스는 구현 클래스라 부른다.
            //person.SayHu();


            //Square square = new Square(10);
            //Console.WriteLine(square.GetArea());
            //Shape shape =new Square(5); //추상클래스로 만들어진 객체에 자식클래스 형식을 할당 가능.
            //Console.WriteLine(shape.GetArea());


            //Child child = new Child();
            //child.SetWord("필드 숨기기 및 자식 클래스에만 멤버 상속");
            //Console.WriteLine(child.GetWord());


            //var job = new ChildJob();
            //job.Work(); //부모 클래스의 함수가 은닉됨.
            #endregion
            #region 메서드 오버라이드
            //Ch c = new Ch();
            //c.Say(); //부모 함수 재사용
            //c.Run(); //부모 함수 은닉
            //c.Walk(); //부모 함수 재정의


            //Animal animal = new Animal();
            //animal.Eat(); //재정의를 했지만 부모 함수는 그대로 출력
            //Animal cat = new Cat();
            //cat.Eat(); //재정의한 함수 출력

            //Son son = new Son("손흥민");
            //Console.WriteLine(son); //객체를 string으로 호출하면 자동으로 ToString 함수 호출


            //ChildClass child = new ChildClass();
            //child.Hi1();
            //child.Hi2();
            //child.Hi3();

            //Child1 child1 = new Child1();
            //child1.Say();
            //child1.hi();
            //child1.walk();
            #endregion
            #region 이진 탐색 알고리즘
            //List<int> arr = new List<int> { 1, 3, 5, 7, 9, 11, 22, 57, 66 };
            //int idx;

            //idx = BinarySearch(arr, 7);

            //if (idx == -1)
            //    Console.WriteLine("탐색 실패");
            //else
            //    Console.WriteLine($"타겟 저장 인덱스 : {idx} / 해당 인덱스 출력 : {arr[idx]}");

            //idx = BinarySearch(arr, 4);
            //if (idx == -1)
            //    Console.WriteLine("탐색 실패");
            //else
            //    Console.WriteLine($"타겟 저장 인덱스 : {idx}");
            #endregion
            #region 이진 탐색 알고리즘 문제
            //List<int> list1 = Enumerable.Range(1, 100).ToList();
            //Random rand = new Random(); //랜덤 객체 생성
            //Shuffle(list1, rand); //리스트 랜덤으로 섞기
            //Console.WriteLine("==============================랜덤으로 섞인 리스트======================================");
            //foreach (int number in list1)
            //{
            //    Console.Write(number + " ");
            //}

            //Bubble(list1); //오름차순으로 정렬
            //Console.WriteLine("\n==============================오름차순으로 정렬된 리스트================================");
            //foreach (int number in list1)
            //{
            //    Console.Write(number + " ");
            //}

            //int idx = BinarySearch(list1, 33);

            //Console.WriteLine("\n<<<탐색>>>");

            //if (idx == -1)
            //    Console.WriteLine("탐색 실패");
            //else
            //    Console.WriteLine($"타겟 저장 인덱스 : {idx} / 해당 인덱스 출력 : {list1[idx]}");
            #endregion
            #region 인덱서 문제
            MyList1 list = new MyList1();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
            #endregion
            #region 인덱서 일반화 문제
            MyList<int> list1 = new MyList<int>();
            for (int i = 0; i < 5; i++)
                list1[i] = i;

            foreach (int e in list1)
                Console.WriteLine(e);
            #endregion
        }
        #region 이진 탐색 알고리즘
        static int BinarySearch(List<int> list, int target)
        {
            int first = 0; //탐색 대상의 인덱스 값
            int last = list.Count - 1; //탐색 대상의 마지막 인덱스 값
            int mid; //남은 리스트 인덱스 중앙 값

            while (first <= last)
            {
                mid = (first + last) / 2; //중앙 값 찾기

                if (target == list[mid]) //해당 중앙 값이 원하는 값이라면
                {
                    return mid; //mid 인덱스 반환
                }
                else //중앙 값이 원하는 값이 아니라면 (이 아래에 조건은 오름차순으로 정렬 되었을 때만 사용)
                {
                    if (target < list[mid]) //중앙 값이 원하는 값보다 작으면
                    {
                        last = mid - 1; //리스트 상위 인덱스를 제외
                    }
                    else //중앙 값이 원하는 값보다 크면
                    {
                        first = mid + 1; //리스트보다 하위 인덱스 제외
                    }
                }
            }
            return -1; //찾지 못하면 반환
        }
        #endregion
        #region 이진 탐색 알고리즘 문제
        public static void Shuffle(List<int> list, Random rng)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static void Bubble(List<int> list)
        {
            int temp;
            for(int i = 0; i <  list.Count - 1; i++)
            {
                for(int j = 0; j < list.Count - (i+1); j++)
                {
                    if(list[j] > list[j+1])
                    {
                        temp = list[j+1];
                        list[j+1] = list[j];
                        list[j] = temp;
                    }
                    
                }
            }
        }
        #endregion
        #region 인덱서 문제

        #endregion
    }
}
