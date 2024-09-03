using Core.Validation;
using CSharpFunctionalExtensions;
using FigureArea.Interfaces;

namespace FigureArea.Models
{
    public class Triangle : IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        private Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {
            var p = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public static Result<Triangle> Create(double sideA, double sideB, double sideC)
        {
            var validator = new Validator();

            if (validator.IsPositive(sideA)
                .IsPositive(sideB)
                .IsPositive(sideC)
                .IsTriangle(sideA, sideB, sideC).IsValid)
                return Result.Success(new Triangle(sideA, sideB, sideC));

            return Result.Failure<Triangle>("Invalid triangle");
        }
    }
}
