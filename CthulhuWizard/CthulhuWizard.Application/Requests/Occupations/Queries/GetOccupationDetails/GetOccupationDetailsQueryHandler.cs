using AutoMapper;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Occupations;
using MediatR;
using MediatR.AspNet.Exceptions;
using Raven.Client.Documents;

namespace CthulhuWizard.Application.Requests.Occupations.Queries.GetOccupationDetails; 

public class GetOccupationDetailsQueryHandler : IRequestHandler<GetOccupationDetailsQuery, OccupationDetailsDto> {
    private readonly IMapper _mapper;
    private readonly IRavenDbContext _context;

    public GetOccupationDetailsQueryHandler(IRavenDbContext dbContext, IMapper mapper) {
        _context = dbContext;
        _mapper = mapper;
    }

    public async Task<OccupationDetailsDto> Handle(GetOccupationDetailsQuery request, CancellationToken cancellationToken) {
        using var session = _context.Store.OpenAsyncSession();
        var occupation = await session
            .Query<OccupationEntity>()
            .FirstOrDefaultAsync(a => a.Id.Equals(request.Id));
        if (occupation == null) {
            throw new NotFoundException($"Occupation with id {request.Id} not found");
        }

        var occupationDto = _mapper.Map<OccupationDetailsDto>(occupation);
        return occupationDto;
    }
}