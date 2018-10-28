using lab1SecondMiha.Figure;

namespace lab1SecondMiha.Builder
{
    /*
     * Конкретный строитель круга
     */
    public class CircleBuilder
    {
        public static IFigure BuildCircle(double Radius)
        {
            return new Circle(Radius);
        }
    }
}