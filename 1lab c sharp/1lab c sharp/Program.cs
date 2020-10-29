using System;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Робертс Даниил Александрович, РТ5-31Б");
            double x1, x2, x3, x4, A = 0.0, B = 0.0, C = 0.0;
            if (args.Length == 0)
                while (A == 0)
                {
                    Console.WriteLine("Введите коэфиценты A, B, C биквадратного уравнения  :");
                    A = ReadDouble();
                    B = ReadDouble();
                    C = ReadDouble();
                }
            else
            {
                A = Convert.ToDouble(args[0]);
                B = Convert.ToDouble(args[1]);
                C = Convert.ToDouble(args[2]);
            }
            Result(A, B, C, out x1, out x2);
            Result(1, 0, -x1, out x1, out x3);
            Result(1, 0, -x2, out x2, out x4);
            Console.ForegroundColor = ConsoleColor.Green;
            if (!Double.IsNaN(x1))
            {
                Console.WriteLine("{0:F3}", x1);
            }
            if (!Double.IsNaN(x2))
            {
                Console.WriteLine("{0:F3}", x2);
            }
            if (x3 != x1 && !Double.IsNaN(x3))
            {
                Console.WriteLine("{0:F3}", x3);
            }
            if (x4 != x2 && !Double.IsNaN(x4))
            {
                Console.WriteLine("{0:F3}", x4);
            }
            if (Double.IsNaN(x1) && Double.IsNaN(x2) && Double.IsNaN(x3) && Double.IsNaN(x4))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет решений");
            }
            Console.ResetColor();
        }
        static void Result(double A, double B, double C, out double x1, out double x2)
        {
            double D = B * B - 4 * C * A;

            x1 = (-B + Math.Sqrt(D)) / (2 * A);
            x2 = (-B - Math.Sqrt(D)) / (2 * A);

        }
        static double ReadDouble()
        {
            string resultString;
            double resultDouble;
            bool flag;
            do
            {
                resultString = Console.ReadLine();
                try
                {
                    resultDouble = double.Parse(resultString);
                    resultDouble = Convert.ToDouble(resultString);
                    flag = true;
                }
                catch
                {
                    resultDouble = 0;
                    flag = false;
                }
                if (!flag)
                {
                    Console.WriteLine("Необходимо ввести вещественное число");
                }
            }
            while (!flag);
            return resultDouble;
        }
    }
}