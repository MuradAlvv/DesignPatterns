
namespace DesignPatterns.Proxy
{
    //Proxy class
    internal class CachedProductRepository : IProductRepository
    {
        private readonly IProductRepository _repository;
        private readonly List<Product> _cache = new();

        public CachedProductRepository(IProductRepository repository)
        {
            _repository = repository;
        }

        public Product FindById(int id)
        {
            if (ContainsInCacheById(id))
            {
                Console.WriteLine("loading from cache..");
                return FindByIdFromCache(id);
            }
            Console.WriteLine("loading from database..");
            Product product = _repository.FindById(id);
            _cache.Add(product);  // saving to cache
            return product;
        }

        public IEnumerable<Product> FindAll()
        {
            return _repository.FindAll();
        }

        public void Remove(Product product)
        {
            _repository.Remove(product);
        }

        public void Save(Product product)
        {
            _repository.Save(product);
        }

        private bool ContainsInCacheById(int id)
        {
            return _cache.Where(p => p.Id == id).Any();
        }

        private Product FindByIdFromCache(int id)
        {
            return _cache.Where(p => p.Id == id).First();
        }
    }
}
