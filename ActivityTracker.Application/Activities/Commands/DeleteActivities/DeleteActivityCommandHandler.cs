using ActivityTracker.Domain.Abstractions;
using MediatR;

namespace ActivityTracker.Application.Activities.Commands.DeleteActivities;

public class DeleteActivityCommandHandler : IRequestHandler<DeleteActivityCommand, bool>
{
    #region Properties
    private readonly IActivityRepository _activityRepository;
    #endregion

    #region Constructor
    public DeleteActivityCommandHandler(IActivityRepository activityRepository) => _activityRepository = activityRepository;
    #endregion

    #region Methods
    public async Task<bool> Handle(DeleteActivityCommand request, CancellationToken cancellationToken)
    {
        return await _activityRepository.DeleteActivityAsync(request.ActivityId);
    }
    #endregion
}
