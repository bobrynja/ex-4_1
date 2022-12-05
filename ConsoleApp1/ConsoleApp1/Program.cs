using System;

namespace ConsoleApp1
{
    class Program
    {
        static double f(int n, double x, int i=0)
        {
            if (i <= n) {
                double result = i + x / f(n, x, i + 1);
                return Math.Round(result,2);
            }
            return 0;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите натуральный n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    Console.WriteLine(f(n, x));
                }
                else Console.WriteLine("n должно быть натуральным числом");
            }
            catch { Console.WriteLine("Некорректный ввод данных"); }
            Console.ReadKey();
        }
    }
}
