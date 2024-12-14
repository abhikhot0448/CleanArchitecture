using ActivityTracker.Domain.Abstractions;
using MediatR;

namespace ActivityTracker.Application.Goals.Commands.DeleteGoals;

public class DeleteGoalCommandHandler : IRequestHandler<DeleteGoalCommand, bool>
{
    #region Properties
    private readonly IGoalRepository _goalRepository;
    #endregion

    #region Constructor
    public DeleteGoalCommandHandler(IGoalRepository goalRepository) => _goalRepository = goalRepository;
    #endregion

    #region Methods
    public async Task<bool> Handle(DeleteGoalCommand request, CancellationToken cancellationToken)
    {
        return await _goalRepository.DeleteGoalAsync(request.GoalId);
    }
    #endregion
}
