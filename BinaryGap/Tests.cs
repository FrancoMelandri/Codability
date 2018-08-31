using NUnit.Framework;

namespace BinaryGap
{
    [TestFixture]
    public class SolutionTests
    {
        Solution sut = new Solution();

        [Test]
        public void ShouldReturnFor8() {
            Assert.AreEqual(sut.solution(8), 0);
        }
    
        [Test]
        public void ShouldReturnFor9() {
            Assert.AreEqual(sut.solution(9), 2);
        }
    
        [Test]
        public void ShouldReturnFor15() {
            Assert.AreEqual(sut.solution(15), 0);
        }
    
        [Test]
        public void ShouldReturnFor32() {
            Assert.AreEqual(sut.solution(32), 0);
        }
    
        [Test]
        public void ShouldReturnFor529() {
            Assert.AreEqual(sut.solution(529), 4);
        }

        [Test]
        public void ShouldReturnFor50001() {
            Assert.AreEqual(sut.solution(50001), 4);
        }
    
        [Test]
        public void ShouldReturnFor1041() {
            Assert.AreEqual(sut.solution(1041), 5);
        }
    }
}