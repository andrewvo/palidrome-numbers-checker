using FluentAssertions;
using PalindroneNumbersKata;
using Xunit;

namespace PalinDroneNumbersTests
{
    public class IntegrationTests
    {
        private readonly PalinArray _palinArray;

        public IntegrationTests()
        {
            _palinArray = new PalinArray(new ValidatePalidrone());
        }
        [Fact]
        public void TestCase1()
        {
            //Arrange
            var testData = new[] {1001};

            //Act
            var result = _palinArray.Validate(testData);

            //Assert
            result.Should().BeTrue();

        }

        [Fact]
        public void TestCase2()
        {
            //Arrange
            var testData = new[] { 1231 };

            //Act
            var result = _palinArray.Validate(testData);

            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void TestCase3()
        {
            //Arrange
            var testData = new[] { 111, 222, 333, 444, 555 };

            //Act
            var result = _palinArray.Validate(testData);

            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void TestCase4()
        {
            //Arrange
            var testData = new[] { 111, 222, 333, 444, 555, 7327 };

            //Act
            var result = _palinArray.Validate(testData);

            //Assert
            result.Should().BeFalse();
        }
    }
}
