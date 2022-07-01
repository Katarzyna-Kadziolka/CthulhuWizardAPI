using FluentValidation;

namespace CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator; 

public class CreateInvestigatorCommandValidator : AbstractValidator<CreateInvestigatorCommand> {
    public CreateInvestigatorCommandValidator() {
        RuleFor(a => a.FirstName)
            .NotNull()
            .NotEmpty();
        RuleFor(a => a.Age)
            .NotNull()
            .NotEmpty()
            .LessThanOrEqualTo(90)
            .GreaterThanOrEqualTo(15);
    }
}