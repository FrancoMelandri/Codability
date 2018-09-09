using NUnit.Framework;

namespace CountDiv
{
    [TestFixture]
    public class CountDivTests
    {
        Solution sut = new Solution();

        [Test]
        public void ShouldReturnOk() {
            int result = sut.solution(0, 0, 0);
        
            Assert.AreEqual(0, result);
        }
    }
}