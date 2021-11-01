using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Индивидуальное 1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d, e, p;
            Console.WriteLine("Введите длины сторон треугольника");
            Console.WriteLine("Если треуголльник является равнобедренным, то вы увидите 'true', иначе - 'false'");
            Console.WriteLine("First:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Second:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Third:");
            c = float.Parse(Console.ReadLine());
            d = a * a; e = b * b; p = c * c;
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Error");
            }
            else if (d == p + e || p == d + e || e == p + d)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}

}