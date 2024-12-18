﻿using AutoBogus;
using Bogus;
using MindBoxTasks.Common.Models;

namespace MindBoxTasks.AreaCalculatorTests.Fakers;

public class TriangleFaker
{
    private readonly Faker<Triangle> _autoFaker = new AutoFaker<Triangle>()
        .CustomInstantiator(f => new Triangle(
            f.Random.Double(50, 100),
            f.Random.Double(50, 100),
            f.Random.Double(50, 100))); 

    public IEnumerable<Triangle> Generate(int count = 1)
    {
        var result = new List<Triangle>();

        for (var i = 0; i < count; ++i)
        {
            result.Add(_autoFaker.Generate());
        }

        return result;
    }
}