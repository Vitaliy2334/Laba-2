using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_2
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