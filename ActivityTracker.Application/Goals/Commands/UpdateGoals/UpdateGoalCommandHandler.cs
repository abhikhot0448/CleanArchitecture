using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Goals.Commands.UpdateGoals;

public class UpdateGoalCommandHandler : IRequestHandler<UpdateGoalCommand, Goal>
{
    #region Properties
    private readonly IGoalRepository _goalRepository;
    #endregion

    #region Constructor
    public UpdateGoalCommandHandler(IGoalRepository goalRepository) => _goalRepository = goalRepository;
    #endregion

    #region Methods
    public async Task<Goal> Handle(UpdateGoalCommand request, CancellationToken cancellationToken)
    {
        return await _goalRepository.UpdateGoalAsync(request.Goal);
    }
    #endregion
}
