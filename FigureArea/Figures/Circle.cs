namespace FigureArea;

/// <summary>
/// Класс для работы с кругом
/// </summary>
public class Circle : IFigure
{
    private double Radius { get; set; }

    public Circle(double radius)
    {
        if ( radius <= 0.0 )
            throw new InvalidDataException( "Радиус должен быть больше 0" );
        
        Radius = radius;
    }
    
    public override double Area()
    {
        return Math.Round(3.14f * Math.Pow(Radius, 2), 2);
    }
}