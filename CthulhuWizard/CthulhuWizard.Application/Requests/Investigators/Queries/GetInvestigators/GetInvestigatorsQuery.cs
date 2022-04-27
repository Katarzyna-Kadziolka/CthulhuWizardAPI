using CthulhuWizard.Persistence.Models.Investigators;
using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Investigators.Queries.GetInvestigators; 

public class GetInvestigatorsQuery : IQuery<List<InvestigatorDto>> {
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public Occupation Occupation { get; set; }
}