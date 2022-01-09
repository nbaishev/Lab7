using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            CubeProp(a);
            Console.ReadKey();
        }

        static void CubeProp(int a)
        {
            int S = a * a * 6;
            int V = a * a * a;
            Console.WriteLine("Площадь поверхности куба {0}, объем {1}", S, V);
        }
    }
}
