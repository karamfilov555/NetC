namespace NetC.Services.Contracts
{
    public interface IIncomeTaxService
    {
        /// <summary>
        /// Calculates the income tax based on the salary.
        /// </summary>
        /// <param name="salary">The value of the gross salary.</param>
        /// <param name="taxPercent">The income tax in percent.</param>
        /// <returns>The income tax in value.</returns>
        double GetIncomeTaxAmount(double salary, double taxPercent);
    }
}