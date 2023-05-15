using DaLatFood.Domain.Core;
using DaLatFood.Domain.Core.IRepositoriesCore;
using DaLatFood.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DaLatFood.Infrastructure.Core.RepositoryService;

public class EfCoreRepository<TEntity, TKey> : IEfCoreRepository<TEntity, TKey>, IRepository<TEntity, TKey>
    where TEntity : class, IEntity<TKey>
{
    private readonly ApplicationDbContext _applicationDbContext;

    protected EfCoreRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }


    private Task<DbSet<TEntity>> GetDbSetAsync()
    {
        return Task.FromResult(_applicationDbContext.Set<TEntity>());
    }
    
    public virtual async Task<TEntity> FindAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default (CancellationToken))
    {
        return await GetAsync(id, isTracking, cancellationToken) ??
               throw new Exception("Not found!");
    }

    public virtual async Task<TEntity> GetAsync(TKey id, bool isTracking = true,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        EfCoreRepository<TEntity, TKey> efCoreRepository = this;
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

    public virtual async Task<TEntity> AddAsync(TEntity entity, bool autoSave = false)
    {
        TEntity saveEntity = _applicationDbContext.AddAsync(entity).Result.Entity;
        if (autoSave)
        {
            await _applicationDbContext.SaveChangesAsync(new CancellationToken());
        }

        return saveEntity;
    }

    public virtual  async Task<TEntity> UpdateAsync(TEntity entity, bool autoSave)
    {
        TEntity updateEntity = _applicationDbContext.Update(entity).Entity;
        if (autoSave)
        {
            await _applicationDbContext.SaveChangesAsync(new CancellationToken());
        }

        return updateEntity;
    }

    public virtual  async Task<TEntity> DeleteAsync(TKey id , bool autoSave = false)
    {
        TEntity entity = await this.FindAsync(id);
        _applicationDbContext.Remove(entity);
        if (autoSave)
        {
            await _applicationDbContext.SaveChangesAsync();
        }

        return entity;
    }

    public async Task<IQueryable<TEntity>> GetQueryableAsync()
    {
        IQueryable<TEntity> queryable = (await this.GetDbSetAsync()).AsQueryable();
        return queryable;
    }
}