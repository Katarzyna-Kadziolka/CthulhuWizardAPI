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
		using var session = _context.Store.OpenAsyncSession();
		var name = request.Name ?? "";
		var equipments = await session
		                 .Query<EquipmentEntity>()
		                 .Search(a => a.Name, $"*{name}*") 
		                 .Where(a => request.Price == null || Math.Abs(a.Price - (double) request.Price ) < 0.001 )
		                 .ToListAsync(cancellationToken);
		
		return _mapper.Map<List<EquipmentDto>>(equipments);

	}
}