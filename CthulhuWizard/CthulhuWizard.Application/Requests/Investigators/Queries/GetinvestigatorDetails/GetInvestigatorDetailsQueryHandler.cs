using AutoMapper;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models.Investigators;
using MediatR;
using MediatR.AspNet.Exceptions;
using Raven.Client.Documents;

namespace CthulhuWizard.Application.Requests.Investigators.Queries.GetinvestigatorDetails; 

public class GetInvestigatorDetailsQueryHandler : IRequestHandler<GetInvestigatorDetailsdQuery, InvestigatorDetailsDto> {
    private readonly IMapper _mapper;
    private readonly IRavenDbContext _context;

    public GetInvestigatorDetailsQueryHandler(IRavenDbContext dbContext, IMapper mapper) {
        _context = dbContext;
        _mapper = mapper;
    }
    
    public async Task<InvestigatorDetailsDto> Handle(GetInvestigatorDetailsdQuery request, CancellationToken cancellationToken) {
        using var session = _context.Store.OpenAsyncSession();
        var investigator = await session
            .Query<InvestigatorEntity>()
            .FirstOrDefaultAsync(a => a.Id.Equals(request.Id), token: cancellationToken);
        if (investigator == null) {
            throw new NotFoundException($"Investigator with id {request.Id} not found");
        }

        var investigatorDto = _mapper.Map<InvestigatorDetailsDto>(investigator);
        return investigatorDto;
    }
}
