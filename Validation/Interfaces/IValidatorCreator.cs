namespace Validation.Interfaces
{
    public interface IValidatorCreator
    {
        IValidator CreateValidator(string validatorName);
    }
}
