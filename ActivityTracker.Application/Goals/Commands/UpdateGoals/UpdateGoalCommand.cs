using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Goals.Commands.UpdateGoals;

public record UpdateGoalCommand(Goal Goal) : IRequest<Goal>;
