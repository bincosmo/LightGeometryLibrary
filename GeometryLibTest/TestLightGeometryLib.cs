using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary.Light;
namespace GeometryLibTest;

[TestClass]
public class TestLightGeometryLib
{
    [TestMethod]
    public void TestRectangleArea()
    {
        var rectangle = new Rectangle();
        double arg1 = 2;
        double arg2 = 9;
        double expected = 18;

        double result = rectangle.Area(arg1, arg2);

        Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void TestCircleArea()
    {
        var circle = new Circle();
        double arg1 = 3;
        double expected = 28.274333882308138;

        double result = circle.Area(arg1);
        Assert.AreEqual(expected, result);
       
    }
    [TestMethod]
    public void TestTriangleArea()
    {
        var triangle = new Triangle();
        double arg1 = 3;
        double arg2 = 4;
        double arg3 = 5;
        double expected = 6;

        double result = triangle.Area(arg1, arg2, arg3);
        Assert.AreEqual(expected, result);
       
    }

}