using AutoMapper;
using Castle.Core.Internal;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Models;
using MediatR;
using Raven.Client.Documents;
using Raven.Client.Documents.Linq;

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
		
		var query = session.Query<EquipmentEntity>();
		if (request.Name != null) {
			query = query.Search(a => a.Name, $"*{request.Name}*");
		}

		if (request.Price != null) {
			query = query.Where(a => a.Price <= request.Price);
		}
		
		if (request.Type != null) {
			query = query.Where(a => a.Type == request.Type);
		}

		var equipments= await query.ToListAsync(cancellationToken);
		
		return _mapper.Map<List<EquipmentDto>>(equipments);

	}
}
