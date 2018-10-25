using lab1SecondMiha.Figure;

namespace lab1SecondMiha.Builder
{
    public class CircleBuilder
    {
        public static IFigure BuildCircle(double Radius)
        {
            return new Circle(Radius);
        }
    }
}