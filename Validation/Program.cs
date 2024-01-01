using Validation.Interfaces;

namespace Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args?.Length < 2)
            {
                Console.WriteLine("ERROR: Bad amount of params.");
                return;
            }

            var validationType = args[0];
            var validationValue = args[1];

            IValidatorCreator validatorCreator = new ValidatorCreator();

            try
            {
                IValidator validator = validatorCreator.CreateValidator(validationType);
                var result = validator.Execute(validationValue);
                Console.WriteLine(result.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }
    }
}
