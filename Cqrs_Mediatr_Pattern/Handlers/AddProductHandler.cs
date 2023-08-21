using Cqrs_Mediatr_Pattern.Commands;
using MediatR;

namespace Cqrs_Mediatr_Pattern.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly FakeDataSource _fakeDS;
        public AddProductHandler(FakeDataSource fakeDataSource)
        {
            _fakeDS = fakeDataSource;
        }
        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDS.AddProduct(request.Product);
            return request.Product;
        }
        
    }
}
