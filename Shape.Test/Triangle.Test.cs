using System;
using NFluent;
using NUnit.Framework;

namespace Shape.Test
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void SideIsAlways3([Random(1, Int32.MaxValue, 100)] double side)
        {
            //A
            var trg = new Triangle(side, side + 1, side * 2, (int)Math.Floor(side+1), (int)(Math.Floor(side*2)));

            //A
            var sides = trg.SideNumber;

            //A
            Check.That(sides).Equals(3);
        }


        [Test]
        public void AnyMatterSide_NameIsTheSame([Random(1, Int32.MaxValue, 100)] double side)
        {
            //A
            var trg = new Triangle(side, side+1, side*2, 0, 0);

            //A
            var name = trg.Name;

            //A
            Check.That(name).Equals("Triangle");
        }

        [Test]
        public void AnyMatterPosition_PerimeterIsTheSame([Random(1, Int32.MaxValue, 10)] int x, [Random(1, Int32.MaxValue, 10)] int y)
        {
            //A
            var trg = new Triangle(4, 5, 6, x, y);

            //A
            var perimeter = trg.Perimeter();

            //A
            Check.That(perimeter).Equals(15.0);
        }

        [Test]
        public void AnyMatterPosition_AreaIsTheSame([Random(1, Int32.MaxValue, 10)] int x, [Random(1, Int32.MaxValue, 10)] int y)
        {
            //A
            var trg = new Triangle(4, 5, 6, x, y);

            //A
            var area = trg.Area();

            //A
            Check.That(Math.Abs(area - 9.92156741649221)).IsLessThan(0.000001);
        }



        [Test]
        public void EquilateralAreaPerimeterRatio([Random(1, Int32.MaxValue, 100)]double side1)
        {
            //A
            var trg = new Triangle(side1, side1, side1, 0 ,0);

            //A
            var ratio = trg.Area() / trg.Perimeter();

            //A
            Check.That(Math.Abs(ratio - side1 * 0.14433756729740643)).IsLessThan(0.000001);
        }


        [Test]
        [TestCase(1,2,3, ExpectedResult = 0d, TestName = "1,2,3 => 0")]
        [TestCase(1,1,2, ExpectedResult = 0d, TestName = "1,1,2 => 0")]
        [TestCase(4, 5, 6, ExpectedResult = 0.66143782776614768d, TestName = "4,5,6 => 0")]
        public double AreaPerimeterRatio(double side1, double side2, double side3)
        {
            //A
            var trg = new Triangle(side1, side2, side3, 0, 0);

            //A
            var ratio = trg.Area() / trg.Perimeter();

            //A
            return ratio;
        }

    }
}