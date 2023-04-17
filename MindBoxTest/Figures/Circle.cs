namespace MindBoxTest.Figures
{
    public class Circle : IFigure
    {
        public double Radius;

        public Circle(double r)
        {
            Radius = r;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
