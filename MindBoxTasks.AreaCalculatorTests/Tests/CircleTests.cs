using MindBoxTasks.AreaCalculator.Models;
using Xunit;

namespace MindBoxTasks.AreaCalculatorTests.Tests;

public class CircleTests
{
    [Fact]
    public void CircleCreation_WithInvalidRadius_ShouldThrowArgumentException()
    {
        // Arrange
        double r = 0;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(r));
    }
}