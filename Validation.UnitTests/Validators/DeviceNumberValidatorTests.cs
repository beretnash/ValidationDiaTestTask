using Validation.Validators;

namespace Validation.UnitTests.Validators
{
    [TestFixture]
    public class DeviceNumberValidatorTests
    {
        [Test]
        [TestCase("B5A648BA-262F-47BF-A0F5-4FDF68AC0C12", ExpectedResult = true)]
        [TestCase("3614435a-8b46-42de-a7b5-bf1d72c4b913", ExpectedResult = true)]
        public bool Execute_ValidDeviceNumber_ReturnsTrue(string deviceNumber)
        {
            // Arrange
            DeviceNumberValidator deviceNumberValidator = new DeviceNumberValidator();

            // Act
            bool result = deviceNumberValidator.Execute(deviceNumber);

            // Assert
            return result;
        }

        [Test]
        [TestCase("B5A648BA-262F-47BF-A0F54-FDF68AC0C12", ExpectedResult = false)]
        [TestCase("B5A648A-262F-47BF-A0F5-4FDF68AC0C12", ExpectedResult = false)]
        [TestCase("3614435a-8b46-42de-a7b5-bf1d724b913", ExpectedResult = false)]
        [TestCase("361443a-8b46-42de-a7b5-bf1d72c4b913", ExpectedResult = false)]
        [TestCase("3614435a-8b46-42de2-a7b5-bf1d724b913", ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase(null, ExpectedResult = false)]
        public bool Execute_InvalidDeviceNumber_ReturnsFalse(string deviceNumber)
        {
            // Arrange
            DeviceNumberValidator deviceNumberValidator = new DeviceNumberValidator();

            // Act
            bool result = deviceNumberValidator.Execute(deviceNumber);

            // Assert
            return result;
        }
    }
}
