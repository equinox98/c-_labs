namespace lab1SecondMiha.Figure
{
    public class ThreeAngle: IFigure
    {
        private double A, B, C;

        public ThreeAngle(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        
        public double GetPerimeter()
        {
            return A + B + C;
        }
    }
}