using NUnit.Framework;

namespace FrogRiverOne
{
    [TestFixture]
    public class FrogRiverOneTests
    {
        Solution sut = new Solution();

        [Test]
        public void ShouldReturnOk() 
        {
            int[] input = new int [] { 1, 3, 1, 4, 2, 3, 5, 4 };
            Assert.AreEqual(6, sut.solution(5, input));
        }

        [Test]
        public void ShouldReturnOk1() 
        {
            int[] input = new int [] { 1, 2, 3, 4, 5, 3, 5, 4 };
            Assert.AreEqual(4, sut.solution(5, input));
        }

        [Test]
        public void ShouldReturnOk2() 
        {
            int[] input = new int [] { 1, 5, 3, 4, 5, 3, 2, 4 };
            Assert.AreEqual(6, sut.solution(5, input));
        }

        [Test]
        public void ShouldReturnKo() 
        {
            int[] input = new int [] { 1, 3, 1, 4, 2, 3, 5, 4 };
            Assert.AreEqual(-1, sut.solution(8, input));
        }
    }
}