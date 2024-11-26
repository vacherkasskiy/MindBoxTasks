using MindBoxTasks.AreaCalculator;
using MindBoxTasks.Common.Models;
using MindBoxTasks.Common.Models.Interfaces;

var circle = (IShape)new Circle(5);
Console.WriteLine($"Площадь круга: {circle.GetArea()}");

var triangle = (IShape)new Triangle(3, 4, 5);
Console.WriteLine($"Площадь треугольника: {triangle.GetArea()}");
Console.WriteLine($"Прямоугольный: {((Triangle)triangle).IsRightAngled}");