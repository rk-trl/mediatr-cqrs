using MediatR;

namespace Cqrs_Mediatr_Pattern.Queries
{
    public record GetProductById(int Id):IRequest<Product>;
}
 