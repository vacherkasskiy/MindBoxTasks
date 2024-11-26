using MindBoxTasks.Common.Models;
using MindBoxTasks.Common.Models.Interfaces;

namespace MindBoxTasks.AreaCalculator;

public static class AreaCalculator
{
    private static readonly Dictionary<Type, Func<IShape, double>> AreaCalculators = new()
    {
        { typeof(Circle), shape => CalculateCircleArea((Circle)shape) },
        { typeof(Triangle), shape => CalculateTriangleArea((Triangle)shape) },
        // Add new shapes here. They have to implement IShape interface.
    };

    public static double GetArea(this IShape shape)
    {
        if (AreaCalculators.TryGetValue(shape.GetType(), out var calculator))
        {
            return calculator(shape);
        }
        throw new ArgumentException("Unsupported shape type.");
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