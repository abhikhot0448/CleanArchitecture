using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Goals.Commands.AddGoals;

public record AddGoalCommand(Goal Goal) : IRequest<Goal>;
