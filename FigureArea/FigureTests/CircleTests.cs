using FigureArea.Models;

namespace FigureTests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_NegativeRadius_ResultFailure()
        {
            var radius = -1;

            var circle = Circle.Create(radius);

            Assert.True(circle.IsFailure);
        }

        [Fact]
        public void Circle_PositiveRadius_ResultSuccess()
        {
            var radius = 1;

            var circle = Circle.Create(radius);

            Assert.True(circle.IsSuccess);
        }
    }
}