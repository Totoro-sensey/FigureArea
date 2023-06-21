namespace FigureArea.Test;

public class TriangleTests
{
    [Test]
    public void TrianglePassingTest2()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.Area(), Is.EqualTo(6));
    }
    
    [Test]
    public void TriangleFailingTest()
    {
        var triangle = new Triangle(3, 6, 8);
        Assert.That(triangle.Area(), !Is.EqualTo(9));
    }
    
    [Test]
    public void TriangleInvalidDataTest()
    {
        Assert.Throws<InvalidDataException>(() =>
        {
            var triangle = new Triangle(-3, 6, 8);
        });
    }
    
    [Test]
    public void TriangleArgumentExceptionTest()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(1, 6, 8);
        });
    }
    
    [Test]
    public void TriangleIsRectangularPassingTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.IsRectangular(), Is.True);
    }
    
    [Test]
    public void TriangleIsRectangularFailingTest()
    {
        var triangle = new Triangle(3, 7, 5);
        Assert.That(triangle.IsRectangular(), Is.False);
    }
}