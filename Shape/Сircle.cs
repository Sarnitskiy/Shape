namespace Shape
{
    public class Сircle : IShape
    {
        public Сircle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Argument must be positive number");
            }

            R = r;
        }

        public double R { get; }

        public double Area() => Math.PI * R * R;
    }
}
