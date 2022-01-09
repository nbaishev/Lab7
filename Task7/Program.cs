using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длины сторон второго треугольника");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());

            if (TriangleSquare(a1, b1, c1) > TriangleSquare(a2, b2, c2))
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }

            if (TriangleSquare(a1, b1, c1) < TriangleSquare(a2, b2, c2))
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }

            if (TriangleSquare(a1, b1, c1) == TriangleSquare(a2, b2, c2))
            {
                Console.WriteLine("Площади равны");
            }

            Console.ReadKey();
        }

        static double TriangleSquare(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
