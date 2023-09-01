namespace Shape
{
    public class Triangle : IShape
    {
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 ||  b <= 0 || c <= 0)
            {
                throw new ArgumentException("Arguments must be positive numbers");
            }

            var triangleSides = new double[] { a, b, c };
            Array.Sort(triangleSides);

            if (triangleSides[2] >= triangleSides[0] + triangleSides[1])
            {
                throw new ArgumentException($"The triangle with sides ({a}, {b}, {c}) does not exist");
            }

            A = triangleSides[0];
            B = triangleSides[1];
            C = triangleSides[2];
        }

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public double Area()
        {
            var semiperimeter = Perimetr() / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C));
        }

        public bool IsRightTriangle() => A * A + B * B == C * C;

        private double Perimetr() => A + B + C;
    }
}
