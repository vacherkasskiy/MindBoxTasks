using FluentAssertions;
using MindBoxTasks.AreaCalculatorTests.Fakers;
using MindBoxTasks.Common.Models;
using Xunit;

namespace MindBoxTasks.AreaCalculatorTests.Tests;

public class TriangleTests
{
    private readonly TriangleFaker _faker = new TriangleFaker();

    [Theory]
    [InlineData(-1, 4, 5)]
    [InlineData(5, -6, 13)]
    [InlineData(6, 8, -1)]
    [InlineData(-4, -3, -6)]
    [InlineData(0, 4, 5)]
    [InlineData(5, 0, 13)]
    [InlineData(6, 8, 0)]
    [InlineData(0, 0, 0)]
    public void Creation_With_NonPositiveSide_ShouldThrow_ArgumentException(
        double a,
        double b,
        double c)
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
    
    [Theory]
    [InlineData(100, 50, 50)]
    [InlineData(2, 100, 3)]
    [InlineData(10, 10, 137)]
    public void Creation_With_ImpossibleSides_ShouldThrow_ArgumentException(
        double a,
        double b,
        double c)
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
    
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(5, 12, 13, true)]
    [InlineData(6, 8, 10, true)]
    [InlineData(3, 3, 3, false)]
    [InlineData(4, 5, 6, false)]
    public void IsRightAngled_ShouldReturn_CorrectValue(
        double a,
        double b,
        double c,
        bool expectedValue)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var actualValue = triangle.IsRightAngled;

        // Assert
        Assert.Equal(expectedValue, actualValue);
    }
    
    [Fact]
    public void GetPerimeter_ShouldReturn_CorrectAnswer()
    {
        // Arrange
        var triangle = _faker.Generate().Single();
        var expected = triangle.A + triangle.B + triangle.C;

        // Act
        var result = triangle.GetPerimeter();

        // Assert
        result.Should().Be(expected);
    }
}