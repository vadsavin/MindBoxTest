using MindBoxTest.Figures;

namespace MindBoxTest.Planemetry
{
    public static class PlanemetryHelper
    {
        public static bool IsRight(this Triangular triangular)
        {
            var arrayOfSides = new double[] {triangular.A, triangular.B, triangular.C}.OrderByDescending(item => item).ToArray();
            return (arrayOfSides[0]*arrayOfSides[0]) == (arrayOfSides[1]*arrayOfSides[1]) + (arrayOfSides[2]*arrayOfSides[2]);            
        }

        public static double GetArea(this IFigure figure)
        {
            return figure.GetArea();
        }
    }
}
