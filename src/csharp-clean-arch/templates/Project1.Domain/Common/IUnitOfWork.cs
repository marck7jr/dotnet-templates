namespace Project1.Domain.Common;
public interface IUnitOfWork
{
    public Task<bool> CommitChangesAsync(CancellationToken cancellationToken = default);
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
