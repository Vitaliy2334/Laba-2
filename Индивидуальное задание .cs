using System;
using System.Collections.Generic;
using System.Text;

using System;
namespace CSharp_Shell
{
    class Program
    {
        void Main()
        {
            int i, j, k;
            for (i = 1; i <= 9; i++)
            {
                for (j = 0; j <= 9; j++)
                {
                    k = 101 * i + 10 * j;
                    Console.Write("±" + k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

2 часть;

public static void PrintIfInRange(int x, int n)
{
    int y = n - x;
    if (y >= 0 && y <= 9)
        Console.Write($" { x * 10 + y } ");
}

static void Main(string[] args)
{
    for (int i = 1; i < 10; i++)
    {
        PrintIfInRange(i, 5);
        PrintIfInRange(i, 10);
        PrintIfInRange(i, 15);
    }

    Console.ReadLine();
};

