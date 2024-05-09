using FluentAssertions;
using MindBoxTasks.AreaCalculatorTests.Fakers;
using MindBoxTasks.Common.Models;
using Xunit;

namespace MindBoxTasks.AreaCalculatorTests.Tests;

public class CircleTests
{
    private readonly CircleFaker _faker = new CircleFaker();
    
    [Fact]
    public void Creation_With_InvalidRadius_ShouldThrow_ArgumentException()
    {
        // Arrange
        double r = 0;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(r));
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