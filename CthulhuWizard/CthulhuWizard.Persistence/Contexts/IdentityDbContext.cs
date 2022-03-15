using Microsoft.EntityFrameworkCore;

namespace CthulhuWizard.Persistence.Contexts;

public class IdentityDbContext : DbContext {
    public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IdentityDbContext).Assembly);
    }
}