namespace CleanArchitecture.Application.Common.Interfaces;
public interface IApplicationDbContext
{
    DbSet<Country> Countries { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
