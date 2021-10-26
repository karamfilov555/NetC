
using Moq;
using NetC.Services;
using NetC.Services.Contracts;
using Xunit;

namespace NetC.Tests
{
    public class NetSalaryServiceTests
    {
        [Fact]
        public void GetSocialContributionAmount_Should_Return_Correct_Answer()
        {
            //Arrange
            var incomeTaxService = new Mock<IIncomeTaxService>();
            incomeTaxService.Setup(p => p.GetIncomeTaxAmount(It.IsAny<double>(), It.IsAny<double>())).Returns(100);
            var socialContributionService = new Mock<ISocialContributionService>();
            socialContributionService.Setup(p => p.GetSocialContributionAmount(It.IsAny<double>(), It.IsAny<double>())).Returns(150);

            //Act
            var actualResult = new NetSalaryService(incomeTaxService.Object, socialContributionService.Object).GetNetSalary(3000, 66, 66);

            //Assert
            Assert.Equal(2750, actualResult);
        }
    }
}
