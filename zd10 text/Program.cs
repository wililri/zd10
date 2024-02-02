using System;

namespace zd10_text
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число B:");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число C:");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число D:");
            int D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("result:");
            if (A % 2 == 0)
            {
                Console.WriteLine(A);
            }

            if (B % 2 == 0)
            {
                Console.WriteLine(B);
            }

            if (C % 2 == 0)
            {
                Console.WriteLine(C);
            }

            if (D % 2 == 0)
            {
                Console.WriteLine(D);
            }
        }
    }
}