using TestDojo.Fundamentals;

namespace TestDojoTests.Fundamentals
{
    [TestFixture]
    public class NumbersTests
    {
        [Test]
        public void Add_When1And2_Returns3()
        {
            //arrange
            var numbers = new Numbers();
            //act
            var result = numbers.Add(1, 2);
            //assert
            Assert.AreEqual(3, result);
        }
    }
}