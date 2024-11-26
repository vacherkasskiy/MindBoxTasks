using MindBoxTasks.Common.Models.Interfaces;

namespace MindBoxTasks.Common.Models;

public class Triangle : IShape
{
    private const double Tolerance = 1e-9;
    public double A { get; }
    public double B { get; }
    public double C { get; }
    public bool IsRightAngled => CheckIfRightAngled();

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Triangle sides must be greater than 0.");
        }

        var sum = a + b + c;
        var max = Max(a, b, c);
        if (max >= sum - max)
        {
            throw new ArgumentException("Triangle with provided sides cannot exist.");
        }
        
        A = a;
        B = b;
        C = c;
    }

    public double GetPerimeter()
    {
        return A + B + C;
    }

    private bool CheckIfRightAngled()
    {
        var a = Max(A, B, C);
        var b = Min(A, B, C);
        var c = GetPerimeter() - a - b;

        return (Math.Abs(a * a - (b * b + c * c)) < Tolerance);
    }

    private double Max(params double[] values)
    {
        return values.Max();
    }
    
    private double Min(params double[] values)
    {
        return values.Min();
    }
    
}