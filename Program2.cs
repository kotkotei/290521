using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static double Vparik(double a1, double b1, double c1)
        {
            double v = 0;
            v = a1 * b1 * c1;
            return v;
        }
            static void Main(string[] args)
        
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Работа с париком N" + i);
                    Console.WriteLine("Введите сторону а");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону b");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону c");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double v = Vparik(a, b, c);
                    Console.WriteLine("v=" + v);
                }
                Console.ReadKey();
            }
        }
    }




   

