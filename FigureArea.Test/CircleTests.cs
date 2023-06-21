namespace FigureArea.Test;

public class CircleTests
{
    [Test]
    public void CirclePassingTest()
    {
        var circle = new Circle(5);
        Assert.That(circle.Area(), Is.EqualTo(78.5));
    }
    
    [Test]
    public void CircleFailingTest()
    {
        var circle = new Circle(3);
        Assert.That(circle.Area(), !Is.EqualTo(9));
    }
    
    [Test]
    public void CircleInvalidDataTest()
    {
        Assert.Throws<InvalidDataException>(() =>
        {
            var circle = new Circle(-3);
        });
    }
}