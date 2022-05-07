using Template.CleanArchitecture.Application.ViewModels;

namespace Template.CleanArchitecture.Application.Services
{
    public interface IProductService
    {
        ProductViewModel GetById(int id);
    }
}
