using Application;
using FigureArea.Models;

namespace FigureTests
{
    public class FigureServiceTests
    {
        [Theory]
        [InlineData(1, 2, 3, 0)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(2.5, 4.1, 3.3, 4.12)]
        public void GetArea_Triangle(double sideA, double sideB, double sideC, double result)
        {
            var triangle = Triangle.Create(sideA, sideB, sideC);

            var figureService = new FigureService();

            Assert.Equal(result, figureService.GetArea(triangle.Value), 0.01);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 3.14)]
        [InlineData(2.5, 19.63)]
        public void GetArea_Circle(double radius, double result)
        {
            var circle = Circle.Create(radius);

            var figureService = new FigureService();

            Assert.Equal(result, figureService.GetArea(circle.Value), 0.01);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(2, 2, 3, false)]
        public void IsRight_Triangle(double sideA, double sideB, double sideC, bool result)
        {
            var triangle = Triangle.Create(sideA, sideB, sideC);

            var figureService = new FigureService();

            Assert.Equal(result, figureService.IsRight(triangle.Value));
        }
    }
}
