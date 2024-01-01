using System.Text.RegularExpressions;
using Validation.Interfaces;

namespace Validation.Validators
{
    public class PassportValidator : IValidator
    {
        public bool Execute(string value)
        {
            return false;
        }
    }
}
