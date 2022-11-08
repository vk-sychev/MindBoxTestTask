namespace FigureCalculator
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        private readonly double _pi = 3.14; //or Pi from Math lib could be used

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius is less or equal zero");
            }

            Radius = radius;
            Square = CalculateSquare();
        }


        protected override double CalculateSquare()
        {
            return _pi * Radius * Radius;
        }
    }
}
