using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;

namespace _0722_Csharp
{
    #region 인덱서(indexer)
    //class MyList
    //{
    //    private int[] array;
    //    public MyList() //매개변수가 없는 생성자.
    //    {
    //        array = new int[3];
    //    }
    //    public int this[int index]//인덱서 프로퍼티
    //    {
    //        get { return array[index]; }
    //        set
    //        {
    //            if (index >= array.Length)//배열의 경계를 넘어선다면
    //            {
    //                Array.Resize(ref array, index + 1);//배열의 사이즈를 넘어선 인덱스 만큼 늘리고
    //                Console.WriteLine($"Array Resized : {array.Length}");
    //            }
    //            array[index] = value;
    //        }
    //    }
    //    public int Length
    //    {
    //        get { return array.Length; }
    //    }
    //}
    #endregion
    #region 문제
    #endregion
    internal class MainApp
    {
        static void Main(string[] args)
        {
            #region 가변길이 배열
            //int[][] jagged = new int[3][]; //가변길이 배열. 앞 인덱스는 정해주어야한다.
            //jagged[0] = new int[5] { 1, 2, 3, 4, 5 }; //2차원배열이지만 한차원의 크기가 정해지지 않았다.
            //jagged[1] = new int[] { 10, 20, 30 };
            //jagged[2] = new int[] { 100, 200 };
            //foreach (int[] arr in jagged)
            //{
            //    WriteLine($"Length : {arr.Length}");
            //    foreach (int i in arr)
            //    {
            //        Write($"i : {i} ");
            //    }
            //    WriteLine();
            //}
            //int[][] jag = new int[2][]
            //{
            //    new int[] { 100, 200 }, new int[] { 6,7,8,9 }

            //};
            //foreach (int[] arr in jag)
            //{
            //    Console.WriteLine($"Length : {arr.Length}");
            //    foreach (int i in arr)
            //    {
            //        Write($"i = {i} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region ArrayList
            //ArrayList list = new ArrayList(); //ArrayList 동적할당, 배열과 달리 컬렉션은 생성할 때 용량을 지정하지 않는다.

            //for (int i = 0; i<5 ; i++)
            //    list.Add(i); //만든 리스트에 i 할당, 자동으로 용량이 늘어난다.


            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("====================");
            //list.RemoveAt(2); //인덱스 2번에 담긴 값 삭제.
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("====================");
            //list.RemoveRange(0, list.Count); //리스트 길이만큼 전체 삭제.
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("====================");
            //list.Insert(0, 2); //0번 인덱스에 2 삽입
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("====================");
            //list.Add("abc"); //자료형이 다른 값도 넣을 수 있다.
            //list.Add("def"); //Arraylist 클래스에서 Arraylist에 담는 변수를 object로 선언했기에 모든 자료형을 입력할 수 있다.
            //for(int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            #endregion
            #region Queue, stack
            //WriteLine("Que"); //먼저 넣은 값을 꺼낼때도 먼저꺼내는 자료구조. (First in First out : FIFO)
            //Queue que = new Queue();
            //que.Enqueue(1); //que안에 순서대로 값을 저장한다.
            //que.Enqueue(2);
            //que.Enqueue(3);
            //que.Enqueue(4);
            //que.Enqueue(5);
            //while (que.Count > 0) //que안에 자료구조를 전부 꺼냈다면 종료
            //    WriteLine(que.Dequeue());//que안에 값을 꺼내면서 삭제한다.

            //WriteLine("Stack"); //먼저 넣은 값을 꺼낼때 제일 마지막에 꺼내는 자료구조. (Last in First out : LIFO)
            //Stack stack = new Stack();
            //stack.Push(1); //Stack안에 순서대로 값을 저장한다.
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //while(stack.Count > 0) //Stack안에 자료를 전부 꺼냈다면 종료
            //    WriteLine(stack.Pop()); //Stack안에 값을 꺼내면서 삭제
            #endregion
            #region HashTable
            //Hashtable ht = new Hashtable();
            //ht["book"] = "책"; // ht[key] = value로 선언된다.
            //ht["cook"] = "요리";
            //ht["snack"] = "과자";
            //WriteLine(ht["book"]); //key를 입력하면 값을 출력한다.
            //WriteLine(ht["cook"]);
            //WriteLine(ht["snack"]);
            #endregion
            #region 컬렉션을 초기화 하는 방법
            //int[] arr = { 123, 456, 789 };
            //ArrayList list = new ArrayList(arr); //동적 할당이므로 할당시 ()에 배열을 넣어서 초기화 가능.
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //WriteLine("=================================");
            //Stack stack = new Stack(arr);
            //foreach(object obj in stack)
            //    Console.WriteLine(obj);
            //WriteLine("=================================");
            //Queue que = new Queue(arr);
            //foreach(object o in que)
            //    Console.WriteLine(o);
            //WriteLine("=================================");
            //Hashtable ht2 = new Hashtable()
            //{
            //    [1] = "One",
            //    [2] = "Two",
            //    [3] = "Three"
            //};
            //for(int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine(ht2[i]);
            //}
            #endregion
            #region 인덱서(indexer)
            //MyList list = new MyList();
            //for (int i = 0; i < 10; i++)
            //    list[i] = i + 1;
            //for(int i = 0; i < list.Length; i++)
            //    Console.WriteLine($"{list[i]}");
            #endregion
            #region 문제
            //Hashtable ht = new Hashtable();
            //ht["회사"] = "Microsoft";
            //ht["URL"] = "www.microsoft";
            //WriteLine("회사 : {0}", ht["회사"]);
            //WriteLine("URL : {0}", ht["URL"]);
            #endregion
        }
    }
}
