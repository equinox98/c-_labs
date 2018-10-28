using lab1SecondMiha.Figure;

namespace lab1SecondMiha.Builder
{
    /*
     * Класс директор для работы с конкретными строителями фигур
     */
    public class Director
    {   
        public static IFigure BuildCircle(double Radius)
        {
            return CircleBuilder.BuildCircle(Radius);
        }

        public static IFigure BuildSquare(double Side)
        {
            return SquareBuilder.BuildSquare(Side);
        }

        public static IFigure BuildThreeAngle(double A, double B, double C)
        {
            return ThreeAngleBuilder.BuildThreeAngle(A, B, C);
        }
    }
}