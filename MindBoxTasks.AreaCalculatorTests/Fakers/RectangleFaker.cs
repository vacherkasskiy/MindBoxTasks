using AutoBogus;
using Bogus;
using MindBoxTasks.Common.Models;

namespace MindBoxTasks.AreaCalculatorTests.Fakers;

public class RectangleFaker
{
    private readonly Faker<Rectangle> _autoFaker = new AutoFaker<Rectangle>()
        .CustomInstantiator(f => new Rectangle(
            f.Random.Double(50, 100),
            f.Random.Double(50, 100))); 

    public IEnumerable<Rectangle> Generate(int count = 1)
    {
        var result = new List<Rectangle>();

        for (var i = 0; i < count; ++i)
        {
            result.Add(_autoFaker.Generate());
        }

        return result;
    }
}