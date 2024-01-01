using System.Text.RegularExpressions;
using Validation.Interfaces;

namespace Validation.Validators
{
    public class IndividualTaxNumberValidator : IValidator
    {
        public bool Execute(string value)
        {
            var pattern = @"\d{10}";
            return !string.IsNullOrEmpty(value) && value.Length == 10 && Regex.IsMatch(value, pattern);
        }
    }
}
