using NUnit.Framework;

namespace TapeEquilibrium
{
    [TestFixture]
    public class TapeEquilibriumTests
    {
        Solution sut = new Solution();
        
        [Test]
        public void ShouldReturnEmptyDetail() 
        {
            int[] input = new int[] {3, 1, 2, 4, 3};
            Assert.AreEqual(1, sut.solution(input));
        }
    }
}