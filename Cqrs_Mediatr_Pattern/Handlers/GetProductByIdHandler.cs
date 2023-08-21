using Cqrs_Mediatr_Pattern.Queries;
using MediatR;

namespace Cqrs_Mediatr_Pattern.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductById, Product>
    {
        private readonly FakeDataSource _fakeDS;
        public GetProductByIdHandler(FakeDataSource fakeDataSource)
        {
            _fakeDS = fakeDataSource;
        }

        public async Task<Product> Handle(GetProductById request, CancellationToken cancellationToken)
        {
            return await _fakeDS.GetProductById(request.Id);
        }
    }
}
