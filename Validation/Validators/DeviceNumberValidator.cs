using System.Text.RegularExpressions;
using Validation.Interfaces;

namespace Validation.Validators
{
    public class DeviceNumberValidator : IValidator
    {
        public bool Execute(string value)
        {
            string pattern = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";
            return !string.IsNullOrEmpty(value) && Regex.IsMatch(value, pattern);
        }
    }
}
