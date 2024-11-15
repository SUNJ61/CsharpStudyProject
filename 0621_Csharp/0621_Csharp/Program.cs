//using System;
//using static System.Console;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Security;
//using System.Xml.Linq;

//namespace _0621_Csharp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            #region 1차원 배열
//            //int[] intArray;
//            //intArray = new int[3];

//            //intArray[0] = 1;
//            //intArray[1] = 2;
//            //intArray[2] = 3;

//            //for (int i = 0; i < intArray.Length; i++)
//            //{
//            //    WriteLine($"{i}번째 인덱스 : {intArray[i]}");
//            //}
//            //foreach (int i in intArray)
//            //{
//            //    WriteLine($"{i}");
//            //}

//            //int[] arr1 = new int[] { 1, 2, 3 }; //1차원 배열 선언 종류
//            ////var arr1 = new int[3] { 1, 2, 3 }; // -> 실무에서 가장 많이 쓰임.
//            ////int[] arr1 = { 1, 2, 3 };

//            //for (int i = 0; i < arr1.Length; i++)
//            //{
//            //    WriteLine($"{i}번째 인덱스 : {arr1[i]}");
//            //}

//            //foreach (int i in arr1)
//            //{
//            //    WriteLine($"{i}");
//            //}

//            //int[] arr2 = { 1, 2, 3 }; //인덱스 증감연산자
//            //int index = 0;
//            //WriteLine(arr2[index++]); //실행후 1증가, 0출력
//            //WriteLine(arr2[index++]); //실행후 1증가, 1출력
//            //WriteLine(arr2[index++]); //실행후 1증가, 2출력
//            //WriteLine(arr2[--index]); //실행전 1감소, 2출력
//            //WriteLine(arr2[--index]); //실행전 1감소, 1출력
//            //WriteLine(arr2[--index]); //실행전 1감소, 0출력

//            //int[] score = new int[3]; //점수 입력 받아 평균 총점내기
//            //int sum = 0;
//            //float avg = 0;

//            //for (int i = 0; i < score.Length; i++)
//            //{
//            //    Write("점수를 입력하시오 : ");
//            //    score[i] = int.Parse(ReadLine());
//            //    sum += score[i];
//            //}
//            //avg = sum / (float)score.Length;

//            //WriteLine($"총점 : {sum}, 평균 : {avg:0.00}");//소수점 표현 -> 실수변수:0.00..(자리수)

//            //float[] arr3 = { 10.5f, 20.1f, 30.2f }; //float(double)과 decimal의 소수점 정확도 차이.
//            //float sum = 0.0f;
//            //foreach (float f in arr3)
//            //{
//            //    sum += f;
//            //}

//            //WriteLine($"{sum:0.00000000}");// float은 소수점 아래 부분이 정확하지 않음. 여기선 안나옴
//            //decimal[] arr4 = { 10.5m, 20.1m, 30.2m };
//            //decimal sum1 = 0.0m;
//            //foreach (decimal m in arr4)
//            //{
//            //    sum1 += m;
//            //}

//            //WriteLine($"{sum1:0.00000000}");// decimal은 소수점 아래부분이 정확하게 출력됨.
//            #endregion
//            #region 다차원 배열(2차원 배열)
//            //char[,] arrx = new char[2, 2]; //2차원 배열 선언과 이중for문으로 입력 출력하기.
//            //arrx[0, 0] = 'a';
//            //arrx[0, 1] = 'b';
//            //arrx[1, 0] = 'c';
//            //arrx[1, 1] = 'd';

//            //WriteLine($"{arrx[0, 0]}, {arrx[0, 1]}");
//            //WriteLine($"{arrx[1, 0]}, {arrx[1, 1]}");

//            //for( int i = 0; i < 2; i++ )
//            //{
//            //    for( int j = 0; j < 2; j++ )
//            //    {
//            //        Write("단어 하나 입력 : ");
//            //        arrx[i,j] = char.Parse(ReadLine());
//            //    }
//            //}

//            //for (int i = 0; i < 2; i++)
//            //{
//            //    for (int j = 0; j < 2; j++)
//            //    {
//            //        WriteLine(arrx[i,j]);
//            //    }
//            //}

