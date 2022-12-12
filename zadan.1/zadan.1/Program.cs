using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double x = int.Parse(Console.ReadLine());

            Console.WriteLine("Длина ребра = " + x.ToString());
            Console.WriteLine("Объем = " + Math.Pow(x, 3).ToString());
            Console.WriteLine("Площадь грани = " + Math.Pow(x, 2).ToString());
            Console.WriteLine("Площадь поверхности = " + (Math.Pow(x, 2) * 6).ToString());

            Console.ReadLine();
        }
    }
}