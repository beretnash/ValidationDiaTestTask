using System.Globalization;
using Validation.Interfaces;

namespace Validation.Validators
{
    public class BirthdayValidator : IValidator
    {
        public bool Execute(string value)
        {
            var format = "dd.MM.yyyy";
            DateTime parsedDate;
            return DateTime.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);
        }
    }
}