//            //int[,] arrx1;
//            //arrx1 = new int[2, 3];
//            //for (int i = 0; i < 2; i++)
//            //{
//            //    for (int j = 0; j < 3; j++)
//            //    {
//            //        Write("정수를 입력하시오 : ");
//            //        arrx1[i, j] = int.Parse(ReadLine());
//            //    }
//            //}

//            //for (int i = 0; i < 2; i++)
//            //{
//            //    for (int j = 0; j < 3; j++)
//            //    {
//            //        Write($"{arrx1[i, j]} ");
//            //    }
//            //    WriteLine();
//            //}

//            //int[,] ints1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; //2차원 배열 선언과 동시에 초기화.
//            //int[,] ints2 = new int[,]{
//            //    { 1, 2, 3 },
//            //    { 4, 5, 6 } }; //2차원 배열 선언과 동시에 초기화.
//            //int[,] ints3 = {
//            //    { 1, 2, 3 },
//            //    { 4, 5, 6 } }; //2차원 배열 선언과 동시에 초기화. 용량은 전부 24byte (4*6)

//            //for (int i = 0; i < 3; i++)
//            //{
//            //    for (int j = 0; j < 2; j++)
//            //    {
//            //        Write($"{ints1[i, j]}");
//            //    }
//            //    WriteLine();
//            //}

//            //int[,] arrx = new int[3, 3];
//            //for (int i = 0; i < 3; i++)
//            //{
//            //    for (int j = 0; j<3; j++)
//            //    {
//            //        if (i==j)
//            //        {
//            //            arrx[i, j] = 1;
//            //        }
//            //        else
//            //        {
//            //            arrx[i, j] = 0;
//            //        }
//            //        Write(arrx[i, j]);
//            //    }
//            //    WriteLine();
//            //}

//            //string[,] scorex = new string[3, 5]; //이름 점수를 입력받아 출력하기.
//            //int sum;
//            //int avg;
//            //for (int i = 0; i < 3; i++)
//            //{
//            //    WriteLine($"{i+1}번째 학생 데이터를 입력하시오.");
//            //    for (int j = 0; j < 3; j++)
//            //    {
//            //        if (j == 0)
//            //        {
//            //            Write("이름을 입력하시오 : ");
//            //            scorex[i, j] = ReadLine();
//            //        }
//            //        else
//            //        {
//            //            Write("점수를 입력하시오 : ");
//            //            scorex[i, j] = ReadLine();
//            //        }
//            //    }
//            //}

//            //for (int i = 0; i < 3; i++)
//            //{
//            //    sum = 0;
//            //    avg = 0;
//            //    sum += int.Parse(scorex[i,1]);
//            //    sum += int.Parse(scorex[i,2]);
//            //    scorex[i,3] = Convert.ToString(sum);
//            //    avg = int.Parse(scorex[i,3]) / 2;
//            //    scorex[i,4] = Convert.ToString(avg);
//            //}

//            //for (int i = 0; i < 3; i++)
//            //{
//            //    for (int j = 0; j < 5; j++)
//            //    {
//            //        Write($"{scorex[i, j]} "); 
//            //    }
//            //    WriteLine();
//            //}

//            //int[,] dan = new int[8, 9]; //2단부터 9단까지 구구단 배열에 담기.
//            //for (int i = 2; i < 10; i++)
//            //{
//            //    for (int j = 1; j < 10; j++)
//            //    {
//            //        dan[i - 2, j - 1] = (i) * (j);
//            //        Write($"{dan[i - 2, j - 1]} ");
//            //    }
//            //    WriteLine();
//            //}
//            #endregion
//            #region 다차원 배열(3차원 배열)
//            //string[,,] names = new string[2, 2, 2]; // [i,j,k]라고 편의상 지칭
//            //names[0, 0, 0] = "C#"; // i는 배열상의 층 / 공간으로 따지면 y이다.
//            //names[0, 0, 1] = "ASP.NET"; // j는 배열상의 열 / 공간으로 따지면 z
//            //names[0, 1, 0] = "Windows Forms"; // k는 배열상의 행 / 공간으로 따지면 x
//            //names[0, 1, 1] = "WPF";
//            //names[1, 0, 0] = "Xamarin";
//            //names[1, 0, 1] = "Unity";
//            //names[1, 1, 0] = "UWP";
//            //names[1, 1, 1] = "Azure";

