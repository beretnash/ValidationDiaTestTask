using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation.Validators;

namespace Validation.UnitTests.Validators
{
    public class IndividualTaxNumberValidatorTests
    {
        [Test]
        [TestCase("1122334455", ExpectedResult = true)]
        [TestCase("1234567489", ExpectedResult = true)]
        [TestCase("2143658791", ExpectedResult = true)]
        public bool Execute_ValidPassportNumber_ReturnsTrue(string passportNumber)
        {
            // Arrange
            IndividualTaxNumberValidator individualTaxNumberValidator = new IndividualTaxNumberValidator();

            // Act
            bool result = individualTaxNumberValidator.Execute(passportNumber);

            // Assert
            return result;
        }

        [Test]
        [TestCase("112233445", ExpectedResult = false)]
        [TestCase("11223344551", ExpectedResult = false)]
        [TestCase("112233445F", ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase(null, ExpectedResult = false)]
        public bool Execute_InvalidPassportNumber_ReturnsFalse(string passportNumber)
        {
            // Arrange
            IndividualTaxNumberValidator individualTaxNumberValidator = new IndividualTaxNumberValidator();

            // Act
            bool result = individualTaxNumberValidator.Execute(passportNumber);

            // Assert
            return result;
        }
    }
}
