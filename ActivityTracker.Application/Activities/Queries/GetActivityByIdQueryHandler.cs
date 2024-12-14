using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Activities.Queries;

public class GetActivityByIdQueryHandler : IRequestHandler<GetActivityByIdQuery, Activity>
{
    #region Properties
    private readonly IActivityRepository _activityRepository;
    #endregion

    #region Constructor
    public GetActivityByIdQueryHandler(IActivityRepository activityRepository) => _activityRepository = activityRepository;
    #endregion

    #region Methods
    public async Task<Activity> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken)
    {
        return await _activityRepository.GetActivityByIdAsync(request.ActivityId);
    }
    #endregion
}
