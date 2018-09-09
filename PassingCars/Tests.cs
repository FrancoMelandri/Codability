using NUnit.Framework;

namespace PassingCars
{
    [TestFixture]
    public class PassingCarsTests
    {
        Solution sut = new Solution();

        [Test]
        public void ShouldReturnOk() {
            int[] input = new int[] { 0, 1, 0, 1, 1};
            int result = sut.solution(input);
        
            Assert.AreEqual(5, result);
        }

        [Test]
        public void ShouldReturnOk1() {
            int[] input = new int[] { 0, 1, 0, 1};
            int result = sut.solution(input);
        
            Assert.AreEqual(3, result);
        }

        [Test]
        public void ShouldReturnOk2() {
            int[] input = new int[] { 0, 0, 0, 0};
            int result = sut.solution(input);
        
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ShouldReturnOk3() {
            int[] input = new int[] { 1, 1, 1, 1};
            int result = sut.solution(input);
        
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ShouldReturnOk5() {
            int[] input = new int[] { 0, 1, 0, 1, 1, 0, 1};
            int result = sut.solution(input);
        
            Assert.AreEqual(8, result);
        }

        [Test]
        public void ShouldReturnOk6() {
            int[] input = new int[] { 0, 0, 0, 1, 1, 0, 1};
            int result = sut.solution(input);
        
            Assert.AreEqual(10, result);
        }
    
        [Test]
        public void ShouldReturnOk7() {
            int[] input = new int[] { 0, 0, 0, 0, 0, 0, 1};
            int result = sut.solution(input);
        
            Assert.AreEqual(6, result);
        }

        [Test]
        public void ShouldReturnOk8() {
            int[] input = new int[] { 1, 0, 0, 0, 0, 0, 0};
            int result = sut.solution(input);
        
            Assert.AreEqual(0, result);
        }
    }
}