using FigureArea.Models;

namespace FigureTests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(-2, 3, 2)]
        [InlineData(1, 1, 3)]
        public void Triangle_InvalidTriangle_ResultFailure(double sideA, double sideB, double sideC)
        {
            var triangle = Triangle.Create(sideA, sideB, sideC);

            Assert.True(triangle.IsFailure);
        }

        [Fact]
        public void Triangle_AllPositiveArguments_ResultSuccess()
        {
            var sideA = 2;
            var sideB = 3;
            var sideC = 2;

            var triangle = Triangle.Create(sideA, sideB, sideC);

            Assert.True(triangle.IsSuccess);
        }
    }
}
