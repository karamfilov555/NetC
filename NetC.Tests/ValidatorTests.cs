

using NetC.Utils;
using Xunit;

namespace NetC.Tests
{
    public class ValidatorTests
    {
        [Theory]
        [InlineData("-2500", false)]
        [InlineData("2500 IDR", false)]
        [InlineData("0", true)]
        [InlineData("2500", true)]
        public void ValidateSalaryInput(string salaryInput, bool expectedResult) 
        {
            //Act
            var actualResult = new Validator().ValidateSalaryInput(salaryInput);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
