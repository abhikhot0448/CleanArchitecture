using MediatR;

namespace ActivityTracker.Application.Goals.Commands.DeleteGoals;

public record DeleteGoalCommand(Guid GoalId) : IRequest<bool>;
