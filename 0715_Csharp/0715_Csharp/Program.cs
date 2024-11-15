using static System.Console;

namespace _0715_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintStar(null);
            PrintStar("하나");
            PrintStar(5);
        }

        static void PrintStar(object? o) //int 값만 찾아내어 값 출력
        {
            if (o is null)
                return;
            if (o is string)
                return;
            if (!(o is int number))
                return;
            WriteLine(new String ('*', number));
        }
    }
}
