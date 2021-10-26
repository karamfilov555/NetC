using NetC.Utils.Contracts;

namespace NetC.Utils
{
    public class Validator : IValidator
    {
        public bool ValidateSalaryInput(string salaryInput)
        {
            bool isValid = double.TryParse(salaryInput, out double result);
            return (isValid && (result >= 0));
        }
    }
}
