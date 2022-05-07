using Template.CleanArchitecture.Core.Entities;

namespace Template.CleanArchitecture.Core.Interfaces.Repositories
{
    public interface IProductRepository
    {
        ProductEntity GetById(int id);
        void Add(ProductEntity product);
    }
}
