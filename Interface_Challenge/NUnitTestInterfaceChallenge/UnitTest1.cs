using NUnit.Framework;
using ClassLibraryInterfaceChallenge;
namespace Tests
{
    public class Tests
    {
        Triangle Triangle;
        Square Square;
        Rectangle Rectangle;
        RightAngle RightAngle;
        Equllateral Equllateral;
        Circle Circle;
        [SetUp]
        public void Setup()
        {
            Triangle = new Triangle();
            Square = new Square();
            Rectangle = new Rectangle();
            RightAngle = new RightAngle();
            Circle = new Circle();
        }

        [Test]
        [TestCase(5,25,20)]
        [TestCase(15, 225, 60)]
        [TestCase(7, 49, 28)]
        public void TestSquare(double Side1,double ExpectedArea,double ExpectedPerimeter)
        {
            Square nSquare = new Square(Side1);
            Assert.AreEqual(ExpectedArea, nSquare.GetArea());
            Assert.AreEqual(ExpectedPerimeter, nSquare.GetPerimeter());
        }
        [TestCase(5, 10, 50, 30)]
        [TestCase(4, 6, 24, 20)]
        [TestCase(9, 7, 63, 32)]
        public void TestRectangle(double Side1,double Side2, double ExpectedArea, double ExpectedPerimeter)
        {
            Rectangle nRectangle = new Rectangle(Side1, Side2);
            Assert.AreEqual(ExpectedArea,nRectangle.GetArea());
            Assert.AreEqual(ExpectedPerimeter,nRectangle.GetPerimeter());
        }
        [TestCase(5, 10.83, 15)]
        [TestCase(15, 97.43, 45)]
        [TestCase(7, 21.22, 21)]
        public void TestEquilateral(double Side1, double ExpectedArea, double ExpectedPerimeter)
        {
            Equllateral nEqullateral = new Equllateral(Side1);
            Assert.AreEqual(ExpectedArea, nEqullateral.GetArea());
            Assert.AreEqual(ExpectedPerimeter, nEqullateral.GetPerimeter());
        }
        [TestCase(5, 10, 25, 26.18)]
        [TestCase(4, 6, 12, 17.21)]
        [TestCase(9, 7, 31.5, 27.4)]
        public void TestRightAngle(double Side1, double Side2, double ExpectedArea, double ExpectedPerimeter)
        {
            RightAngle nRightAngle = new RightAngle(Side1, Side2);
            Assert.AreEqual(ExpectedArea,nRightAngle.GetArea());
            Assert.AreEqual(ExpectedPerimeter,nRightAngle.GetPerimeter());
        }
        [TestCase(5, 78.55, 31.42)]
        [TestCase(15, 706.95, 94.26)]
        [TestCase(7, 153.96, 43.99)]
        public void Testcircle(double Radius, double ExpectedArea, double ExpectedPerimeter)
        {
            Circle nCircle = new Circle(Radius);
            Assert.AreEqual(ExpectedArea,nCircle.GetArea());
            Assert.AreEqual(ExpectedPerimeter,nCircle.GetPerimeter());
        }
    }
}