using System;

namespace Shape
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var trg = new Triangle(1.0, 2.0, 3.0, 0, 0);

            Console.Write("{0} ist at [{1};{2}] and its area/perimeter is: {3}", trg.Name, trg.Position.Item1,
                trg.Position.Item2, trg.Area()/trg.Perimeter());
        }
    }
}