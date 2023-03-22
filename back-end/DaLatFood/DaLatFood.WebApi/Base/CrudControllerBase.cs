using DaLatFood.Application.Base;
using DaLatFood.Application.Common;
using DaLatFood.Domain.Core;
using DaLatFood.Domain.Core.Response;
using Microsoft.AspNetCore.Mvc;

namespace DaLatFood.WebApi.Base;
[ApiController]
public abstract class CrudControllerBase<TEntity, TListDto, TDetailDto, TCreateDto, TUpdateDto> : ControllerBase
    where TEntity : class, IEntity<Guid>
    where TDetailDto: class
{
    private readonly ICrudService<TEntity, TListDto, TDetailDto, TCreateDto, TUpdateDto> _crudService;

    protected CrudControllerBase(ICrudService<TEntity, TListDto, TDetailDto, TCreateDto, TUpdateDto> crudService)
    {
        _crudService = crudService;
    }

    [HttpGet("list")]
    public virtual async Task<ApiResponse<PaginatedList<TListDto>>> GetListAsync(CancellationToken cancellationToken = default (CancellationToken))
    {
        var listResult = await _crudService.GetListAsync(cancellationToken);
        return ApiResponse<PaginatedList<TListDto>>.Ok(listResult);
    }

    [HttpGet("detail")]
    public virtual async Task<ApiResponse<TDetailDto>> GetDetailAsync(Guid id,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        var result = await _crudService.GetDetailAsync(id, cancellationToken);
        return ApiResponse<TDetailDto>.Ok(result);
    }

    [HttpPost("create")]
    public virtual async Task<ApiResponse<TDetailDto>> CreateAsync([FromBody] TCreateDto createDto)
    {
        var result = await _crudService.CreateAsync(createDto);
        return ApiResponse<TDetailDto>.Ok(result);
    }

    [HttpPost("update")]
    public virtual async Task<ApiResponse<TDetailDto>> UpdateAsync([FromBody] TUpdateDto updateDto)
    {
        var result = await _crudService.UpdateAsync(updateDto);
        return ApiResponse<TDetailDto>.Ok(result);
    }
}