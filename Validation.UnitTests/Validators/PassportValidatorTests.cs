using Validation.Validators;

namespace Validation.UnitTests.Validators
{
    [TestFixture]
    public class PassportValidatorTests
    {
        [Test]
        [TestCase("СЮ112233", ExpectedResult = true)]
        [TestCase("ПІ456789", ExpectedResult = true)]
        [TestCase("КК123456", ExpectedResult = true)]
        public bool Execute_ValidPassportNumber_ReturnsTrue(string passportNumber)
        {
            // Arrange
            PassportValidator passportValidator = new PassportValidator();

            // Act
            bool result = passportValidator.Execute(passportNumber);

            // Assert
            return result;
        }

        [Test]
        [TestCase("RЮ112233", ExpectedResult = false)]
        [TestCase("С112233", ExpectedResult = false)]
        [TestCase("СЮ11223", ExpectedResult = false)]
        [TestCase("ЛЫ123456", ExpectedResult = false)]
        [TestCase("123456СЮ", ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase(null, ExpectedResult = false)]
        public bool Execute_InvalidPassportNumber_ReturnsFalse(string passportNumber)
        {
            // Arrange
            PassportValidator passportValidator = new PassportValidator();

            // Act
            bool result = passportValidator.Execute(passportNumber);

            // Assert
            return result;
        }
    }
}
