using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Investigators.Queries.GetinvestigatorDetails; 

public class GetInvestigatorDetailsQuery: IQuery<InvestigatorDetailsDto> {
    public Guid Id { get; set; }
}
