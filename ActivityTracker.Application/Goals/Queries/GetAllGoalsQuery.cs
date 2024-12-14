using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Goals.Queries;

public record GetAllGoalsQuery() : IRequest<IEnumerable<Goal>>;
