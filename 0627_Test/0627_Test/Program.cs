using static System.Random;
using static System.Console;

namespace _0627_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] num = new int[6];
            bool[] test = new bool[6];
            int i = 0;
            while (true)
            {
                if (i == 0)
                {
                    num[i] = rnd.Next(1, 46);
                    i++;
                }
                else if (i > 0)
                {
                    int temp = rnd.Next(1, 46);
                    for (int x = 0; x < test.Length; x++)
                        test[x] = true;

                    for (int k = 0; k < i; k++)
                    {
                        if (temp == num[k])
                        {
                            test[k] = false;
                        }
                    }

                    if (test[0] && test[1] && test[2] && test[3] && test[4] && test[5])
                    {
                        num[i] = temp;
                        i++;
                    }
                }

                if (i == 6)
                {
                    break;
                }
            }
            for (int j = 0; j < num.Length; j++)
            {
                WriteLine(num[j]);
            }
        }
    }
}
