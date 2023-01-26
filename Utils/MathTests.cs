using Xunit;
using MyUtilities;

public class MathTests
{
    [Fact]
    public void Tests()
    {
        Assert.Equal(25, Matz.Power(5, 2));
        Assert.Equal(7, Matz.Root(49));
        Assert.Equal(99, Matz.Max(99, 56));
        Assert.Equal(56, Matz.Min(99, 56));
        Assert.Equal(69, Matz.Add(54, 15));
        Assert.Equal(420, Matz.Subtract(469, 49));
        Assert.Equal(1467, Matz.Multiply(3, 489));
        Assert.Equal(8008135, Matz.Divide(16016270, 2));
        Assert.Equal(12, Matz.AreaOfRectangle(3, 4));
        Assert.Equal(1134.11494795, Matz.FindCircleArea(19.0));
        Assert.Equal(3204, Matz.FindRectPrismArea(89, 3, 12));
        Assert.Equal(967, Matz.Negate(-967));
    }
}
