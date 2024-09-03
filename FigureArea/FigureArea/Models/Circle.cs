using Core.Validation;
using CSharpFunctionalExtensions;
using FigureArea.Interfaces;

namespace FigureArea.Models
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        private Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return MathF.PI * Radius * Radius;
        }

        public static Result<Circle> Create(double radius)
        {
            var validator = new Validator();

            if (validator.IsPositive(radius).IsValid)
                return Result.Success(new Circle(radius));

            return Result.Failure<Circle>("Invalid circle");
        }
    }
}
