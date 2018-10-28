using System;
using lab1SecondMiha.Builder;
using lab1SecondMiha.Figure;

namespace lab1SecondMiha
{
    /*
     * Демонстрация работы порождающего шаблона "Строитель"
     */
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            IFigure figure1 = Director.BuildThreeAngle(1, 2, 3);
            IFigure figure2 = Director.BuildCircle(1);
            IFigure figure3 = Director.BuildSquare(1);
            Console.WriteLine(figure1.GetPerimeter());
            Console.WriteLine(figure2.GetPerimeter());
            Console.WriteLine(figure3.GetPerimeter());
        }
    }
}