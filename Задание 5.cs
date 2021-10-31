static void Main(string[] args)
{
    double x, y, z;
    Console.WriteLine("Программа выводящая на экран все комбинации  натуральных  чисел x, y, z,таких что x^3 + y^3 + z^3 = N");
    Console.WriteLine("Введите число N");
    double N = double.Parse(Console.ReadLine());
    int j = 0;
    for (x = 0; x <= N; x++)
    {
        var xa = Math.Pow(x, 3);
        for (y = 0; y <= N; y++)
        {
            var ya = Math.Pow(y, 3);
            for (z = 0; z <= N; z++)
            {
                var za = Math.Pow(z, 3);
                double sum = xa + ya + za;
                if (sum == N)
                {
                    Console.WriteLine($"{xa}+{ya}+{za} = {N}");
                    j++;
                }
            }
        }
    }
    if (j == 0)
    {
        Console.WriteLine("No such combinations!");
    }
}
        }
    }
