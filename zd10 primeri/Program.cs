using System;
namespace zd10_primeri
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());

            double g = 0;
            if (x <= -3)
            {
                g = -x * x - 1.1 * x + 9;
            }
            else
            {
                g = Math.Log(x + 3) / (Math.Pow(x, 2) + 9);
            }
            Console.WriteLine("Результат = {0:f3}", g);
        }
    }
}