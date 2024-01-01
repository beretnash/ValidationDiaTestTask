using System.Text.RegularExpressions;
using Validation.Interfaces;

namespace Validation.Validators
{
    public class PassportValidator : IValidator
    {
        public bool Execute(string value)
        {
            var pattern = @"[АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЮЯ]{2}\d{6}";
            return !string.IsNullOrEmpty(value) && Regex.IsMatch(value, pattern);
        }
    }
}
