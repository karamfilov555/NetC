namespace NetC.Utils.Contracts
{
    public interface IValidator
    {
        /// <summary>
        /// Should be used for the gross salary read from the input stream before converting it to a double value.
        /// Checks if the salary number read from the input is given as expected.
        /// </summary>
        /// <param name="salaryInput">The salary number in string read from the input stream<./param>
        /// <returns>True if the salary number read from the input is given as expected.</returns>
        bool ValidateSalaryInput(string salaryInput);
    }
}