using Validation.Common;
using Validation.Interfaces;
using Validation.Validators;

namespace Validation
{
    internal class ValidatorCreator : IValidatorCreator
    {
        public IValidator CreateValidator(string validatorName)
        {
            return validatorName switch
            {
                ValidationParams.Passport => new PassportValidator(),
                ValidationParams.IndividualTaxNumber => new IndividualTaxNumberValidator(),
                ValidationParams.Birthday => new BirthdayValidator(),
                ValidationParams.DeviceNumber => new DeviceNumberValidator(),
                _ => throw new Exception("Incorrect validation name param."),
            };
        }
    }
}
