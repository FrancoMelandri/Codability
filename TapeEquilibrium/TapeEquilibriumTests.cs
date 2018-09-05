using NUnit.Framework;

namespace TapeEquilibrium
{
    [TestFixture]
    public class TapeEquilibriumTests
    {
        Solution sut = new Solution();
        
        [Test]
        public void ShouldReturnRight1() 
        {
            int[] input = new int[] {3, 1, 2, 4, 3};
            Assert.AreEqual(1, sut.solution(input));
        }

        [Test]
        public void ShouldReturnRight2() 
        {
            int[] input = new int[] {3, 1};
            Assert.AreEqual(2, sut.solution(input));
        }

        [Test]
        public void ShouldReturnRight3() 
        {
            int[] input = new int[] {1, 3};
            Assert.AreEqual(2, sut.solution(input));
        }

        [Test]
        public void ShouldReturnRight4() 
        {
            int[] input = new int[] {-1000, 1000, 0, 4, 3};
            Assert.AreEqual(1, sut.solution(input));
        }
    }
}