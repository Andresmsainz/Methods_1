using System;

namespace Methods_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods #1!");

            int a, b, c, d;
            int addresult = 0;

            c = 15;
            d = 10;
            addresult = PerformAddition(c, d);
            Console.WriteLine($"{c} + {d} = {addresult}");
            DisplayMessage();

            a = 5;
            b = 3;
            addresult = PerformAddition(a, b);
            Console.WriteLine($"{a} + {b} = {addresult}");
            DisplayMessage();


        }

        static int PerformAddition(int x, int y)
        {
            int result = 0;
            result = x + y;
            return result;
        }
        static void DisplayMessage()
        {
            Console.WriteLine("Process is Done!");
        }
    }
}
