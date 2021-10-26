using NetC.CLI.Contracts;
using NetC.CLI.ScreenView.Contracts;
using NetC.Services.Contracts;
using NetC.Utils.Contracts;

namespace NetC.CLI
{
    public class Engine : IEngine
    {
        private const double _incomeTaxPercent = 10;
        private const double _socialContributionPercent = 15;
        private readonly IReader _reader;
        private readonly IWriter _writer;
        private readonly INetCScreen _netCScreen;
        private readonly IValidator _validator;
        private readonly IIncomeTaxService _incomeTaxService;
        private readonly ISocialContributionService _socialContributionService;
        private readonly INetSalaryService _netSalaryService;
        public Engine(IReader reader, IWriter writer, INetCScreen netCScreen, IValidator validator,
            IIncomeTaxService incomeTaxService, ISocialContributionService socialContributionService, INetSalaryService netSalaryService)
        {
            _reader = reader;
            _writer = writer;
            _netCScreen = netCScreen;
            _validator = validator;
            _incomeTaxService = incomeTaxService;
            _socialContributionService = socialContributionService;
            _netSalaryService = netSalaryService;
        }
        /// <summary>
        /// First we call the _netCScreen.DisplayLayout() method to show our console logo.
        /// Then we declare all variables that we will be using.
        /// In a do-while loop, we ask the person to provide a gross salary.
        /// After we calculate the net salary we display it and ask the user if he/she wants to see the amount gone for income tax and social contribution.
        /// Regardless of the answer, we ask the user if he/she wants to see the net salary for another gross value.
        /// If not the program ends.
        /// </summary>
        public void Run()
        {
            _netCScreen.DisplayLayout();
            string answer = string.Empty;
            string salaryInput;
            double salary;
            double incomeTax;
            double socialContribution;
            double netSalary;
            do
            {
                _writer.Write("Enter the gross value of a salary in IDR and see the net amount (use dot for floating point): ");
                salaryInput = _reader.ReadLine();
                if (!_validator.ValidateSalaryInput(salaryInput))
                {
                    _writer.WriteLine("Please enter a non negative number only");
                    continue;
                }
                salary = double.Parse(salaryInput);

                netSalary = _netSalaryService.GetNetSalary(salary, _incomeTaxPercent, _socialContributionPercent);
                _writer.WriteLine($"Net salary is {netSalary} IDR");

                _writer.WriteLine($"Do you want to see the income tax and the social contribution of the entered gross salary? (yes/no)");
                answer = _reader.ReadLine().ToLower();
                if (!answer.Equals("no"))
                {
                    incomeTax = _incomeTaxService.GetIncomeTaxAmount(salary, _incomeTaxPercent);
                    socialContribution = _socialContributionService.GetSocialContributionAmount(salary, _socialContributionPercent);

                    _writer.WriteLine($"The income tax paid is {incomeTax} IDR");
                    _writer.WriteLine($"The social contribution is {socialContribution} IDR");
                }

                _writer.WriteLine("Do you want to see the net value of another salary? (yes/no)");
                answer = _reader.ReadLine().ToLower();
            } while (!answer.Equals("no"));
        }

    }

}
