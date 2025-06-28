using Xunit;

namespace SingleInstanceApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void SampleTest()
        {
            // Arrange
            int expected = 5;
            int actual = 2 + 3;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}


