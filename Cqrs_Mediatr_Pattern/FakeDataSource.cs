namespace Cqrs_Mediatr_Pattern
{
    public class FakeDataSource
    {
        private static List<Product> _products;

        public FakeDataSource()
        {
            _products = new List<Product>()
            {
                new Product() {Id = 1, Name ="Product 1"},
                new Product() {Id = 1, Name ="Product 2"},
                new Product() {Id = 1, Name ="Product 3"}
            };
        }

        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllProducts() => await Task.FromResult(_products);

        public async Task<Product> GetProductById(int id) =>
            await Task.FromResult(_products.Single(x=> x.Id == id));

        public async Task EventOccurred(Product product, string evt)
        {
            _products.Single(x => x.Id == product.Id).Name = $"{product.Name} evt: {evt}";
            await Task.CompletedTask;
        }

    }
}
