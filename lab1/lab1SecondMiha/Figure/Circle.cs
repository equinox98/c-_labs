namespace lab1SecondMiha.Figure
{
    public class Circle: IFigure
    {
        private double Radius;

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        
        public double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }
    }
}