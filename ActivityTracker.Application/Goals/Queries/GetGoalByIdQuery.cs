using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Goals.Queries;

public record GetGoalByIdQuery(Guid GoalId) : IRequest<Goal>;
