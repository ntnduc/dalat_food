using DaLatFood.Domain.Core;
using DaLatFood.Domain.Core.IRepositoriesCore;
using DaLatFood.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DaLatFood.Infrastructure.Core.RepositoryService;

public class EfCoreRepository<TDbContext, TEntity, TKey> : IEfCoreRepository<TDbContext, TEntity, TKey>, IRepository<TEntity, TKey> where
    TDbContext : DbContext
    where TEntity : class, IEntity<TKey>
{
    private readonly ApplicationDbContext _applicationDbContext;
    public EfCoreRepository( ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }


    private Task<DbSet<TEntity>> GetDbSetAsync()
    {
        return Task.FromResult(_applicationDbContext.Set<TEntity>());
    }

    public virtual async Task<TEntity> FindAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        return await GetAsync(id, isTracking, cancellationToken) ??
               throw new Exception("Not found!");
    }

    public virtual async Task<TEntity> GetAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        EfCoreRepository<TDbContext, TEntity, TKey> efCoreRepository = this;
        IQueryable<TEntity> queryable;
        queryable = await efCoreRepository.GetQueryableAsync();
        IQueryable<TEntity> source = queryable;
        if (!isTracking)
        {
            source = source.AsNoTracking<TEntity>();
        }

        var result = await source.FirstOrDefaultAsync<TEntity>(x => x.Id.Equals(id), cancellationToken);
        if (result == null)
        {
            throw new Exception("Not found!");
        }
        return result;
    }
    
    

    public async Task<IQueryable<TEntity>> GetQueryableAsync()
    {
        IQueryable<TEntity> queryable = (await this.GetDbSetAsync()).AsQueryable();
        return queryable;
    }
}