//            //WriteLine("0층");
//            //WriteLine($"{names[0,0,0],20}{names[0,0,1],20}");
//            //WriteLine($"{names[0,1,0],20}{names[0,1,1],20}");
//            //WriteLine("1층");
//            //WriteLine($"{names[1,0,0],20}{names[1,0,1],20}");
//            //WriteLine($"{names[1,1,0],20}{names[1,1,1],20}");

//            //int[,,] arrxx = new int[2, 3, 4]; //3차원 배열 선언 방법

//            //for (int i = 0; i < 2; i++)
//            //{
//            //    for (int j = 0; j<3; j++)
//            //    {
//            //        for (int k = 0; k<4; k++)
//            //        {
//            //            Write("정수입력 : ");
//            //            arrxx[i, j, k] = int.Parse(ReadLine());
//            //        }
//            //        WriteLine();
//            //    }
//            //}

//            //for (int i = 0; i < 2; i++)
//            //{
//            //    for (int j = 0; j < 3; j++)
//            //    {
//            //        for (int k = 0; k < 4; k++)
//            //        {
//            //            Write($"{arrxx[i, j, k]} ");
//            //        }
//            //        WriteLine();
//            //    }
//            //    WriteLine();
//            //}

//            //int[,,] arrxx1 = new int[2, 2, 2];
//            //int m = 0;
//            //for (int i = 0; i < 2; i++)
//            //{
//            //    for(int j = 0; j< 2; j++)
//            //    {
//            //        for(int k = 0; k< 2; k++)
//            //        {
//            //            m++;
//            //            arrxx1[i, j, k] = m;
//            //        }
//            //    }
//            //}

//            //WriteLine($"차수 출력 : {arrxx1.Rank}");
//            //WriteLine($"길이 출력 : {arrxx1.Length}");

//            //for (int i = 0; i < arrxx1.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < arrxx1.GetLength(1); j++)
//            //    {
//            //        for (int k = 0; k < arrxx1.GetLength(2); k++)
//            //        {
//            //            Write("{0}\t", arrxx1[i,j,k]);
//            //        }
//            //        Console.WriteLine();
//            //    }
//            //    Console.WriteLine();
//            //}
//            #endregion
//            #region 가변 배열과 var를 이용하여 배열 선언하기
//            //int[][] zag = new int[2][]; //동적으로 자료 n개로 초기화가능

//            //zag[0] = new int[] { 1, 2 };
//            //zag[1] = new int[] { 3, 4, 5 };

//            //for (int i = 0; i < zag[0].Length; i++)
//            //{
//            //    for (int j = 0; j < zag[i].Length; j++)
//            //    {
//            //        Console.Write($"{zag[i][j]}\t");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //WriteLine();

//            var num = new int[] { 1, 2, 3 }; //var로 배열 할당하기.
//            foreach(var item in num)
//            {
//                Console.WriteLine($"item : {item}, 타입 : {num.GetType()}");
//            }

//            #endregion
//            #region 장난감
//            //int[] arr = new int[3]; //배열 인덱스를 1칸씩 옮겨 돌리기
//            //arr[0] = 1;
//            //arr[1] = 2;
//            //arr[2] = 3;

//            //int temp;

//            //Write("반복할 횟수 입력 : ");
//            //int ban = int.Parse(ReadLine());
//            //int b = 0;
//            //while (true)
//            //{
//            //    b++;
//            //    temp = arr[0]; 
//            //    arr[0] = arr[1];
//            //    arr[1] = arr[2];
//            //    arr[2] = temp;

//            //    WriteLine(arr[0]);
//            //    WriteLine(arr[1]);
//            //    WriteLine(arr[2]);
//            //    WriteLine();

//            //    if (b == ban)
//            //    {
//            //        break;
//            //    }
//            //}
//            #endregion
//        }
//    }
//}
