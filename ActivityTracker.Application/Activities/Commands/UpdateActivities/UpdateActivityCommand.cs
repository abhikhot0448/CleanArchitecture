using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Activities.Commands.UpdateActivities;

public record UpdateActivityCommand(Activity Activity) : IRequest<Activity>;
