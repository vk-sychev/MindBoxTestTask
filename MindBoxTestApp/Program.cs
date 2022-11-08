using FigureCalculator;

namespace MindBoxTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(10);
            var triangle = new Triangle(2, 2, 3);

            Console.WriteLine($"Circle's square: {circle.Square}");
            Console.WriteLine($"Triangle's square: {triangle.Square}");
        }
    }
}