using System;
using System.Linq;
using AutoFixture;
using FluentAssertions;
using Moq;
using Moq.AutoMock;
using PalindroneNumbersKata;
using Xunit;

namespace PalinDroneNumbersTests
{
    public class PalinArrayTests
    {
        public AutoMocker Mocker { get; set; }

        public PalinArrayTests()
        {
            Mocker = new AutoMocker();
        }
        [Fact]
        public void TestCase1()
        {
            //Arrange
            var subject = Mocker.CreateInstance<PalinArray>();
            var intArray = new [] { 1 };
            Mocker.GetMock<IValidatePalindrone>().Setup(ivp => ivp.Validate(intArray[0])).Returns(true);
            //Act
            var result = subject.Validate(intArray);
            //Assert
            result.Should().BeTrue();
            Mocker.GetMock<IValidatePalindrone>().Verify(ivp => ivp.Validate(It.IsAny<int>()),Times.Exactly(intArray.Length));
        }

        [Fact]
        public void TestCase2()
        {
            //Arrange
            var subject = Mocker.CreateInstance<PalinArray>();
            var intArray = new [] { 5 };
            Mocker.GetMock<IValidatePalindrone>().Setup(ivp => ivp.Validate(intArray[0])).Returns(true);
            //Act
            var result = subject.Validate(intArray);
            //Assert
            result.Should().BeTrue();
            Mocker.GetMock<IValidatePalindrone>().Verify(ivp => ivp.Validate(It.IsAny<int>()), Times.Exactly(intArray.Length));
        }

        [Fact]
        public void TestCase3()
        {
            //Arrange
            var subject = Mocker.CreateInstance<PalinArray>();
            var intArray = new [] { 111, 222, 333, 444, 555 };
            foreach (var integer in intArray)
            {
                Mocker.GetMock<IValidatePalindrone>().Setup(ivp => ivp.Validate(integer)).Returns(true);
            }
            //Act
            var result = subject.Validate(intArray);
            //Assert
            result.Should().BeTrue();
            Mocker.GetMock<IValidatePalindrone>().Verify(ivp => ivp.Validate(It.IsAny<int>()), Times.Exactly(intArray.Length));
        }

        [Fact]
        public void TestCase4()
        {
            //Arrange
            var subject = Mocker.CreateInstance<PalinArray>();
            var intArray = new[] { 111, 222, 333, 444, 555 };
            foreach (var integer in intArray)
            {
                Mocker.GetMock<IValidatePalindrone>().Setup(ivp => ivp.Validate(integer)).Returns(true);
            }
            //Act
            var result = subject.Validate(intArray);
            //Assert
            result.Should().BeTrue();
            Mocker.GetMock<IValidatePalindrone>().Verify(ivp => ivp.Validate(It.IsAny<int>()), Times.Exactly(intArray.Length));
        }

        [Fact]
        public void TestCase5()
        {
            //Arrange
            var subject = Mocker.CreateInstance<PalinArray>();
            var intArray = new[] { 5 };
            foreach (var integer in intArray)
            {
                Mocker.GetMock<IValidatePalindrone>().Setup(ivp => ivp.Validate(integer)).Returns(true);
            }
            //Act
            var result = subject.Validate(intArray);
            //Assert
            result.Should().BeTrue();
            Mocker.GetMock<IValidatePalindrone>().Verify(ivp => ivp.Validate(It.IsAny<int>()), Times.Exactly(intArray.Length));
        }

        [Fact]
        public void TestCase6()
        {
            //Arrange
            var subject = Mocker.CreateInstance<PalinArray>();
            var intArray = new[] { 121, 131, 20 };
            foreach (var integer in intArray)
            {
                if (integer != 20)
                {
                    Mocker.GetMock<IValidatePalindrone>().Setup(ivp => ivp.Validate(integer)).Returns(true);
                }
                else
                {
                    Mocker.GetMock<IValidatePalindrone>().Setup(ivp => ivp.Validate(integer)).Returns(false);
                }
            }
            //Act
            var result = subject.Validate(intArray);
            //Assert
            result.Should().BeFalse();
            Mocker.GetMock<IValidatePalindrone>().Verify(ivp => ivp.Validate(It.IsAny<int>()), Times.Exactly(intArray.Length));
        }
    }
}
