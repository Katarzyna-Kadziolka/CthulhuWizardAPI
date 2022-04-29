using CthulhuWizard.Persistence.Models;
using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Investigators.Queries.GetInvestigators; 

public class GetInvestigatorsQuery : IQuery<List<InvestigatorDto>> {
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public OccupationEntity? OccupationEntity { get; set; }
}