using ShapeLibrary;

namespace MinBoxTestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Circle(2.0),
                new Triangle(5, 5, 6)
            };

            shapes.ForEach(s => Console.WriteLine(s.GetArea()));
        }
    }
}