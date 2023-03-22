using AutoMapper;
using DaLatFood.Application.Common;
using DaLatFood.Domain.Core;
using DaLatFood.Domain.Core.IRepositoriesCore;
using Microsoft.EntityFrameworkCore;

namespace DaLatFood.Application.Base;

public class
    CrudService<TEntity, TListDto, TDetailDto, TCreateDto, TUpdateDto> : ICrudService<TEntity, TListDto, TDetailDto,
        TCreateDto, TUpdateDto> where TEntity : class, IEntity<Guid>
    where TCreateDto : class
    where TUpdateDto : class
{
    private readonly IRepository<TEntity, Guid> _repository;
    private readonly IMapper _mapper;

    public CrudService(IRepository<TEntity, Guid> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;

    }


    public async Task<PaginatedList<TListDto>> GetListAsync(
        CancellationToken cancellationToken = default(CancellationToken))
    {
        var qb = await _repository.GetQueryableAsync();
        var entities = await qb.ToListAsync(cancellationToken);
        var result = _mapper.Map<List<TEntity>, List<TListDto>>(entities);
        var total = await qb.CountAsync(cancellationToken: cancellationToken);
        return new PaginatedList<TListDto>(result, total);
    }

    public virtual async Task<TDetailDto> GetDetailAsync(Guid id,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        var entity = await _repository.FindAsync(id, cancellationToken: cancellationToken);
        var result = _mapper.Map<TEntity, TDetailDto>(entity);
        return result ?? throw new Exception("Not Found!");
    }

    public virtual async Task<TDetailDto> UpdateAsync(TUpdateDto updateDto)
    {
        var entity = _mapper.Map<TUpdateDto, TEntity>(updateDto);
        var entityNew = await _repository.UpdateAsync(entity, true);
        var result = _mapper.Map<TEntity, TDetailDto>(entityNew);
        return result;
    }

    public virtual async Task<TDetailDto> CreateAsync(TCreateDto createDto)
    {
        var entity = _mapper.Map<TCreateDto, TEntity>(createDto);
        var entityNew = await _repository.AddAsync(entity, true);
        var result = _mapper.Map<TEntity, TDetailDto>(entityNew);
        return result;
    }
}