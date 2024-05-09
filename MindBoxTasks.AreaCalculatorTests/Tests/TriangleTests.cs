using FluentAssertions;
using MindBoxTasks.AreaCalculatorTests.Fakers;
using MindBoxTasks.Common.Models;
using Xunit;

namespace MindBoxTasks.AreaCalculatorTests.Tests;

public class TriangleTests
{
    private readonly TriangleFaker _faker = new TriangleFaker();

    [Fact]
    public void Creation_With_NegativeSide_ShouldThrow_ArgumentException()
    {
        // Arrange
        double a = 10, b = 20, c = -1;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
    
    [Fact]
    public void Creation_With_ImpossibleSides_ShouldThrow_ArgumentException()
    {
        // Arrange
        double a = 50, b = 50, c = 100;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
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