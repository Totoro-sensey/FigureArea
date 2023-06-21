namespace FigureArea;

/// <summary>
/// Интерфейс для получения площади фигуры
/// </summary>
public interface ICalculateFigureArea
{
    /// <summary>
    /// Метод для получения площади фигуры
    /// </summary>
    /// <param name="figure"></param>
    /// <returns></returns>
    public double CalculateArea(dynamic figure);
}