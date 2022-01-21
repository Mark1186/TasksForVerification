using System;

namespace AreaFigures
{
    public abstract class Figure
    {
        private int _id;
        private string _name;

        public int Id { get => _id; set
            {
                if (value < 0)
                    _id = value * -1;
                else
                    _id = value;
            }}

        public string Name { get => _name; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    _name = "Фигура";
                else
                    _name = value;
            }}

        public Figure()
        {

        }

        public Figure(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract double CalculateArea();
        public void PrintInformation()
        {
            Console.WriteLine($"\nНаименование фигуры \"{Name}\" имеет площадь равной {CalculateArea().ToString()}");
        }
    }
}
