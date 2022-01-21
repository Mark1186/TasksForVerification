using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    public class Triangle : Figure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA { get => _sideA; set
            {
                if (value < 0) _sideA = value * -1;
                else _sideA = value;
            } }
        public double SideB { get => _sideB; set
            {
                if (value < 0) _sideB = value * -1;
                else _sideB = value;
            } }
        public double SideC { get => _sideC; set
            {
                if (value < 0) _sideC = value * -1;
                else _sideC = value;
            } }

        public Triangle()
        {

        }

        public Triangle(int id, string name, double sideA, double sideB, double sideC)
            : base (id, name)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            if (IsTheTriangleRectengular())
            {
                Console.WriteLine("Треугольник является прямоугольным");
                return 0.5 * (SideA * SideB);
            }

            return FormulaGerona();
        }

        private bool IsTheTriangleRectengular()
        {
            var hypotenuse = Pifagor();
            if (SideC == hypotenuse)
                return true;
            return false;
        }
        private double FormulaGerona()
        {
            double perimetr = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(perimetr * (perimetr - SideA) * (perimetr - SideB) * (perimetr - SideC));
        }

        private double Pifagor()
        {
            return Math.Round(Math.Sqrt(SideA*SideA + SideB*SideB), 1);
        }

    }
}
