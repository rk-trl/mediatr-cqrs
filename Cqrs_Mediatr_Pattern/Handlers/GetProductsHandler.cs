using Cqrs_Mediatr_Pattern.Queries;
using MediatR;

namespace Cqrs_Mediatr_Pattern.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeDataSource _dataSource;
        public GetProductsHandler(FakeDataSource  fakeDataSource)
        {
            _dataSource = fakeDataSource;
        }

        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken) => await _dataSource.GetAllProducts();


    }
}
