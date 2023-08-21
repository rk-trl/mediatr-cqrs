using Cqrs_Mediatr_Pattern.Notifications;
using MediatR;

namespace Cqrs_Mediatr_Pattern.Handlers
{
    public class EmailHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly FakeDataSource _dataSource;

        public EmailHandler(FakeDataSource fakeDataSource)
        {
            _dataSource = fakeDataSource;
        }


        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _dataSource.EventOccurred(notification.product, "Email Sent");
            await Task.CompletedTask;
        }
    }
}
