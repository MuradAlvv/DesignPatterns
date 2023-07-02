
namespace DesignPatterns.Proxy
{
    //resource-intensive class
    internal class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();  // here must be connection to a database

        public ProductRepository()
        {
            _products.Add(new Product(0, "a", 10));
            _products.Add(new Product(1, "b", 20));
            _products.Add(new Product(2, "c", 30));
            _products.Add(new Product(3, "d", 40));
            _products.Add(new Product(4, "e", 50));
            _products.Add(new Product(5, "f", 60));
            _products.Add(new Product(6, "a", 0));

        }

        public IEnumerable<Product> FindAll()
        {
            return _products;
        }

        public Product FindById(int id)
        {
            return _products.Where(p => p.Id == id).First();
        }

        public void Remove(Product product)
        {
            _products.Remove(product);
        }

        public void Save(Product product)
        {
            _products.Add(product);
        }
    }
}
