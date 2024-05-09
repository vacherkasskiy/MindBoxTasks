using FluentAssertions;
using MindBoxTasks.AreaCalculatorTests.Fakers;
using MindBoxTasks.Common.Models;
using Xunit;

namespace MindBoxTasks.AreaCalculatorTests.Tests;

public class RectangleTests
{
    private readonly RectangleFaker _faker = new RectangleFaker();
    
    [Fact]
    public void Creation_With_NegativeSide_ShouldThrow_ArgumentException()
    {
        // Arrange
        double a = 10, b = -1;
        
        // Act & Assert
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