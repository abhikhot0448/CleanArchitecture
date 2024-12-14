using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Activities.Queries;

public record GetActivityByIdQuery(Guid ActivityId) : IRequest<Activity>;
