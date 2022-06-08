using MediatR;
using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Investigators.Queries.GetInvestigators; 

public class GetInvestigatorsQuery : IQuery<List<InvestigatorDto>>, IRequest<List<InvestigatorDto>> { }