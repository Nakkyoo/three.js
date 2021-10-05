using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] AAA = new string[3][];
            int[] BBB = new int[] { 3, 2, 5 };
            for (int i = 0; i < AAA.Length; ++i)
            {
                AAA[i] = new string[BBB[i]];
            }
            AAA[0][0] = "sex";
            Console.Write($"{AAA[0][0]}");
        }
    }
}
