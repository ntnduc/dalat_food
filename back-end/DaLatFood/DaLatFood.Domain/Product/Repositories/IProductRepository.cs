using DaLatFood.Domain.Core.IRepositoriesCore;
using DaLatFood.Domain.Product.Entity;

namespace DaLatFood.Domain.Product.Repositories;

public interface IProductRepository : IRepository<Production, Guid>
{
}