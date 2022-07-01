using AutoMapper;
using AutoMapper.QueryableExtensions;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models.Investigators;
using MediatR;
using Raven.Client.Documents;

namespace CthulhuWizard.Application.Requests.Investigators.Queries.GetInvestigators;

public class GetInvestigatorsQueryHandler : IRequestHandler<GetInvestigatorsQuery, List<InvestigatorDto>> {
    private readonly IMapper _mapper;
    private readonly IRavenDbContext _context;

    public GetInvestigatorsQueryHandler(IRavenDbContext dbContext, IMapper mapper) {
        _context = dbContext;
        _mapper = mapper;
    }

    public async Task<List<InvestigatorDto>> Handle(GetInvestigatorsQuery request, CancellationToken cancellationToken) {
        using var session = _context.Store.OpenAsyncSession();
        var investigators = await session
            .Query<InvestigatorEntity>()
            .ProjectTo<InvestigatorDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
        return investigators;
    }
}