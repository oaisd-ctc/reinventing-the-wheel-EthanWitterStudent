using Xunit;
using MyUtilities;

public class SoupTests
    {
        [Fact]
        public void SoupTesting()
        {
            int[] Soup = new int[] {2, 4, 6, 7, 1};
            int[] NewSoup = new int[] {1, 4, 6, 7, 1};
            int[] NewerSoup = new int[] {1, 2, 4, 6, 7};
            int[] NewestSoup = new int[] {7, 6, 4, 2, 1};
            int[] SoupMarioSunshine = new int[] {1, 7, 6, 4, 2};
            int[] SoupSmashBrosUltimate = new int[] {2, 4, 6, 7, 1};
            Assert.Equal(4, ArrayUtils.Average(Soup));
            Assert.Equal(7, ArrayUtils.Max(Soup));
            Assert.Equal(1, ArrayUtils.Min(Soup));
            Assert.Equal(NewerSoup, ArrayUtils.SortAscending(Soup));
            Assert.Equal(NewestSoup, ArrayUtils.SortDescending(Soup));
            Assert.Equal(20, ArrayUtils.Sum(Soup));
            Assert.Equal(336, ArrayUtils.Product(Soup));
            Assert.Equal(SoupMarioSunshine, ArrayUtils.Reverse(Soup));
            Assert.Equal(4, ArrayUtils.Median(Soup));
            Assert.Equal(SoupSmashBrosUltimate, ArrayUtils.Mode(Soup));
            Assert.Equal(6, ArrayUtils.Range(Soup));
        }
    }