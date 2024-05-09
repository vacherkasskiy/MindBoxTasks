using FluentAssertions;
using MindBoxTasks.AreaCalculatorTests.Fakers;
using MindBoxTasks.Common.Models;
using Xunit;

namespace MindBoxTasks.AreaCalculatorTests.Tests;

public class CircleTests
{
    private readonly CircleFaker _faker = new CircleFaker();
    
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Creation_With_InvalidRadius_ShouldThrow_ArgumentException(double radius)
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
    
    [Fact]
    public void GetPerimeter_ShouldReturn_CorrectAnswer()
    {
        // Arrange
        var circle = _faker.Generate().Single();
        var expected = 2 * Math.PI * circle.Radius;
        
        // Act
        var result = circle.GetPerimeter();
        
        // Act & Assert
        result.Should().Be(expected);
    }
}