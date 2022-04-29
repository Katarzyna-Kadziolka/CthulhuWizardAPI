using AutoMapper;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models;
using MediatR;
using Raven.Client.Documents;

namespace CthulhuWizard.Application.Requests.Equipments.Queries.GetEquipments;

public class GetEquipmentsQueryHandler : IRequestHandler<GetEquipmentsQuery, List<EquipmentDto>> {
	private readonly IMapper _mapper;
	private readonly IRavenDbContext _context;

	public GetEquipmentsQueryHandler(IRavenDbContext dbContext, IMapper mapper) {
		_context = dbContext;
		_mapper = mapper;
	}

	public async Task<List<EquipmentDto>> Handle(GetEquipmentsQuery request, CancellationToken cancellationToken) {
		using var session = _context.Store.OpenSession();
		return await session
		       .Query<Equipment>()
		       .Where(a => (string.IsNullOrEmpty(request.Name) || a.Name.StartsWith(request.Name)) &&
		                   (request.Price == null || a.Price == request.Price))
		       .Select(a => _mapper.Map<EquipmentDto>(a))
		       .ToListAsync(cancellationToken);
	}
}