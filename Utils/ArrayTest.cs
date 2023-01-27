using Xunit;
using MyUtilities;

public class ArrayTests
    {
        [Fact]
        public void Array()
        {
            int[] Soup = new int[] {2, 4, 6, 7, 1};
            int[] NewSoup = new int[] {1, 4, 6, 7, 1};
            Assert.Equal(4, ArrayUtils.Average(Soup));
            Assert.Equal(4, ArrayUtils.Max(Soup));
            Assert.Equal(4, ArrayUtils.Min(Soup));
            Assert.Equal(4, ArrayUtils.Average(Soup));
            Assert.Equal(4, ArrayUtils.Average(Soup));
            Assert.Equal(4, ArrayUtils.Average(Soup));
            Assert.Equal(4, ArrayUtils.Average(Soup));
            Assert.Equal(4, ArrayUtils.Average(Soup));
            Assert.Equal(4, ArrayUtils.Average(Soup));
            Assert.Equal(4, ArrayUtils.Average(Soup));
            Assert.Equal(4, ArrayUtils.Average(Soup));
        }
    }