using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Investigators.Queries.GetinvestigatorDetails; 

public class GetInvestigatorDetailsdQuery: IQuery<InvestigatorDetailsDto> {
    public Guid Id { get; set; }
}
