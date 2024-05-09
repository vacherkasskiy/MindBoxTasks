using MindBoxTasks.Common.Models;
using MindBoxTasks.Common.Models.Interfaces;

namespace MindBoxTasks.AreaCalculator;

public static class AreaCalculator
{
    public static double GetArea(this IShape shape)
    {
        return shape switch
        {
            Triangle triangle => CalculateTriangleArea(triangle),
            Circle circle => CalculateCircleArea(circle),
            // Add new shapes here. They have to implement IShape interface.
            _ => throw new ArgumentException("Unsupported shape type.")
        };
    }
    
    private static double CalculateTriangleArea(Triangle triangle)
    {
        var p = triangle.GetPerimeter() / 2;
        var a = triangle.A;
        var b = triangle.B;
        var c = triangle.C;
        
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    private static double CalculateCircleArea(Circle circle)
    {
        return Math.PI * circle.Radius * circle.Radius;
    }
}