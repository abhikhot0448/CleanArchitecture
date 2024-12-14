using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Activities.Queries;

public record GetAllActivitiesQuery() : IRequest<IEnumerable<Activity>>;
