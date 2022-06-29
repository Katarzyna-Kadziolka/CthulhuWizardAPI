using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Occupations.Queries.GetOccupationDetails; 

public class GetOccupationDetailsQuery : IQuery<OccupationDetailsDto> {
    public Guid Id { get; set; }
}