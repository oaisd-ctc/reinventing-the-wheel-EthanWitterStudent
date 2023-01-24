using Xunit;
using MyUtilities;

public class Tests
    {
        [Fact]
        public void PassingPower()
        {
            Assert.Equal(2, Matz.Root(32,5));
        }
    }
