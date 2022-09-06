namespace MyApp.Tests;

public class IsLeapYearTests
{
    [Fact]
    public void Should_Return_True_If_Year_Is_Divisible_By_Four()
    {

        // Arrange
            var ily = new IsLeapYear(); 

            var test1 = 12;
            var test2 = 2400;
            var test3 = 17;

            var test11 = 2100;
            var test12 = 1600;
            var test13 = 1700;

            var test21 = 2200;
            var test22 = 3300;
            var test23 = 4000;

         // Act
            var result1 = ily.Is_Leap_Year(test1);
            var result2 = ily.Is_Leap_Year(test2);
            var result3 = ily.Is_Leap_Year(test3);
            
            var result11 = ily.Is_Leap_Year(test11);
            var result12 = ily.Is_Leap_Year(test12);
            var result13 = ily.Is_Leap_Year(test13);

            var result21 = ily.Is_Leap_Year(test21);
            var result22 = ily.Is_Leap_Year(test22);
            var result23 = ily.Is_Leap_Year(test23);

        // Assert
            result1.Should().Be(false);
            result2.Should().Be(true);
            result3.Should().Be(false); 

            result11.Should().Be(false);
            result12.Should().Be(true);
            result13.Should().Be(false); 

            result21.Should().Be(false);
            result22.Should().Be(false);
            result23.Should().Be(true); 
    }
}