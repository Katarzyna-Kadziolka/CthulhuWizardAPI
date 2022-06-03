using CthulhuWizard.Persistence.Models;
using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Investigators.Queries.GetInvestigators; 

public class GetInvestigatorsQuery : IQuery<List<InvestigatorDto>> { }