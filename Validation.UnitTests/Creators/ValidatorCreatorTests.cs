using NUnit.Framework.Internal;
using Validation.Common;
using Validation.Exceptions;
using Validation.Interfaces;
using Validation.Validators;

namespace Validation.UnitTests.Creators
{
    [TestFixture]
    public class ValidatorCreatorTests
    {
        [Test]
        public void CreateValidator_Passport_PassportValidatorCreated()
        {
            // Arrange
            IValidatorCreator _validatorCreator = new ValidatorCreator();

            // Act
            IValidator validator = _validatorCreator.CreateValidator(ValidationParams.Passport);

            // Assert
            Assert.That(validator, Is.Not.Null);
            Assert.That(validator is PassportValidator, Is.True);
        }

        [Test]
        public void CreateValidator_IndividualTaxNumber_IndividualTaxNumberValidatorCreated()
        {
            // Arrange
            IValidatorCreator _validatorCreator = new ValidatorCreator();

            // Act
            IValidator validator = _validatorCreator.CreateValidator(ValidationParams.IndividualTaxNumber);

            // Assert
            Assert.That(validator, Is.Not.Null);
            Assert.That(validator is IndividualTaxNumberValidator, Is.True);
        }

        [Test]
        public void CreateValidator_Birthday_BirthdayValidatorCreated()
        {
            // Arrange
            IValidatorCreator _validatorCreator = new ValidatorCreator();

            // Act
            IValidator validator = _validatorCreator.CreateValidator(ValidationParams.Birthday);

            // Assert
            Assert.That(validator, Is.Not.Null);
            Assert.That(validator is BirthdayValidator, Is.True);
        }

        [Test]
        public void CreateValidator_DeviceNumber_DeviceNumberValidatorCreated()
        {
            // Arrange
            IValidatorCreator _validatorCreator = new ValidatorCreator();

            // Act
            IValidator validator = _validatorCreator.CreateValidator(ValidationParams.DeviceNumber);

            // Assert
            Assert.That(validator, Is.Not.Null);
            Assert.That(validator is DeviceNumberValidator, Is.True);
        }


        [Test]
        public void CreateValidator_BadName_IncorrectValidatorExceptionThrown()
        {
            // Arrange
            IValidatorCreator _validatorCreator = new ValidatorCreator();

            // Act
            // Assert
            Assert.Catch(typeof(IncorrectValidatorException), () => _validatorCreator.CreateValidator("notexistvalidatorname"));
        }
    }
}
