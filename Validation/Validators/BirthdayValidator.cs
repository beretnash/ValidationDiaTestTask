using Validation.Interfaces;

namespace Validation.Validators
{
    public class BirthdayValidator : IValidator
    {
        public bool Execute(string value)
        {
            return false;
        }
    }
}
