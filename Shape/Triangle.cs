using System;

namespace Shape
{
    public class Triangle
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;
        private readonly int _x;
        private readonly int _y;

        public Triangle(double side1, double side2, double side3, int x, int y)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            _x = x;
            _y = y;
        }

        public Tuple<int, int> Position => new Tuple<int, int>(_x, _y);

        public int SideNumber => 3;

        public string Name => "Triangle";

        public double Perimeter()
        {
            return _side1 + _side2 + _side3;
        }

        public double Area()
        {
            return Math.Sqrt(Perimeter()/2*(Perimeter()/2 - _side1)*(Perimeter()/2 - _side2)*(Perimeter()/2 - _side3));
        }
    }
}