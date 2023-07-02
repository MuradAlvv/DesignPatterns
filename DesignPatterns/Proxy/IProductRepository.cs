
namespace DesignPatterns.Proxy
{
    internal interface IProductRepository
    {
        void Save(Product product);
        void Remove(Product product);
        Product FindById(int id);
        IEnumerable<Product> FindAll();
    }
}
