using TestDojo.Fundamentals;
namespace TestDojoTests.Fundamentals;

[TestFixture]
public class FizzBuzzTests
{
    [Test]
    public void GetFizzBuzz_Input15_ReturnsCorrectList(){
        //Arrange
        var fizzBuzz = new FizzBuzz();
        //Act
        var result = fizzBuzz.GetFizzBuzz(15);
        //Assert
        Assert.AreEqual(15, result.Count);
        Assert.AreEqual("Fizz", result[3-1]);
        Assert.AreEqual("Buzz", result[5-1]);
        Assert.AreEqual("FizzBuzz", result[15-1]);
    }
}
