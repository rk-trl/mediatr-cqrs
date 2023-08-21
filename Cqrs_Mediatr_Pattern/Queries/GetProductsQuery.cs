using MediatR;

namespace Cqrs_Mediatr_Pattern.Queries
{
    public record GetProductsQuery:IRequest<IEnumerable<Product>>
    { 
    }
}
