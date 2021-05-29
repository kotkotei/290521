using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._05
{
    class Program
    {
        public static bool Triangle_bool(double a1, double b1, double c1)
        {
            bool k = false;
            if (a1 <= (b1 + c1) && b1 <= (a1 + c1) && c1 <= (b1 + a1))
            {
                k = true;
            }
            return k;
        }

        public static double STriangle(double a1, double b1, double c1)
        {
            double s = 0;
            double p = (a1 + b1 + c1) / 2;
            s = Math.Sqrt(p * (p - a1) * (p - b1) * (p - c1));
            return s;
        }

        static void Main(string[] args)
        {
            //даны три треуггольника и длины их сторон
            //вычислить существует ли такой треугольник
            //найти их площади

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("работа с треугольником №" + i);
                Console.WriteLine("введите сторону a");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите сторону b");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите сторону c");
                double c = Convert.ToDouble(Console.ReadLine());
                bool otvet = Triangle_bool(a, b, c);
                if (otvet == true)
                {
                    Console.WriteLine("Существует");
                }
                else
                {
                    Console.WriteLine("Не существует");
                }
            }
            Console.ReadKey();
        }
    }
}
