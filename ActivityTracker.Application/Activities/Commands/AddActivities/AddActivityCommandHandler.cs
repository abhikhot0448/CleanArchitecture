using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Activities.Commands.AddActivities;

public class AddActivityCommandHandler : IRequestHandler<AddActivityCommand, Activity>
{
    #region Properties
    private readonly IActivityRepository _activityRepository;
    #endregion

    #region Constructor
    public AddActivityCommandHandler(IActivityRepository activityRepository) => _activityRepository = activityRepository;
    #endregion

    #region Methods
    public async Task<Activity> Handle(AddActivityCommand request, CancellationToken cancellationToken)
    {
        return await _activityRepository.AddActivityAsync(request.Activity);
    }
    #endregion
}
