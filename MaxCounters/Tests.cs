using NUnit.Framework;

namespace MaxCounters
{
    [TestFixture]
    public class MaxCountersTests
    {
        Solution sut = new Solution();

        [Test]
        public void ShouldReturnOk() {
            int[] input = new int[] { 3, 4, 4, 6, 1, 4, 4};
            int[] result = sut.solution(5, input);
            
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(2, result[2]);
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(2, result[4]);
        }

        [Test]
        public void ShouldReturnOk1() {
            int[] input = new int[] { 3, 4, 4, 6, 1, 4, 6};
            int[] result = sut.solution(5, input);
            
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(3, result[3]);
            Assert.AreEqual(3, result[4]);
        }
    }
}