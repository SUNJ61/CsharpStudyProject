using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _0704_Csharp
{
    internal class MainApp
    {
        #region try - catch 선언
        static void Divide(int num1, int num2)
        {
            if (num2 == 0)
                throw new Exception("제수는 0으로 나눌 수 없다.");

            WriteLine($"나눗셈 몫 : {num1 / num2}");
            WriteLine($"나눗셈 나머지 : {num1 % num2}");
        }

        static void DoSomeThing(int arg)
        {
            if ((arg < 10))
            {
                WriteLine($"{arg}");
            }
            else
            {
                throw new Exception("arg가 10보다 큽니다.");
            }
        }
        #endregion
        #region try - catch - finally 선언
        static int F_Divide(int divdend, int divisor)
        {
            try
            {
                WriteLine("F_Divide() 시작");
                return divdend / divisor; //예외가 일어나지 않고 정상적으로 return 하더라도 finally는 실행된다. 
            }
            catch (DivideByZeroException e)
            {
                WriteLine("F_Divide() 예외 발생");
                throw e; //예외가 일어나더라도 finally절은 실행된다.
            }
            finally //여기서 finally가 없으면 밑에 writeline은 출력되지 않고 종료된다. (return이 위에서 발생하기 때문)
            {
                WriteLine("F_Divide() 끝");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region try - catch 메인
            //int count = 0;
            //while (true)
            //{
            //    Write("두개의 숫자 입력\n");
            //    Write("첫번째 숫자 입력 : ");
            //    int num1 = Convert.ToInt32(ReadLine());
            //    Write("두번째 숫자 입력 : ");
            //    int num2 = Convert.ToInt32(ReadLine());

            //    try
            //    {
            //        Divide(num1, num2);
            //        WriteLine("나눗셈을 마쳤습니다.");
            //    }
            //    catch (Exception ex)
            //    {
            //        WriteLine($"{ex.Message}");
            //        WriteLine($"프로그램을 다시 실행하세요. {++count}번째");
            //    }
            //    finally //try나 catch를 거친 후에 반드시 finally를 거친다.
            //    {
            //        WriteLine("프로그램 종료!");
            //    }
            //    if (num2 != 0) break;
            //    else if (count == 3)
            //    {
            //        WriteLine("0을 3번이상 입력했습니다.");
            //        break;
            //    }
            //}

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //try
            //{
            //    WriteLine("두 수 입력");
            //    Write("첫번째 수 : ");
            //    int a = Convert.ToInt32(ReadLine());
            //    Write("두번째 수 : ");
            //    int b = Convert.ToInt32(ReadLine());

            //    WriteLine($"나눗셈 몫 : {a/b}");

            //    for (int i = 0; i < 11; i++)
            //    {
            //        WriteLine(arr[i]);
            //    }
            //}
            //catch (IndexOutOfRangeException e) //예외처리 객체가 여러가지 있음, 인덱스 범위를 넘어갔을 때 예외처리
            //{
            //    WriteLine($"예외가 발생 했습니다 : {e.Message}");
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine($"예외 발생 : {e.Message}");
            //}
            //WriteLine("종료");

            //int counter = 0;
            //while (true)
            //{
            //    Write("숫자 입력 : ");
            //    int k = Convert.ToInt32(ReadLine());
            //    try
            //    { 
            //        DoSomeThing(k);
            //    }
            //    catch (Exception ex)
            //    {
            //        WriteLine($"예외 발생 : {ex.Message} {++counter}번째 예외입니다.");
            //    }
            //    if (k < 10) break;
            //    else if (counter >= 3) break;
            //}

            //try
            //{
            //    int? a = null; //a는 null을 허용하여 저장. 하지만 b는 null을 허용하지 않아서 a가 할당 되지 않고바로 throw식이 실행된다.
            //    int b = a ?? throw new ArgumentNullException();
            //}

            //catch(ArgumentNullException e)
            //{
            //    WriteLine(e);
            //}

            //try
            //{
            //    int[] array = new[] { 1, 2, 3 };
            //    int index = 4;
            //    int value = array[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];
            //}
            //catch(IndexOutOfRangeException e)
            //{
            //    WriteLine(e);
            //}
            #endregion
            #region try - catch - finally 메인
            //try
            //{
            //    Write("제수를 입력하세요 : ");
            //    string temp = ReadLine();
            //    int dividend = Convert.ToInt32(temp);
            //    Write("피 제수를 입력하세요 : ");
            //    temp = ReadLine();
            //    int divisor = Convert.ToInt32(temp);
            //    WriteLine($"{dividend} / {divisor} = {F_Divide(dividend, divisor)}");
            //}
            //catch(FormatException e) //양식에 관련된 예외처리 -> 형변환 중 형변환이 불가능한 값이 들어왔을 때 처리
            //{
            //    WriteLine("에러 : " + e.Message);
            //}
            //catch(DivideByZeroException e)
            //{
            //    WriteLine("에러 : " + e.Message);
            //}
            //finally
            //{
            //    WriteLine("프로그램 종료");
            //}
            #endregion

        }
    }
}
