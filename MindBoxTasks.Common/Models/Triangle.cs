using MindBoxTasks.Common.Models.Interfaces;
using MindBoxTasks.Common.Utils;

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
        var max = MyMath.Max(a, b, c);
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
        var a = MyMath.Max(A, B, C);
        var b = MyMath.Min(A, B, C);
        var c = GetPerimeter() - a - b;

        return (Math.Abs(a * a - (b * b + c * c)) < Tolerance);
    }
}