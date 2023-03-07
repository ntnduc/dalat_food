using System.Linq.Expressions;
using DaLatFood.Domain.Core.CommonModel;

namespace DaLatFood.Domain.Core.IRepositoriesCore;

public interface IRepository<TEntity, TKey> 
{
    Task<TEntity> FindAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<TEntity> GetAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<IQueryable<TEntity>> GetQueryableAsync();
}