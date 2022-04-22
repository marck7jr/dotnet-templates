namespace Project1.Domain.Common;
public interface IRepository<TEntity> where TEntity : Entity, IAggregateRoot
{
    public IQueryable<TEntity> Queryable { get; }
    public IUnitOfWork UnitOfWork { get; }
    public Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    public Task<TEntity?> FindAsync(object[] keyValues, CancellationToken cancellationToken = default);
    public Task<TEntity> RemoveAsync(TEntity entity, CancellationToken cancellationToken = default);
    public Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
}