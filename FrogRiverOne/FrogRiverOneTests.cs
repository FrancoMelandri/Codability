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
        public void ShouldReturnOkHuge() 
        {
            int[] input = new int [100000];
            for (int i = 0; i < 100000; i++)
                input[i] = i + 1;
            Assert.AreEqual(99999, sut.solution(100000, input));
        }
    
        [Test]
        public void ShouldReturnOkHugeLast() 
        {
            int[] input = new int [100000];
            for (int i = 1; i < 99999; i++)
                input[i] = i + 1;
            input[99999] = 1;
            Assert.AreEqual(99999, sut.solution(100000, input));
        }
    
        [Test]
        public void ShouldReturnKo() 
        {
            int[] input = new int [] { 1, 3, 1, 4, 2, 3, 5, 4 };
            Assert.AreEqual(-1, sut.solution(8, input));
        }
    }
}