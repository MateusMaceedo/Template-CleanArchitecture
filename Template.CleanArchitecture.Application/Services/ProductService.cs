using Template.CleanArchitecture.Application.InputModels;
using Template.CleanArchitecture.Application.ViewModels;

namespace Template.CleanArchitecture.Application.Services
{
    public class ProductService : IProductService   
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductInputModel productInputModel)
        {
            var product = new Product();

            _productRepository.Add(product);
        }

        public ProductViewModel GetById(int id)
        {
            var product = _productRepository.GetById(id);

            return new ProductViewModel(product.Title, product.Price);
        }
    }
}
