using FigureArea.Interfaces;
using FigureArea.Models;

namespace Application
{
    public class FigureService : IFigureService
    {
        public double GetArea(IFigure figure)
        {
            return figure.GetArea();
        }

        public bool IsRight(Triangle triangle)
        {
            var squareA = triangle.SideA * triangle.SideA;
            var squareB = triangle.SideB * triangle.SideB;
            var squareC = triangle.SideC * triangle.SideC;

            return squareA == squareB + squareC ||
                squareB == squareC + squareA ||
                squareC == squareA + squareB;
        }
    }
}
