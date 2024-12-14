using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Activities.Queries;

public class GetAllActivitiesQueryHandler : IRequestHandler<GetAllActivitiesQuery, IEnumerable<Activity>>
{
    #region Properties
    private readonly IActivityRepository _activityRepository;
    #endregion

    #region Constructor
    public GetAllActivitiesQueryHandler(IActivityRepository activityRepository) => _activityRepository = activityRepository;
    #endregion

    #region Methods
    public async Task<IEnumerable<Activity>> Handle(GetAllActivitiesQuery request, CancellationToken cancellationToken)
    {
        return await _activityRepository.GetActivitiesAsync();
    }
    #endregion
}
