using DaLatFood.Application.Common;
using DaLatFood.Domain.Core;

namespace DaLatFood.Application.Base;

public interface ICrudService<TEntity, TListDto, TDetailDto, TCreateDto, TUpdateDto> where TEntity : IEntity<Guid>
{
    Task<PaginatedList<TListDto>> GetListAsync(
        CancellationToken cancellationToken = default(CancellationToken));

    Task<TDetailDto> GetDetailAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken));

    Task<TDetailDto> UpdateAsync(TUpdateDto updateDto,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<TDetailDto> CreateAsync(TCreateDto createDto,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<TDetailDto> DeleteAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken));
}