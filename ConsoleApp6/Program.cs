using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        private static double F(double x)
        {
            return x * x;
        }

        static Func <double, double> CreateFunc(double a, double b, double c)
        {
            return x => a * x * x + b * x + c;
        }

        private double d2fdx2(double x)
        {
            return -1 * (Math.Cos(x) + Math.Sin(x));
        }

        private double Newton(double start, double eps, ref bool isMax)
        {
            double x1, dx;
            double x0 = start;
            do
            {
                x1 = x0 - dfdx(x0) / d2fdx2(x0);
                dx = Math.Abs(x1 - x0);
                x0 = x1;
            }
            while (dx < eps);
            if (d2fdx2(x1) < 0)
            {
                retun x1;
            }
            else
            {
                throw new Exception("Экстремум на этом интервале не является максимумом!");
            }
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Введите условие");
            Console.Write("a>");
            string usl = Console.ReadLine();
            double a = double.Parse(usl);
            Console.Write("b>");
            string usl_2 = Console.ReadLine();
            double b = double.Parse(usl_2);
            Console.Write("c>");
            string usl_3 = Console.ReadLine();
            double c = double.Parse(usl_3);

            Func<double, double> f = F;
            //  Func<double, double> = CreateFunc(a, b, c);
            Console.WriteLine("Введите ограничения");
            Console.Write("x1>");
            string us4 = Console.ReadLine();
            double x1 = double.Parse(us4);
            Console.Write("x2>");
            string us5 = Console.ReadLine();
            double x2 = double.Parse(us5);

            double D = b * b - 4 * a * c;
            if (D<0)
            { 
                Console.WriteLine("Нет решения")
            }
            if (D=0)
            {
                double ansx1 = (-b + Math.Sqrt(D)) / (2 * a);
                double ansx2 = (-b - Math.Sqrt(D)) / (2 * a);
            }
            if (D>0)





        }
    }
}
