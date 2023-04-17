using MindBoxTest;
using MindBoxTest.Figures;
using MindBoxTest.Planemetry;

namespace MindBoxTests
{
    [TestClass]
    public class PlanemetryTests
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            Dictionary<IFigure, double> figures = new Dictionary<IFigure, double>()
            {
                { new Triangular(2,2,3), 1.984313483298443 },
                { new Triangular(1,2,3), 0 },
                { new Circle(1), Math.PI },
                { new Circle(0), 0 },
            };

            foreach (var pair in figures)
            {
                Assert.AreEqual(pair.Value, pair.Key.GetArea());
            }
        }

        [TestMethod]
        public void IsRightTriangularTest()
        {
            Dictionary<Triangular, bool> triangulars = new Dictionary<Triangular, bool>()
            {
                { new Triangular(1,20,20), false },
                { new Triangular(3,4,5), true }
            };

            foreach (var pair in triangulars)
            {
                Assert.AreEqual(pair.Value, pair.Key.IsRight());
            }
        }
    }
}