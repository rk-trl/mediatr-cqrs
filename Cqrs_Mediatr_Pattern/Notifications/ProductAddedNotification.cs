using MediatR;

namespace Cqrs_Mediatr_Pattern.Notifications
{
    public record ProductAddedNotification(Product product):INotification;
}
