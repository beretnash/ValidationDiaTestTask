using Validation.Common;
using Validation.Exceptions;
using Validation.Interfaces;
using Validation.Validators;

namespace Validation
{
    public class ValidatorCreator : IValidatorCreator
    {
        public IValidator CreateValidator(string validatorName)
        {
            return validatorName switch
            {
                ValidationParams.Passport => new PassportValidator(),
                ValidationParams.IndividualTaxNumber => new IndividualTaxNumberValidator(),
                ValidationParams.Birthday => new BirthdayValidator(),
                ValidationParams.DeviceNumber => new DeviceNumberValidator(),
                _ => throw new IncorrectValidatorException("Incorrect validation name param."),
            };
        }
    }
}
