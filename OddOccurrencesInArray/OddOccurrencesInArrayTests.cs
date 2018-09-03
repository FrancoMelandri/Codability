using NUnit.Framework;

namespace OddOccurrencesInArray
{
    [TestFixture]
    public class OddOccurrencesInArrayTests
    {
        private Solution sut = new Solution();

        [Test]
        public void ShouldReturn7() 
        {
            int[] input = new int[] { 9, 3, 9, 3, 9, 7, 9 }; 
            Assert.AreEqual(7, new Solution().solution(input));
        }
    
        [Test]
        public void ShouldReturnWithMaxValue7() 
        {
            int[] input = new int[] { 1000000000, 3, 1000000000, 3, 9, 7, 9 }; 
            Assert.AreEqual(7, new Solution().solution(input));
        }

        [Test]
        public void ShouldReturnWithMaxValue43Huge() 
        {
            const int MAX_NUM_ITEMS = 1000000 - 1;
            int[] input = new int[MAX_NUM_ITEMS];
            for (int i = 0; i < MAX_NUM_ITEMS; i++)
                input[i] = 42;
            input[10] = 43;
            Assert.AreEqual(43, new Solution().solution(input));
        }
    
        [Test]
        public void ShouldReturnWithMaxValue43Huge1() 
        {
            const int MAX_NUM_ITEMS = 1000000 - 1;
            int[] input = new int[MAX_NUM_ITEMS];
            for (int i = 0; i < MAX_NUM_ITEMS; i++)
                input[i] = 42;
            input[MAX_NUM_ITEMS - 1] = 43;
            Assert.AreEqual(43, new Solution().solution(input));
        }
    
        [Test]
        public void ShouldReturnWithMaxValue43Huge2() 
        {
            const int MAX_NUM_ITEMS = 1000000 - 1;
            int[] input = new int[MAX_NUM_ITEMS];
            for (int i = 0; i < MAX_NUM_ITEMS; i++)
                input[i] = 42;
            input[0] = 43;
            Assert.AreEqual(43, new Solution().solution(input));
        }
    }
}