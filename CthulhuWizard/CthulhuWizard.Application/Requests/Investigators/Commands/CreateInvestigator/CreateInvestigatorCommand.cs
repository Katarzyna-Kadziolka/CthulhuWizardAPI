using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator; 

public class CreateInvestigatorCommand : ICommand<InvestigatorDto> { }