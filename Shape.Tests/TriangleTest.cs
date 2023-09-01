namespace Shape.Tests
{
    public class TriangleTest
    {
        [Test]
        public void IsArgumentsPositive()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 2, 3));
        }

        [Test]
        public void IsExist()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 2));
        }

        [Test]
        public void Area()
        {
            var triangle = new Triangle(3, 2, 2);

            var area = triangle.Area();

            Assert.That(Math.Round(area, 2, MidpointRounding.AwayFromZero), Is.EqualTo(1.98));
        }

        [Test]
        public void IsRightTriangle_True()
        {
            var triangle = new Triangle(6, 8, 10);

            var isRight = triangle.IsRightTriangle();

            Assert.That(isRight, Is.True);
        }

        [Test]
        public void IsRightTriangle_False()
        {
            var triangle = new Triangle(6, 8, 9);

            var isRight = triangle.IsRightTriangle();

            Assert.That(isRight, Is.False);
        }
    }
}