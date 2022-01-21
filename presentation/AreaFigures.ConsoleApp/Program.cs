using System;

namespace AreaFigures.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t***Рассчет площади фигур***\n");

            Figure triangle = new Triangle(1, "Треугольник", 2, 3, 4);
            triangle.PrintInformation();

            Figure circle = new Circle(2, "Круг", 5);
            circle.PrintInformation();

            Figure rectangle = new Rectangle(3, "Прямоугольник", 3, 6);
            rectangle.PrintInformation();

            Figure triangle2 = new Triangle(4, "Прямоугольный треугольник", 2, 3, 3.6);
            triangle2.PrintInformation();

            LimitedCurve randomShape = new LimitedCurve(0, 10, 1000);
            randomShape.PrintInformation();

            Console.ReadKey();
        }
    }
}
