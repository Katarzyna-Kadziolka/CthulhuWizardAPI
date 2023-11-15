using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.DefaultData;
using CthulhuWizard.Persistence.DefaultData.Equipments;
using CthulhuWizard.Persistence.DefaultData.Occupations;
using Raven.Client.Documents.Session;

namespace CthulhuWizard.Persistence; 

public class Seeder {
	private IRavenDbContext _context;
	public Seeder(IRavenDbContext dbContext) {
		_context = dbContext;
	}

	public void SeedDefaultData() {
		using var session = _context.Store.OpenSession();
		AddIfEmpty(session, OccupationDefaultData.Data,x => x.Id.ToString());
		AddIfEmpty(session, EquipmentDefaultData.Data, x => x.Id.ToString());
		AddIfEmpty(session, WeaponDefaultData.Data, x=> x.Id.ToString());
		session.SaveChanges();
	}

	private void AddIfEmpty<T>(IDocumentSession session, IEnumerable<T> collectionToAdd, Func<T, string> getKey) {
		if (!session.Query<T>().Any()) {
			foreach (var entity in collectionToAdd) {
				session.Store(entity, getKey(entity));
			}
		}
	}
}
