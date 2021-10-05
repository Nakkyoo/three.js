using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MonthsAll = 12;
            int[] daysInEachMonth = new int[MonthsAll] {31,28,31,30,31,30,31,31,30,31,30,31};
            string[][] calendar = new string[MonthsAll][];
            for(int i =0; i < MonthsAll; i++)
            {
                calendar[i] = new string[daysInEachMonth[i]];
            }
            while(true)
            {
                Console.Write("달을 입력하십시오 (1~12):");
                string monthString = Console.ReadLine();
                int month = int.Parse(monthString);

                if(month <= 0 || month > 12)
                {
                    Console.WriteLine("유효하지 않은 달을 입력하셨습니다.");
                    break;
                }

                Console.Write($"원하는 일자를 입력하십시오 (1 ~ {calendar[month - 1].Length}) : ");
                string dayString = Console.ReadLine();
                int day = int.Parse(dayString);
                    if(day <= 0 || day > calendar[month - 1].Length)
                {
                    Console.WriteLine("유효하지 않은 일을 입력하셨습니다");
                    break;
                }
                Console.WriteLine("원하는 스케줄을 입력하십시오 : ");
                string schedule = Console.ReadLine();
                calendar[month - 1][day - 1] = schedule;

                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------");
                for (int i = 0; i < MonthsAll; i++)
                {
                    for(int j = 0; j < calendar[i].Length; j++)
                    {
                        if (!string.IsNullOrEmpty(calendar[i][j]))
                        {
                            Console.WriteLine($"{i + 1} / {j + 1} : {calendar[i][j]} ");
                        }
                    }
                        
                }
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------");

            }
        }
    }
}
