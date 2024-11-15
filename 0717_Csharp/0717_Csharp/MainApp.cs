using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
namespace _0717_Csharp
{
    #region 인터페이스의 프로퍼티
    //interface INameValue//인터페이스는 함수는 선언만 가능, 프로퍼티를 사용하면?
    //{
    //    string Name { get; set; }//자동 구현 프로퍼티로 선언 했지만 구현은 없다. C#컴파일러는 인터페이스의 프로퍼티에 대해서
    //    string Value { get; set; }//자동으로 구현해주지 않는다. 즉, 선언만 된 프로퍼티임.
    //}
    //class NamedValue : INameValue//인터페이스에서 선언된 프로퍼티는 상속받은 클래스에서 다시 구현해 주어야한다.
    //{//이때 프로퍼티를 다시 구현할 때 자동 구현 프로퍼티를 사용해도 무관하다.
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }
    //    public string Value 
    //    { 
    //        get;
    //        set;
    //    }
    //}
    #endregion
    #region 추상클래스 프로퍼티
    //abstract class Product //부모클래스는 추상클래스인 경우가 많다.
    //{
    //    private static int serial = 0;
    //    public string SerialId //추상클래스 안에 선언된 프로퍼티 (구현이 되어있음.)
    //    {
    //        get { return String.Format("{0:d5}", serial++); }
    //    }
    //    abstract public DateTime ProductDate //추상클래스안에 선언된 추상 프로퍼티
    //    {
    //        get;
    //        set;
    //    }
    //}
    //class MyProduct : Product
    //{
    //    public override DateTime ProductDate
    //    {
    //        get;
    //        set;
    //    }
    //}
    #endregion
    #region a

    #endregion
    internal class MainApp
    {
        #region 알고리즘
        //private static bool CheckPassed(int score)
        //{
        //    return score >= 60;
        //}
        //private static void Print(int value)
        //{
        //    Write($"{value} ");
        //}
        #endregion
        #region 콜렉션 리스트
        #endregion
        static void Main(string[] args)
        {
            #region 무명형식
            //var a = new { Name = "박지성", Age = 44 };
            //WriteLine($"Name : {a.Name}, Age : {a.Age}");
            //var b = new { Subject = "수학", Score = new int[] { 90, 80, 70, 60 } };
            //WriteLine($"Subject : {b.Subject}, Score : ");
            //foreach (var score in b.Score)
            //{
            //    Write($"{score} ");
            //}
            //WriteLine();
            #endregion
            #region 인터페이스의 프로퍼티
            //NamedValue nv = new NamedValue()
            //{
            //    Name = "이름",
            //    Value = "박지성"
            //};
            //NamedValue height = new NamedValue()
            //{
            //    Name = "키",
            //    Value = "177cm"
            //};
            //NamedValue weight = new NamedValue()
            //{
            //    Name = "몸무게",
            //    Value = "75kg"
            //};

            //WriteLine($"{nv.Name} : {nv.Value}");
            //WriteLine($"{height.Name} : {height.Value}");
            //WriteLine($"{weight.Name} : {weight.Value}");
            #endregion
            #region 추상클래스 프로퍼티
            //Product product1 = new MyProduct()
            //{
            //    ProductDate = new DateTime(2024,07,17)
            //};
            //WriteLine("Product : {0}, Product Date : {1}", product1.SerialId, product1.SerialId);

            //Product product2 = new MyProduct()
            //{
            //    ProductDate = new DateTime(2020, 07, 09)
            //};
            //WriteLine("Product : {0}, Product Date : {1}", product2.SerialId, product2.SerialId);
            #endregion
            #region 간단한 문제
            ////무명형식 시용하기
            //var nameCard = new { Name = "박상현", Age = 17 };
            //WriteLine("이름:{0}, 나이:{1}",nameCard.Name, nameCard.Age);

            //var Complex = new { Real = 3, Imaginary = -12 };
            //WriteLine("Real:{0}, Imaginary:{1}",Complex.Real,Complex.Imaginary);

            ////배열 합계 구하기
            //int[] scores = new int[5];
            //scores[0] = 80;
            //scores[1] = 74;
            //scores[2] = 81;
            //scores[3] = 90;
            //scores[4] = 34;

            //int sum = 0;
            //for(int i = 0; i < scores.Length; i++)
            //{
            //    WriteLine(scores[i]);
            //    sum += scores[i];
            //}
            //float avg = (float)sum / scores.Length;

            //WriteLine($"합계: {sum}, 평균: {avg}");

            //int[,] result = new int[8,9];

            //for (int i = 0; i < 8; i++)
            //{
            //    for(int j = 0; j < 9; j++)
            //    {
            //        result[i,j] = (i+2)*(j+1);
            //        Write($"{i + 2}X{j + 1}={result[i,j]} ");
            //    }
            //    WriteLine();
            //}
            #endregion
            #region 알고리즘
//            int[] scores = new int[] { 80, 74, 81, 90, 34 };
//            foreach (int score in scores)
//            {
//                Write($"{score} ");
//            }
//            WriteLine();

//            Array.Sort(scores); //배열을 작은 수 부터 앞으로 오도록 정렬
//            Array.ForEach<int>(scores, new Action<int>(Print)); //scores배열에 있는 모든 요소를 Print함수로 출력
//            WriteLine();

//            WriteLine($"Number of dimensions : {scores.Rank}"); //배열의 차원 반환

//            WriteLine($"Binary Search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}");
//            //이진 탐색 알고리즘 매소드로 입력된 값의 인덱스를 찾는다.

//            WriteLine($"Linear Search : 90 is at" + $"{Array.IndexOf<int>(scores, 90)}");
//            //배열의 앞부터 순서대로 입력된 값의 인덱스를 찾는다.

//            WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");
//            //배열의 모든요소가 지정한조건 (60점을 넘냐)에 부합 여부를 반환

//            int index = Array.FindIndex<int>(scores, (scores) => scores < 60);
//            //배열에서 지정한 조건에 부합하는 첫번재 요소의 인덱스를 반환하여 저장 (60점보다 작은 수를 찾는다.)

//            scores[index] = 61; //60점보다 작은 수를 61로 다시 입력
//            WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");
//            //배열의 모든요소가 지정한조건 (60점을 넘냐)에 부합 여부를 반환
//            WriteLine("Old length of scores : " + $"{scores.GetLength(0)}");
//            //해당 차원의 배열의 길이를 반환한다. (1차원이므로 첫번째 차원의 인덱스는 0)

//            Array.Resize<int>(ref scores, 10); //배열의 크기 재조정 ()
//            WriteLine($"New length of scores : {scores.Length}");
//            //현재 배열의 길이 출력.

//            Array.ForEach<int>(scores, new Action<int>(Print)); //늘린 길이의 배열 출력, 늘린 공간은 0으로 초기화 됬음.
//            WriteLine();

//            Array.Clear(scores, 3, 7); //인덱스 3부터 7개의 배열의 요소를 0으로 초기화
//            Array.ForEach<int>(scores, new Action<int>(Print));
//            WriteLine();

//            int[] sliced = new int[3]; //공간이 3인 배열 선언.
//            Array.Copy(scores, 0, sliced, 0, 3);
//// 배열의 길이가 3인 새로운 배열의 0 인덱스 부터 3개의 공간의 값을 배열의 길이가 10인 기존 배열 0인덱스 부터 3개의 값을 넣는다.
//            Array.ForEach<int>(sliced, new Action<int>(Print));//공간이 3인 배열의 값 출력, 기존 배열 0,1,2 인덱스 값 출력됨.
//            WriteLine();
            #endregion
            #region 콜렉션 리스트

            #endregion
        }
    }
}