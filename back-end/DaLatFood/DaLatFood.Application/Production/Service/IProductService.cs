namespace DaLatFood.Application.Production.Service;

public interface IProductService
{
    Task<object> GetProduction(Guid id);
}