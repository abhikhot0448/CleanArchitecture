using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Goals.Queries;

public class GetGoalByIdQueryHandler : IRequestHandler<GetGoalByIdQuery, Goal>
{
    #region Properties
    private readonly IGoalRepository _goalRepository;
    #endregion

    #region Constructor
    public GetGoalByIdQueryHandler(IGoalRepository goalRepository) => _goalRepository = goalRepository;
    #endregion

    #region Methods
    public async Task<Goal> Handle(GetGoalByIdQuery request, CancellationToken cancellationToken)
    {
        return await _goalRepository.GetGoalByIdAsync(request.GoalId);
    }
    #endregion
}
