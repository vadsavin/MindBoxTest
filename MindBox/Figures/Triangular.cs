namespace MindBoxTest.Figures
{
    public class Triangular : IFigure
    {
        public double A, B, C;
        public Triangular(double _a, double _b, double _c)
        {
            A = _a;
            B = _b;
            C = _c;
        }

        public double GetArea()
        {
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
