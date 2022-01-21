using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    public class Rectangle : Figure
    {
        private double _sideA;
        private double _sideB;

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

        public Rectangle()
        {

        }

        public Rectangle(int id, string name, double sideA, double sideB)
            :base(id, name)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override double CalculateArea()
        {
            return SideA * SideB;
        }
    }
}
