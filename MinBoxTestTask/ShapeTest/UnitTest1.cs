using ShapeLibrary;

namespace ShapeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RightAngle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var result = triangle.IsRightAngled();
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void WrongTriangle()
        {
            IShape shape = new Triangle(10, 2, 3);
            var result = shape.GetArea();
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CommonTriangle()
        {
            IShape shape = new Triangle(5, 5, 6);
            var result = shape.GetArea();
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void CommonCircle()
        {
            IShape shape = new Circle(2);
            var result = shape.GetArea();
            Assert.That(result, Is.AtLeast(12));
        }
    }
}