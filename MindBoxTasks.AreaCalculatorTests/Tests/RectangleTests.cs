using FluentAssertions;
using MindBoxTasks.AreaCalculatorTests.Fakers;
using MindBoxTasks.Common.Models;
using Xunit;

namespace MindBoxTasks.AreaCalculatorTests.Tests;

public class RectangleTests
{
    private readonly RectangleFaker _faker = new RectangleFaker();
    
    [Theory]
    [InlineData(0, 10)]
    [InlineData(5, 0)]
    [InlineData(-1, 2)]
    [InlineData(-3, 4)]
    [InlineData(-1, -1)]
    [InlineData(0, 0)]
    public void Creation_With_NegativeSide_ShouldThrow_ArgumentException(double a, double b)
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new Rectangle(a, b));
    }
    
    [Fact]
    public void GetPerimeter_ShouldReturn_CorrectAnswer()
    {
        // Arrange
        var rectangle = _faker.Generate().Single();
        var expected = (rectangle.A + rectangle.B) * 2;

        // Act
        var result = rectangle.GetPerimeter();

        // Assert
        result.Should().Be(expected);
    }
}