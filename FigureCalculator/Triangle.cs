namespace FigureCalculator
{
    public class Triangle : Figure
    {
        public double FirstSide { get; private set; }

        public double SecondSide { get; private set; }

        public double ThirdSide { get; private set; }

        public bool IsRightTriangle { get; private set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            ValidateTriangle(firstSide, secondSide, thirdSide);

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            IsRightTriangle = ValidateIsRightTriangle();
            Square = CalculateSquare();
        }

        protected override double CalculateSquare()
        {
            var halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
        }

        private void ValidateTriangle(double firstSide, double secondSide, double thirdSide) 
        {
            if (!(ValidateSide(firstSide) && ValidateSide(secondSide) && ValidateSide(thirdSide))) {
                throw new ArgumentException("Side is less or equal zero");
            }
        }

        private bool ValidateSide(double side)
        {
            return side > 0;
        }

        private bool ValidateIsRightTriangle()
        {
            var hypotenuse = new[] { FirstSide, SecondSide, ThirdSide }.Max();
            return hypotenuse * hypotenuse + hypotenuse * hypotenuse 
                == FirstSide * FirstSide + SecondSide * SecondSide + ThirdSide * ThirdSide;
        }
    }
}
