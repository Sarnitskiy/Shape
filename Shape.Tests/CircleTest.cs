namespace Shape.Tests
{
    public class CircleTest
    {
        [Test]
        public void IsArgumentPositive()
        {
            Assert.Throws<ArgumentException>(() => new Сircle(-2));
        }

        [Test]
        public void Area8()
        {
            var circle = new Сircle(3);

            Assert.That(circle.Area(), Is.EqualTo(Math.PI * circle.R * circle.R));
        }
    }
}
