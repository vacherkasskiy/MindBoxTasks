using MindBoxTasks.Common.Models.Interfaces;

namespace MindBoxTasks.Common.Models;

public class Rectangle : IShape
{
    public double A { get; }
    public double B { get; }

    public Rectangle(double a, double b)
    {
        if (a <= 0 || b <= 0)
        {
            throw new ArgumentException("Rectangle sides must be greater than 0.");
        }
        
        A = a;
        B = b;
    }

    public double GetPerimeter()
    {
        return (A + B) * 2;
    }
}