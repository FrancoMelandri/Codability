using NUnit.Framework;

namespace PermCheck
{
    [TestFixture]
    public class PermCheckTests
    {
        [Test]
        public void ShouldReturnOk() 
        {
            int[] input = new [] { 1, 2, 3 };
            Assert.AreEqual(1, new Solution().solution(input));
        }
    
        [Test]
        public void ShouldReturnOk1() 
        {
            int[] input = new int[100000];
            for (int i = 0; i < 100000; i++)
                input[i] = i + 1;
            Assert.AreEqual(1, new Solution().solution(input));
        }

        [Test]
        public void ShouldReturnKo() 
        {
            int[] input = new [] { 1, 2, 4};
            Assert.AreEqual(0, new Solution().solution(input));
        }

        // [Test]
        // public void ShouldReturnKoAntiSum() 
        // {
        //     int[] input = new [] { 1, 1, 4 };
        //     Assert.AreEqual(0, new Solution().solution(input));
        // }
    }
}