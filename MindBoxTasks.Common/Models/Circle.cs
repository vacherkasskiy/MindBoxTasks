using MindBoxTasks.Common.Models.Interfaces;

namespace MindBoxTasks.Common.Models;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be greater than 0.");
        }
        
        Radius = radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}