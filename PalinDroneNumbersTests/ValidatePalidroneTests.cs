using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using FluentAssertions;
using Moq.AutoMock;
using PalindroneNumbersKata;
using Xunit;

namespace PalinDroneNumbersTests
{
    public class ValidatePalidroneTests
    {
        public Fixture AutoFixture { get; set; }
        public AutoMocker Mocker { get; set; }

        public ValidatePalidroneTests()
        {
            AutoFixture = new Fixture();
            Mocker = new AutoMocker();
        }

        [Fact]
        public void TestCase1()
        {
            //Arrange
            var subject = Mocker.CreateInstance<ValidatePalidrone>();
            //Act
            var result = subject.Validate(1);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void TestCase2()
        {
            //Arrange
            var subject = Mocker.CreateInstance<ValidatePalidrone>();
            //Act
            var result = subject.Validate(10);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void TestCase3()
        {
            //Arrange
            var subject = Mocker.CreateInstance<ValidatePalidrone>();
            //Act
            var result = subject.Validate(123454321);
            //Assert
            result.Should().BeTrue();
        }
    }
}
