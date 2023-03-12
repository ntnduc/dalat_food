using DaLatFood.Domain.Product.Entity;
using DaLatFood.Domain.Product.Repositories;
using DaLatFood.Infrastructure.Core.DbContextProvider;
using DaLatFood.Infrastructure.Core.RepositoryService;
using DaLatFood.Infrastructure.Data;

namespace DaLatFood.Infrastructure.Repositories.Product;

public class ProductRepository: EfCoreRepository<ApplicationDbContext, Production, Guid>, IProductRepository
{
    public ProductRepository(IDbContextProvider<ApplicationDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}