using System;
using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            double rez1;
            double rez2;
            double rez3;
            double Pi = 3.1415926535;
            double E = 2.7182818284;
            Math.Round(Pi, 4);
            Math.Round(E, 3);
            Console.WriteLine("Введите 3 числа");
            Console.Write("a= ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("c= ");
            c = Convert.ToInt16(Console.ReadLine());
            rez1 = a / Pi;
            Console.WriteLine("Результат вычисления a/Pi :{0}", Math.Round(rez1,4));
            rez2 = a + b + c;
            Console.WriteLine("Результат вычисления a+b+c :{0}", rez2);
            rez3 = c / E;
            Console.WriteLine("Результат вычисления c/E :{0}", Math.Round(rez3,3));

        }
    }
}
