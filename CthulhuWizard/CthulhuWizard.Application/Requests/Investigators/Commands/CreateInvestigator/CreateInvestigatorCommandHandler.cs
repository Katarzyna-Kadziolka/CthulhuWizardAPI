using AutoMapper;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models.Investigators;
using MediatR;
using Raven.Client.Documents.Commands;
using Raven.Client.Documents.Session;

namespace CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;

public class CreateInvestigatorCommandHandler : IRequestHandler<CreateInvestigatorCommand, InvestigatorDetailsDto> {
    private readonly IMapper _mapper;
    private readonly IRavenDbContext _context;

    public CreateInvestigatorCommandHandler(IRavenDbContext dbContext, IMapper mapper) {
        _context = dbContext;
        _mapper = mapper;
    }

    public async Task<InvestigatorDetailsDto> Handle(CreateInvestigatorCommand request, CancellationToken cancellationToken) {
        using var session = _context.Store.OpenAsyncSession();
        
        var investigator = _mapper.Map<InvestigatorEntity>(request);
        await session.StoreAsync(investigator, Guid.NewGuid().ToString(), cancellationToken);
        
        await session.SaveChangesAsync(cancellationToken);
        
        return _mapper.Map<InvestigatorDetailsDto>(investigator);
    }
}