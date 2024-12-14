using MediatR;
using Microsoft.Extensions.Logging;

namespace ActivityTracker.Application.Users.Events
{
    public class StartMemberShipEventHandler(ILogger<StartMemberShipEventHandler> logger) : INotificationHandler<UserCreatedEvent>
    {

        public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("User created : Send mail started");

            await Task.Delay(2000, cancellationToken);
            //Send email to the user

            logger.LogInformation("User created : Send mail done");

        }
    }
}
