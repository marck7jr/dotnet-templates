namespace Project1.Domain.Common;
public interface IRepository<TEntity> 
    where TEntity : class, IEntity, IAggregateRoot
{
    public IQueryable<TEntity> Queryable { get; }
    public IUnitOfWork UnitOfWork { get; }
    public ValueTask<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    public ValueTask<TEntity?> FindAsync(object[] keyValues, CancellationToken cancellationToken = default);
    public ValueTask<TEntity> RemoveAsync(TEntity entity, CancellationToken cancellationToken = default);
    public ValueTask<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
}