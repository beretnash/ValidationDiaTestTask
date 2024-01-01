namespace Validation.Interfaces
{
    internal interface IValidatorCreator
    {
        IValidator CreateValidator(string validatorName);
    }
}
