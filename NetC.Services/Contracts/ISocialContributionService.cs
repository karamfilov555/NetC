namespace NetC.Services.Contracts
{
    public interface ISocialContributionService
    {

        /// <summary>
        /// Calculates the social contribution amount.
        /// </summary>
        /// <param name="salary">The value of the gross salary.</param>
        /// <param name="socialContributionPercent">The money for social contribution in percent.</param>
        /// <returns>The money for social contribution.</returns>
        double GetSocialContributionAmount(double salary, double socialContributionPercent);
    }
}