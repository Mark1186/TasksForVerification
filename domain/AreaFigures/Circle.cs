using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    public class Circle : Figure
    {
        private double _radius;

        public double Radius { get => _radius; set
            {
                if (value < 0) _radius = value * -1;
                else _radius = value;
            } }

        public Circle()
        {

        }

        public Circle(int id, string name, double radius)
            :base(id, name)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
