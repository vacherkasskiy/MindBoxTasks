using MindBoxTasks.AreaCalculator;
using MindBoxTasks.AreaCalculatorTests.Fakers;
using Xunit;

namespace MindBoxTasks.AreaCalculatorTests.Tests;

public class CalculatorTests
{
    private readonly TriangleFaker _triangleFaker = new TriangleFaker();
    private readonly CircleFaker _circleFaker = new CircleFaker();
    private readonly RectangleFaker _rectangleFaker = new RectangleFaker();

    [Fact]
    public void GetTriangleArea_ShouldReturn_CorrectAnswer()
    {
        // Arrange
        var triangle = _triangleFaker.Generate().Single();
        double p = triangle.GetPerimeter() / 2, a = triangle.A, b = triangle.B, c = triangle.C;
        var expectedArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        // Act
        var actualArea = triangle.GetArea();

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }
    
    [Fact]
    public void GetCircleArea_ShouldReturn_CorrectAnswer()
    {
        // Arrange
        var circle = _circleFaker.Generate().Single();
        var expectedArea = Math.PI * circle.Radius * circle.Radius;

        // Act
        var actualArea = circle.GetArea();

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void GetArea_With_UnsupportedShape_ShouldThrow_ArgumentException()
    {
        // Arrange
        var rectangle = _rectangleFaker.Generate().Single();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => rectangle.GetArea());
    }
}