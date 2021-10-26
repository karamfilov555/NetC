namespace NetC.Services.Contracts
{
    public interface INetSalaryService
    {
        /// <summary>
        /// Calculates the net salary based on gross salary, income tax and social contribution.
        /// </summary>
        /// <param name="salary">The value of the gross salary.</param>
        /// <param name="taxPercent">The income tax in percent.</param>
        /// <param name="socialContributionPercent">The money for social contribution in percent.</param>
        /// <returns>The net salary</returns>
        double GetNetSalary(double salary, double taxPercent, double socialContributionPercent);
    }
}