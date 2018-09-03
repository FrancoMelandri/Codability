using NUnit.Framework;

namespace PermMissingElem
{
    [TestFixture]
    public class PermMissingElemTests
    {
        private Solution sut = new Solution();

        [Test]
        public void ShouldReturnMissingElelemnt1() 
        {
            int[] input = new int[] { 2, 3, 1, 5 };            
            Assert.AreEqual(4, sut.solution(input));
        }

        [Test]
        public void ShouldReturnMissingElelemnt2() 
        {
            int[] input = new int[] { 2, 3, 1, 5, 6 };            
            Assert.AreEqual(4, sut.solution(input));
        }
    
        [Test]
        public void ShouldReturnMissingElelemnt3() 
        {
            int[] input = new int[] { 2, 4, 1, 5 };            
            Assert.AreEqual(3, sut.solution(input));
        }

        [Test]
        public void ShouldReturnMissingElelemnt4() 
        {
            int[] input = new int[] { 2, 4, 1, 5, 6 };            
            Assert.AreEqual(3, sut.solution(input));
        }

        [Test]
        public void ShouldReturnMissingElelemnt5() 
        {
            const int NUM_ITEMS = 100000;
            int[] input = new int[NUM_ITEMS];           
            for(int i = 0; i < NUM_ITEMS; i++)
                input[i] = i + 1;
            input[0] = NUM_ITEMS + 1;
            Assert.AreEqual(1, sut.solution(input));
        }

        [Test]
        public void ShouldReturnMissingElelemnt6() 
        {
            const int NUM_ITEMS = 100000;
            int[] input = new int[NUM_ITEMS];           
            for(int i = 0; i < NUM_ITEMS; i++)
                input[i] = i + 1;
            input[90] = NUM_ITEMS + 1;
            Assert.AreEqual(91, sut.solution(input));
        }
    
        [Test]
        public void ShouldReturnMissingElelemnt7() 
        {
            const int NUM_ITEMS = 100000;
            int[] input = new int[NUM_ITEMS];           
            for(int i = 0; i < NUM_ITEMS; i++)
                input[i] = i + 1;
            input[NUM_ITEMS - 1] = NUM_ITEMS + 1;
            Assert.AreEqual(NUM_ITEMS, sut.solution(input));
        }
    }
}