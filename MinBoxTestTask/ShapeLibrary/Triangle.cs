namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        readonly double a;
        readonly double b;
        readonly double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetArea()
        {
            if (!checkTriangle()) return 0;
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public bool IsRightAngled()
        {
            return a * a + b * b == c * c
                || a * a + c * c == b * b
                || b * b + c * c == a * a;
        }

        private bool checkTriangle()
        {
            return a + b > c
                && b + c > a
                && c + a > b;
        }
    }
}
