using MediatR;

namespace Cqrs_Mediatr_Pattern.Commands
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
}
