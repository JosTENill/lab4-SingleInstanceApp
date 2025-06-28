using Xunit;
using SingleInstanceApp;

namespace SingleInstanceApp.Tests
{
    public class AppMutexManagerTests
    {
        [Fact]
        public void IsOnlyInstance_ShouldReturnTrue_WhenFirstInstance()
        {
            var mutexManager = new AppMutexManager();
            var result = mutexManager.IsOnlyInstance();
            Assert.True(result);
            mutexManager.Release();
        }
    }
}


