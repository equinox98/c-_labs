namespace lab1SecondMiha.Figure
{
    public class Square: IFigure
    {
        private double Side;

        public Square(double Side)
        {
            this.Side = Side;
        }
        
        public double GetPerimeter()
        {
            return 4 * Side;
        }
    }
}