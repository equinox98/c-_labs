using lab1SecondMiha.Figure;

namespace lab1SecondMiha.Builder
{
    /*
     * Конкретный строитель трекгольник
     */
    public class ThreeAngleBuilder
    {
        public static IFigure BuildThreeAngle(double A, double B, double C)
        {
            return new ThreeAngle(A, B, C);
        }
    }
}