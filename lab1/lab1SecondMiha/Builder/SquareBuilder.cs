using lab1SecondMiha.Figure;

namespace lab1SecondMiha.Builder
{
    /*
     * Конкретный строитель квадрата
     */
    public class SquareBuilder
    {
        public static IFigure BuildSquare(double Side)
        {
            return new Square(Side);
        }
    }
}