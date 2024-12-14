using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Activities.Commands.UpdateActivities;

public class UpdateActivityCommandHandler : IRequestHandler<UpdateActivityCommand, Activity>
{
    #region Properties
    private readonly IActivityRepository _activityRepository;
    #endregion

    #region Constructor
    public UpdateActivityCommandHandler(IActivityRepository activityRepository) => _activityRepository = activityRepository;
    #endregion

    #region Methods
    public async Task<Activity> Handle(UpdateActivityCommand request, CancellationToken cancellationToken)
    {
        return await _activityRepository.UpdateActivityAsync(request.Activity);
    }
    #endregion
}
