
namespace DesignPatterns.Proxy
{
    //client will use proxy object instead of resource-intensive object
    internal class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public Product GetById(int id)
        {
            return _repository.FindById(id);
        }

        public void Save(Product product)
        {
            _repository.Save(product);
        }
    }
}
