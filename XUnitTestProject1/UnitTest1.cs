using System;
using System.Threading.Tasks;
using Demo;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task MyMethodAsync_ReturnFalse()
        {
            bool result = await AsyncDemo.MyMethodAsync();
            Assert.False(result);
        }

        [Fact]
        public async Task DivideAsync_WhenDenominatorIsZero_ThrowDivideByZero()
        {
            await Assert.ThrowsAsync<DivideByZeroException>(async () =>
            {
                await AsyncDemo.DivideAsync(5, 0);
            });
        }
    }
}
