namespace MindBoxTasks.Common.Models.Interfaces;

/// <summary>
/// Все фигуры должны реализовывать данный интерфейс.
/// Иначе не получится достичь удобства добавления новых фигур.
/// </summary>
public interface IShape
{
    double GetPerimeter();
}