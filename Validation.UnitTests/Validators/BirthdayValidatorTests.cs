using Validation.Validators;

namespace Validation.UnitTests.Validators
{
    [TestFixture]
    public class BirthdayValidatorTests
    {
        [Test]
        [TestCase("01.01.2001", ExpectedResult = true)]
        [TestCase("02.12.2024", ExpectedResult = true)]
        [TestCase("31.12.2023", ExpectedResult = true)]
        public bool Execute_ValidBirthday_ReturnsTrue(string date)
        {
            // Arrange
            BirthdayValidator birthdayValidator = new BirthdayValidator();

            // Act
            bool result = birthdayValidator.Execute(date);

            // Assert
            return result;
        }

        [Test]
        [TestCase("01012001", ExpectedResult = false)]
        [TestCase("01.012.001", ExpectedResult = false)]
        [TestCase("31.02.2001", ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase(null, ExpectedResult = false)]
        public bool Execute_InvalidBirthday_ReturnsFalse(string date)
        {
            // Arrange
            BirthdayValidator birthdayValidator = new BirthdayValidator();

            // Act
            bool result = birthdayValidator.Execute(date);

            // Assert
            return result;
        }
    }
}
