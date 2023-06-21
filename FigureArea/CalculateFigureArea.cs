namespace FigureArea;

public class CalculateFigureArea : ICalculateFigureArea
{
        public double CalculateArea(dynamic shape)
        {
            if (shape is IFigure figure)
            {
                return figure.Area();
            }

            throw new ArgumentException("Не является фигурой.");
        }
}