using Validation.Validators;

namespace Validation.UnitTests.Validators
{
    [TestFixture]
    public class IndividualTaxNumberValidatorTests
    {
        [Test]
        [TestCase("1122334455", ExpectedResult = true)]
        [TestCase("1234567489", ExpectedResult = true)]
        [TestCase("2143658791", ExpectedResult = true)]
        public bool Execute_ValidIndividualTaxNumber_ReturnsTrue(string taxNumber)
        {
            // Arrange
            IndividualTaxNumberValidator individualTaxNumberValidator = new IndividualTaxNumberValidator();

            // Act
            bool result = individualTaxNumberValidator.Execute(taxNumber);

            // Assert
            return result;
        }

        [Test]
        [TestCase("112233445", ExpectedResult = false)]
        [TestCase("11223344551", ExpectedResult = false)]
        [TestCase("112233445F", ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase(null, ExpectedResult = false)]
        public bool Execute_InvalidIndividualTaxNumber_ReturnsFalse(string taxNumber)
        {
            // Arrange
            IndividualTaxNumberValidator individualTaxNumberValidator = new IndividualTaxNumberValidator();

            // Act
            bool result = individualTaxNumberValidator.Execute(taxNumber);

            // Assert
            return result;
        }
    }
}
