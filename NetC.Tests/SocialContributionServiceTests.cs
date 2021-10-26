using NetC.Services;
using Xunit;

namespace NetC.Tests
{
    public class SocialContributionServiceTests
    {
        [Theory]
        [InlineData(600, 10, 0)]
        [InlineData(1200, 5, 10)]
        [InlineData(5540, 10, 200)]
        [InlineData(-10000, 2.5, 0)]
        [InlineData(10000, 2.5, 50)]
        [InlineData(10000, 0, 0)]
        [InlineData(0, 20, 0)]
        [InlineData(1979, -10, -97.9)]
        public void GetSocialContributionAmount_Should_Return_Correct_Answers(double salary, double socialContributionPercent, double expectedResult)
        {
            //Act
            var actualResult = new SocialContributionService().GetSocialContributionAmount(salary, socialContributionPercent);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
