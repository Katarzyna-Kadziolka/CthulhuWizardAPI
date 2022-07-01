using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Occupations.Queries.GetOccupations;

public class GetOccupationsQuery : IQuery<List<OccupationDto>> { }