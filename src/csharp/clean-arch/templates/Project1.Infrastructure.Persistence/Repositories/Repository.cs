using Microsoft.EntityFrameworkCore;
using Project1.Domain.Common;

namespace Project1.Infrastructure.Persistence.Repositories;
public sealed class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class, IEntity, IAggregateRoot
{
    private readonly DbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;
    private readonly IUnitOfWork _unitOfWork;

    public Repository(IUnitOfWork unitOfWork)
    {
        _dbContext = (DbContext)unitOfWork;
        _dbSet = _dbContext.Set<TEntity>();
        _unitOfWork = unitOfWork;
    }

    public IQueryable<TEntity> Queryable => _dbSet;

    public IUnitOfWork UnitOfWork => _unitOfWork;

    public ValueTask<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _dbSet.Add(entity);

        return ValueTask.FromResult(entity);
    }

    public ValueTask<TEntity?> FindAsync(object[] keyValues, CancellationToken cancellationToken = default)
    {
        return _dbSet.FindAsync(keyValues, cancellationToken);
    }

    public ValueTask<TEntity> RemoveAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _dbSet.Remove(entity);

        return ValueTask.FromResult(entity);
    }

    public ValueTask<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _dbSet.Update(entity);

        return ValueTask.FromResult(entity);
    }
}