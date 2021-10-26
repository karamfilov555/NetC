

using NetC.Services;
using Xunit;

namespace NetC.Tests
{
    public class IncomeTaxServiceTests
    {
        [Theory]
        [InlineData(600, 10, 0)]
        [InlineData(1200, 5, 10)]
        [InlineData(5540, 10, 454)]
        [InlineData(-10000, 2.5, 0)]
        [InlineData(10000, 2.5, 225)]
        [InlineData(10000, 0, 0)]
        [InlineData(0, 20, 0)]
        [InlineData(1979, -10, -97.9)]
        public void GetIncomeTaxAmount_Should_Return_Correct_Answers(double salary, double taxPercent, double expectedResult) 
        {
            //Act
            var actualResult = new IncomeTaxService().GetIncomeTaxAmount(salary, taxPercent);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
