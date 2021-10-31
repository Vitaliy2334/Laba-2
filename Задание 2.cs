using System;

namespace _ задание 2
class TMain
{
    static void Main()
    {
        bool plus = true;
        double pi = 0;
        for (int i = 1; i < 500; i += 2)
        {
            if (plus) pi += 1.0 / i;
            else pi -= 1.0 / i;
            plus = !plus;
        }
        pi *= 4;
        Console.WriteLine(pi);
        Console.ReadKey();
    }
}
