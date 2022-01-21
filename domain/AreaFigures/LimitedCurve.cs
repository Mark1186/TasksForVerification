using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    /// <summary>
    /// Площадь ограниченной фигуры между двумя кривыми
    /// </summary>
    public class LimitedCurve
    {
        private double _theLowerBoundOfTheIntegral;
        private double _theUpperBoundOfTheIntegral;
        private double _numberOfPartitions;

        public double TheLowerBoundOfTheIntegral 
            { get => _theLowerBoundOfTheIntegral; 
              set 
            {
                _theLowerBoundOfTheIntegral = value; 
            }
        }
        public double TheUpperBoundOfTheIntegral 
            { get => _theUpperBoundOfTheIntegral;
              set 
            { 
                _theUpperBoundOfTheIntegral = value;
            } }
        public double NumberOfPartitions
            { get => _numberOfPartitions;
              set 
            { 
                _numberOfPartitions = value;
            } }

        public LimitedCurve()
        {

        }

        public LimitedCurve(double lowerBound, double UpperBound, double numberOfPartitions)
        {
            TheLowerBoundOfTheIntegral = lowerBound;
            TheUpperBoundOfTheIntegral = UpperBound;
            NumberOfPartitions = numberOfPartitions;
        }

        private double TrapezoidMethodForFunctionF(double a, double b, double n)
        {
            double h = (b - a) / n;
            double sum = FunctionF(a) + FunctionF(b);

            for (int i = 1; i <= n - 1; i++)
            {
                sum += 2 * FunctionF(a + i * h);
            }

            sum *= h / 2;

            return TrapezoidMethodForFunctionG(a, b, n) - sum;
        }

        private double TrapezoidMethodForFunctionG(double a, double b, double n)
        {
            double h = (b - a) / n;
            double sum = FunctionG(a) + FunctionG(b);

            for (int i = 1; i <= n - 1; i++)
            {
                sum += 2 * FunctionG(a + i * h);
            }

            sum *= h / 2;

            return sum;
        }

        private double FunctionF(double x)
        {
            return Math.Sin(x);
        }

        private double FunctionG(double x)
        {
            return x;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"\nПлощадь ограниченной фигуры между двумя кривыми");
            Console.WriteLine($"S = {TrapezoidMethodForFunctionF(TheLowerBoundOfTheIntegral, TheUpperBoundOfTheIntegral, NumberOfPartitions)}");
        }
    }
}
