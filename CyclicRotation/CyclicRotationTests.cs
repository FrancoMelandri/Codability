using NUnit.Framework;
using System.Linq;

namespace CyclicRotation
{
    [TestFixture]
    public class CyclicRotationTests
    {
        private Solution sut = new Solution();
    
        [Test]
        public void ShouldReturnShiftedyArrayBy1() 
        {
            int[] input = new [] {3, 8, 9, 7, 6};
            int[] expected = new [] {6, 3, 8, 9, 7};
            int[] result = sut.solution(input, 1);

            Assert.IsTrue(expected.SequenceEqual(result));
        }
    
        [Test]
        public void ShouldReturnShiftedyArrayBy3() 
        {
            int[] input = new [] {3, 8, 9, 7, 6};
            int[] expected = new [] {9, 7, 6, 3, 8};
            int[] result = sut.solution(input, 3);

            Assert.IsTrue(expected.SequenceEqual(result));
        }
    
        [Test]
        public void ShouldReturnShiftedyArrayBy4() 
        {
            int[] input = new [] {1, 2, 3, 4};
            int[] expected = new [] {1, 2, 3, 4};
            int[] result = sut.solution(input, 4);

            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}