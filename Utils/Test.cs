using Xunit;
using MyUtilities;

public class Tests
    {
        [Fact]
        public void PassingPower()
        {
            Assert.Equal(7, Matz.Root(49));
        }
    }
