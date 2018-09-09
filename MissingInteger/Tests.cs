using NUnit.Framework;

namespace MissingInteger
{
    [TestFixture]
    public class MissingIntegerTests
    {
        Solution sut = new Solution();

        [Test]
        public void ShouldReturnOk() {
            int[] input = new int[] { 1, 3, 6, 4, 1, 2 };
            int result = sut.solution(input);
        
            Assert.AreEqual(5, result);
        }

        [Test]
        public void ShouldReturnOk1() {
            int[] input = new int[] { 1, 2, 3 };
            int result = sut.solution(input);
        
            Assert.AreEqual(4, result);
        }

        [Test]
        public void ShouldReturnOk2() {
            int[] input = new int[] { 2, 3, 6, 4, 2, 2 };
            int result = sut.solution(input);
        
            Assert.AreEqual(1, result);
        }

        [Test]
        public void ShouldReturnOk3() {
            int[] input = new int[] { 2, 3, 6, 4, 1, 2 };
            int result = sut.solution(input);
        
            Assert.AreEqual(5, result);
        }
    }
}