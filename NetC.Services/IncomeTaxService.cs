using NetC.Services.Contracts;

namespace NetC.Services
{
    public class IncomeTaxService : IIncomeTaxService
    {
        public double GetIncomeTaxAmount(double salary, double taxPercent)
        {
            double tax = 0;
            double taxableAmount = (salary - 1000);
            if (taxableAmount > 0)
            {
                tax = (taxableAmount * (taxPercent / 100));
            }
            return tax;
        }
    }
}
