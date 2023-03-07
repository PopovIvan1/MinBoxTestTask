namespace ShapeLibrary
{
    public class Circle : IShape
    {
        readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
