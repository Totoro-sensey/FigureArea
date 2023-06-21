namespace FigureArea;

/// <summary>
/// Класс для работы с треугольником
/// </summary>
public class Triangle : IFigure
{
    /// <summary>
    /// Первая сторона
    /// </summary>
    private double SideA { get; set; }
    
    /// <summary>
    /// Вторая сторона
    /// </summary>
    private double SideB { get; set; }
    
    /// <summary>
    /// Третья сторона
    /// </summary>
    private double SideC { get; set; }

    /// <summary>
    /// Треугольник
    /// </summary>
    /// <param name="args">Стороны треугольника</param>
    /// <exception cref="InvalidDataException">Неверно указаны аргументы/Одна или несколько сторон меньше или навны нулю</exception>
    /// <exception cref="ArgumentException">Стороны не соответствуют правилу существования треугольников</exception>
    public Triangle(params double[] args)
    {
        if (args.Length != 3)
            throw new InvalidDataException( "Неверно указаны аргументы" );

        Array.Sort(args);
        SideA = args[0];
        SideB = args[1];
        SideC = args[2];
        
        if (SideA <= 0.0)
            throw new InvalidDataException( "Стороны должны быть больше нуля" );
        
        if (SideA + SideB < SideC)
            throw new ArgumentException( "Такого треугольника не существует" );
    }
    
    /// <summary>
    /// Метод для получения площади треугольника
    /// </summary>
    /// <returns>Площадь треугольника</returns>
    public override double Area()
    {
        var halfMeter = (SideA + SideB + SideC) / 2;
        var area = Math.Sqrt(halfMeter * (halfMeter - SideA) * (halfMeter - SideB) * (halfMeter - SideC));
        
        return area;
    }

    /// <summary>
    /// Метод проверки прямоугольности треугольника
    /// </summary>
    /// <returns>True, если треугольник прямоугольный, иначе False</returns>
    public bool IsRectangular()
    {
        const double tolerance = 1e-9;

        return Math.Abs(Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - Math.Pow(SideC, 2)) < tolerance;
    }
}