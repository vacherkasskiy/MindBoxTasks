using MindBoxTasks.AreaCalculator.Models;
using Xunit;

namespace MindBoxTasks.AreaCalculatorTests.Tests;

public class TriangleTests
{
    /// <summary>
    /// Шаблон для написания будущих тестов.
    /// TODO: Убрать.
    /// </summary>
    [Fact]
    public void Action_Condition_Result()
    {
        // Arrange
        
        // Act
        
        // Assert
    }
    
    [Fact]
    public void TriangleCreation_WithNegativeSide_ShouldThrowArgumentException()
    {
        // Arrange
        double a = 10, b = 20, c = -1;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
    
    [Fact]
    public void TriangleCreation_WithImpossibleSides_ShouldThrowArgumentException()
    {
        // Arrange
        double a = 50, b = 50, c = 100;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
}