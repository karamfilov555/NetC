using NetC.Services.Contracts;

namespace NetC.Services
{
    public class SocialContributionService : ISocialContributionService
    {
        public double GetSocialContributionAmount(double salary, double socialContributionPercent)
        {
            double socialContribution = 0;
            double taxableAmount = (salary - 1000) > 2000 ? 2000 : (salary - 1000);
            if (taxableAmount > 0)
            {
                socialContribution = (taxableAmount * (socialContributionPercent / 100));
            }
            return socialContribution;
        }
    }
}
