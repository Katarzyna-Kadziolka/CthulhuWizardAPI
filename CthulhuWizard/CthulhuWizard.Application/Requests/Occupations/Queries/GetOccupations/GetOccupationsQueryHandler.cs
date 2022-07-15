using AutoMapper;
using AutoMapper.QueryableExtensions;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Occupations;
using MediatR;
using Raven.Client.Documents;

namespace CthulhuWizard.Application.Requests.Occupations.Queries.GetOccupations; 

public class GetOccupationsQueryHandler: IRequestHandler<GetOccupationsQuery, List<OccupationDto>> {
    private readonly IMapper _mapper;
    private readonly IRavenDbContext _context;

    public GetOccupationsQueryHandler(IRavenDbContext dbContext, IMapper mapper) {
        _context = dbContext;
        _mapper = mapper;
    }
    public async Task<List<OccupationDto>> Handle(GetOccupationsQuery request, CancellationToken cancellationToken) {
        using var session = _context.Store.OpenAsyncSession();
        var occupations = await session
            .Query<OccupationEntity>()
            .ProjectTo<OccupationDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
        return occupations;
    }
}