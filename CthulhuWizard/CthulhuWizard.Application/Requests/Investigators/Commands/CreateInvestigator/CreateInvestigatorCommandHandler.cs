using AutoMapper;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models.Investigators;
using MediatR;
using Raven.Client.Documents.Commands;
using Raven.Client.Documents.Session;

namespace CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator; 

public class CreateInvestigatorCommandHandler : IRequestHandler<CreateInvestigatorCommand, InvestigatorDto> {
	private readonly IMapper _mapper;
	private readonly IRavenDbContext _context;
	public CreateInvestigatorCommandHandler(IRavenDbContext dbContext, IMapper mapper) {
		_context = dbContext;
		_mapper = mapper;
	}
	public async Task<InvestigatorDto> Handle(CreateInvestigatorCommand request, CancellationToken cancellationToken) {
		using var session = _context.Store.OpenAsyncSession();
		var investigatorInfo = new DocumentInfo {
			Collection = "Investigators"
		};
		var investigator = _mapper.Map<InvestigatorEntity>(request);
		var blittableInvestigator = session.Advanced.JsonConverter.ToBlittable(investigator, investigatorInfo);
		var id = Guid.NewGuid();
		var command = new PutDocumentCommand(id.ToString(), null, blittableInvestigator);
		await session.Advanced.RequestExecutor.ExecuteAsync(command, session.Advanced.Context, token: cancellationToken);
		var investigatorDto = _mapper.Map<InvestigatorDto>(investigator);
		investigatorDto.Id = id;
		return investigatorDto;
	}
}