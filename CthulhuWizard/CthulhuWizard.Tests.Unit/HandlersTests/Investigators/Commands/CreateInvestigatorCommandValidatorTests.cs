using CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;
using CthulhuWizard.Tests.Shared.Generators.InvestigatorGenerators;
using FluentAssertions;
using FluentValidation.TestHelper;
using NUnit.Framework;

namespace CthulhuWizard.Tests.Unit.HandlersTests.Investigators.Commands; 

public class CreateInvestigatorCommandValidatorTests {
    [Test]
    public void CreateInvestigatorCommandValidator_ShouldReturnTrue() {
        // Arrange
        var command = new CreateInvestigatorCommandGenerator().Generate();
        var validator = new CreateInvestigatorCommandValidator();
        // Act
        var result = validator.TestValidate(command);
        // Assert
        result.IsValid.Should().BeTrue();
    }
    [Test]
    public void CreateInvestigatorCommandValidator_FirstNameIsNull_ShouldReturnFalse() {
        // Arrange
        var command = new CreateInvestigatorCommandGenerator().Generate();
        var validator = new CreateInvestigatorCommandValidator();
        command.FirstName = null;
        // Act
        var result = validator.TestValidate(command);
        // Assert
        result.IsValid.Should().BeFalse();
    }
    [Test]
    public void CreateInvestigatorCommandValidator_FirstNameIsEmpty_ShouldReturnFalse() {
        // Arrange
        var command = new CreateInvestigatorCommandGenerator().Generate();
        var validator = new CreateInvestigatorCommandValidator();
        command.FirstName = string.Empty;
        // Act
        var result = validator.TestValidate(command);
        // Assert
        result.IsValid.Should().BeFalse();
    }
    [Test]
    [TestCase(14)]
    [TestCase(0)]
    [TestCase(-15)]
    public void CreateInvestigatorCommandValidator_AgeIsLessThan15_ShouldReturnFalse(int age) {
        // Arrange
        var command = new CreateInvestigatorCommandGenerator().Generate();
        var validator = new CreateInvestigatorCommandValidator();
        command.Age = age;
        // Act
        var result = validator.TestValidate(command);
        // Assert
        result.IsValid.Should().BeFalse();
    }
    [Test]
    [TestCase(91)]
    [TestCase(1000)]
    public void CreateInvestigatorCommandValidator_AgeIsMoreThan90_ShouldReturnFalse(int age) {
        // Arrange
        var command = new CreateInvestigatorCommandGenerator().Generate();
        var validator = new CreateInvestigatorCommandValidator();
        command.Age = age;
        // Act
        var result = validator.TestValidate(command);
        // Assert
        result.IsValid.Should().BeFalse();
    }
}