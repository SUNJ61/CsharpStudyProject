using System.Runtime.InteropServices;
using static System.Console;

namespace _0709_test
{
    struct ACSetting
    {
        public double CIC; //현재 온도
        public double target; //희망 온도

            public readonly double GetFH()
            {
            double target = CIC * 1.8 + 32;
            return target;
            }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.CIC = 25;
            acs.target = 25;

            WriteLine($"{acs.GetFH()}");
            WriteLine($"{acs.target}");
        }
    }
}
