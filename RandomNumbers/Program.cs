using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int seed = 12345678;
            var csharpRandom = new Random(seed);
            double[] csharpNumbers = new double[100];
            double[] lcmNumbers = new double[100];
            double m = Math.Pow(2, 16);
            for (int i = 0; i < 100; i++)
            {
                csharpNumbers[i] = csharpRandom.NextDouble();
                if (i == 0)
                {
                    lcmNumbers[i] = Math.Abs((101427 * seed + 321) % (m))/m;
                }
                else
                {
                    lcmNumbers[i] = Math.Abs((101427 * lcmNumbers[i - 1] + 321) % (m))/m;
                }

               
            }
            PrintNumbers(csharpNumbers);
            Console.WriteLine("LCM numbers are:");
            PrintNumbers(lcmNumbers);
            // char a = 'a';
            //while (a == 'a')
            //{
            //    Console.WriteLine(csharpRandom.NextDouble());
            //    a = Console.ReadKey().KeyChar;
            //}
            static void PrintNumbers(double[] numbers)
            {
                Console.WriteLine();
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                    if (i % 4 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
