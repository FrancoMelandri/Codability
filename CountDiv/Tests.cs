using NUnit.Framework;

namespace CountDiv
{
    [TestFixture]
    public class CountDivTests
    {
        Solution sut = new Solution();

        [Test]
        public void ShouldReturnOk() {
            int result = sut.solution(6, 11, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void ShouldReturnOk1() {
            int result = sut.solution(6, 11, 1);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void ShouldReturnOk2() {
            int result = sut.solution(1, 2000000000, 2);
            Assert.AreEqual(1000000000, result);
        }

        [Test]
        public void ShouldReturnOk3() {
            int result = sut.solution(0, 2000000000, 2);
            Assert.AreEqual(1000000001, result);
        }

        [Test]
        public void ShouldReturnOk4() {
            int result = sut.solution(1, 2000000000, 1);
            Assert.AreEqual(2000000000, result);
        }
    
        [Test]
        public void ShouldReturnOk5() {
            int result = sut.solution(0, 2000000000, 1);
            Assert.AreEqual(2000000001, result);
        }
    }
}