namespace FigureCalculator
{
    public abstract class Figure
    {
        public double Square { get; set; }

        protected abstract double CalculateSquare();
    }
}