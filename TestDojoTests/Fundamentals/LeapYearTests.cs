using TestDojo.Fundamentals;
namespace TestDojoTests.Fundamentals;

[TestFixture]
public class LeapYearTests
{
    [Test]
    public void IsLeapYear_InputYear_ReturnCorrectValue(){
        //Arrange
        var leapYear = new LeapYear();
        //Act
        var result = leapYear.IsLeapYear(1900);
        //Assert
        Assert.That(result, Is.False);
    }
}
