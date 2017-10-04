using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение аргемунта a : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение аргумента q : ");
            double q = double.Parse(Console.ReadLine());
            Console.Write("Введите значение аргемунта b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение аргумента y : ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите значение аргемунта n : ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Введите значение аргумента x в градусах : ");
            double x = double.Parse(Console.ReadLine());

            double res = (a + (Math.Pow(q, n) / Math.Cos(x))) * (Math.Log10(a + 1) / (Math.Sqrt(b) + Math.Pow(Math.E, -y)));

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
