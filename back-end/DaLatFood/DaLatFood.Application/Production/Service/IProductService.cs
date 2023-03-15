namespace DaLatFood.Application.Production.Service;

public interface IProductService
{
    Task<object> GetProductionAsync(Guid id);
    Task<List<Domain.Product.Entity.Production>> GetListProductionAsync();
}