using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Goals.Commands.AddGoals;

public class AddGoalCommandHandler : IRequestHandler<AddGoalCommand, Goal>
{
    #region Properties
    private readonly IGoalRepository _goalRepository;
    #endregion

    #region Constructor
    public AddGoalCommandHandler(IGoalRepository goalRepository) => _goalRepository = goalRepository;
    #endregion

    #region Methods
    public async Task<Goal> Handle(AddGoalCommand request, CancellationToken cancellationToken)
    {
        return await _goalRepository.AddGoalAsync(request.Goal);
    }
    #endregion
}
