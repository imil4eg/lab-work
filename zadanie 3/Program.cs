using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начало интервала : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите конец интервала : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите количество точек : ");
            int n = int.Parse(Console.ReadLine());

            int t = a;

            int shag = (b - a) / n;

            for(int i = 0;i < n && t >= 0 && t >= a && t <= b; i++,t += shag)
            {
                double Y = 4 * Math.Pow(Math.E, -0.5 * t) * Math.Cos(t);

                Console.WriteLine(Y);
            }

            Console.ReadKey();
        }
    }
}
