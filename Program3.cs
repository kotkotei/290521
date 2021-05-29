using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static int Faktorial(int a)
    {
        int f = 1;
        for (int i = 1; i <= a; i++)
        {
            f = f * i;
        }
        return f;
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("фBbod a");
                int a = Convert.ToInt32(Console.ReadLine());
                int f = Faktorial(a);
                Console.WriteLine("f=" + f);


            }
            Console.ReadKey();
        }
    }
}

