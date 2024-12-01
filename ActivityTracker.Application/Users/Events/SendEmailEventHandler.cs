using MediatR;
using Microsoft.Extensions.Logging;

namespace ActivityTracker.Application.Users.Events;

public class SendEmailEventHandler(ILogger<SendEmailEventHandler> logger) : INotificationHandler<UserCreatedEvent>
{
    #region Methods
    public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation($"User created : Send mail started with identifier {notification.user.Id}");

        await Task.Delay(2000, cancellationToken);
        //Send email to the user

        logger.LogInformation($"User created : Send mail done with identifier {notification.user.Id}");

    }
    #endregion
}
