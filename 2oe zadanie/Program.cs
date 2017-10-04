using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2oe_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение y : ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите значение z : ");
            double z = double.Parse(Console.ReadLine());

            if(x + y + z < 1)
            {
                if(x < y && x < z)
                {
                    x = (y + z) / 2;
                }else if(y < z && y < x)
                {
                    y = (x + z) / 2;
                }
                else
                {
                    z = (y + x) / 2;
                }
            }
            else
            {
               if(x > y)
                {
                    x /= 2;
                }
                else
                {
                    y /= 2;
                }
            }

            Console.WriteLine(x + " " + y + " " + z);
        }
    }
}
