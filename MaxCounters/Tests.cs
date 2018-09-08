using NUnit.Framework;

namespace MaxCounters
{
    [TestFixture]
    public class MaxCountersTests
    {
        Solution sut = new Solution();

        [Test]
        public void ShouldReturnOk() {
            Assert.IsEmpty(sut.solution(0,new int[] {}));
        }
    }
}