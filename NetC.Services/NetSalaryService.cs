using NetC.Services.Contracts;

namespace NetC.Services
{
    public class NetSalaryService : INetSalaryService
    {
        IIncomeTaxService _incomeTaxService;
        ISocialContributionService _socialContributionService;
        public NetSalaryService(IIncomeTaxService incomeTaxService, ISocialContributionService socialContributionService)
        {
            _incomeTaxService = incomeTaxService;
            _socialContributionService = socialContributionService;
        }

        public double GetNetSalary(double salary, double taxPercent, double socialContributionPercent)
        {
            var incomeTax = _incomeTaxService.GetIncomeTaxAmount(salary, taxPercent);
            var socialContribution = _socialContributionService.GetSocialContributionAmount(salary, socialContributionPercent);
            var netSalary = salary - (incomeTax + socialContribution);
            return netSalary;
        }
    }
}
