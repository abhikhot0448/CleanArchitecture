using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Activities.Commands.AddActivities;

public record AddActivityCommand(Activity Activity) : IRequest<Activity>;
