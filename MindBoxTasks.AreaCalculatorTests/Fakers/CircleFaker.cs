using AutoBogus;
using Bogus;
using MindBoxTasks.Common.Models;

namespace MindBoxTasks.AreaCalculatorTests.Fakers;

public class CircleFaker
{
    private readonly Faker<Circle> _autoFaker = new AutoFaker<Circle>()
        .CustomInstantiator(f => new Circle(f.Random.Double(1, 100))); 

    public IEnumerable<Circle> Generate(int count = 1)
    {
        var result = new List<Circle>();

        for (var i = 0; i < count; ++i)
        {
            result.Add(_autoFaker.Generate());
        }

        return result;
    }
}