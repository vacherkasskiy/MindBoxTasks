using MindBoxTasks.AreaCalculator.Models.Interfaces;

namespace MindBoxTasks.AreaCalculator.Models;

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

    public int GetPerimeter()
    {
        throw new NotImplementedException();
    }
}