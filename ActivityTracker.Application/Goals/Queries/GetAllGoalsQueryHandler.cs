using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Goals.Queries;

public class GetAllGoalsQueryHandler : IRequestHandler<GetAllGoalsQuery, IEnumerable<Goal>>
{
    #region Properties
    private readonly IGoalRepository _goalRepository;
    #endregion

    #region Constructor
    public GetAllGoalsQueryHandler(IGoalRepository goalRepository) => _goalRepository = goalRepository;
    #endregion

    #region Methods
    public async Task<IEnumerable<Goal>> Handle(GetAllGoalsQuery request, CancellationToken cancellationToken)
    {
        return await _goalRepository.GetGoalsAsync();
    }
    #endregion
}
